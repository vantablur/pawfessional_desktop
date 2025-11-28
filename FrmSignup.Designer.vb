<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSignup))
        Panel2 = New Panel()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        Label2 = New Label()
        pnlLogin = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label7 = New Label()
        lblPasswordMatch = New Label()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        Label6 = New Label()
        lnkLogin = New LinkLabel()
        Label4 = New Label()
        chkShowPassword = New CheckBox()
        Label5 = New Label()
        btnSignup = New Button()
        txtConfirmPassword = New TextBox()
        txtUserName = New TextBox()
        Label1 = New Label()
        lblTitle = New Label()
        Label3 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnlLogin.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(247), CByte(249), CByte(249))
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1816, 1050)
        Panel2.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(100), CByte(133))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(pnlLogin)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(206, 109)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1332, 877)
        Panel1.TabIndex = 10
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(139, 81)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(237, 173)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1074, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(61, 395)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(412, 423)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 13
        PictureBox4.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(819, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 74)
        Label2.TabIndex = 4
        Label2.Text = "Welcome"
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.White
        pnlLogin.BorderStyle = BorderStyle.FixedSingle
        pnlLogin.Controls.Add(PictureBox7)
        pnlLogin.Controls.Add(PictureBox6)
        pnlLogin.Controls.Add(PictureBox5)
        pnlLogin.Controls.Add(PictureBox3)
        pnlLogin.Controls.Add(Label7)
        pnlLogin.Controls.Add(lblPasswordMatch)
        pnlLogin.Controls.Add(txtPassword)
        pnlLogin.Controls.Add(txtEmail)
        pnlLogin.Controls.Add(Label6)
        pnlLogin.Controls.Add(lnkLogin)
        pnlLogin.Controls.Add(Label4)
        pnlLogin.Controls.Add(chkShowPassword)
        pnlLogin.Controls.Add(Label5)
        pnlLogin.Controls.Add(btnSignup)
        pnlLogin.Controls.Add(txtConfirmPassword)
        pnlLogin.Controls.Add(txtUserName)
        pnlLogin.Location = New Point(725, 138)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(443, 707)
        pnlLogin.TabIndex = 9
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(52, 326)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(30, 31)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 19
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(52, 249)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(30, 31)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 18
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(52, 172)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(30, 31)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 17
        PictureBox5.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(159, 26)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(116, 116)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(87, 633)
        Label7.Name = "Label7"
        Label7.Size = New Size(213, 25)
        Label7.TabIndex = 15
        Label7.Text = "Already have an account?"
        ' 
        ' lblPasswordMatch
        ' 
        lblPasswordMatch.AutoSize = True
        lblPasswordMatch.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPasswordMatch.ForeColor = Color.Black
        lblPasswordMatch.Location = New Point(93, 329)
        lblPasswordMatch.Name = "lblPasswordMatch"
        lblPasswordMatch.Size = New Size(97, 28)
        lblPasswordMatch.TabIndex = 14
        lblPasswordMatch.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(52, 360)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(333, 31)
        txtPassword.TabIndex = 13
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(52, 280)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(333, 31)
        txtEmail.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(93, 252)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 28)
        Label6.TabIndex = 11
        Label6.Text = "Email"
        ' 
        ' lnkLogin
        ' 
        lnkLogin.AutoSize = True
        lnkLogin.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lnkLogin.ForeColor = Color.Black
        lnkLogin.LinkColor = Color.Black
        lnkLogin.Location = New Point(293, 633)
        lnkLogin.Name = "lnkLogin"
        lnkLogin.Size = New Size(64, 25)
        lnkLogin.TabIndex = 9
        lnkLogin.TabStop = True
        lnkLogin.Text = "Log In"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(88, 175)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 28)
        Label4.TabIndex = 6
        Label4.Text = "Username"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.ForeColor = Color.Black
        chkShowPassword.Location = New Point(52, 493)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(162, 29)
        chkShowPassword.TabIndex = 3
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(52, 410)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 28)
        Label5.TabIndex = 7
        Label5.Text = "Confirm Password"
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.FromArgb(CByte(44), CByte(100), CByte(133))
        btnSignup.FlatStyle = FlatStyle.Flat
        btnSignup.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignup.ForeColor = Color.White
        btnSignup.Location = New Point(75, 553)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(292, 54)
        btnSignup.TabIndex = 2
        btnSignup.Text = "Sign Up"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(52, 441)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(333, 31)
        txtConfirmPassword.TabIndex = 1
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(52, 206)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(333, 31)
        txtUserName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(197, 274)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 70)
        Label1.TabIndex = 3
        Label1.Text = "fessional"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblTitle.Location = New Point(78, 273)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(137, 70)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Paw"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(235), CByte(152), CByte(78))
        Label3.Location = New Point(707, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(485, 30)
        Label3.TabIndex = 5
        Label3.Text = "Create your Pawfessional account to continue"
        ' 
        ' FrmSignup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1816, 1050)
        Controls.Add(Panel2)
        Name = "FrmSignup"
        Text = "FrmSignup"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lnkLogin As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPasswordMatch As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
