Imports Google.Cloud.Firestore
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class UcOrders
    Private db As FirestoreDb
    Private allOrders As List(Of Dictionary(Of String, Object))
    Private ordersListener As FirestoreChangeListener
    Private isUpdating As Boolean = False


    ' 🔶 --- Orange Border Settings ---
    ' 🔶 --- Rounded Orange Border for Panels ---
    ' 🔶 --- Rounded Orange Border for Panels ---
    ' 🔶 --- Class-level Border Settings ---
    ' 🔶 --- Class-level Border Settings ---
    ' 🔶 --- Class-level Border Settings ---
    ' 🔶 --- Class-level Border Settings ---
    Private ReadOnly panelBorderColor As Color = Color.FromArgb(31, 42, 68)
    Private ReadOnly panelBorderWidth As Integer = 2
    Private ReadOnly pictureBorderColor As Color = Color.FromArgb(31, 42, 68)
    Private ReadOnly pictureBorderWidth As Integer = 1
    Private ReadOnly borderRadius As Integer = 0 ' 0 = sharp corners, change to >0 for rounded

    ' 🔶 --- Paint Event Handler for Panels and PictureBoxes ---
    Private Sub Control_Paint(sender As Object, e As PaintEventArgs) _
    Handles panelTotalOrders.Paint, panelNewOrders.Paint, panelCompletedOrders.Paint, panelCanceledOrders.Paint,
            PictureBox1.Paint, PictureBox2.Paint, PictureBox3.Paint, PictureBox4.Paint

        Dim ctrl As Control = DirectCast(sender, Control)

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
        Dim rect As New Rectangle(currentBorderWidth \ 2, currentBorderWidth \ 2,
                              ctrl.Width - currentBorderWidth, ctrl.Height - currentBorderWidth)

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Using pen As New Pen(currentBorderColor, currentBorderWidth)
            pen.Alignment = Drawing2D.PenAlignment.Inset

            If borderRadius > 0 Then
                Using path As New Drawing2D.GraphicsPath()
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

    ' 🔹 Load event
    Private Sub UcOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeFirestore()
        StyleUI()
        StyleDataGrid()
        SetupComboBoxes()
        StartRealtimeOrders() ' Start real-time listener
    End Sub

    ' 🔹 Initialize Firestore connection
    Private Sub InitializeFirestore()
        Try
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", Application.StartupPath & "\serviceAccount.json")
            db = FirestoreDb.Create("pawfessional-app")
        Catch ex As Exception
            MessageBox.Show("Firestore initialization failed: " & ex.Message)
        End Try
    End Sub

    ' 🎨 Elegant UI Styling
    Private Sub StyleUI()
        Me.BackColor = Color.FromArgb(248, 249, 252)
        For Each lbl In New Label() {lblTotalOrders, lblNewOrders, lblCompletedOrders, lblCanceledOrders}
            lbl.Font = New Font("Segoe UI", 16, FontStyle.Bold)
            lbl.ForeColor = Color.FromArgb(64, 64, 64)
        Next
    End Sub

    ' 🎨 DataGridView Styling
    Private Sub StyleDataGrid()
        With dgvOrders
            .ReadOnly = True
            .Dock = DockStyle.Fill
            .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            .BorderStyle = BorderStyle.None
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Header style
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersHeight = 28
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 42, 68)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Cell style
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 215, 255)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .DefaultCellStyle.Font = New Font("Segoe UI", 9)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Alternating rows
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 240, 255)
            .AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowTemplate.Height = 36
            .RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 232, 255)
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

            ' Optional border accent
            AddHandler .Paint, Sub(sender As Object, e As PaintEventArgs)
                                   Using pen As New Pen(Color.FromArgb(220, 210, 255), 1)
                                       e.Graphics.DrawRectangle(pen, .DisplayRectangle)
                                   End Using
                               End Sub
        End With
    End Sub

    ' 🔹 Initialize ComboBoxes
    Private Sub SetupComboBoxes()
        If cmbProductType IsNot Nothing Then
            cmbProductType.Items.Clear()
            cmbProductType.Items.Add("All")
            cmbProductType.Items.Add("Food")
            cmbProductType.Items.Add("Vitamin")
            cmbProductType.Items.Add("Pet Supplies")
            cmbProductType.SelectedIndex = 0
        End If

        If cmbStatus IsNot Nothing Then
            cmbStatus.Items.Clear()
            cmbStatus.Items.Add("All")
            cmbStatus.Items.Add("Pending")
            cmbStatus.Items.Add("Completed")
            cmbStatus.Items.Add("Cancelled")
            cmbStatus.SelectedIndex = 0
        End If
    End Sub

    ' 🔹 Start real-time listener
    Private Sub StartRealtimeOrders()
        Try
            If ordersListener IsNot Nothing Then ordersListener.StopAsync()
            ordersListener = db.Collection("orders").Listen(AddressOf OnOrdersChanged)
        Catch ex As Exception
            MessageBox.Show("Failed to start real-time listener: " & ex.Message)
        End Try
    End Sub

    ' 🔹 Firestore snapshot callback
    Private Sub OnOrdersChanged(snapshot As QuerySnapshot)
        allOrders = New List(Of Dictionary(Of String, Object))

        For Each doc In snapshot.Documents
            Dim order = doc.ToDictionary()
            order("docId") = doc.Id
            If Not order.ContainsKey("productType") Then order("productType") = "Unknown"
            allOrders.Add(order)
        Next

        ' Update UI on main thread
        If Me.InvokeRequired Then
            Me.Invoke(Sub()
                          ApplyFilters()
                          UpdateStats(snapshot)
                      End Sub)
        Else
            ApplyFilters()
            UpdateStats(snapshot)
        End If
    End Sub

    ' 🔹 Update statistics
    Private Sub UpdateStats(snapshot As QuerySnapshot)
        Dim todayUtc = DateTime.UtcNow.Date

        Dim newOrders = snapshot.Where(Function(d)
                                           Return d.ContainsField("createdAt") AndAlso
                                                  d.GetValue(Of Timestamp)("createdAt").ToDateTime().Date = todayUtc
                                       End Function).Count()
        lblNewOrders.Text = newOrders.ToString()

        Dim completedOrders = snapshot.Where(Function(d)
                                                 If d.ContainsField("status") Then
                                                     Dim s = d.GetValue(Of String)("status").Trim().ToLower()
                                                     Return s = "paid" OrElse s = "completed" OrElse s = "done"
                                                 End If
                                                 Return False
                                             End Function).Count()
        lblCompletedOrders.Text = completedOrders.ToString()

        Dim cancelledOrders = snapshot.Where(Function(d)
                                                 If d.ContainsField("status") Then
                                                     Dim s = d.GetValue(Of String)("status").Trim().ToLower()
                                                     Return s = "cancelled" OrElse s = "canceled"
                                                 End If
                                                 Return False
                                             End Function).Count()
        lblCanceledOrders.Text = cancelledOrders.ToString()
        lblTotalOrders.Text = snapshot.Count.ToString()
    End Sub

    ' 🔹 Display orders in DataGridView
    Private Sub DisplayOrders(orderList As List(Of Dictionary(Of String, Object)))
        dgvOrders.Rows.Clear()
        dgvOrders.Columns.Clear()

        ' === SETUP COLUMNS FOR dgvOrders ===
        dgvOrders.Columns.Add("customername", "Customer Name")
        dgvOrders.Columns.Add("product", "Product")
        dgvOrders.Columns.Add("quantity", "Quantity")
        dgvOrders.Columns.Add("price", "Total Amount")
        dgvOrders.Columns.Add("status", "Status")
        dgvOrders.Columns.Add("docId", "Document ID")
        dgvOrders.Columns.Add("productType", "Product Type")

        dgvOrders.Columns("docId").Visible = False
        dgvOrders.Columns("productType").Visible = False

        ' 🔹 CENTER the numeric columns
        dgvOrders.Columns("quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvOrders.Columns("price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' 🔹 Ensure columns fill grid
        dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' 🔹 Widths
        dgvOrders.Columns("customername").FillWeight = 150
        dgvOrders.Columns("product").FillWeight = 150
        dgvOrders.Columns("quantity").FillWeight = 60
        dgvOrders.Columns("price").FillWeight = 70
        dgvOrders.Columns("status").FillWeight = 90



        ' Add rows
        For Each order In orderList
            Dim customerName = If(order.ContainsKey("customerName"), order("customerName").ToString(), "N/A")
            Dim product = If(order.ContainsKey("productName"), order("productName").ToString(), "N/A")
            Dim quantity = If(order.ContainsKey("quantity"), order("quantity").ToString(), "N/A")
            Dim price = If(order.ContainsKey("price"), order("price").ToString(), "0.00")
            Dim status = If(order.ContainsKey("status"), order("status").ToString(), "Pending")
            Dim docId = If(order.ContainsKey("docId"), order("docId").ToString(), "")
            Dim productType = If(order.ContainsKey("productType"), order("productType").ToString(), "Unknown")

            dgvOrders.Rows.Add(customerName, product, quantity, price, status, docId, productType)
        Next

        dgvOrders.ClearSelection()
        ApplyStatusColors()
    End Sub



    ' 🎨 Apply status colors
    Private Sub ApplyStatusColors()

        ' Ensure the Status column exists
        If Not dgvOrders.Columns.Contains("status") Then Exit Sub

        For Each row As DataGridViewRow In dgvOrders.Rows

            ' Skip placeholder new row
            If row.IsNewRow Then Continue For

            Dim cell As DataGridViewCell = row.Cells("status")

            ' Skip empty values
            If cell.Value Is Nothing Then Continue For

            Dim statusText As String = cell.Value.ToString().Trim().ToLower()

            Select Case statusText
                Case "pending"
                    cell.Style.ForeColor = Color.Orange

                Case "completed", "done", "paid"
                    cell.Style.ForeColor = Color.Green

                Case "cancelled", "canceled", "rejected"
                    cell.Style.ForeColor = Color.Red

                Case Else
                    cell.Style.ForeColor = Color.Black
            End Select

        Next

    End Sub

    ' 🎨 Rounded badges
    Private Sub dgvOrders_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvOrders.CellPainting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso dgvOrders.Columns(e.ColumnIndex).Name = "status" Then
            e.Handled = True
            e.PaintBackground(e.CellBounds, True)
            Dim g As Graphics = e.Graphics
            Dim text As String = e.FormattedValue.ToString()
            Dim smallerFont As New Font(e.CellStyle.Font.FontFamily, e.CellStyle.Font.Size - 0.5!, e.CellStyle.Font.Style)
            Dim textSize As Size = TextRenderer.MeasureText(text, e.CellStyle.Font)
            Dim horizontalPadding As Integer = 5
            Dim verticalPadding As Integer = 7
            Dim badgeWidth As Single = textSize.Width - 6 + horizontalPadding * 2
            Dim badgeHeight As Single = textSize.Height - 6 + verticalPadding * 2
            Dim badgeRect As New RectangleF(
                e.CellBounds.X + (e.CellBounds.Width - badgeWidth) / 2,
                e.CellBounds.Y + (e.CellBounds.Height - badgeHeight) / 2,
                badgeWidth, badgeHeight)

            Dim cornerRadius As Single = 2.5F
            Dim bgColor As Color
            Dim textColor As Color
            Select Case text.Trim().ToLower()
                Case "pending" : bgColor = Color.FromArgb(0, 204, 102) : textColor = Color.Black
                Case "completed", "done", "paid" : bgColor = Color.FromArgb(0, 255, 255) : textColor = Color.Black
                Case "cancelled", "canceled", "rejected" : bgColor = Color.FromArgb(255, 102, 102) : textColor = Color.Black
                Case Else : bgColor = Color.Gainsboro : textColor = Color.Black
            End Select

            Using path As GraphicsPath = CreateRoundedRectangle(badgeRect, cornerRadius)
                Using brush As New SolidBrush(bgColor)
                    g.FillPath(brush, path)
                End Using
            End Using

            TextRenderer.DrawText(g, text, smallerFont, Rectangle.Round(badgeRect), textColor,
                                  TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If
    End Sub

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

    ' 🔹 Filters
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatus.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub cmbProductType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductType.SelectedIndexChanged
        ApplyFilters()
    End Sub

    Private Sub ApplyFilters()
        If allOrders Is Nothing Then Return
        Dim searchText As String = txtSearch.Text.Trim().ToLower()
        Dim selectedStatus As String = cmbStatus.SelectedItem.ToString().ToLower()
        Dim selectedProductType As String = cmbProductType.SelectedItem.ToString().ToLower()

        Dim filteredOrders = allOrders.Where(Function(order)
                                                 Dim matchStatus = (selectedStatus = "all" OrElse (order.ContainsKey("status") AndAlso order("status").ToString().ToLower().Contains(selectedStatus)))
                                                 Dim matchProduct = (selectedProductType = "all" OrElse (order.ContainsKey("productType") AndAlso order("productType").ToString().ToLower() = selectedProductType))
                                                 Dim matchSearch = (String.IsNullOrEmpty(searchText) OrElse order.Values.Any(Function(v) v.ToString().ToLower().Contains(searchText)))
                                                 Return matchStatus AndAlso matchProduct AndAlso matchSearch
                                             End Function).ToList()

        DisplayOrders(filteredOrders)
    End Sub

    ' ❌ Delete Order
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check selection
        If dgvOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an order to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Ensure required columns exist
        If Not dgvOrders.Columns.Contains("docId") Then
            MessageBox.Show("The order list is still loading. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Lock UI updates
        isUpdating = True

        Try
            ' Stop real-time listener to avoid conflicts during delete
            If ordersListener IsNot Nothing Then
                Try
                    Await ordersListener.StopAsync()
                Catch
                    ' Ignore listener stopping error
                End Try
                ordersListener = Nothing
            End If

            ' Get selected row safely
            Dim row As DataGridViewRow = dgvOrders.SelectedRows(0)
            If row Is Nothing OrElse row.IsNewRow Then
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Safe access to docId cell
            Dim docCell = row.Cells("docId")
            If docCell Is Nothing OrElse docCell.Value Is Nothing Then
                MessageBox.Show("Cannot delete: Missing document ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim docId As String = docCell.Value.ToString().Trim()

            If String.IsNullOrWhiteSpace(docId) Then
                MessageBox.Show("Invalid document ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Delete from Firestore
            Try
                Await db.Collection("orders").Document(docId).DeleteAsync()
                MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' DO NOT manually delete the row — listener will refresh the grid
            Catch ex As Exception
                MessageBox.Show("Failed to delete order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Finally
            ' Restart listener
            Try
                StartRealtimeOrders()
            Catch ex As Exception
                MessageBox.Show("Warning: failed to restart listener: " & ex.Message,
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            isUpdating = False
        End Try
    End Sub


    ' ✅ Complete Orders
    ' Add this at the top of your form:
    ' Private isUpdating As Boolean = False

    Private Async Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        ' Basic selection check
        If dgvOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one pending order to complete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Ensure columns exist (defensive)
        If Not dgvOrders.Columns.Contains("status") OrElse Not dgvOrders.Columns.Contains("docId") Then
            MessageBox.Show("The order list is still loading. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Lock updates and stop listener to avoid race conditions
        isUpdating = True
        Try
            ' Stop the real-time listener to prevent it from rebuilding the grid mid-update
            If ordersListener IsNot Nothing Then
                Try
                    Await ordersListener.StopAsync()
                Catch exStop As Exception
                    ' non-fatal: log or ignore; we'll still attempt updates
                End Try
                ordersListener = Nothing
            End If

            Dim updatedCount As Integer = 0

            ' Copy selected rows to array to avoid collection-modification issues
            Dim rows = dgvOrders.SelectedRows.Cast(Of DataGridViewRow)().ToArray()

            For Each row As DataGridViewRow In rows
                If row Is Nothing OrElse row.IsNewRow Then Continue For

                ' Defensive access: ensure cell exists for this row
                If Not dgvOrders.Columns.Contains("status") OrElse Not dgvOrders.Columns.Contains("docId") Then
                    Continue For
                End If

                Dim statusCell = row.Cells("status")
                Dim docCell = row.Cells("docId")

                If statusCell Is Nothing OrElse docCell Is Nothing Then Continue For

                Dim currentStatus As String = If(statusCell.Value, "").ToString().Trim().ToLower()
                Dim docId As String = If(docCell.Value, "").ToString().Trim()

                If String.IsNullOrWhiteSpace(docId) Then Continue For

                If currentStatus = "pending" Then
                    Try
                        Await db.Collection("orders").Document(docId).UpdateAsync(
                        New Dictionary(Of String, Object) From {{"status", "Completed"}})

                        ' Update UI cell if column still exists
                        If dgvOrders.Columns.Contains("status") Then
                            row.Cells("status").Value = "Completed"
                        End If

                        updatedCount += 1
                    Catch ex As Exception
                        MessageBox.Show($"Failed to update order ({docId}): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Next

            If updatedCount > 0 Then
                MessageBox.Show($"{updatedCount} order(s) marked as completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Finally
            ' Always restart the listener and unlock
            Try
                StartRealtimeOrders()
            Catch exStart As Exception
                ' If restart fails, show a message (or log). Do not crash.
                MessageBox.Show("Warning: failed to restart orders listener: " & exStart.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            isUpdating = False
        End Try
    End Sub

    ' ❌ Cancel Orders
    Private Async Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Basic selection check
        If dgvOrders.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one pending order to cancel.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Ensure columns exist (defensive)
        If Not dgvOrders.Columns.Contains("status") OrElse Not dgvOrders.Columns.Contains("docId") Then
            MessageBox.Show("The order list is still loading. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Lock updates
        isUpdating = True

        Try
            ' Stop listener to avoid grid refreshing while updating
            If ordersListener IsNot Nothing Then
                Try
                    Await ordersListener.StopAsync()
                Catch
                    ' safe ignore
                End Try
                ordersListener = Nothing
            End If

            Dim updatedCount As Integer = 0

            ' Copy selection to array to avoid modification issues
            Dim rows = dgvOrders.SelectedRows.Cast(Of DataGridViewRow)().ToArray()

            For Each row As DataGridViewRow In rows
                If row Is Nothing OrElse row.IsNewRow Then Continue For

                ' Safe per-row column access
                If Not dgvOrders.Columns.Contains("status") OrElse Not dgvOrders.Columns.Contains("docId") Then
                    Continue For
                End If

                Dim statusCell = row.Cells("status")
                Dim docCell = row.Cells("docId")

                If statusCell Is Nothing OrElse docCell Is Nothing Then Continue For

                Dim currentStatus As String = If(statusCell.Value, "").ToString().Trim().ToLower()
                Dim docId As String = If(docCell.Value, "").ToString().Trim()

                If String.IsNullOrWhiteSpace(docId) Then Continue For

                ' Only cancel pending orders
                If currentStatus = "pending" Then
                    Try
                        Await db.Collection("orders").Document(docId).UpdateAsync(
                            New Dictionary(Of String, Object) From {{"status", "Cancelled"}})

                        ' Update UI
                        If dgvOrders.Columns.Contains("status") Then
                            row.Cells("status").Value = "Cancelled"
                        End If

                        updatedCount += 1

                    Catch ex As Exception
                        MessageBox.Show($"Failed to cancel order ({docId}): {ex.Message}", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Next

            If updatedCount > 0 Then
                MessageBox.Show($"{updatedCount} order(s) marked as cancelled.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Finally
            ' Restart the listener no matter what
            Try
                StartRealtimeOrders()
            Catch ex As Exception
                MessageBox.Show("Warning: unable to restart order listener: " & ex.Message,
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try

            isUpdating = False
        End Try
    End Sub


End Class
