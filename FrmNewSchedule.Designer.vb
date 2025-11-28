<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        btnSave = New Button()
        lblHeader = New Label()
        lblEmail = New Label()
        lblContact = New Label()
        lblPetCondition = New Label()
        pnlHeader = New Panel()
        lblPawIcon = New Label()
        GroupBox1 = New GroupBox()
        txtName = New TextBox()
        lblName = New Label()
        GroupBox2 = New GroupBox()
        txtPetCondition = New TextBox()
        txtPetType = New TextBox()
        lblPetType = New Label()
        lblTime = New Label()
        chkConsultation = New GroupBox()
        chkPrevention = New CheckBox()
        chkDeworming = New CheckBox()
        chkHealthCertificate = New CheckBox()
        chkTiter = New CheckBox()
        chkMicroship = New CheckBox()
        chkFecalysis = New CheckBox()
        chkHomeservice = New CheckBox()
        chkConfinement = New CheckBox()
        chkUltrasound = New CheckBox()
        chkSurgery = New CheckBox()
        chkBloodTest = New CheckBox()
        chkVaccine = New CheckBox()
        chkGrooming = New CheckBox()
        chkConsult = New CheckBox()
        btnCancel = New Button()
        SfCalendar1 = New Syncfusion.WinForms.Input.SfCalendar()
        cmbTime = New ComboBox()
        pnlHeader.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        chkConsultation.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(80, 98)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(331, 53)
        txtEmail.TabIndex = 3
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(92, 157)
        txtContact.Multiline = True
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(319, 50)
        txtContact.TabIndex = 4
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Green
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(593, 640)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(123, 55)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(427, 9)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(268, 38)
        lblHeader.TabIndex = 12
        lblHeader.Text = "New Appointment "
        lblHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(6, 104)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(63, 25)
        lblEmail.TabIndex = 13
        lblEmail.Text = "Email:"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContact.Location = New Point(3, 171)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(83, 25)
        lblContact.TabIndex = 14
        lblContact.Text = "Contact:"
        ' 
        ' lblPetCondition
        ' 
        lblPetCondition.AutoSize = True
        lblPetCondition.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPetCondition.Location = New Point(10, 153)
        lblPetCondition.Name = "lblPetCondition"
        lblPetCondition.Size = New Size(132, 25)
        lblPetCondition.TabIndex = 18
        lblPetCondition.Text = "Pet Condition:"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(255), CByte(152), CByte(0))
        pnlHeader.Controls.Add(lblPawIcon)
        pnlHeader.Controls.Add(lblHeader)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1033, 60)
        pnlHeader.TabIndex = 20
        ' 
        ' lblPawIcon
        ' 
        lblPawIcon.AutoSize = True
        lblPawIcon.BackColor = Color.FromArgb(CByte(255), CByte(152), CByte(0))
        lblPawIcon.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPawIcon.ForeColor = Color.White
        lblPawIcon.Location = New Point(365, 9)
        lblPawIcon.Name = "lblPawIcon"
        lblPawIcon.Size = New Size(56, 38)
        lblPawIcon.TabIndex = 13
        lblPawIcon.Text = "🐾"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(lblName)
        GroupBox1.Controls.Add(lblEmail)
        GroupBox1.Controls.Add(lblContact)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtContact)
        GroupBox1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(75, 75)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(435, 243)
        GroupBox1.TabIndex = 21
        GroupBox1.TabStop = False
        GroupBox1.Text = "New appointment Schedule for:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(80, 43)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(331, 49)
        txtName.TabIndex = 18
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(6, 49)
        lblName.Name = "lblName"
        lblName.Size = New Size(67, 25)
        lblName.TabIndex = 17
        lblName.Text = "Name:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        GroupBox2.Controls.Add(cmbTime)
        GroupBox2.Controls.Add(txtPetCondition)
        GroupBox2.Controls.Add(txtPetType)
        GroupBox2.Controls.Add(lblPetType)
        GroupBox2.Controls.Add(lblTime)
        GroupBox2.Controls.Add(lblPetCondition)
        GroupBox2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(516, 75)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(442, 232)
        GroupBox2.TabIndex = 22
        GroupBox2.TabStop = False
        GroupBox2.Text = "Appointment Details"
        ' 
        ' txtPetCondition
        ' 
        txtPetCondition.Location = New Point(139, 139)
        txtPetCondition.Multiline = True
        txtPetCondition.Name = "txtPetCondition"
        txtPetCondition.Size = New Size(257, 51)
        txtPetCondition.TabIndex = 19
        ' 
        ' txtPetType
        ' 
        txtPetType.Location = New Point(114, 85)
        txtPetType.Multiline = True
        txtPetType.Name = "txtPetType"
        txtPetType.Size = New Size(282, 48)
        txtPetType.TabIndex = 5
        ' 
        ' lblPetType
        ' 
        lblPetType.AutoSize = True
        lblPetType.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPetType.Location = New Point(10, 85)
        lblPetType.Name = "lblPetType"
        lblPetType.Size = New Size(98, 28)
        lblPetType.TabIndex = 2
        lblPetType.Text = "Pet Type:"
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(10, 40)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(64, 28)
        lblTime.TabIndex = 0
        lblTime.Text = "Time:"
        ' 
        ' chkConsultation
        ' 
        chkConsultation.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        chkConsultation.Controls.Add(chkPrevention)
        chkConsultation.Controls.Add(chkDeworming)
        chkConsultation.Controls.Add(chkHealthCertificate)
        chkConsultation.Controls.Add(chkTiter)
        chkConsultation.Controls.Add(chkMicroship)
        chkConsultation.Controls.Add(chkFecalysis)
        chkConsultation.Controls.Add(chkHomeservice)
        chkConsultation.Controls.Add(chkConfinement)
        chkConsultation.Controls.Add(chkUltrasound)
        chkConsultation.Controls.Add(chkSurgery)
        chkConsultation.Controls.Add(chkBloodTest)
        chkConsultation.Controls.Add(chkVaccine)
        chkConsultation.Controls.Add(chkGrooming)
        chkConsultation.Controls.Add(chkConsult)
        chkConsultation.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkConsultation.Location = New Point(516, 313)
        chkConsultation.Name = "chkConsultation"
        chkConsultation.Size = New Size(442, 321)
        chkConsultation.TabIndex = 23
        chkConsultation.TabStop = False
        chkConsultation.Text = "Services"
        ' 
        ' chkPrevention
        ' 
        chkPrevention.AutoSize = True
        chkPrevention.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkPrevention.Location = New Point(202, 275)
        chkPrevention.Name = "chkPrevention"
        chkPrevention.Size = New Size(236, 32)
        chkPrevention.TabIndex = 40
        chkPrevention.Text = "Tick & Flea Prevention"
        chkPrevention.UseVisualStyleBackColor = True
        ' 
        ' chkDeworming
        ' 
        chkDeworming.AutoSize = True
        chkDeworming.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkDeworming.Location = New Point(21, 275)
        chkDeworming.Name = "chkDeworming"
        chkDeworming.Size = New Size(148, 32)
        chkDeworming.TabIndex = 39
        chkDeworming.Text = "Deworming"
        chkDeworming.UseVisualStyleBackColor = True
        ' 
        ' chkHealthCertificate
        ' 
        chkHealthCertificate.AutoSize = True
        chkHealthCertificate.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkHealthCertificate.Location = New Point(202, 239)
        chkHealthCertificate.Name = "chkHealthCertificate"
        chkHealthCertificate.Size = New Size(207, 32)
        chkHealthCertificate.TabIndex = 37
        chkHealthCertificate.Text = "Health Certificate"
        chkHealthCertificate.UseVisualStyleBackColor = True
        ' 
        ' chkTiter
        ' 
        chkTiter.AutoSize = True
        chkTiter.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkTiter.Location = New Point(21, 238)
        chkTiter.Name = "chkTiter"
        chkTiter.Size = New Size(83, 32)
        chkTiter.TabIndex = 38
        chkTiter.Text = "Titer"
        chkTiter.UseVisualStyleBackColor = True
        ' 
        ' chkMicroship
        ' 
        chkMicroship.AutoSize = True
        chkMicroship.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkMicroship.Location = New Point(202, 201)
        chkMicroship.Name = "chkMicroship"
        chkMicroship.Size = New Size(133, 32)
        chkMicroship.TabIndex = 36
        chkMicroship.Text = "Microchip"
        chkMicroship.UseVisualStyleBackColor = True
        ' 
        ' chkFecalysis
        ' 
        chkFecalysis.AutoSize = True
        chkFecalysis.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkFecalysis.Location = New Point(21, 200)
        chkFecalysis.Name = "chkFecalysis"
        chkFecalysis.Size = New Size(121, 32)
        chkFecalysis.TabIndex = 35
        chkFecalysis.Text = "Fecalysis"
        chkFecalysis.UseVisualStyleBackColor = True
        ' 
        ' chkHomeservice
        ' 
        chkHomeservice.AutoSize = True
        chkHomeservice.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkHomeservice.Location = New Point(202, 124)
        chkHomeservice.Name = "chkHomeservice"
        chkHomeservice.Size = New Size(169, 32)
        chkHomeservice.TabIndex = 31
        chkHomeservice.Text = "Home Service"
        chkHomeservice.UseVisualStyleBackColor = True
        ' 
        ' chkConfinement
        ' 
        chkConfinement.AutoSize = True
        chkConfinement.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkConfinement.Location = New Point(202, 162)
        chkConfinement.Name = "chkConfinement"
        chkConfinement.Size = New Size(160, 32)
        chkConfinement.TabIndex = 30
        chkConfinement.Text = "Confinement"
        chkConfinement.UseVisualStyleBackColor = True
        ' 
        ' chkUltrasound
        ' 
        chkUltrasound.AutoSize = True
        chkUltrasound.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkUltrasound.Location = New Point(202, 86)
        chkUltrasound.Name = "chkUltrasound"
        chkUltrasound.Size = New Size(142, 32)
        chkUltrasound.TabIndex = 29
        chkUltrasound.Text = "Ultrasound"
        chkUltrasound.UseVisualStyleBackColor = True
        ' 
        ' chkSurgery
        ' 
        chkSurgery.AutoSize = True
        chkSurgery.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkSurgery.Location = New Point(202, 48)
        chkSurgery.Name = "chkSurgery"
        chkSurgery.Size = New Size(112, 32)
        chkSurgery.TabIndex = 28
        chkSurgery.Text = "Surgery"
        chkSurgery.UseVisualStyleBackColor = True
        ' 
        ' chkBloodTest
        ' 
        chkBloodTest.AutoSize = True
        chkBloodTest.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkBloodTest.Location = New Point(22, 162)
        chkBloodTest.Name = "chkBloodTest"
        chkBloodTest.Size = New Size(137, 32)
        chkBloodTest.TabIndex = 27
        chkBloodTest.Text = "Blood Test"
        chkBloodTest.UseVisualStyleBackColor = True
        ' 
        ' chkVaccine
        ' 
        chkVaccine.AutoSize = True
        chkVaccine.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkVaccine.Location = New Point(21, 124)
        chkVaccine.Name = "chkVaccine"
        chkVaccine.Size = New Size(147, 32)
        chkVaccine.TabIndex = 21
        chkVaccine.Text = "Vaccination"
        chkVaccine.UseVisualStyleBackColor = True
        ' 
        ' chkGrooming
        ' 
        chkGrooming.AutoSize = True
        chkGrooming.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkGrooming.Location = New Point(21, 86)
        chkGrooming.Name = "chkGrooming"
        chkGrooming.Size = New Size(168, 32)
        chkGrooming.TabIndex = 20
        chkGrooming.Text = "Pet Grooming"
        chkGrooming.UseVisualStyleBackColor = True
        ' 
        ' chkConsult
        ' 
        chkConsult.AutoSize = True
        chkConsult.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkConsult.Location = New Point(21, 48)
        chkConsult.Name = "chkConsult"
        chkConsult.Size = New Size(158, 32)
        chkConsult.TabIndex = 19
        chkConsult.Text = "Consultation"
        chkConsult.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(737, 640)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(123, 55)
        btnCancel.TabIndex = 24
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' SfCalendar1
        ' 
        SfCalendar1.Location = New Point(72, 324)
        SfCalendar1.Name = "SfCalendar1"
        SfCalendar1.Size = New Size(434, 371)
        SfCalendar1.TabIndex = 25
        SfCalendar1.Text = "SfCalendar1"
        ' 
        ' cmbTime
        ' 
        cmbTime.FormattingEnabled = True
        cmbTime.Location = New Point(114, 42)
        cmbTime.Name = "cmbTime"
        cmbTime.Size = New Size(282, 36)
        cmbTime.TabIndex = 20
        ' 
        ' FrmNewSchedule
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1033, 946)
        Controls.Add(SfCalendar1)
        Controls.Add(btnCancel)
        Controls.Add(chkConsultation)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(pnlHeader)
        Controls.Add(btnSave)
        Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmNewSchedule"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmNewSchedule"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        chkConsultation.ResumeLayout(False)
        chkConsultation.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPetCondition As Label
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTime As Label
    Friend WithEvents txtPetType As TextBox
    Friend WithEvents lblPetType As Label
    Friend WithEvents txtPetCondition As TextBox
    Friend WithEvents chkConsultation As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPawIcon As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents SfCalendar1 As Syncfusion.WinForms.Input.SfCalendar
    Friend WithEvents chkConsult As CheckBox
    Friend WithEvents chkGrooming As CheckBox
    Friend WithEvents chkVaccine As CheckBox
    Friend WithEvents chkBloodTest As CheckBox
    Friend WithEvents chkSurgery As CheckBox
    Friend WithEvents chkUltrasound As CheckBox
    Friend WithEvents chkConfinement As CheckBox
    Friend WithEvents chkHomeservice As CheckBox
    Friend WithEvents chkPrevention As CheckBox
    Friend WithEvents chkDeworming As CheckBox
    Friend WithEvents chkHealthCertificate As CheckBox
    Friend WithEvents chkTiter As CheckBox
    Friend WithEvents chkMicroship As CheckBox
    Friend WithEvents chkFecalysis As CheckBox
    Friend WithEvents cmbTime As ComboBox
End Class
