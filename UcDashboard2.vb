Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Text
Imports Google.Cloud.Firestore
Imports Grpc.Core
Imports Syncfusion.Windows.Forms.Tools

Public Class UcDashboard2

    Private firestoreDb As FirestoreDb
    Private ordersListener As FirestoreChangeListener
    Private appointmentsListener As FirestoreChangeListener

    Private isModernTheme As Boolean = True
    Private isInitializing As Boolean = True

    ' 🔶 Border Settings
    Private ReadOnly panelBorderColor As Color = Color.FromArgb(31, 42, 68)
    Private ReadOnly panelBorderWidth As Integer = 2

    Private ReadOnly pictureBorderColor As Color = Color.FromArgb(31, 42, 68)
    Private ReadOnly pictureBorderWidth As Integer = 1

    Private ReadOnly borderRadius As Integer = 0 ' 0 = sharp corners

    ' ------------------------------------------------------------
    ' 🔶 Paint Event Handler for Panels and PictureBoxes
    ' ------------------------------------------------------------
    Private Sub Control_Paint(sender As Object, e As PaintEventArgs) _
        Handles Panel1.Paint, Panel2.Paint, Panel5.Paint, Panel6.Paint, Panel7.Paint, Panel8.Paint,
                PictureBox3.Paint, PictureBox5.Paint, PictureBox1.Paint, PictureBox6.Paint

        Dim ctrl = DirectCast(sender, Control)

        Dim currentBorderWidth As Integer
        Dim currentBorderColor As Color

        If TypeOf ctrl Is Panel Then
            currentBorderWidth = panelBorderWidth
            currentBorderColor = panelBorderColor

        ElseIf TypeOf ctrl Is PictureBox Then
            currentBorderWidth = pictureBorderWidth
            currentBorderColor = pictureBorderColor

        Else
            Exit Sub
        End If

        Dim rect As New Rectangle(
            currentBorderWidth \ 2,
            currentBorderWidth \ 2,
            ctrl.Width - currentBorderWidth,
            ctrl.Height - currentBorderWidth
        )

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Using pen As New Pen(currentBorderColor, currentBorderWidth)
            pen.Alignment = PenAlignment.Inset

            If borderRadius > 0 Then
                Using path As New GraphicsPath()
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


    ' ------------------------------------------------------------
    ' 🔥 Firestore Realtime Dashboard
    ' ------------------------------------------------------------
    Private Sub StartDashboardRealtime()
        Try
            ' 🔹 Listen to ORDERS
            firestoreDb.Collection("orders").Listen(
            Sub(snapshot)
                Me.BeginInvoke(New Func(Of Task)(AddressOf LoadDashboardData))
            End Sub)

            ' 🔹 Listen to APPOINTMENTS
            firestoreDb.Collection("appointments").Listen(
            Sub(snapshot)
                Me.BeginInvoke(New Func(Of Task)(AddressOf LoadDashboardData))
            End Sub)

        Catch ex As Exception
            Console.WriteLine("Dashboard realtime error: " & ex.Message)
        End Try
    End Sub


    ' ------------------------------------------------------------
    ' 🧠 Load Event
    ' ------------------------------------------------------------
    Private Async Sub UcDashboard2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        ApplyTheme()
        StyleDataGrid()
        Await ConnectToFirestore()
        Await StartFadeIn()
    End Sub


    ' ------------------------------------------------------------
    ' 🎨 Theme Switcher
    ' ------------------------------------------------------------
    Private Sub ApplyTheme()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Panel AndAlso Not TypeOf ctrl Is DataGridView Then
                Dim pnl = DirectCast(ctrl, Panel)
                pnl.BackColor = If(isModernTheme, Color.White, Color.FromArgb(240, 240, 240))
            End If
        Next
    End Sub


    ' ------------------------------------------------------------
    ' ✨ DataGridView Styling
    ' ------------------------------------------------------------
    Private Sub StyleDataGrid()
        Dim headerBackColor As Color = Color.FromArgb(31, 42, 68)
        Dim headerForeColor As Color = Color.White
        Dim altRowColor As Color = Color.FromArgb(245, 240, 255)
        Dim gridLineColor As Color = Color.FromArgb(220, 210, 255)
        Dim selectedRowColor As Color = Color.FromArgb(210, 232, 255)

        Dim grids() As DataGridView = {dgvRecentOrders, dgvAppointment}

        For Each dgv In grids
            dgv.Dock = DockStyle.Fill
            dgv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv.AllowUserToResizeColumns = False
            dgv.AllowUserToResizeRows = False
            dgv.AllowUserToAddRows = False
            dgv.AllowUserToDeleteRows = False
            dgv.AllowUserToOrderColumns = False
            dgv.ReadOnly = True
            dgv.RowHeadersVisible = False
            dgv.BackgroundColor = Color.White
            dgv.GridColor = gridLineColor
            dgv.BorderStyle = BorderStyle.None
            dgv.EnableHeadersVisualStyles = False

            dgv.ColumnHeadersDefaultCellStyle.BackColor = headerBackColor
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = headerForeColor
            dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10)
            dgv.ColumnHeadersHeight = 28
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.DefaultCellStyle.BackColor = Color.White
            dgv.DefaultCellStyle.ForeColor = Color.Black
            dgv.AlternatingRowsDefaultCellStyle.BackColor = altRowColor

            dgv.DefaultCellStyle.SelectionBackColor = selectedRowColor
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgv.RowTemplate.Height = 44
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ' Clear selection
            AddHandler dgv.DataBindingComplete,
                Sub(s, e) dgv.ClearSelection()

            ' Enforce row height
            AddHandler dgv.RowPrePaint,
                Sub(sender2, e2)
                    Dim g = DirectCast(sender2, DataGridView)
                    g.Rows(e2.RowIndex).Height = 34
                End Sub
        Next

        ' --- Setup columns (unchanged) ---
        dgvRecentOrders.Columns.Clear()
        dgvRecentOrders.Columns.AddRange(
            New DataGridViewColumn() {
                New DataGridViewTextBoxColumn With {.Name = "itemId", .HeaderText = "Item ID", .FillWeight = 70},
                New DataGridViewTextBoxColumn With {.Name = "customerName", .HeaderText = "Customer Name", .FillWeight = 160},
                New DataGridViewTextBoxColumn With {.Name = "productName", .HeaderText = "Product Name", .FillWeight = 200},
                New DataGridViewTextBoxColumn With {.Name = "price", .HeaderText = "Total", .FillWeight = 60},
                New DataGridViewTextBoxColumn With {.Name = "quantity", .HeaderText = "Quantity", .FillWeight = 60},
                New DataGridViewTextBoxColumn With {.Name = "status", .HeaderText = "Status", .FillWeight = 80}
            })

        dgvAppointment.Columns.Clear()
        dgvAppointment.Columns.AddRange(
            New DataGridViewColumn() {
                New DataGridViewTextBoxColumn With {.Name = "name", .HeaderText = "Client Name", .FillWeight = 140},
                New DataGridViewTextBoxColumn With {.Name = "contactNumber", .HeaderText = "Contact Number", .FillWeight = 100},
                New DataGridViewTextBoxColumn With {.Name = "email", .HeaderText = "Email", .FillWeight = 150},
                New DataGridViewTextBoxColumn With {.Name = "appointmentDate", .HeaderText = "Date", .FillWeight = 100},
                New DataGridViewTextBoxColumn With {.Name = "appointmentTime", .HeaderText = "Time", .FillWeight = 100},
                New DataGridViewTextBoxColumn With {.Name = "status", .HeaderText = "Status", .FillWeight = 80},
                New DataGridViewTextBoxColumn With {.Name = "docId", .HeaderText = "Doc ID", .Visible = False}
            })
    End Sub


    ' ------------------------------------------------------------
    ' 💨 Fade-in Animation
    ' ------------------------------------------------------------
    Private Async Function StartFadeIn() As Task
        Dim alpha As Integer = 180
        Dim bg As Color = Color.FromArgb(245, 247, 250)

        For i As Integer = alpha To 255 Step 5
            Me.BackColor = Color.FromArgb(i, bg)
            Await Task.Delay(15)
        Next
    End Function


    ' ------------------------------------------------------------
    ' 🔥 Firestore Setup
    ' ------------------------------------------------------------
    Private Async Function ConnectToFirestore() As Task
        Try
            Environment.SetEnvironmentVariable(
                "GOOGLE_APPLICATION_CREDENTIALS",
                Application.StartupPath & "\serviceAccount.json"
            )

            firestoreDb = FirestoreDb.Create("pawfessional-app")

            Await LoadDashboardData()
            StartRealtimeListeners()
            StartDashboardRealtime()

            isInitializing = False

        Catch ex As Exception
            Console.WriteLine("Error connecting to Firestore: " & ex.Message)
        End Try
    End Function


    ' ------------------------------------------------------------
    ' 📊 Load Dashboard Totals
    ' ------------------------------------------------------------
    Private Async Function LoadDashboardData() As Task
        Try
            ' Load product costs FIRST
            If productCostCache.Count = 0 Then
                Await LoadProductCostsAsync()
            End If

            Dim ordersSnapshot = Await firestoreDb.Collection("orders").GetSnapshotAsync()
            Dim appointmentSnapshot = Await firestoreDb.Collection("appointments").GetSnapshotAsync()

            lblTotalOrders.Text = ordersSnapshot.Count.ToString()
            lblTotalAppointments.Text = appointmentSnapshot.Count.ToString()

            Dim totalRevenue As Double = 0
            Dim totalCost As Double = 0
            Dim totalSales As Integer = 0

            For Each doc In ordersSnapshot.Documents
                If Not doc.ContainsField("status") Then Continue For

                Dim status As String = doc.GetValue(Of String)("status").ToLower()
                If status <> "completed" AndAlso status <> "paid" AndAlso status <> "done" Then Continue For

                ' FIX WRONG STORED PRICE (auto-correct)
                Dim storedPrice = Convert.ToDouble(doc.GetValue(Of Object)("price"))
                Dim qty = Convert.ToInt32(doc.GetValue(Of Object)("quantity"))

                Dim unitPrice As Double = storedPrice
                If storedPrice > 0 AndAlso qty > 1 AndAlso storedPrice > 100 Then
                    unitPrice = storedPrice / qty
                End If

                totalRevenue += unitPrice * qty
                totalSales += qty

                ' Compute cost
                If doc.ContainsField("itemId") Then
                    Dim itemId = doc.GetValue(Of String)("itemId")

                    If productCostCache.ContainsKey(itemId) Then
                        totalCost += productCostCache(itemId) * qty
                    End If
                End If
            Next

            lblTotalRevenue.Text = "₱" & totalRevenue.ToString("N2")
            lblTotalSales.Text = totalSales.ToString("N0")
            lblTotalCost.Text = "₱" & totalCost.ToString("N2")
            lblTotalProfit.Text = "₱" & (totalRevenue - totalCost).ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard data: " & ex.Message)
        End Try
    End Function

    ' ------------------------------------------------------------
    ' Helper Background Calculator
    ' ------------------------------------------------------------

    Private Async Sub CalculateCostAndProfitAsync(
        ordersSnapshot As QuerySnapshot,
        totalRevenue As Double)

        Try
            Dim totalCost As Double = 0
            Dim productQuantities As New Dictionary(Of String, Integer)

            For Each doc In ordersSnapshot.Documents
                If Not doc.ContainsField("status") Then Continue For

                Dim status As String = doc.GetValue(Of String)("status").ToLower()
                If status <> "completed" AndAlso status <> "paid" AndAlso status <> "done" Then Continue For

                If doc.ContainsField("itemId") Then
                    Dim itemId = doc.GetValue(Of String)("itemId")
                    Dim qty As Integer =
                        If(doc.ContainsField("quantity") AndAlso IsNumeric(doc.GetValue(Of Object)("quantity")),
                           Convert.ToInt32(doc.GetValue(Of Object)("quantity")), 1)

                    If productQuantities.ContainsKey(itemId) Then
                        productQuantities(itemId) += qty
                    Else
                        productQuantities(itemId) = qty
                    End If
                End If
            Next

            Dim productTasks =
    productQuantities.Keys.
        Select(Function(id)
                   Return firestoreDb.Collection("products").Document(id).GetSnapshotAsync()
               End Function).
        ToArray()

            Dim productSnapshots = Await Task.WhenAll(productTasks)


            For Each snap In productSnapshots
                If snap.Exists AndAlso snap.ContainsField("cost") Then
                    Dim itemId = snap.Id
                    Dim cost As Double = Convert.ToDouble(snap.GetValue(Of Object)("cost"))
                    Dim qty As Integer = productQuantities(itemId)
                    totalCost += cost * qty
                End If
            Next

            Dim totalProfit = totalRevenue - totalCost

            Me.Invoke(Sub()
                          lblTotalCost.Text = "₱" & totalCost.ToString("N2")
                          lblTotalProfit.Text = "₱" & totalProfit.ToString("N2")
                      End Sub)

        Catch ex As Exception
            Console.WriteLine("Error calculating cost/profit: " & ex.Message)
        End Try
    End Sub


    ' ------------------------------------------------------------
    ' Product Cost Cache Loader
    ' ------------------------------------------------------------

    Private productCostCache As New Dictionary(Of String, Double)

    Private Async Function LoadProductCostsAsync() As Task
        Dim productsSnapshot = Await firestoreDb.Collection("products").GetSnapshotAsync()

        For Each snap In productsSnapshot.Documents
            If snap.Exists AndAlso snap.ContainsField("cost") Then
                productCostCache(snap.Id) = Convert.ToDouble(snap.GetValue(Of Object)("cost"))
            End If
        Next
    End Function


    ' ------------------------------------------------------------
    ' Real-time Listeners
    ' ------------------------------------------------------------

    Private Sub StartRealtimeListeners()
        ListenToRecentOrders()
        ListenToAppointments()
    End Sub


    ' ------------------------------------------------------------
    ' 🔥 Recent Orders Listener
    ' ------------------------------------------------------------

    Private Sub ListenToRecentOrders()
        Try
            ordersListener =
                firestoreDb.Collection("orders").Listen(
                    Sub(snapshot)
                        Me.Invoke(Sub()

                                      dgvRecentOrders.SuspendLayout()

                                      Dim rowsToAdd As New List(Of DataGridViewRow)
                                      Dim rowsToUpdate As New List(Of Tuple(Of DataGridViewRow, Dictionary(Of String, Object)))()
                                      Dim rowsToRemove As New List(Of DataGridViewRow)

                                      For Each change In snapshot.Changes
                                          Dim d = change.Document.ToDictionary()

                                          Select Case change.ChangeType

                                              Case DocumentChange.Type.Added
                                                  Dim row As New DataGridViewRow()
                                                  row.CreateCells(
                                                      dgvRecentOrders,
                                                      d.GetValueOrDefault("itemId", "N/A").ToString(),
                                                      d.GetValueOrDefault("customerName", "N/A").ToString(),
                                                      d.GetValueOrDefault("productName", "N/A").ToString(),
                                                      "₱" & d.GetValueOrDefault("price", "0.00").ToString(),
                                                      d.GetValueOrDefault("quantity", "0").ToString(),
                                                      d.GetValueOrDefault("status", "Pending").ToString()
                                                  )
                                                  rowsToAdd.Add(row)

                                              Case DocumentChange.Type.Modified
                                                  For Each row As DataGridViewRow In dgvRecentOrders.Rows
                                                      If row.Cells("itemId").Value.ToString() =
                                                          d.GetValueOrDefault("itemId", "").ToString() Then

                                                          rowsToUpdate.Add(Tuple.Create(row, d))
                                                          Exit For
                                                      End If
                                                  Next

                                              Case DocumentChange.Type.Removed
                                                  For Each row As DataGridViewRow In dgvRecentOrders.Rows
                                                      If row.Cells("itemId").Value.ToString() =
                                                          d.GetValueOrDefault("itemId", "").ToString() Then

                                                          rowsToRemove.Add(row)
                                                          Exit For
                                                      End If
                                                  Next
                                          End Select

                                      Next

                                      For Each row In rowsToRemove
                                          dgvRecentOrders.Rows.Remove(row)
                                      Next

                                      For Each tup In rowsToUpdate
                                          Dim row = tup.Item1
                                          Dim d = tup.Item2

                                          row.Cells("customerName").Value = d.GetValueOrDefault("customerName", "N/A").ToString()
                                          row.Cells("productName").Value = d.GetValueOrDefault("productName", "N/A").ToString()
                                          row.Cells("price").Value = "₱" & d.GetValueOrDefault("price", "0.00").ToString()
                                          row.Cells("quantity").Value = d.GetValueOrDefault("quantity", "0").ToString()
                                          row.Cells("status").Value = d.GetValueOrDefault("status", "Pending").ToString()
                                      Next

                                      For Each row In rowsToAdd
                                          dgvRecentOrders.Rows.Add(row)
                                      Next

                                      dgvRecentOrders.ClearSelection()
                                      dgvRecentOrders.ResumeLayout()

                                  End Sub)
                    End Sub)

        Catch ex As Exception
            Console.WriteLine("Error listening to recent orders: " & ex.Message)
        End Try
    End Sub


    ' ------------------------------------------------------------
    ' 🔥 Appointments Listener
    ' ------------------------------------------------------------

    Private Sub ListenToAppointments()
        Try
            appointmentsListener =
                firestoreDb.Collection("appointments").Listen(
                    Sub(snapshot)
                        Me.Invoke(Sub()

                                      dgvAppointment.SuspendLayout()

                                      Dim rowsToAdd As New List(Of DataGridViewRow)
                                      Dim rowsToUpdate As New List(Of Tuple(Of DataGridViewRow, Dictionary(Of String, Object)))()
                                      Dim rowsToRemove As New List(Of DataGridViewRow)

                                      For Each change In snapshot.Changes

                                          Dim d = change.Document.ToDictionary()
                                          Dim docId As String = change.Document.Id

                                          Dim formattedStatus As String =
                                              StrConv(d.GetValueOrDefault("status", "Pending").ToString(), VbStrConv.ProperCase)

                                          Select Case change.ChangeType

                                              Case DocumentChange.Type.Added
                                                  Dim row As New DataGridViewRow()
                                                  row.CreateCells(
                                                      dgvAppointment,
                                                      d.GetValueOrDefault("name", "").ToString(),
                                                      d.GetValueOrDefault("contactNumber", "").ToString(),
                                                      d.GetValueOrDefault("email", "").ToString(),
                                                      d.GetValueOrDefault("appointmentDate", "").ToString(),
                                                      d.GetValueOrDefault("appointmentTime", "").ToString(),
                                                      formattedStatus,
                                                      docId
                                                  )
                                                  rowsToAdd.Add(row)

                                              Case DocumentChange.Type.Modified
                                                  For Each row As DataGridViewRow In dgvAppointment.Rows
                                                      If row.Cells("docId").Value IsNot Nothing AndAlso
                                                         row.Cells("docId").Value.ToString() = docId Then

                                                          rowsToUpdate.Add(Tuple.Create(row, d))
                                                          Exit For
                                                      End If
                                                  Next

                                              Case DocumentChange.Type.Removed
                                                  For Each row As DataGridViewRow In dgvAppointment.Rows
                                                      If row.Cells("docId").Value IsNot Nothing AndAlso
                                                         row.Cells("docId").Value.ToString() = docId Then

                                                          rowsToRemove.Add(row)
                                                          Exit For
                                                      End If
                                                  Next

                                          End Select

                                      Next

                                      For Each row In rowsToRemove
                                          dgvAppointment.Rows.Remove(row)
                                      Next

                                      For Each tup In rowsToUpdate
                                          Dim row = tup.Item1
                                          Dim d = tup.Item2

                                          row.Cells("name").Value = d.GetValueOrDefault("name", "").ToString()
                                          row.Cells("email").Value = d.GetValueOrDefault("email", "").ToString()
                                          row.Cells("appointmentDate").Value = d.GetValueOrDefault("appointmentDate", "").ToString()
                                          row.Cells("appointmentTime").Value = d.GetValueOrDefault("appointmentTime", "").ToString()
                                          row.Cells("status").Value =
                                              StrConv(d.GetValueOrDefault("status", "Pending").ToString(), VbStrConv.ProperCase)
                                      Next

                                      For Each row In rowsToAdd
                                          dgvAppointment.Rows.Add(row)
                                      Next

                                      dgvAppointment.ClearSelection()
                                      dgvAppointment.ResumeLayout()

                                  End Sub)
                    End Sub)

        Catch ex As Exception
            Console.WriteLine("Error listening to appointments: " & ex.Message)
        End Try
    End Sub


    ' ------------------------------------------------------------
    ' Utility: Rounded Rectangle Generator
    ' ------------------------------------------------------------

    Private Function CreateRoundedRectangle(rect As RectangleF, radius As Single) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim diameter As Single = radius * 2

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()

        Return path
    End Function


    ' ------------------------------------------------------------
    ' Status Cell Painting (Orders)
    ' ------------------------------------------------------------
    Private Sub dgvRecentOrders_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) _
        Handles dgvRecentOrders.CellPainting

        If e.RowIndex < 0 Then Exit Sub
        If dgvRecentOrders.Columns(e.ColumnIndex).Name <> "status" Then Exit Sub

        e.Handled = True
        e.PaintBackground(e.CellBounds, True)

        Dim g As Graphics = e.Graphics
        Dim text As String = e.FormattedValue.ToString()
        Dim font As New Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 0.5!, e.CellStyle.Font.Style)

        Dim textSize As Size = TextRenderer.MeasureText(text, font)
        Dim padX As Integer = 5
        Dim padY As Integer = 7

        Dim badgeWidth As Single = textSize.Width - 6 + padX * 2
        Dim badgeHeight As Single = textSize.Height - 6 + padY * 2

        Dim rect As New RectangleF(
            e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2,
            e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2,
            badgeWidth,
            badgeHeight
        )

        Dim bgColor As Color

        Select Case text.Trim().ToLower()
            Case "pending" : bgColor = Color.FromArgb(0, 204, 102)
            Case "completed", "done", "paid" : bgColor = Color.FromArgb(0, 255, 255)
            Case "cancelled", "canceled", "rejected" : bgColor = Color.FromArgb(255, 102, 102)
            Case Else : bgColor = Color.Gainsboro
        End Select

        Using path = CreateRoundedRectangle(rect, 2.5F)
            Using brush As New SolidBrush(bgColor)
                g.FillPath(brush, path)
            End Using
        End Using

        TextRenderer.DrawText(
            g, text, font, Rectangle.Round(rect), Color.Black,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter
        )
    End Sub


    ' ------------------------------------------------------------
    ' Status Cell Painting (Appointments)
    ' ------------------------------------------------------------
    Private Sub dgvAppointment_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) _
        Handles dgvAppointment.CellPainting

        If e.RowIndex < 0 Then Exit Sub
        If dgvAppointment.Columns(e.ColumnIndex).Name <> "status" Then Exit Sub

        e.Handled = True
        e.PaintBackground(e.CellBounds, True)

        Dim g As Graphics = e.Graphics
        Dim text As String = e.FormattedValue.ToString()
        Dim font As New Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 0.5!, e.CellStyle.Font.Style)

        Dim textSize As Size = TextRenderer.MeasureText(text, font)
        Dim padX As Integer = 5
        Dim padY As Integer = 7

        Dim badgeWidth As Single = textSize.Width - 6 + padX * 2
        Dim badgeHeight As Single = textSize.Height - 6 + padY * 2

        Dim rect As New RectangleF(
            e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2,
            e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2,
            badgeWidth,
            badgeHeight
        )

        Dim bgColor As Color

        Select Case text.Trim().ToLower()
            Case "pending" : bgColor = Color.FromArgb(0, 204, 102)
            Case "completed", "done", "paid" : bgColor = Color.FromArgb(0, 255, 255)
            Case "cancelled", "canceled", "rejected" : bgColor = Color.FromArgb(255, 102, 102)
            Case Else : bgColor = Color.Gainsboro
        End Select

        Using path = CreateRoundedRectangle(rect, 2.5F)
            Using brush As New SolidBrush(bgColor)
                g.FillPath(brush, path)
            End Using
        End Using

        TextRenderer.DrawText(
            g, text, font, Rectangle.Round(rect), Color.Black,
            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter
        )
    End Sub


    ' ------------------------------------------------------------
    ' 🔹 Dispose → Stop Listeners
    ' ------------------------------------------------------------
    Private Async Sub UcDashboard2_Disposed(sender As Object, e As EventArgs) _
        Handles MyBase.Disposed

        Try
            If ordersListener IsNot Nothing Then Await ordersListener.StopAsync()
            If appointmentsListener IsNot Nothing Then Await appointmentsListener.StopAsync()
        Catch
        End Try
    End Sub

End Class
