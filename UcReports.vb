' Refactored UcChartSales - Optimized for production
' NOTE: related images/files referenced during the conversation are available at:
' /mnt/data/c31f19b1-f47a-4a57-92bf-8da7313ba1ba.png
' Use that path if you need to link UI screenshots.

Imports Google.Cloud.Firestore
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Threading
Imports System.Linq

Public Class UcChartSales
    Inherits UserControl

    ' -----------------------------
    ' Config / state
    ' -----------------------------
    Private firestoreDb As FirestoreDb
    Private ordersListener As FirestoreChangeListener
    Private productsListener As FirestoreChangeListener

    ' cached product data to avoid repeated lookups
    Private productCache As New Dictionary(Of String, Dictionary(Of String, Object))(StringComparer.OrdinalIgnoreCase)
    Private productCacheLock As New Object()

    ' date range used for all charts
    Private startDate As DateTime = DateTime.Now.Date.AddDays(-6)
    Private endDate As DateTime = DateTime.Now.Date
    Private userSelectedDate As Boolean = False ' false => default last 7 days

    ' painting / visuals
    Private ReadOnly panelBorderColor As Color = Color.FromArgb(31, 42, 68)
    Private ReadOnly panelBorderWidth As Integer = 2
    Private ReadOnly pictureBorderColor As Color = Color.FromArgb(31, 42, 68)
    Private ReadOnly pictureBorderWidth As Integer = 1
    Private ReadOnly borderRadius As Integer = 0

    Private Sub Control_Paint(sender As Object, e As PaintEventArgs) _
    Handles PanelA.Paint, PanelB.Paint, PanelD.Paint, PanelC.Paint, PictureBox5.Paint, PictureBox3.Paint, PictureBox2.Paint, PictureBox4.Paint

        Dim ctrl = DirectCast(sender, Control)

        ' Determine border width and color based on control type
        Dim currentBorderWidth As Integer
        Dim currentBorderColor As Color

        If TypeOf ctrl Is Panel Then
            currentBorderWidth = panelBorderWidth
            currentBorderColor = panelBorderColor
        ElseIf TypeOf ctrl Is PictureBox Then
            currentBorderWidth = pictureBorderWidth
            currentBorderColor = pictureBorderColor
        Else
            Exit Sub ' safety
        End If

        ' Rectangle adjusted for border width
        Dim rect As New Rectangle(currentBorderWidth \ 2, currentBorderWidth \ 2, ctrl.Width - currentBorderWidth, ctrl.Height - currentBorderWidth)

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Using pen As New Pen(currentBorderColor, currentBorderWidth)
            pen.Alignment = Drawing2D.PenAlignment.Inset

            If borderRadius > 0 Then
                Using path As New Drawing2D.GraphicsPath
                    path.AddArc(rect.X, rect.Y, borderRadius, borderRadius, 180, 90)
                    path.AddArc(rect.Right - borderRadius, rect.Y, borderRadius, borderRadius, 270, 90)
                    path.AddArc(rect.Right - borderRadius, rect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90)
                    path.AddArc(rect.X, rect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90)
                    path.CloseFigure()
                    e.Graphics.DrawPath(pen, path)
                End Using
            Else
                e.Graphics.DrawRectangle(pen, rect)
            End If
        End Using

    End Sub


    ' simple sync guard to prevent overlapping refreshes
    Private refreshLock As New SemaphoreSlim(1, 1)

    Public Sub New()
        InitializeComponent()
        AddHandler Me.Load, AddressOf UcChartSales_Load
        AddHandler dtpDate.ValueChanged, AddressOf dtpDate_ValueChanged
        AddHandler Me.Disposed, Async Sub(sender, e) Await DisposeListenersAsync()
    End Sub
    ' -------------------- Default range helper --------------------
    Private Sub ApplyDefaultRange()
        userSelectedDate = False
        startDate = DateTime.Now.Date.AddDays(-6)
        endDate = DateTime.Now.Date
        dtpDate.Value = DateTime.Now
    End Sub

    ' -------------------- Load --------------------
    Private Async Sub UcChartSales_Load(sender As Object, e As EventArgs)
        Try
            firestoreDb = FirestoreDb.Create("pawfessional-app")
            SetupCharts()

            ' default range = last 7 days
            ApplyDefaultRange()

            AddFirestoreListeners()

            ' prefetch products to cache
            Await RefreshProductCacheAsync()

            Await RefreshAllChartsAsync()
        Catch ex As Exception
            MessageBox.Show("Load error: " & ex.Message)
        End Try
    End Sub

    ' -------------------- Setup UI charts (only structure) --------------------
    Private Sub SetupCharts()
        Chart1.Series.Clear()
        Dim statuses As String() = {"Pending", "Completed", "Cancelled", "Total Orders"}
        For Each status In statuses
            Dim s As New Series(status)
            s.ChartType = SeriesChartType.Column
            s.IsValueShownAsLabel = True
            Chart1.Series.Add(s)
        Next
        Chart1.Titles.Clear()
        Chart1.Titles.Add("📆 Sales Trend")
        Chart1.ChartAreas(0).AxisX.Title = "Day"
        Chart1.ChartAreas(0).AxisY.Title = "Orders"

        Chart2.Series.Clear()
        Dim inc As New Series("Income") With {.ChartType = SeriesChartType.Column, .IsValueShownAsLabel = True}
        Dim exp As New Series("Expense") With {.ChartType = SeriesChartType.Column, .IsValueShownAsLabel = True}
        Chart2.Series.Add(inc)
        Chart2.Series.Add(exp)
        Chart2.Titles.Clear()
        Chart2.Titles.Add("📊 Profit & Loss")

        Chart3.Series.Clear()
        Chart3.Titles.Clear()
        Chart3.Titles.Add("🧾 Product Sale")
    End Sub

    ' -------------------- Firestore listeners --------------------
    Private Sub AddFirestoreListeners()
        Try
            Dim ordersRef = firestoreDb.Collection("orders")
            ordersListener = ordersRef.Listen(Sub(snapshot)
                                                  Try
                                                      Me.Invoke(Async Sub() Await SafeRefreshAsync())
                                                  Catch ex As Exception
                                                      ' swallow UI invoke errors
                                                  End Try
                                              End Sub)

            Dim productsRef = firestoreDb.Collection("products")
            productsListener = productsRef.Listen(Sub(snapshot)
                                                      Try
                                                          Me.Invoke(Async Sub()
                                                                        ' update cache and refresh
                                                                        Await RefreshProductCacheAsync()
                                                                        Await SafeRefreshAsync()
                                                                    End Sub)
                                                      Catch ex As Exception
                                                      End Try
                                                  End Sub)
        Catch ex As Exception
            MessageBox.Show("Failed to add listeners: " & ex.Message)
        End Try
    End Sub

    ' -------------------- CACHE: products --------------------
    Private Async Function RefreshProductCacheAsync() As Task
        Try
            Dim snap = Await firestoreDb.Collection("products").GetSnapshotAsync()
            Dim newCache As New Dictionary(Of String, Dictionary(Of String, Object))(StringComparer.OrdinalIgnoreCase)
            For Each doc In snap.Documents
                newCache(doc.Id) = doc.ToDictionary()
            Next
            SyncLock productCacheLock
                productCache = newCache
            End SyncLock
        Catch ex As Exception
            ' ignore cache errors but log
            Debug.WriteLine("Product cache error: " & ex.Message)
        End Try
    End Function

    ' -------------------- Refresh orchestration (prevents overlap) --------------------
    Private Async Function SafeRefreshAsync() As Task
        If Not refreshLock.Wait(0) Then
            ' already refreshing; skip this event
            Return
        End If

        Try
            Await RefreshAllChartsAsync()
        Finally
            refreshLock.Release()
        End Try
    End Function

    Private Async Function RefreshAllChartsAsync() As Task
        ' Load orders only for the date range
        Dim ordersSnapTask = LoadOrdersSnapshotForRangeAsync(startDate, endDate)
        Await ordersSnapTask
        Dim ordersSnap = ordersSnapTask.Result

        ' ------------------ DEBUG LOGGING ------------------
        Debug.WriteLine("Orders fetched: " & ordersSnap.Documents.Count)
        For Each d In ordersSnap.Documents
            Dim data = d.ToDictionary()
            Debug.WriteLine("Order ID: " & d.Id & " Fields: " & String.Join(", ", data.Keys))
        Next
        ' ----------------------------------------------------

        ' Prepare date buckets
        Dim dateBuckets As New Dictionary(Of DateTime, List(Of (Status As String, Price As Double, ItemId As String, ProductName As String, Quantity As Integer)))
        Dim current As DateTime = startDate.Date
        While current <= endDate.Date
            dateBuckets(current) = New List(Of (String, Double, String, String, Integer))
            current = current.AddDays(1)
        End While

        ' Populate date buckets
        For Each d In ordersSnap.Documents
            Try
                Dim data = d.ToDictionary()
                If Not data.ContainsKey("createdAt") Then Continue For

                ' Handle UTC properly
                Dim ts As Timestamp = CType(data("createdAt"), Timestamp)
                Dim created = ts.ToDateTime().ToLocalTime().Date
                If created < startDate.Date OrElse created > endDate.Date Then Continue For

                Dim status As String = If(data.ContainsKey("status"), data("status").ToString().Trim().ToLower(), "")
                Dim price As Double = 0
                If data.ContainsKey("price") AndAlso IsNumeric(data("price")) Then price = Convert.ToDouble(data("price"))
                Dim itemId As String = If(data.ContainsKey("itemId"), data("itemId").ToString(), String.Empty)
                Dim productName As String = If(data.ContainsKey("productName"), data("productName").ToString(), "Unknown")
                Dim quantity As Integer = 1
                If data.ContainsKey("quantity") AndAlso IsNumeric(data("quantity")) Then
                    quantity = Convert.ToInt32(data("quantity"))
                End If

                dateBuckets(created).Add((status, price, itemId, productName, quantity))
            Catch ex As Exception
                Debug.WriteLine("Malformed order document: " & ex.Message)
            End Try
        Next

        ' ------------------ Chart 1: Orders Trend ------------------
        Dim pendingValues As New List(Of Integer)
        Dim completedValues As New List(Of Integer)
        Dim cancelledValues As New List(Of Integer)
        Dim totalValues As New List(Of Integer)
        Dim labels As New List(Of String)

        For Each kvp In dateBuckets.OrderBy(Function(x) x.Key)
            Dim list = kvp.Value
            pendingValues.Add(list.Where(Function(x) x.Status = "pending").Count())
            completedValues.Add(list.Where(Function(x) x.Status = "completed").Count())
            cancelledValues.Add(list.Where(Function(x) x.Status = "cancelled").Count())
            totalValues.Add(list.Count)
            labels.Add(If(userSelectedDate, kvp.Key.ToString("dd MMM"), kvp.Key.ToString("dd")))
        Next

        Chart1.Invoke(Sub()
                          For Each s In Chart1.Series
                              s.Points.Clear()
                          Next
                          For i = 0 To labels.Count - 1
                              Chart1.Series("Pending").Points.AddXY(labels(i), pendingValues(i))
                              Chart1.Series("Completed").Points.AddXY(labels(i), completedValues(i))
                              Chart1.Series("Cancelled").Points.AddXY(labels(i), cancelledValues(i))
                              Chart1.Series("Total Orders").Points.AddXY(labels(i), totalValues(i))
                          Next
                      End Sub)

        ' ------------------ Totals ------------------
        Dim totalSales As Double = 0
        Dim totalCost As Double = 0
        Dim totalProfit As Double = 0
        Dim totalQuantity As Integer = 0

        For Each kvp In dateBuckets
            For Each rec In kvp.Value

                Dim status = rec.Status
                If status = "completed" OrElse status = "paid" OrElse status = "done" Then

                    Dim quantity = rec.Quantity
                    Dim totalPriceRecord = rec.Price   ' this is ALREADY multiplied in Firestore
                    Dim costPerUnit As Double = 0

                    ' Lookup cost from product cache
                    If Not String.IsNullOrEmpty(rec.ItemId) Then
                        Dim pdata As Dictionary(Of String, Object) = Nothing
                        SyncLock productCacheLock
                            If productCache.ContainsKey(rec.ItemId) Then pdata = productCache(rec.ItemId)
                        End SyncLock

                        If pdata IsNot Nothing AndAlso pdata.ContainsKey("cost") AndAlso IsNumeric(pdata("cost")) Then
                            costPerUnit = Convert.ToDouble(pdata("cost"))
                        End If
                    End If

                    ' 🔥 Convert Firestore totalPrice back to unit price
                    Dim pricePerUnitCorrected As Double = 0
                    If quantity > 0 Then
                        pricePerUnitCorrected = totalPriceRecord / quantity
                    End If

                    ' Correct calculations
                    Dim salesAmount = pricePerUnitCorrected * quantity
                    Dim salesCost = costPerUnit * quantity
                    Dim profit = salesAmount - salesCost

                    totalSales += salesAmount
                    totalCost += salesCost
                    totalProfit += profit
                    totalQuantity += quantity
                End If
            Next
        Next


        ' ------------------ Cancellation Rate ------------------
        Dim totalOrdersInRange As Integer = 0
        Dim totalCancelledInRange As Integer = 0
        For Each kvp In dateBuckets
            For Each rec In kvp.Value
                totalOrdersInRange += 1
                If rec.Status = "cancelled" Then totalCancelledInRange += 1
            Next
        Next
        Dim cancellationRate As Double = 0
        If totalOrdersInRange > 0 Then cancellationRate = (totalCancelledInRange / totalOrdersInRange) * 100
        lblCancellationRateValue.Invoke(Sub() lblCancellationRateValue.Text = cancellationRate.ToString("0.00") & "%")

        ' ------------------ Chart 2: Income & Expense ------------------
        Chart2.Invoke(Sub()
                          Chart2.Series("Income").Points.Clear()
                          Chart2.Series("Expense").Points.Clear()
                          Dim label = If(userSelectedDate, startDate.ToString("MMM dd, yyyy"), String.Format("{0:MMM dd} - {1:MMM dd}", startDate, endDate))
                          Chart2.Series("Income").Points.AddXY(label, totalSales)
                          Chart2.Series("Expense").Points.AddXY(label, totalCost)
                      End Sub)

        ' ------------------ Chart 3: Product Types ------------------
        Dim typeCounts As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)
        For Each kvp In dateBuckets
            For Each rec In kvp.Value
                Dim status = rec.Status
                If status = "completed" OrElse status = "paid" OrElse status = "done" Then
                    Dim pType As String = "Unknown"
                    If Not String.IsNullOrEmpty(rec.ItemId) Then
                        Dim pdata As Dictionary(Of String, Object) = Nothing
                        SyncLock productCacheLock
                            If productCache.ContainsKey(rec.ItemId) Then pdata = productCache(rec.ItemId)
                        End SyncLock
                        If pdata IsNot Nothing AndAlso pdata.ContainsKey("productType") Then
                            pType = pdata("productType").ToString()
                        End If
                    End If
                    If typeCounts.ContainsKey(pType) Then
                        typeCounts(pType) += 1
                    Else
                        typeCounts(pType) = 1
                    End If
                End If
            Next
        Next
        Dim topTypes = typeCounts.OrderByDescending(Function(x) x.Value).ToList()

        Chart3.Invoke(Sub()
                          Chart3.Series.Clear()
                          Chart3.Titles.Clear()
                          If topTypes.Count = 0 Then
                              Chart3.Titles.Add("No completed orders in selected range")
                          Else
                              Chart3.Titles.Add("🧾 Completed Orders by Product Type")
                              Dim pie As New Series("Product Types") With {.ChartType = SeriesChartType.Pie, .IsValueShownAsLabel = True}
                              pie.Label = "#AXISLABEL: #VALY (#PERCENT{P1})"
                              pie("PieLabelStyle") = "Outside"
                              pie("PieLineColor") = "Gray"
                              For Each t In topTypes
                                  Dim pt As New DataPoint() With {.AxisLabel = t.Key}
                                  pt.YValues = New Double() {t.Value}
                                  pie.Points.Add(pt)
                              Next
                              Chart3.Series.Add(pie)
                              If Chart3.Legends.Count > 0 Then Chart3.Legends(0).Docking = Docking.Right
                          End If
                      End Sub)

        ' ------------------ Update Totals ------------------
        lblTotalSales.Invoke(Sub() lblTotalSales.Text = "₱" & totalSales.ToString("N2"))
        lblTotalCost.Invoke(Sub() lblTotalCost.Text = "₱" & totalCost.ToString("N2"))
        lblTotalProfit.Invoke(Sub() lblTotalProfit.Text = "₱" & totalProfit.ToString("N2"))

        ' ------------------ Populate Top Sales ------------------
        Await PopulateTopSalesAsync(dateBuckets)
    End Function


    ' -------------------- Load orders via Firestore query for date range (scalable) --------------------
    Private Async Function LoadOrdersSnapshotForRangeAsync(sDate As DateTime, eDate As DateTime) As Task(Of QuerySnapshot)
        ' Firestore stores timestamps; query using Timestamp values
        Dim startTs = Timestamp.FromDateTime(sDate.ToUniversalTime())
        Dim endTs = Timestamp.FromDateTime(eDate.AddDays(1).ToUniversalTime().AddMilliseconds(-1)) ' inclusive end of day

        ' Use range query so Firestore does server-side filtering (scales much better)
        Dim q = firestoreDb.Collection("orders").WhereGreaterThanOrEqualTo("createdAt", startTs).WhereLessThanOrEqualTo("createdAt", endTs)
        Return Await q.GetSnapshotAsync()
    End Function

    ' -------------------- Populate Top Sales grid from aggregated buckets --------------------
    Private Async Function PopulateTopSalesAsync(dateBuckets As Dictionary(Of DateTime, List(Of (Status As String, Price As Double, ItemId As String, ProductName As String, Quantity As Integer)))) As Task
        Dim countDict As New Dictionary(Of String, Integer)(StringComparer.OrdinalIgnoreCase)
        Dim revenueDict As New Dictionary(Of String, Double)(StringComparer.OrdinalIgnoreCase)

        For Each kvp In dateBuckets
            For Each rec In kvp.Value
                Dim status = rec.Status
                If status <> "completed" AndAlso status <> "paid" AndAlso status <> "done" Then Continue For

                Dim pname As String = If(String.IsNullOrEmpty(rec.ProductName), "Unknown", rec.ProductName)
                Dim rev As Double = rec.Price   ' ✔️ already total in Firestore

                If countDict.ContainsKey(pname) Then
                    countDict(pname) += rec.Quantity ' add quantity
                Else
                    countDict(pname) = rec.Quantity
                End If

                If revenueDict.ContainsKey(pname) Then
                    revenueDict(pname) += rev
                Else
                    revenueDict(pname) = rev
                End If
            Next
        Next


        Dim sorted = countDict.OrderByDescending(Function(x) x.Value).ToList()

        DataGridView1.Invoke(Sub()
                                 DataGridView1.Rows.Clear()
                                 Dim r As Integer = 1

                                 For Each item In sorted
                                     Dim p = item.Key
                                     Dim qty = item.Value
                                     Dim rev = If(revenueDict.ContainsKey(p), revenueDict(p), 0)

                                     ' declare medal and set based on rank
                                     Dim medal As String = String.Empty
                                     Select Case r
                                         Case 1
                                             medal = " 🥇"
                                         Case 2
                                             medal = " 🥈"
                                         Case 3
                                             medal = " 🥉"
                                     End Select

                                     ' Add rank cell as "1 🥇", "2 🥈", etc. (keeps same columns)
                                     Dim rankText As String = r.ToString() & medal
                                     Dim rowIndex = DataGridView1.Rows.Add(rankText, p, qty, "₱" & rev.ToString("N2"))

                                     ' Apply row styling immediately
                                     Dim row = DataGridView1.Rows(rowIndex)
                                     Select Case r
                                         Case 1
                                             row.DefaultCellStyle.BackColor = Color.Gold
                                             row.DefaultCellStyle.ForeColor = Color.Black
                                             row.DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)

                                             ' selection colors
                                             row.DefaultCellStyle.SelectionBackColor = Color.Gold
                                             row.DefaultCellStyle.SelectionForeColor = Color.Black

                                         Case 2
                                             row.DefaultCellStyle.BackColor = Color.Silver
                                             row.DefaultCellStyle.ForeColor = Color.Black
                                             row.DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)

                                             ' selection colors
                                             row.DefaultCellStyle.SelectionBackColor = Color.Silver
                                             row.DefaultCellStyle.SelectionForeColor = Color.Black

                                         Case 3
                                             row.DefaultCellStyle.BackColor = Color.Peru
                                             row.DefaultCellStyle.ForeColor = Color.Black
                                             row.DefaultCellStyle.Font = New Font(DataGridView1.Font, FontStyle.Bold)

                                             ' selection colors
                                             row.DefaultCellStyle.SelectionBackColor = Color.Peru
                                             row.DefaultCellStyle.SelectionForeColor = Color.Black

                                         Case Else
                                             row.DefaultCellStyle.BackColor = Color.White
                                             row.DefaultCellStyle.ForeColor = Color.Black

                                             ' selection colors for other rows
                                             row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 232, 255)
                                             row.DefaultCellStyle.SelectionForeColor = Color.Black
                                     End Select


                                     r += 1
                                 Next

                                 DataGridView1.ClearSelection()
                                 DataGridView1.CurrentCell = Nothing
                             End Sub)
    End Function


    ' -------------------- Date picker handler --------------------
    Private Async Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        userSelectedDate = True
        Dim d = dtpDate.Value.Date
        startDate = d
        endDate = d
        Await SafeRefreshAsync()
    End Sub

    ' -------------------- Reset helper --------------------
    Public Async Function ResetToDefault() As Task
        userSelectedDate = False
        startDate = DateTime.Now.Date.AddDays(-6)
        endDate = DateTime.Now.Date
        dtpDate.Value = DateTime.Now
        Await SafeRefreshAsync()
    End Function

    ' -------------------- Dispose listeners --------------------
    Private Async Function DisposeListenersAsync() As Task
        Try
            If ordersListener IsNot Nothing Then
                Await ordersListener.StopAsync()
                ordersListener = Nothing
            End If
            If productsListener IsNot Nothing Then
                Await productsListener.StopAsync()
                productsListener = Nothing
            End If
        Catch ex As Exception
            Debug.WriteLine("Dispose listeners error: " & ex.Message)
        End Try
    End Function

End Class
