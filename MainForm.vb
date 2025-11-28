Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class MainForm

    ' 🧭 Navigation setup
    Private navButtons As List(Of Button)
    Private activeIndicator As Panel
    Private activeButton As Button
    Private WithEvents animationTimer As Timer
    Private indicatorTargetY As Integer
    Private indicatorSpeed As Double = 0

    ' 🧱 Cached user controls for instant switching
    Private pageDashboard As UcDashboard2
    Private pageInventory As UcInventory
    Private pageAppointment As UcAppointment
    Private pageOrders As UcOrders
    Private pageChart As UcChartSales

    ' 🎨 Color palette
    Private ReadOnly BgColor As Color = Color.FromArgb(245, 247, 250)
    Private ReadOnly HoverColor1 As Color = Color.FromArgb(175, 210, 250)
    Private ReadOnly HoverColor2 As Color = Color.FromArgb(175, 210, 250)
    Private ReadOnly ActiveColor1 As Color = Color.FromArgb(175, 210, 250)
    Private ReadOnly ActiveColor2 As Color = Color.FromArgb(175, 210, 250)
    Private ReadOnly TextNormal As Color = Color.White
    Private ReadOnly TextActive As Color = Color.FromArgb(60, 70, 85)
    Private ReadOnly IndicatorColor As Color = Color.FromArgb(0, 120, 215)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 🌤️ Smooth UI setup
        Me.BackColor = BgColor
        Me.DoubleBuffered = True

        ' ⚙️ Sidebar button list
        navButtons = New List(Of Button) From {
            btnDashboard, btnInventory, btnAppointments, btnOrders, btnChart
        }

        ' 🎨 Style buttons once (no repeated GDI+ calls)
        For Each btn As Button In navButtons
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.ForeColor = TextNormal
            btn.BackColor = Color.Transparent
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.ImageAlign = ContentAlignment.MiddleLeft
            btn.Padding = New Padding(35, 0, 0, 0)
        Next

        ' 🔹 Create the vertical indicator bar
        activeIndicator = New Panel() With {
            .Width = 5,
            .Height = btnDashboard.Height,
            .BackColor = IndicatorColor,
            .Visible = False
        }
        panelSidebar.Controls.Add(activeIndicator)
        activeIndicator.BringToFront()

        ' 🕹️ Timer for indicator animation
        animationTimer = New Timer() With {.Interval = 15}

        ' ⚡ Preload all user controls in memory for instant switching
        pageDashboard = New UcDashboard2() With {.Dock = DockStyle.Fill}
        pageInventory = New UcInventory() With {.Dock = DockStyle.Fill}
        pageAppointment = New UcAppointment() With {.Dock = DockStyle.Fill}
        pageOrders = New UcOrders() With {.Dock = DockStyle.Fill}
        pageChart = New UcChartSales() With {.Dock = DockStyle.Fill}

        ' 🩵 Add all to panel (only show one at a time)
        panelMain.Controls.AddRange({pageDashboard, pageInventory, pageAppointment, pageOrders, pageChart})
        For Each ctrl As Control In panelMain.Controls
            ctrl.Visible = False
        Next

        ' 🚀 Default selected view
        btnDashboard.PerformClick()
    End Sub

    ' --- MainForm.vb ---
    Public Sub SetUserName(username As String)
        lblUserName.Text = username
    End Sub



    ' ✨ Gradient background (cached brush)
    Private Sub PaintGradient(btn As Button, c1 As Color, c2 As Color)
        If btn.Width <= 0 OrElse btn.Height <= 0 Then Exit Sub
        Dim bmp As New Bitmap(btn.Width, btn.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Using brush As New LinearGradientBrush(btn.ClientRectangle, c1, c2, LinearGradientMode.Vertical)
                g.FillRectangle(brush, btn.ClientRectangle)
            End Using
        End Using
        btn.BackgroundImage = bmp
        btn.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    ' 💫 Reset inactive buttons
    Private Sub ResetButtons()
        For Each btn As Button In navButtons
            btn.ForeColor = TextNormal
            btn.BackgroundImage = Nothing
            btn.BackColor = Color.Transparent
        Next
    End Sub

    ' 🌟 Highlight active button
    Private Sub SetActiveButton(btn As Button)
        ResetButtons()
        activeButton = btn
        PaintGradient(btn, ActiveColor1, ActiveColor2)
        btn.ForeColor = TextActive

        activeIndicator.Visible = True
        indicatorTargetY = btn.Top
        indicatorSpeed = 0
        animationTimer.Start()
    End Sub

    ' ⚡ Smooth vertical slide animation
    Private Sub animationTimer_Tick(sender As Object, e As EventArgs) Handles animationTimer.Tick
        If activeIndicator Is Nothing OrElse activeButton Is Nothing Then Exit Sub

        Dim diff As Double = indicatorTargetY - activeIndicator.Top
        indicatorSpeed += diff * 0.2
        indicatorSpeed *= 0.6
        activeIndicator.Top += CInt(indicatorSpeed)
        activeIndicator.Left = 0
        activeIndicator.Height = activeButton.Height
        activeIndicator.BringToFront()
    End Sub

    ' 🖱️ Hover effects
    Private Sub navButton_MouseEnter(sender As Object, e As EventArgs) Handles _
        btnDashboard.MouseEnter, btnInventory.MouseEnter, btnAppointments.MouseEnter, btnOrders.MouseEnter, btnChart.MouseEnter
        Dim btn = DirectCast(sender, Button)
        If btn IsNot activeButton Then PaintGradient(btn, HoverColor1, HoverColor2)
    End Sub

    Private Sub navButton_MouseLeave(sender As Object, e As EventArgs) Handles _
        btnDashboard.MouseLeave, btnInventory.MouseLeave, btnAppointments.MouseLeave, btnOrders.MouseLeave, btnChart.MouseLeave
        Dim btn = DirectCast(sender, Button)
        If btn IsNot activeButton Then
            btn.BackgroundImage = Nothing
            btn.BackColor = Color.Transparent
        End If
    End Sub

    ' 🧭 Navigation buttons
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        SetActiveButton(btnDashboard)
        ShowPage(pageDashboard)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        SetActiveButton(btnInventory)
        ShowPage(pageInventory)
    End Sub

    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        SetActiveButton(btnAppointments)
        ShowPage(pageAppointment)
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        SetActiveButton(btnOrders)
        ShowPage(pageOrders)
    End Sub

    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        SetActiveButton(btnChart)
        ShowPage(pageChart)
    End Sub

    ' 🔄 Instantly show preloaded pages
    Private Sub ShowPage(page As UserControl)
        For Each ctrl As Control In panelMain.Controls
            ctrl.Visible = False
        Next
        page.Visible = True
        page.BringToFront()
    End Sub

    ' 🚪 Log out
    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Logout Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            ' Optional: stop listeners, cleanup etc.
            ResetButtons()

            ' Hide MainForm
            Me.Hide()

            ' Show Login Form
            Dim loginForm As New FrmLogin()
            loginForm.Show()

            MessageBox.Show("You have been logged out successfully.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
