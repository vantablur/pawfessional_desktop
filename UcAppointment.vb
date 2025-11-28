Imports Google.Cloud.Firestore
Imports Syncfusion.WinForms.Input
Imports Syncfusion.Licensing
Imports System.Drawing
Imports Google.Cloud.Firestore.V1
Imports Grpc.Core
Imports System
Imports System.Collections.Generic
Imports System.Threading.Tasks

Public Class UcAppointment
    Private db As FirestoreDb
    Private appointmentList As New Dictionary(Of String, Dictionary(Of String, Object))
    Private selectedAppointmentId As String = Nothing
    Private appointmentsListener As FirestoreChangeListener
    Private currentSelectedDate As Date = DateTime.Today ' Track calendar selection

    ' =========================================================
    ' 🚀 Load Event
    ' =========================================================
    Private Async Sub UcAppointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SyncfusionLicenseProvider.RegisterLicense(
            "Ngo9BigBOggjHTQxAR8/V1JFaF1cX2hIf0x1WmFZfVtgdVRMZFlbRXZPIiBoS35Rc0RjW3hcc3BQR2BdWUJ3VEFc"
        )

        InitializeFirestore()
        SfCalendar1.MinDate = DateTime.Today
        SfCalendar1.SelectedDate = DateTime.Today
        currentSelectedDate = DateTime.Today

        AddAppointmentListener()
        Await LoadAppointmentsAsync()
        HighlightCalendarDates()
    End Sub

    Private Sub InitializeFirestore()
        db = FirestoreDb.Create("pawfessional-app")
    End Sub

    ' =========================================================
    ' 🔹 REAL-TIME LISTENER
    ' =========================================================
    Private Sub AddAppointmentListener()
        Dim colRef = db.Collection("appointments")
        appointmentsListener = colRef.Listen(Sub(snapshot As Google.Cloud.Firestore.QuerySnapshot)
                                                 Try
                                                     For Each change As Google.Cloud.Firestore.DocumentChange In snapshot.Changes
                                                         Dim doc = change.Document
                                                         Dim appointmentId = doc.Id
                                                         Dim data = doc.ToDictionary()

                                                         Select Case change.ChangeType
                                                             Case Google.Cloud.Firestore.DocumentChange.Type.Added,
                                                            Google.Cloud.Firestore.DocumentChange.Type.Modified
                                                                 appointmentList(appointmentId) = data
                                                             Case Google.Cloud.Firestore.DocumentChange.Type.Removed
                                                                 appointmentList.Remove(appointmentId)
                                                         End Select
                                                     Next

                                                     ' Update UI safely
                                                     Me.Invoke(Sub()
                                                                   DisplayAppointmentsForDate(currentSelectedDate)
                                                                   HighlightCalendarDates()
                                                               End Sub)
                                                 Catch ex As Exception
                                                     MessageBox.Show($"Listener processing error: {ex.Message}")
                                                 End Try
                                             End Sub)
    End Sub




    ' =========================================================
    ' 🔹 LOAD APPOINTMENTS
    ' =========================================================
    Private Async Function LoadAppointmentsAsync() As Task
        Try
            flpAppointments.Controls.Clear()
            appointmentList.Clear()

            Dim snapshot = Await db.Collection("appointments").GetSnapshotAsync()
            For Each doc In snapshot.Documents
                appointmentList(doc.Id) = doc.ToDictionary()
            Next

            DisplayAppointmentsForDate(currentSelectedDate)
            HighlightCalendarDates()
        Catch ex As Exception
            MessageBox.Show($"Error loading appointments: {ex.Message}")
        End Try
    End Function

    ' =========================================================
    ' 🔹 DISPLAY APPOINTMENTS FOR SPECIFIC DATE
    ' =========================================================
    Private Sub DisplayAppointmentsForDate(filterDate As Date)
        flpAppointments.Controls.Clear()
        ClearDetailsSection()

        ' Filter only pending and approved appointments for selected date
        Dim filteredSource = appointmentList.
    Where(Function(a)
              Dim dateStr As String = a.Value.GetValueOrDefault("appointmentDate", "").ToString()
              Dim dt As Date
              If Not Date.TryParse(dateStr, dt) Then Return False

              Dim status As String = a.Value.GetValueOrDefault("status", "").ToString().ToLower()

              ' Status + date filter
              If dt.Date <> filterDate Then Return False
              If Not {"pending", "approved"}.Contains(status) Then Return False

              ' Search filter
              Dim keyword As String = txtSearch.Text.Trim().ToLower()
              If keyword <> "" Then
                  Dim name = a.Value.GetValueOrDefault("name", "").ToString().ToLower()
                  Dim email = a.Value.GetValueOrDefault("email", "").ToString().ToLower()

                  If Not (name.Contains(keyword) Or email.Contains(keyword)) Then Return False
              End If

              Return True
          End Function).
    ToDictionary(Function(k) k.Key, Function(v) v.Value)


        ' Show empty message if none
        If filteredSource.Count = 0 Then
            Dim lblEmpty As New Label() With {
                .Text = "No appointments found for this date.",
                .AutoSize = True,
                .Font = New Font("Segoe UI", 10, FontStyle.Italic),
                .ForeColor = Color.Gray,
                .Margin = New Padding(15),
                .TextAlign = ContentAlignment.MiddleCenter
            }
            flpAppointments.Controls.Add(lblEmpty)
            Return
        End If

        ' Display each appointment
        For Each kvp In filteredSource
            Dim docId = kvp.Key
            Dim data = kvp.Value
            Dim status = data.GetValueOrDefault("status", "").ToString().ToLower()

            ' Panel
            Dim pnl As New Panel() With {
                .Width = 300,
                .Height = 60,
                .BackColor = If(status = "approved", Color.LightBlue, Color.LightGreen),
                .BorderStyle = BorderStyle.FixedSingle,
                .Margin = New Padding(6)
            }

            ' Profile picture
            Dim picProfile As New PictureBox() With {
                .Image = My.Resources.Resource1.customericon1,
                .SizeMode = PictureBoxSizeMode.Zoom,
                .Size = New Size(50, 50),
                .Location = New Point(6, 4),
                .Cursor = Cursors.Hand,
                .Tag = docId,
                .BackColor = Color.LightGray
            }
            Dim gp As New Drawing2D.GraphicsPath()
            gp.AddEllipse(0, 0, picProfile.Width, picProfile.Height)
            picProfile.Region = New Region(gp)
            AddHandler picProfile.MouseEnter, Sub() picProfile.BackColor = Color.Silver
            AddHandler picProfile.MouseLeave, Sub() picProfile.BackColor = Color.LightGray
            AddHandler picProfile.Click, AddressOf ProfileIcon_Click

            ' Labels
            Dim lblName As New Label() With {.Text = data.GetValueOrDefault("name", "").ToString(), .AutoSize = True, .Font = New Font("Segoe UI", 10, FontStyle.Bold), .Location = New Point(60, 8)}
            Dim lblEmail As New Label() With {.Text = data.GetValueOrDefault("email", "").ToString(), .AutoSize = True, .Font = New Font("Segoe UI", 9), .Location = New Point(60, 32)}

            pnl.Controls.Add(picProfile)
            pnl.Controls.Add(lblName)
            pnl.Controls.Add(lblEmail)
            flpAppointments.Controls.Add(pnl)
        Next
    End Sub

    ' =========================================================
    ' 🔹 PROFILE ICON CLICK
    ' =========================================================
    Private Sub ProfileIcon_Click(sender As Object, e As EventArgs)
        Dim clickedIcon As PictureBox = DirectCast(sender, PictureBox)
        selectedAppointmentId = clickedIcon.Tag.ToString()

        Dim data As Dictionary(Of String, Object) = Nothing
        If appointmentList.TryGetValue(selectedAppointmentId, data) Then
            lblName.Text = data.GetValueOrDefault("name", "").ToString()
            lblEmail.Text = data.GetValueOrDefault("email", "").ToString()
            lblContactNo.Text = data.GetValueOrDefault("contactNumber", "").ToString()
            lblDate.Text = data.GetValueOrDefault("appointmentDate", "").ToString()
            lblTitleTime.Text = data.GetValueOrDefault("appointmentTime", "").ToString()

            ' --- FIXED PET TYPE LOGIC ---
            Dim petType As String = data.GetValueOrDefault("typeOfPet", "").ToString()
            Dim otherPet As String = data.GetValueOrDefault("otherPet", "").ToString()

            If petType = "Others" AndAlso otherPet <> "" Then
                lblTitlePetType.Text = otherPet        ' show actual pet: "Hamster", "Turtle", etc.
            Else
                lblTitlePetType.Text = petType         ' show Dog / Cat
            End If

            txtCondition.Text = data.GetValueOrDefault("condition", "").ToString()

            ' Reset all checkboxes
            chkConsult.Checked = False
            chkGrooming.Checked = False
            chkVaccine.Checked = False
            chkSurgery.Checked = False
            chkUltrasound.Checked = False
            chkHomeservice.Checked = False
            chkBloodTest.Checked = False
            chkConfinement.Checked = False
            chkFecalysis.Checked = False
            chkMicroship.Checked = False
            chkTiter.Checked = False
            chkHealthCertificate.Checked = False
            chkDeworming.Checked = False
            chkPrevention.Checked = False

            ' ==========================
            ' 🔹 Load Services
            ' ==========================
            Dim serviceObj As Object = Nothing
            If data.TryGetValue("service", serviceObj) Then
                Dim serviceList As New List(Of String)

                If TypeOf serviceObj Is String Then
                    serviceList.Add(serviceObj.ToString())
                ElseIf TypeOf serviceObj Is IEnumerable(Of Object) Then
                    serviceList.AddRange(DirectCast(serviceObj, IEnumerable(Of Object)).Select(Function(o) o.ToString()))
                End If

                For Each s In serviceList
                    Select Case s.ToLower()
                        Case "consultation" : chkConsult.Checked = True
                        Case "pet grooming" : chkGrooming.Checked = True
                        Case "vaccination" : chkVaccine.Checked = True
                        Case "surgery" : chkSurgery.Checked = True
                        Case "ultrasound" : chkUltrasound.Checked = True
                        Case "home service" : chkHomeservice.Checked = True
                        Case "blood test" : chkBloodTest.Checked = True
                        Case "confinement" : chkConfinement.Checked = True
                        Case "fecalysis" : chkFecalysis.Checked = True
                        Case "microchip" : chkMicroship.Checked = True
                        Case "titer" : chkTiter.Checked = True
                        Case "health certificate" : chkHealthCertificate.Checked = True
                        Case "deworming" : chkDeworming.Checked = True
                        Case "tick & flea prevention" : chkPrevention.Checked = True
                    End Select
                Next
            End If

            ' ==========================
            ' 🔹 Enable/Disable Buttons
            ' ==========================
            Dim status As String = data.GetValueOrDefault("status", "").ToString().ToLower()

            ' Disable Approve if already approved
            btnApprove.Enabled = (status <> "approved")

            ' Enable Complete ONLY when approved
            btnCompleted.Enabled = (status = "approved")

            ' Reject only allowed if pending
            btnReject.Enabled = (status = "pending")

        End If
    End Sub



    ' =========================================================
    ' 🔹 ACTION HANDLER
    ' =========================================================
    Private Async Function HandleAppointmentAction(action As String) As Task
        If selectedAppointmentId Is Nothing Then
            MessageBox.Show("Please select an appointment first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim msg As String = ""
        Select Case action.ToLower()
            Case "complete" : msg = "mark this appointment as completed?"
            Case "approve" : msg = "approve this appointment?"
            Case "reject" : msg = "reject this appointment?"
            Case "delete" : msg = "delete this appointment?"
        End Select

        Dim confirm = MessageBox.Show($"Are you sure you want to {msg}", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Return

        Try
            Dim docRef = db.Collection("appointments").Document(selectedAppointmentId)
            Select Case action.ToLower()
                Case "complete" : Await docRef.UpdateAsync(New Dictionary(Of String, Object) From {{"status", "Completed"}})
                Case "approve" : Await docRef.UpdateAsync(New Dictionary(Of String, Object) From {{"status", "approved"}})
                Case "reject" : Await docRef.UpdateAsync(New Dictionary(Of String, Object) From {{"status", "rejected"}})
                Case "delete" : Await docRef.DeleteAsync()
            End Select

            ClearDetailsSection()
            MessageBox.Show($"Appointment {action}d successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Await LoadAppointmentsAsync()
            HighlightCalendarDates()
        Catch ex As Exception
            MessageBox.Show($"Error performing {action}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    ' =========================================================
    ' 🔹 BUTTON EVENTS
    ' =========================================================
    Private Async Sub btnCompleted_Click(sender As Object, e As EventArgs) Handles btnCompleted.Click
        Await HandleAppointmentAction("complete")
    End Sub

    Private Async Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Await HandleAppointmentAction("approve")
    End Sub

    Private Async Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        Await HandleAppointmentAction("reject")
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Await HandleAppointmentAction("delete")
    End Sub

    ' =========================================================
    ' 🔹 NEW SCHEDULE BUTTON
    ' =========================================================
    Private Async Sub btnNewSchedule_Click(sender As Object, e As EventArgs) Handles btnNewSchedule.Click
        Try
            If selectedAppointmentId Is Nothing Then
                MessageBox.Show("Please select an appointment to reschedule.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim confirm = MessageBox.Show(
                "Creating a new schedule will cancel the client's current one. Do you want to continue?",
                "Confirm Reschedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.No Then Return

            ' Collect existing details
            Dim clientName As String = lblName.Text
            Dim clientEmail As String = lblEmail.Text
            Dim clientContact As String = lblContactNo.Text
            Dim petType As String = lblTitlePetType.Text
            Dim petCondition As String = txtCondition.Text

            ' Collect services
            Dim selectedServices As New List(Of String)
            If chkConsult.Checked Then selectedServices.Add("Consultation")
            If chkGrooming.Checked Then selectedServices.Add("Pet Grooming")
            If chkVaccine.Checked Then selectedServices.Add("Vaccination")
            If chkSurgery.Checked Then selectedServices.Add("Surgery")
            If chkUltrasound.Checked Then selectedServices.Add("Ultrasound")
            If chkHomeservice.Checked Then selectedServices.Add("Home Service")
            If chkBloodTest.Checked Then selectedServices.Add("Blood Test")
            If chkConfinement.Checked Then selectedServices.Add("Confinement")
            If chkFecalysis.Checked Then selectedServices.Add("Fecalysis")
            If chkMicroship.Checked Then selectedServices.Add("Microchip")
            If chkTiter.Checked Then selectedServices.Add("Titer")
            If chkHealthCertificate.Checked Then selectedServices.Add("Health Certificate")
            If chkDeworming.Checked Then selectedServices.Add("Deworming")
            If chkPrevention.Checked Then selectedServices.Add("Tick & Flea Prevention")

            ' Cancel old appointment
            Dim oldDocRef = db.Collection("appointments").Document(selectedAppointmentId)
            Await oldDocRef.UpdateAsync(New Dictionary(Of String, Object) From {{"status", "Cancelled"}})

            ' Open new schedule form
            Dim newScheduleForm As New FrmNewSchedule(clientName, clientEmail, clientContact, petType, petCondition, selectedServices)
            newScheduleForm.ShowDialog()

            ' After saving, reload
            If newScheduleForm.IsSavedSuccessfully Then
                Await LoadAppointmentsAsync()
                HighlightCalendarDates()

                Dim newId = newScheduleForm.CreatedAppointmentId
                If appointmentList.ContainsKey(newId) Then
                    selectedAppointmentId = newId
                    Dim data = appointmentList(newId)

                    lblName.Text = data.GetValueOrDefault("name", "").ToString()
                    lblEmail.Text = data.GetValueOrDefault("email", "").ToString()
                    lblContactNo.Text = data.GetValueOrDefault("contactNumber", "").ToString()
                    lblDate.Text = data.GetValueOrDefault("appointmentDate", "").ToString()
                    lblTitleTime.Text = data.GetValueOrDefault("appointmentTime", "").ToString()

                    ' --- FIXED PET TYPE LOGIC (renamed variables) ---
                    Dim selectedPetType As String = data.GetValueOrDefault("typeOfPet", "").ToString()
                    Dim selectedOtherPet As String = data.GetValueOrDefault("otherPet", "").ToString()

                    If selectedPetType = "Others" AndAlso selectedOtherPet <> "" Then
                        lblTitlePetType.Text = selectedOtherPet
                    Else
                        lblTitlePetType.Text = selectedPetType
                    End If

                    txtCondition.Text = data.GetValueOrDefault("condition", "").ToString()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show($"Error creating new schedule: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================
    ' 🔹 CALENDAR HIGHLIGHTS
    ' =========================================================
    Private Sub HighlightCalendarDates()
        SfCalendar1.SpecialDates.Clear()

        ' Highlight today
        Dim todayDate As New SpecialDate() With {
            .Value = DateTime.Today,
            .BackColor = Color.Orange,
            .ForeColor = Color.White
        }
        SfCalendar1.SpecialDates.Add(todayDate)

        ' Highlight appointments: pending and approved only
        For Each kvp In appointmentList
            Dim data = kvp.Value
            Dim status = data.GetValueOrDefault("status", "").ToString().ToLower()
            If {"completed", "rejected", "cancelled"}.Contains(status) Then Continue For

            Dim dt As Date
            If Date.TryParse(data.GetValueOrDefault("appointmentDate", "").ToString(), dt) Then
                SfCalendar1.SpecialDates.Add(New SpecialDate() With {
                                               .Value = dt,
                                               .BackColor = If(status = "approved", Color.LightBlue, Color.LightGreen),
                                               .Font = New Font("Segoe UI", 9, FontStyle.Bold)
                                           })
            End If
        Next

        SfCalendar1.Invalidate()
        SfCalendar1.Refresh()
    End Sub

    ' =========================================================
    ' 🔹 CALENDAR SELECTION
    ' =========================================================
    Private Sub SfCalendar1_SelectionChanged(sender As Object, e As EventArgs) Handles SfCalendar1.SelectionChanged
        If SfCalendar1.SelectedDate.HasValue Then
            currentSelectedDate = SfCalendar1.SelectedDate.Value.Date
            DisplayAppointmentsForDate(currentSelectedDate)
        End If
    End Sub

    ' =========================================================
    ' 🔹 CLEAR DETAILS
    ' =========================================================
    Private Sub ClearDetailsSection()
        lblName.Text = ""
        lblEmail.Text = ""
        lblContactNo.Text = ""
        lblDate.Text = ""
        lblTitleTime.Text = ""
        lblTitlePetType.Text = ""
        txtCondition.Text = ""
        chkConsult.Checked = False
        chkGrooming.Checked = False
        chkVaccine.Checked = False
        chkSurgery.Checked = False
        chkUltrasound.Checked = False
        chkHomeservice.Checked = False
        chkBloodTest.Checked = False
        chkConfinement.Checked = False
        chkFecalysis.Checked = False
        chkMicroship.Checked = False
        chkTiter.Checked = False
        chkHealthCertificate.Checked = False
        chkDeworming.Checked = False
        chkPrevention.Checked = False
        selectedAppointmentId = Nothing
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        DisplayAppointmentsForDate(currentSelectedDate)
    End Sub


End Class
