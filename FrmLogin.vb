Imports Google.Cloud.Firestore
Imports System.Windows.Forms
Imports System.Threading.Tasks
Imports System.Drawing.Drawing2D

Public Class FrmLogin

    ' --- Form Load ---
    Private Async Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.Enabled = False     ' Disable login until Firestore is ready

        Await FirestoreHelperClass.InitializeFirestoreAsync()

        UpdateLoginButtonState()
        MakeButtonRounded(btnLogin, 34)
        MakePanelRounded(Panel1, 6)

        txtPassword.UseSystemPasswordChar = True
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

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        panel.Region = New Region(path)
    End Sub


    ' --- Toggle Password Visibility ---
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub


    ' --- Enable login button when fields are filled ---
    Private Sub txtFields_TextChanged(sender As Object, e As EventArgs) _
        Handles txtUserName.TextChanged, txtPassword.TextChanged,
                txtUserName.TextChanged, txtPassword.TextChanged

        UpdateLoginButtonState()
    End Sub


    Private Sub UpdateLoginButtonState()
        btnLogin.Enabled =
            Not String.IsNullOrWhiteSpace(txtUserName.Text) AndAlso
            Not String.IsNullOrWhiteSpace(txtPassword.Text) AndAlso
            FirestoreHelperClass.db IsNot Nothing
    End Sub


    ' --- Login button click ---
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = txtUserName.Text.Trim
        Dim password = txtPassword.Text.Trim

        If FirestoreHelperClass.db Is Nothing Then
            MessageBox.Show("Firestore is not initialized yet. Please wait a moment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Fetch user document from Firestore
            Dim userDoc = Await FirestoreHelperClass.db.Collection("users").Document(username).GetSnapshotAsync
            If userDoc.Exists Then
                Dim storedPassword = userDoc.GetValue(Of String)("password")
                ' ✅ Use BCrypt to verify hashed password
                If BCrypt.Net.BCrypt.Verify(password, storedPassword) Then
                    ' Login successful
                    Dim mainF As New MainForm
                    mainF.Show()
                    mainF.SetUserName(username)
                    Hide()
                Else
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("User not found! Please signup first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Login failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' --- Press Enter to Login ---
    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter AndAlso btnLogin.Enabled Then
            btnLogin.PerformClick()
        End If
    End Sub


    ' --- Navigate to Signup Form ---
    Private Sub lnkSignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
        Handles lnkSignup.LinkClicked, lnkSignup.LinkClicked

        Dim signupForm As New FrmSignup
        signupForm.Show()
        Hide()
    End Sub


    ' --- Pre-fill username after signup ---
    Public Sub PreFillUsername(username As String)
        txtUserName.Text = username
        txtPassword.Clear()
        txtPassword.Focus()
        UpdateLoginButtonState()
    End Sub

End Class
