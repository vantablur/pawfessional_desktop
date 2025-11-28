Imports Google.Cloud.Firestore
Imports System.Text.RegularExpressions
Imports Syncfusion.Licensing ' ✅ Add this import
Imports Syncfusion.WinForms.Input
Imports Syncfusion.WinForms.Input.Events


Public Class FrmNewSchedule
    Private db As FirestoreDb
    Private clientName As String
    Private clientEmail As String
    Private clientContact As String
    Private petType As String
    Private petCondition As String
    Private services As List(Of String)

    ' ✅ Flags
    Public Property IsSavedSuccessfully As Boolean = False
    Public Property CreatedAppointmentId As String

    ' =========================================================
    ' 🧩 Constructor
    ' =========================================================
    Public Sub New(name As String, email As String, contact As String, pet As String, condition As String, selectedServices As List(Of String))
        InitializeComponent()

        clientName = name
        clientEmail = email
        clientContact = contact
        petType = pet
        petCondition = condition
        services = selectedServices
    End Sub

    ' =========================================================
    ' 🚀 Load Event
    ' =========================================================
    Private Sub FrmNewSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 🔹 Initialize Firestore
            db = FirestoreDb.Create("pawfessional-app")

            ' 🔹 Display client info
            txtName.Text = clientName
            txtEmail.Text = clientEmail
            txtContact.Text = clientContact
            txtPetType.Text = petType
            txtPetCondition.Text = petCondition

            ' 🔹 Disable non-editable fields
            txtName.ReadOnly = True
            txtEmail.ReadOnly = True
            txtContact.ReadOnly = True
            txtPetType.ReadOnly = True
            txtPetCondition.ReadOnly = True

            ' 🔹 Disable service checkboxes
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


            ' 🔹 Pre-check selected services
            For Each s In services
                Select Case s.ToLower().Trim()
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

            ' 🔹 Default date
            SfCalendar1.SelectedDate = DateTime.Today

            ' 🔹 Prevent selecting past dates
            SfCalendar1.MinDate = DateTime.Today

            SfCalendar1.SpecialDates.Clear()
            Dim todayHighlight As New SpecialDate() With {
            .Value = DateTime.Today,
            .BackColor = Color.Orange,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9, FontStyle.Bold)
        }
            SfCalendar1.SpecialDates.Add(todayHighlight)
            SfCalendar1.Invalidate()
            SfCalendar1.Refresh()

            ' 🔹 TIME PLACEHOLDER + ITEMS
            cmbTime.Items.Clear()
            cmbTime.Items.Add("8:00 AM - 12:00 PM")
            cmbTime.Items.Add("1:00 PM - 6:00 PM")

            cmbTime.Text = "Select time..."
            cmbTime.ForeColor = Color.Gray

        Catch ex As Exception
            MessageBox.Show("Error initializing Firestore: " & ex.Message,
                    "Firestore Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub cmbTime_Enter(sender As Object, e As EventArgs) Handles cmbTime.Enter
        If cmbTime.Text = "Select time..." Then
            cmbTime.Text = ""
            cmbTime.ForeColor = Color.Black
        End If
    End Sub
    Private Sub cmbTime_Leave(sender As Object, e As EventArgs) Handles cmbTime.Leave
        If cmbTime.Text.Trim() = "" Then
            cmbTime.Text = "Select time..."
            cmbTime.ForeColor = Color.Gray
        End If
    End Sub


    ' =========================================================
    ' 💾 Save Button — Create new appointment
    ' =========================================================
    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            SfCalendar1.AllowMultipleSelection = False

            ' 🕒 Get time input
            Dim timeInput As String = cmbTime.Text.Trim()

            ' 🗓️ Get selected date from SfCalendar
            Dim selectedDate As DateTime = SfCalendar1.SelectedDate

            ' 🗂️ Prepare new appointment data
            Dim newAppointment As New Dictionary(Of String, Object) From {
                {"name", clientName},
                {"email", clientEmail},
                {"contactNumber", clientContact},
                {"appointmentDate", selectedDate.ToString("yyyy-MM-dd")},
                {"appointmentTime", timeInput},
                {"typeOfPet", petType},
                {"condition", petCondition},
                {"service", services},
                {"status", "Pending"},
                {"createdAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}
            }

            ' 💾 Save to Firestore
            Dim newDocRef = Await db.Collection("appointments").AddAsync(newAppointment)
            CreatedAppointmentId = newDocRef.Id
            IsSavedSuccessfully = True

            MessageBox.Show("✅ New schedule created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving appointment: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================
    ' ❌ Cancel Button
    ' =========================================================
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Cancel creating new schedule?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' =========================================================
    ' 🧩 Confirm close without save
    ' =========================================================
    Private Sub FrmNewSchedule_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not IsSavedSuccessfully AndAlso e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("Do you want to discard this new schedule?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then e.Cancel = True
        End If
    End Sub

End Class
