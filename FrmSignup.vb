Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Google.Cloud.Firestore
Imports BCrypt.Net

Public Class FrmSignup

    ' --- Form Load ---
    Private Async Sub FrmSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSignup.Enabled = False

        ' Initialize Firestore
        Await FirestoreHelperClass.InitializeFirestoreAsync()

        ' Setup UI
        MakeButtonRounded(btnSignup, 34)
        MakePanelRounded(Panel1, 6)

        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True

        UpdateSignupButtonState()
        UpdatePasswordMatchStatus()
    End Sub


    ' --- Rounded Button ---
    Private Sub MakeButtonRounded(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, btn.Width, btn.Height)

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)

        path.CloseAllFigures()
        btn.Region = New Region(path)
    End Sub


    ' --- Rounded Panel ---
    Private Sub MakePanelRounded(panel As Panel, radius As Integer)
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, panel.Width, panel.Height)

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)

        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub


    ' --- Input Fields Change ---
    Private Sub txtFields_TextChanged(sender As Object, e As EventArgs) _
        Handles txtUserName.TextChanged,
                txtEmail.TextChanged,
                txtPassword.TextChanged,
                txtConfirmPassword.TextChanged

        UpdateSignupButtonState()
        UpdatePasswordMatchStatus()
    End Sub


    ' --- Update Signup Button State ---
    Private Sub UpdateSignupButtonState()
        btnSignup.Enabled =
            Not String.IsNullOrWhiteSpace(txtUserName.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtEmail.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtPassword.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtConfirmPassword.Text) AndAlso
            FirestoreHelperClass.db IsNot Nothing
    End Sub


    ' --- Toggle Password Visibility ---
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub


    ' --- Signup Button Click ---
    Private Async Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

        Dim username As String = txtUserName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirmPassword As String = txtConfirmPassword.Text.Trim()

        ' --- Validation ---
        If password <> confirmPassword Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Regex.IsMatch(email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            MessageBox.Show("Please enter a valid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Strong password check
        ' Simplified password check: at least 8 characters
        Dim passwordPattern As String = "^.{8,}$"

        If Not Regex.IsMatch(password, passwordPattern) Then
            MessageBox.Show(
        "Password must be at least 8 characters.",
        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        ' --- Firestore Registration ---
        Try
            Dim userDoc = FirestoreHelperClass.db.Collection("users").Document(username)
            Dim snapshot = Await userDoc.GetSnapshotAsync()

            If snapshot.Exists Then
                MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Hash password before saving
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

            Dim userData As New Dictionary(Of String, Object) From {
                {"username", username},
                {"email", email},
                {"password", hashedPassword}
            }

            Await userDoc.SetAsync(userData)

            MessageBox.Show("Signup successful! You can now login.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Navigate to login with pre-filled username
            Dim loginForm As New FrmLogin()
            loginForm.PreFillUsername(username)
            loginForm.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Signup failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    ' --- Navigate Back to Login ---
    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Dim loginForm As New FrmLogin()
        loginForm.Show()
        Me.Hide()
    End Sub


    ' --- Live Password Match Feedback ---
    Private Sub UpdatePasswordMatchStatus()

        lblPasswordMatch.Text = "Password"
        lblPasswordMatch.ForeColor = Color.Black

        If txtConfirmPassword.Text <> "" Then
            txtConfirmPassword.BackColor =
                If(txtPassword.Text = txtConfirmPassword.Text, Color.LightGreen, Color.LightCoral)
        Else
            txtConfirmPassword.BackColor = Color.White
        End If

    End Sub

End Class
