<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        panelSidebar = New Panel()
        PictureBox8 = New PictureBox()
        lblName = New Label()
        lblRole = New Label()
        Panel1 = New Panel()
        lblUserName = New Label()
        lblLogOut = New Label()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        lblLineNavigation = New Label()
        Label2 = New Label()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnChart = New Button()
        btnOrders = New Button()
        btnAppointments = New Button()
        btnInventory = New Button()
        btnDashboard = New Button()
        lbltitle = New Label()
        panelMain = New Panel()
        panelSidebar.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelSidebar
        ' 
        panelSidebar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        panelSidebar.BorderStyle = BorderStyle.FixedSingle
        panelSidebar.Controls.Add(PictureBox8)
        panelSidebar.Controls.Add(lblName)
        panelSidebar.Controls.Add(lblRole)
        panelSidebar.Controls.Add(Panel1)
        panelSidebar.Controls.Add(Label2)
        panelSidebar.Controls.Add(PictureBox5)
        panelSidebar.Controls.Add(PictureBox4)
        panelSidebar.Controls.Add(PictureBox3)
        panelSidebar.Controls.Add(PictureBox2)
        panelSidebar.Controls.Add(PictureBox1)
        panelSidebar.Controls.Add(btnChart)
        panelSidebar.Controls.Add(btnOrders)
        panelSidebar.Controls.Add(btnAppointments)
        panelSidebar.Controls.Add(btnInventory)
        panelSidebar.Controls.Add(btnDashboard)
        panelSidebar.Controls.Add(lbltitle)
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(368, 1050)
        panelSidebar.TabIndex = 0
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(117, 82)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(120, 114)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 25
        PictureBox8.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(20, 199)
        lblName.Name = "lblName"
        lblName.Size = New Size(323, 32)
        lblName.TabIndex = 28
        lblName.Text = "Mrs. Cellie Mae U. Rombaon"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRole.ForeColor = Color.Black
        lblRole.Location = New Point(139, 231)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(86, 25)
        lblRole.TabIndex = 27
        lblRole.Text = "Manager"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblUserName)
        Panel1.Controls.Add(lblLogOut)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(lblLineNavigation)
        Panel1.Location = New Point(12, 807)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(331, 168)
        Panel1.TabIndex = 24
        ' 
        ' lblUserName
        ' 
        lblUserName.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUserName.Location = New Point(55, 74)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(227, 38)
        lblUserName.TabIndex = 23
        lblUserName.Text = "Don Gabriel Beso"
        lblUserName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblLogOut
        ' 
        lblLogOut.AutoSize = True
        lblLogOut.Cursor = Cursors.Hand
        lblLogOut.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblLogOut.Location = New Point(127, 122)
        lblLogOut.Name = "lblLogOut"
        lblLogOut.Size = New Size(84, 28)
        lblLogOut.TabIndex = 22
        lblLogOut.Text = "Log out"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(14, 74)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(37, 38)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 19
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(288, 78)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(31, 34)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 21
        PictureBox7.TabStop = False
        ' 
        ' lblLineNavigation
        ' 
        lblLineNavigation.BackColor = Color.Black
        lblLineNavigation.Location = New Point(14, 35)
        lblLineNavigation.Name = "lblLineNavigation"
        lblLineNavigation.Size = New Size(305, 1)
        lblLineNavigation.TabIndex = 11
        lblLineNavigation.Text = """"""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.RoyalBlue
        Label2.Location = New Point(13, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 32)
        Label2.TabIndex = 23
        Label2.Text = "🐾"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(13, 647)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(38, 35)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(13, 566)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 35)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 17
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(13, 487)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(38, 35)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(13, 407)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(38, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 331)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' btnChart
        ' 
        btnChart.BackColor = Color.White
        btnChart.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnChart.ForeColor = Color.Orange
        btnChart.Location = New Point(54, 633)
        btnChart.Name = "btnChart"
        btnChart.Size = New Size(240, 57)
        btnChart.TabIndex = 13
        btnChart.Text = "Reports"
        btnChart.UseVisualStyleBackColor = False
        ' 
        ' btnOrders
        ' 
        btnOrders.BackColor = Color.White
        btnOrders.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOrders.ForeColor = Color.Orange
        btnOrders.Location = New Point(54, 556)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(240, 57)
        btnOrders.TabIndex = 4
        btnOrders.Text = "Orders"
        btnOrders.UseVisualStyleBackColor = False
        ' 
        ' btnAppointments
        ' 
        btnAppointments.BackColor = Color.White
        btnAppointments.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAppointments.ForeColor = Color.Orange
        btnAppointments.Location = New Point(54, 478)
        btnAppointments.Name = "btnAppointments"
        btnAppointments.Size = New Size(240, 57)
        btnAppointments.TabIndex = 3
        btnAppointments.Text = "Appointments"
        btnAppointments.UseVisualStyleBackColor = False
        ' 
        ' btnInventory
        ' 
        btnInventory.BackColor = Color.White
        btnInventory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInventory.ForeColor = Color.Orange
        btnInventory.Location = New Point(54, 395)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(240, 57)
        btnInventory.TabIndex = 2
        btnInventory.Text = "Inventory"
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.White
        btnDashboard.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.ForeColor = Color.Orange
        btnDashboard.Location = New Point(54, 318)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(240, 57)
        btnDashboard.TabIndex = 1
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
        ' 
        ' lbltitle
        ' 
        lbltitle.AutoSize = True
        lbltitle.Font = New Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbltitle.ForeColor = Color.White
        lbltitle.Location = New Point(54, 8)
        lbltitle.Name = "lbltitle"
        lbltitle.Size = New Size(252, 51)
        lbltitle.TabIndex = 0
        lbltitle.Text = "Pawfessional"
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelMain.Dock = DockStyle.Fill
        panelMain.Location = New Point(368, 0)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(998, 1050)
        panelMain.TabIndex = 1
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.LightPink
        ClientSize = New Size(1366, 1050)
        Controls.Add(panelMain)
        Controls.Add(panelSidebar)
        Name = "MainForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        WindowState = FormWindowState.Maximized
        panelSidebar.ResumeLayout(False)
        panelSidebar.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelSidebar As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnAppointments As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents lblLineNavigation As Label
    Friend WithEvents btnChart As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblLogOut As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblUserName As Label

End Class
