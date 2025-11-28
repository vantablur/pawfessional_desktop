<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcAppointment
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcAppointment))
        flpAppointments = New FlowLayoutPanel()
        txtSearch = New TextBox()
        lblTitle = New Label()
        cardProfile = New Panel()
        pbAvatar = New PictureBox()
        lblName = New Label()
        chkPrevention = New CheckBox()
        chkDeworming = New CheckBox()
        chkHealthCertificate = New CheckBox()
        chkTiter = New CheckBox()
        chkMicroship = New CheckBox()
        chkFecalysis = New CheckBox()
        chkConfinement = New CheckBox()
        chkBloodTest = New CheckBox()
        chkHomeservice = New CheckBox()
        chkConsult = New CheckBox()
        chkUltrasound = New CheckBox()
        lblContactNo = New Label()
        lblContactNum = New Label()
        lblAppointmentServices = New Label()
        lblEmailTitle = New Label()
        lblCondition = New Label()
        lblTitlePetType = New Label()
        lblTitleTime = New Label()
        lblTime = New Label()
        btnDelete = New Button()
        btnNewSchedule = New Button()
        btnCompleted = New Button()
        txtCondition = New TextBox()
        chkVaccine = New CheckBox()
        chkGrooming = New CheckBox()
        chkSurgery = New CheckBox()
        lblPet = New Label()
        lblDate = New Label()
        lblDateTitle = New Label()
        lblEmail = New Label()
        btnApprove = New Button()
        btnReject = New Button()
        panelMain = New Panel()
        btnSearch = New Button()
        Label3 = New Label()
        SfCalendar1 = New Syncfusion.WinForms.Input.SfCalendar()
        Label2 = New Label()
        Label1 = New Label()
        cardProfile.SuspendLayout()
        CType(pbAvatar, ComponentModel.ISupportInitialize).BeginInit()
        panelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' flpAppointments
        ' 
        flpAppointments.AutoScroll = True
        flpAppointments.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        flpAppointments.BorderStyle = BorderStyle.FixedSingle
        flpAppointments.FlowDirection = FlowDirection.TopDown
        flpAppointments.Location = New Point(936, 107)
        flpAppointments.Name = "flpAppointments"
        flpAppointments.Padding = New Padding(10)
        flpAppointments.Size = New Size(451, 603)
        flpAppointments.TabIndex = 3
        flpAppointments.WrapContents = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.WhiteSmoke
        txtSearch.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Black
        txtSearch.Location = New Point(962, 61)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search here..."
        txtSearch.Size = New Size(392, 44)
        txtSearch.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(964, 18)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(349, 32)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Today's Schedule Appointment"
        ' 
        ' cardProfile
        ' 
        cardProfile.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        cardProfile.BorderStyle = BorderStyle.FixedSingle
        cardProfile.Controls.Add(pbAvatar)
        cardProfile.Controls.Add(lblName)
        cardProfile.Controls.Add(chkPrevention)
        cardProfile.Controls.Add(chkDeworming)
        cardProfile.Controls.Add(chkHealthCertificate)
        cardProfile.Controls.Add(chkTiter)
        cardProfile.Controls.Add(chkMicroship)
        cardProfile.Controls.Add(chkFecalysis)
        cardProfile.Controls.Add(chkConfinement)
        cardProfile.Controls.Add(chkBloodTest)
        cardProfile.Controls.Add(chkHomeservice)
        cardProfile.Controls.Add(chkConsult)
        cardProfile.Controls.Add(chkUltrasound)
        cardProfile.Controls.Add(lblContactNo)
        cardProfile.Controls.Add(lblContactNum)
        cardProfile.Controls.Add(lblAppointmentServices)
        cardProfile.Controls.Add(lblEmailTitle)
        cardProfile.Controls.Add(lblCondition)
        cardProfile.Controls.Add(lblTitlePetType)
        cardProfile.Controls.Add(lblTitleTime)
        cardProfile.Controls.Add(lblTime)
        cardProfile.Controls.Add(btnDelete)
        cardProfile.Controls.Add(btnNewSchedule)
        cardProfile.Controls.Add(btnCompleted)
        cardProfile.Controls.Add(txtCondition)
        cardProfile.Controls.Add(chkVaccine)
        cardProfile.Controls.Add(chkGrooming)
        cardProfile.Controls.Add(chkSurgery)
        cardProfile.Controls.Add(lblPet)
        cardProfile.Controls.Add(lblDate)
        cardProfile.Controls.Add(lblDateTitle)
        cardProfile.Controls.Add(lblEmail)
        cardProfile.Location = New Point(3, 18)
        cardProfile.Name = "cardProfile"
        cardProfile.Padding = New Padding(12)
        cardProfile.Size = New Size(442, 858)
        cardProfile.TabIndex = 0
        ' 
        ' pbAvatar
        ' 
        pbAvatar.BorderStyle = BorderStyle.FixedSingle
        pbAvatar.Image = CType(resources.GetObject("pbAvatar.Image"), Image)
        pbAvatar.Location = New Point(179, 15)
        pbAvatar.Name = "pbAvatar"
        pbAvatar.Size = New Size(87, 97)
        pbAvatar.SizeMode = PictureBoxSizeMode.Zoom
        pbAvatar.TabIndex = 0
        pbAvatar.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(84, 115)
        lblName.Name = "lblName"
        lblName.Size = New Size(283, 38)
        lblName.TabIndex = 1
        lblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' chkPrevention
        ' 
        chkPrevention.AutoSize = True
        chkPrevention.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkPrevention.Location = New Point(198, 580)
        chkPrevention.Name = "chkPrevention"
        chkPrevention.Size = New Size(236, 32)
        chkPrevention.TabIndex = 34
        chkPrevention.Text = "Tick & Flea Prevention"
        chkPrevention.UseVisualStyleBackColor = True
        ' 
        ' chkDeworming
        ' 
        chkDeworming.AutoSize = True
        chkDeworming.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkDeworming.Location = New Point(17, 580)
        chkDeworming.Name = "chkDeworming"
        chkDeworming.Size = New Size(148, 32)
        chkDeworming.TabIndex = 33
        chkDeworming.Text = "Deworming"
        chkDeworming.UseVisualStyleBackColor = True
        ' 
        ' chkHealthCertificate
        ' 
        chkHealthCertificate.AutoSize = True
        chkHealthCertificate.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkHealthCertificate.Location = New Point(198, 544)
        chkHealthCertificate.Name = "chkHealthCertificate"
        chkHealthCertificate.Size = New Size(207, 32)
        chkHealthCertificate.TabIndex = 32
        chkHealthCertificate.Text = "Health Certificate"
        chkHealthCertificate.UseVisualStyleBackColor = True
        ' 
        ' chkTiter
        ' 
        chkTiter.AutoSize = True
        chkTiter.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkTiter.Location = New Point(17, 543)
        chkTiter.Name = "chkTiter"
        chkTiter.Size = New Size(83, 32)
        chkTiter.TabIndex = 32
        chkTiter.Text = "Titer"
        chkTiter.UseVisualStyleBackColor = True
        ' 
        ' chkMicroship
        ' 
        chkMicroship.AutoSize = True
        chkMicroship.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkMicroship.Location = New Point(198, 506)
        chkMicroship.Name = "chkMicroship"
        chkMicroship.Size = New Size(133, 32)
        chkMicroship.TabIndex = 31
        chkMicroship.Text = "Microchip"
        chkMicroship.UseVisualStyleBackColor = True
        ' 
        ' chkFecalysis
        ' 
        chkFecalysis.AutoSize = True
        chkFecalysis.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkFecalysis.Location = New Point(17, 505)
        chkFecalysis.Name = "chkFecalysis"
        chkFecalysis.Size = New Size(121, 32)
        chkFecalysis.TabIndex = 30
        chkFecalysis.Text = "Fecalysis"
        chkFecalysis.UseVisualStyleBackColor = True
        ' 
        ' chkConfinement
        ' 
        chkConfinement.AutoSize = True
        chkConfinement.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkConfinement.Location = New Point(198, 467)
        chkConfinement.Name = "chkConfinement"
        chkConfinement.Size = New Size(160, 32)
        chkConfinement.TabIndex = 27
        chkConfinement.Text = "Confinement"
        chkConfinement.UseVisualStyleBackColor = True
        ' 
        ' chkBloodTest
        ' 
        chkBloodTest.AutoSize = True
        chkBloodTest.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkBloodTest.Location = New Point(17, 467)
        chkBloodTest.Name = "chkBloodTest"
        chkBloodTest.Size = New Size(137, 32)
        chkBloodTest.TabIndex = 26
        chkBloodTest.Text = "Blood Test"
        chkBloodTest.UseVisualStyleBackColor = True
        ' 
        ' chkHomeservice
        ' 
        chkHomeservice.AutoSize = True
        chkHomeservice.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkHomeservice.Location = New Point(198, 429)
        chkHomeservice.Name = "chkHomeservice"
        chkHomeservice.Size = New Size(169, 32)
        chkHomeservice.TabIndex = 25
        chkHomeservice.Text = "Home Service"
        chkHomeservice.UseVisualStyleBackColor = True
        ' 
        ' chkConsult
        ' 
        chkConsult.AutoSize = True
        chkConsult.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkConsult.Location = New Point(17, 353)
        chkConsult.Name = "chkConsult"
        chkConsult.Size = New Size(158, 32)
        chkConsult.TabIndex = 18
        chkConsult.Text = "Consultation"
        chkConsult.UseVisualStyleBackColor = True
        ' 
        ' chkUltrasound
        ' 
        chkUltrasound.AutoSize = True
        chkUltrasound.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkUltrasound.Location = New Point(198, 391)
        chkUltrasound.Name = "chkUltrasound"
        chkUltrasound.Size = New Size(142, 32)
        chkUltrasound.TabIndex = 19
        chkUltrasound.Text = "Ultrasound"
        chkUltrasound.UseVisualStyleBackColor = True
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Location = New Point(135, 197)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(0, 25)
        lblContactNo.TabIndex = 24
        ' 
        ' lblContactNum
        ' 
        lblContactNum.AutoSize = True
        lblContactNum.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNum.Location = New Point(15, 194)
        lblContactNum.Name = "lblContactNum"
        lblContactNum.Size = New Size(124, 28)
        lblContactNum.TabIndex = 23
        lblContactNum.Text = "Contact No:"
        ' 
        ' lblAppointmentServices
        ' 
        lblAppointmentServices.AutoSize = True
        lblAppointmentServices.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppointmentServices.Location = New Point(15, 325)
        lblAppointmentServices.Name = "lblAppointmentServices"
        lblAppointmentServices.Size = New Size(193, 25)
        lblAppointmentServices.TabIndex = 21
        lblAppointmentServices.Text = "Appointment Sevices:"
        ' 
        ' lblEmailTitle
        ' 
        lblEmailTitle.AutoSize = True
        lblEmailTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmailTitle.Location = New Point(15, 166)
        lblEmailTitle.Name = "lblEmailTitle"
        lblEmailTitle.Size = New Size(69, 28)
        lblEmailTitle.TabIndex = 20
        lblEmailTitle.Text = "Email:"
        ' 
        ' lblCondition
        ' 
        lblCondition.AutoSize = True
        lblCondition.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCondition.Location = New Point(17, 633)
        lblCondition.Name = "lblCondition"
        lblCondition.Size = New Size(139, 25)
        lblCondition.TabIndex = 17
        lblCondition.Text = "Pet Conditions:"
        ' 
        ' lblTitlePetType
        ' 
        lblTitlePetType.AutoSize = True
        lblTitlePetType.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitlePetType.Location = New Point(135, 278)
        lblTitlePetType.Name = "lblTitlePetType"
        lblTitlePetType.Size = New Size(0, 28)
        lblTitlePetType.TabIndex = 16
        ' 
        ' lblTitleTime
        ' 
        lblTitleTime.AutoSize = True
        lblTitleTime.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitleTime.Location = New Point(75, 250)
        lblTitleTime.Name = "lblTitleTime"
        lblTitleTime.Size = New Size(0, 28)
        lblTitleTime.TabIndex = 15
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(15, 250)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(64, 28)
        lblTime.TabIndex = 14
        lblTime.Text = "Time:"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Black
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(286, 781)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(119, 67)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnNewSchedule
        ' 
        btnNewSchedule.BackColor = Color.ForestGreen
        btnNewSchedule.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnNewSchedule.ForeColor = Color.White
        btnNewSchedule.Location = New Point(22, 780)
        btnNewSchedule.Name = "btnNewSchedule"
        btnNewSchedule.Size = New Size(132, 68)
        btnNewSchedule.TabIndex = 12
        btnNewSchedule.Text = "New Schedule"
        btnNewSchedule.UseVisualStyleBackColor = False
        ' 
        ' btnCompleted
        ' 
        btnCompleted.BackColor = Color.ForestGreen
        btnCompleted.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCompleted.ForeColor = Color.White
        btnCompleted.Location = New Point(157, 782)
        btnCompleted.Name = "btnCompleted"
        btnCompleted.Size = New Size(123, 67)
        btnCompleted.TabIndex = 11
        btnCompleted.Text = "Completed"
        btnCompleted.UseVisualStyleBackColor = False
        ' 
        ' txtCondition
        ' 
        txtCondition.Location = New Point(22, 661)
        txtCondition.Multiline = True
        txtCondition.Name = "txtCondition"
        txtCondition.Size = New Size(383, 114)
        txtCondition.TabIndex = 10
        ' 
        ' chkVaccine
        ' 
        chkVaccine.AutoSize = True
        chkVaccine.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkVaccine.Location = New Point(17, 429)
        chkVaccine.Name = "chkVaccine"
        chkVaccine.Size = New Size(147, 32)
        chkVaccine.TabIndex = 9
        chkVaccine.Text = "Vaccination"
        chkVaccine.UseVisualStyleBackColor = True
        ' 
        ' chkGrooming
        ' 
        chkGrooming.AutoSize = True
        chkGrooming.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkGrooming.Location = New Point(17, 391)
        chkGrooming.Name = "chkGrooming"
        chkGrooming.Size = New Size(168, 32)
        chkGrooming.TabIndex = 8
        chkGrooming.Text = "Pet Grooming"
        chkGrooming.UseVisualStyleBackColor = True
        ' 
        ' chkSurgery
        ' 
        chkSurgery.AutoSize = True
        chkSurgery.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkSurgery.Location = New Point(198, 353)
        chkSurgery.Name = "chkSurgery"
        chkSurgery.Size = New Size(112, 32)
        chkSurgery.TabIndex = 7
        chkSurgery.Text = "Surgery"
        chkSurgery.UseVisualStyleBackColor = True
        ' 
        ' lblPet
        ' 
        lblPet.AutoSize = True
        lblPet.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPet.Location = New Point(15, 278)
        lblPet.Name = "lblPet"
        lblPet.Size = New Size(127, 28)
        lblPet.TabIndex = 6
        lblPet.Text = "Type Of Pet:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(73, 222)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(0, 28)
        lblDate.TabIndex = 5
        ' 
        ' lblDateTitle
        ' 
        lblDateTitle.AutoSize = True
        lblDateTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateTitle.Location = New Point(15, 222)
        lblDateTitle.Name = "lblDateTitle"
        lblDateTitle.Size = New Size(62, 28)
        lblDateTitle.TabIndex = 4
        lblDateTitle.Text = "Date:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(80, 166)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(0, 28)
        lblEmail.TabIndex = 2
        ' 
        ' btnApprove
        ' 
        btnApprove.BackColor = Color.Green
        btnApprove.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnApprove.ForeColor = Color.White
        btnApprove.Location = New Point(1026, 716)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(119, 67)
        btnApprove.TabIndex = 8
        btnApprove.Text = "Approved"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.AutoSize = True
        btnReject.BackColor = Color.Red
        btnReject.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReject.ForeColor = Color.White
        btnReject.Location = New Point(1168, 716)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(119, 67)
        btnReject.TabIndex = 9
        btnReject.Text = "Reject"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.WhiteSmoke
        panelMain.BorderStyle = BorderStyle.FixedSingle
        panelMain.Controls.Add(btnSearch)
        panelMain.Controls.Add(Label3)
        panelMain.Controls.Add(btnApprove)
        panelMain.Controls.Add(SfCalendar1)
        panelMain.Controls.Add(btnReject)
        panelMain.Controls.Add(Label2)
        panelMain.Controls.Add(Label1)
        panelMain.Controls.Add(cardProfile)
        panelMain.Controls.Add(txtSearch)
        panelMain.Controls.Add(lblTitle)
        panelMain.Controls.Add(flpAppointments)
        panelMain.Dock = DockStyle.Fill
        panelMain.Location = New Point(0, 0)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1392, 1042)
        panelMain.TabIndex = 4
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(1313, 65)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(43, 36)
        btnSearch.TabIndex = 11
        btnSearch.Text = "🔍"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(1314, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 32)
        Label3.TabIndex = 10
        Label3.Text = "🐾"
        ' 
        ' SfCalendar1
        ' 
        SfCalendar1.ForeColor = Color.Black
        SfCalendar1.Location = New Point(458, 107)
        SfCalendar1.Name = "SfCalendar1"
        SfCalendar1.Size = New Size(455, 525)
        SfCalendar1.TabIndex = 7
        SfCalendar1.Text = "SfCalendar1"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Black
        Label2.Location = New Point(919, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(1, 859)
        Label2.TabIndex = 6
        Label2.Text = """"""
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Location = New Point(451, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(1, 859)
        Label1.TabIndex = 5
        Label1.Text = """"""
        ' 
        ' UcAppointment
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        Controls.Add(panelMain)
        Name = "UcAppointment"
        Size = New Size(1392, 1042)
        cardProfile.ResumeLayout(False)
        cardProfile.PerformLayout()
        CType(pbAvatar, ComponentModel.ISupportInitialize).EndInit()
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents flpAppointments As FlowLayoutPanel
    Friend WithEvents lblTimeTitle As Label
    Friend WithEvents lblPetType As Label
    Friend WithEvents cardProfile As Panel
    Friend WithEvents lblEmailTitle As Label
    Friend WithEvents chkUltrasound As CheckBox
    Friend WithEvents chkConsult As CheckBox
    Friend WithEvents lblCondition As Label
    Friend WithEvents lblTitlePetType As Label
    Friend WithEvents lblTitleTime As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnNewSchedule As Button
    Friend WithEvents btnCompleted As Button
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents chkVaccine As CheckBox
    Friend WithEvents chkGrooming As CheckBox
    Friend WithEvents chkSurgery As CheckBox
    Friend WithEvents lblPet As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDateTitle As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents pbAvatar As PictureBox
    Friend WithEvents panelMain As Panel
    Friend WithEvents lblAppointmentServices As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SfCalendar1 As Syncfusion.WinForms.Input.SfCalendar
    Friend WithEvents lblContactNum As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents pnlNewSchedule As Panel
    Friend WithEvents btnReject As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents chkHomeservice As CheckBox
    Friend WithEvents chkConfinement As CheckBox
    Friend WithEvents chkBloodTest As CheckBox
    Friend WithEvents chkFecalysis As CheckBox
    Friend WithEvents chkHealthCertificate As CheckBox
    Friend WithEvents chkTiter As CheckBox
    Friend WithEvents chkMicroship As CheckBox
    Friend WithEvents chkDeworming As CheckBox
    Friend WithEvents chkPrevention As CheckBox

End Class
