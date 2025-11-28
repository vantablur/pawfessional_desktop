Imports Google.Cloud.Firestore
Imports System.Windows.Forms.DataVisualization.Charting

Public Class UcDashboard
    Private firestoreDb As FirestoreDb
    Private ordersListener As Object
    Private appointmentsListener As Object

    Private Async Sub UcDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await ConnectToFirestore()
    End Sub

    Private Async Function ConnectToFirestore() As Task
        Try
            ' ✅ Path ng iyong serviceAccount.json (dapat nasa root folder ng project mo)
            Dim path As String = Application.StartupPath & "\serviceAccount.json"
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path)

            ' ✅ Firestore Project ID (pareho dapat sa mobile app)
            firestoreDb = FirestoreDb.Create("pawfessional-app")

            ' ✅ Load initial data
            Await LoadDashboardData()
            Await LoadRecentOrders()

            ' ✅ Initialize Chart
            SetupChart()

            ' ✅ Start Firestore listeners for real-time updates
            StartRealtimeListeners()

        Catch ex As Exception
            Console.WriteLine("Error connecting to Firestore: " & ex.Message)
        End Try
    End Function

    ' ===============================
    ' 🟢 DASHBOARD COUNTS
    ' ===============================
    Private Async Function LoadDashboardData() As Task
        Try
            Dim appointmentCollection As CollectionReference = firestoreDb.Collection("appointments")
            Dim appointmentSnapshot As QuerySnapshot = Await appointmentCollection.GetSnapshotAsync()
            Dim totalAppointments As Integer = appointmentSnapshot.Count

            Dim ordersCollection As CollectionReference = firestoreDb.Collection("orders")
            Dim ordersSnapshot As QuerySnapshot = Await ordersCollection.GetSnapshotAsync()
            Dim totalOrders As Integer = ordersSnapshot.Count

            lblTotalAppointments.Text = totalAppointments.ToString()
            lblTotalOrders.Text = totalOrders.ToString()

            ' ✅ Update chart with latest snapshot
            UpdateChartWithOrders(ordersSnapshot)

        Catch ex As Exception
            Console.WriteLine("Error loading dashboard data: " & ex.Message)
        End Try
    End Function

    ' ===============================
    ' 🟢 RECENT ORDERS
    ' ===============================
    Private Async Function LoadRecentOrders() As Task
        Try
            Dim ordersRef As CollectionReference = firestoreDb.Collection("orders")
            Dim snapshot As QuerySnapshot = Await ordersRef.GetSnapshotAsync()

            dgvRecentOrders.Rows.Clear()

            For Each doc As DocumentSnapshot In snapshot.Documents
                Dim data = doc.ToDictionary()

                Dim itemId As String = If(data.ContainsKey("itemId"), data("itemId").ToString(), "N/A")
                Dim name As String = If(data.ContainsKey("productName"), data("productName").ToString(), "N/A")
                Dim price As String = If(data.ContainsKey("price"), "₱" & data("price").ToString(), "₱0.00")
                Dim quantity As String = If(data.ContainsKey("quantity"), data("quantity").ToString(), "0")
                Dim status As String = If(data.ContainsKey("status"), data("status").ToString(), "N/A")

                Dim rowIndex As Integer = dgvRecentOrders.Rows.Add(itemId, name, price, quantity, status)

                Dim row = dgvRecentOrders.Rows(rowIndex)
                row.DefaultCellStyle.ForeColor = Color.Black
            Next

        Catch ex As Exception
            Console.WriteLine("Error loading recent orders: " & ex.Message)
        End Try
    End Function

    ' ===============================
    ' 🟢 REAL-TIME LISTENERS
    ' ===============================
    Private Sub StartRealtimeListeners()
        Try
            ordersListener = firestoreDb.Collection("orders").Listen(
                Sub(snapshot)
                    Me.Invoke(New Action(Async Sub()
                                             Await LoadDashboardData()
                                             Await LoadRecentOrders()
                                             UpdateChartWithOrders(snapshot)
                                         End Sub))
                End Sub)

            appointmentsListener = firestoreDb.Collection("appointments").Listen(
                Sub(snapshot)
                    Me.Invoke(New Action(Async Sub()
                                             Await LoadDashboardData()
                                         End Sub))
                End Sub)

        Catch ex As Exception
            Console.WriteLine("Error starting listeners: " & ex.Message)
        End Try
    End Sub

    ' ===============================
    ' 🟢 CHART SETUP
    ' ===============================
    Private Sub SetupChart()
        Try
            Chart1.Series.Clear()
            Chart1.ChartAreas.Clear()
            Chart1.Titles.Clear()

            Dim area As New ChartArea("MainArea")
            Chart1.ChartAreas.Add(area)

            Dim series As New Series("Order Status")
            series.ChartType = SeriesChartType.Column
            series.IsValueShownAsLabel = True
            series.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            Chart1.Series.Add(series)

            Chart1.Titles.Add("📊 Order Status Overview")
            Chart1.Titles(0).Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Catch ex As Exception
            Console.WriteLine("Error setting up chart: " & ex.Message)
        End Try
    End Sub

    ' ===============================
    ' 🟢 CHART UPDATE FUNCTION
    ' ===============================
    Private Sub UpdateChartWithOrders(snapshot As QuerySnapshot)
        Try
            Dim paidCount As Integer = 0
            Dim pendingCount As Integer = 0
            Dim cancelledCount As Integer = 0

            For Each doc As DocumentSnapshot In snapshot.Documents
                If doc.ContainsField("status") Then
                    Dim status As String = doc.GetValue(Of String)("status").ToLower()
                    Select Case status
                        Case "paid"
                            paidCount += 1
                        Case "pending"
                            pendingCount += 1
                        Case "cancelled"
                            cancelledCount += 1
                    End Select
                End If
            Next

            ' ✅ Update chart visually
            Dim series = Chart1.Series("Order Status")
            series.Points.Clear()
            series.Points.AddXY("Paid", paidCount)
            series.Points.AddXY("Pending", pendingCount)
            series.Points.AddXY("Cancelled", cancelledCount)

        Catch ex As Exception
            Console.WriteLine("Error updating chart: " & ex.Message)
        End Try
    End Sub

    Private Async Sub UcDashboard_Disposed(sender As Object, e As EventArgs) Handles MyBase.Disposed
        Try
            ' ✅ Safely stop Firestore listeners if they exist
            If ordersListener IsNot Nothing Then
                Try
                    Await ordersListener.StopAsync()
                Catch
                End Try
            End If

            If appointmentsListener IsNot Nothing Then
                Try
                    Await appointmentsListener.StopAsync()
                Catch
                End Try
            End If

        Catch
            ' Ignore any shutdown errors
        End Try
    End Sub

End Class
