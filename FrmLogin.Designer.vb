<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Panel2 = New Panel()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        pnlLogin = New Panel()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        txtPassword = New TextBox()
        txtUserName = New TextBox()
        btnLogin = New Button()
        PictureBox3 = New PictureBox()
        lnkSignup = New LinkLabel()
        Label6 = New Label()
        Label4 = New Label()
        chkShowPassword = New CheckBox()
        Label5 = New Label()
        Label1 = New Label()
        lblTitle = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlLogin.SuspendLayout()
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
        Panel2.ForeColor = Color.White
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1816, 1050)
        Panel2.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(100), CByte(133))
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(pnlLogin)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(248, 133)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1332, 786)
        Panel1.TabIndex = 10
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(49, 342)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(412, 423)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1088, 47)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(94, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(137, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(237, 173)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.White
        pnlLogin.BorderStyle = BorderStyle.FixedSingle
        pnlLogin.Controls.Add(PictureBox6)
        pnlLogin.Controls.Add(PictureBox5)
        pnlLogin.Controls.Add(txtPassword)
        pnlLogin.Controls.Add(txtUserName)
        pnlLogin.Controls.Add(btnLogin)
        pnlLogin.Controls.Add(PictureBox3)
        pnlLogin.Controls.Add(lnkSignup)
        pnlLogin.Controls.Add(Label6)
        pnlLogin.Controls.Add(Label4)
        pnlLogin.Controls.Add(chkShowPassword)
        pnlLogin.Controls.Add(Label5)
        pnlLogin.Location = New Point(747, 173)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Size = New Size(444, 578)
        pnlLogin.TabIndex = 9
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(53, 262)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(30, 31)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 19
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(53, 182)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(30, 31)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 18
        PictureBox5.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(53, 296)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(335, 31)
        txtPassword.TabIndex = 1
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(53, 213)
        txtUserName.Multiline = True
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(335, 31)
        txtUserName.TabIndex = 0
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(44), CByte(100), CByte(133))
        btnLogin.Enabled = False
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(73, 413)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(299, 53)
        btnLogin.TabIndex = 11
        btnLogin.Text = "Log in"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(165, 26)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(116, 116)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' lnkSignup
        ' 
        lnkSignup.AutoSize = True
        lnkSignup.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lnkSignup.LinkColor = Color.Black
        lnkSignup.Location = New Point(299, 515)
        lnkSignup.Name = "lnkSignup"
        lnkSignup.Size = New Size(78, 25)
        lnkSignup.TabIndex = 9
        lnkSignup.TabStop = True
        lnkSignup.Text = "Sign Up"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(84, 512)
        Label6.Name = "Label6"
        Label6.Size = New Size(223, 28)
        Label6.TabIndex = 8
        Label6.Text = "Don't have an account?"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(89, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 28)
        Label4.TabIndex = 6
        Label4.Text = "Username"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.ForeColor = Color.Black
        chkShowPassword.Location = New Point(53, 347)
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
        Label5.Location = New Point(89, 265)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 28)
        Label5.TabIndex = 7
        Label5.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(193, 245)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 74)
        Label1.TabIndex = 3
        Label1.Text = "fessional"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblTitle.Location = New Point(75, 245)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(140, 74)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Paw"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(823, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 74)
        Label2.TabIndex = 4
        Label2.Text = "Welcome"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(235), CByte(152), CByte(78))
        Label3.Location = New Point(723, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(508, 30)
        Label3.TabIndex = 5
        Label3.Text = "Log in to your Pawfessional account to continue"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1816, 1050)
        Controls.Add(Panel2)
        ForeColor = Color.White
        Name = "FrmLogin"
        Text = "FrmLogin"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lnkSignup As LinkLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
