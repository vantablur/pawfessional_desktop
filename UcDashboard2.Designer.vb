<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcDashboard2
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcDashboard2))
        Panel3 = New Panel()
        lbldgvLine = New Label()
        dgvAppointment = New DataGridView()
        colClientName = New DataGridViewTextBoxColumn()
        ColContact = New DataGridViewTextBoxColumn()
        colEmail = New DataGridViewTextBoxColumn()
        coldate = New DataGridViewTextBoxColumn()
        colTime = New DataGridViewTextBoxColumn()
        colStatuss = New DataGridViewTextBoxColumn()
        dgvRecentOrders = New DataGridView()
        colItemID = New DataGridViewTextBoxColumn()
        colCustomerName = New DataGridViewTextBoxColumn()
        colProductName = New DataGridViewTextBoxColumn()
        colTotal = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        lblAppointmentHistory = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        Panel8 = New Panel()
        PictureBox6 = New PictureBox()
        lblTotalSales = New Label()
        Label7 = New Label()
        Panel6 = New Panel()
        PictureBox5 = New PictureBox()
        lblTotalCost = New Label()
        Label6 = New Label()
        Panel7 = New Panel()
        PictureBox1 = New PictureBox()
        lblTotalProfit = New Label()
        lblProfit = New Label()
        Panel5 = New Panel()
        PictureBox4 = New PictureBox()
        lblTotalRevenue = New Label()
        Label1 = New Label()
        lblDashboard = New Label()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        lblTotalOrders = New Label()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        lblTotalAppointments = New Label()
        panelMain = New Panel()
        Panel3.SuspendLayout()
        CType(dgvAppointment, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvRecentOrders, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel8.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        panelMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lbldgvLine)
        Panel3.Controls.Add(dgvAppointment)
        Panel3.Controls.Add(dgvRecentOrders)
        Panel3.Controls.Add(lblAppointmentHistory)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(-1, 218)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1534, 863)
        Panel3.TabIndex = 6
        ' 
        ' lbldgvLine
        ' 
        lbldgvLine.BackColor = Color.Black
        lbldgvLine.Location = New Point(0, 382)
        lbldgvLine.Name = "lbldgvLine"
        lbldgvLine.Size = New Size(1525, 1)
        lbldgvLine.TabIndex = 8
        lbldgvLine.Text = """"""
        ' 
        ' dgvAppointment
        ' 
        dgvAppointment.AllowUserToAddRows = False
        dgvAppointment.AllowUserToDeleteRows = False
        dgvAppointment.AllowUserToResizeColumns = False
        dgvAppointment.AllowUserToResizeRows = False
        dgvAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAppointment.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(31), CByte(42), CByte(68))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(51), CByte(62), CByte(88))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAppointment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAppointment.ColumnHeadersHeight = 28
        dgvAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvAppointment.Columns.AddRange(New DataGridViewColumn() {colClientName, ColContact, colEmail, coldate, colTime, colStatuss})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.White
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvAppointment.DefaultCellStyle = DataGridViewCellStyle2
        dgvAppointment.EnableHeadersVisualStyles = False
        dgvAppointment.GridColor = Color.LightGray
        dgvAppointment.Location = New Point(0, 422)
        dgvAppointment.MultiSelect = False
        dgvAppointment.Name = "dgvAppointment"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Highlight
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvAppointment.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvAppointment.RowHeadersVisible = False
        dgvAppointment.RowHeadersWidth = 62
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        dgvAppointment.RowsDefaultCellStyle = DataGridViewCellStyle4
        dgvAppointment.ScrollBars = ScrollBars.Vertical
        dgvAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAppointment.Size = New Size(1533, 380)
        dgvAppointment.TabIndex = 6
        ' 
        ' colClientName
        ' 
        colClientName.FillWeight = 180F
        colClientName.HeaderText = "Client Name"
        colClientName.MinimumWidth = 8
        colClientName.Name = "colClientName"
        colClientName.ReadOnly = True
        ' 
        ' ColContact
        ' 
        ColContact.HeaderText = "Contact Number"
        ColContact.MinimumWidth = 8
        ColContact.Name = "ColContact"
        ColContact.ReadOnly = True
        ' 
        ' colEmail
        ' 
        colEmail.HeaderText = "Email"
        colEmail.MinimumWidth = 8
        colEmail.Name = "colEmail"
        colEmail.ReadOnly = True
        ' 
        ' coldate
        ' 
        coldate.HeaderText = "Date"
        coldate.MinimumWidth = 8
        coldate.Name = "coldate"
        coldate.ReadOnly = True
        ' 
        ' colTime
        ' 
        colTime.HeaderText = "Time"
        colTime.MinimumWidth = 8
        colTime.Name = "colTime"
        colTime.ReadOnly = True
        ' 
        ' colStatuss
        ' 
        colStatuss.HeaderText = "Status"
        colStatuss.MinimumWidth = 8
        colStatuss.Name = "colStatuss"
        colStatuss.ReadOnly = True
        ' 
        ' dgvRecentOrders
        ' 
        dgvRecentOrders.AllowUserToAddRows = False
        dgvRecentOrders.AllowUserToDeleteRows = False
        dgvRecentOrders.AllowUserToResizeColumns = False
        dgvRecentOrders.AllowUserToResizeRows = False
        dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentOrders.BackgroundColor = SystemColors.Window
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(31), CByte(42), CByte(68))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(51), CByte(62), CByte(88))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvRecentOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvRecentOrders.ColumnHeadersHeight = 28
        dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRecentOrders.Columns.AddRange(New DataGridViewColumn() {colItemID, colCustomerName, colProductName, colTotal, colQuantity, colStatus})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Window
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Desktop
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvRecentOrders.DefaultCellStyle = DataGridViewCellStyle6
        dgvRecentOrders.EnableHeadersVisualStyles = False
        dgvRecentOrders.GridColor = Color.LightGray
        dgvRecentOrders.Location = New Point(-1, 40)
        dgvRecentOrders.MultiSelect = False
        dgvRecentOrders.Name = "dgvRecentOrders"
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Desktop
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvRecentOrders.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvRecentOrders.RowHeadersVisible = False
        dgvRecentOrders.RowHeadersWidth = 62
        dgvRecentOrders.ScrollBars = ScrollBars.Vertical
        dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentOrders.Size = New Size(1533, 322)
        dgvRecentOrders.TabIndex = 5
        ' 
        ' colItemID
        ' 
        colItemID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colItemID.HeaderText = "Item ID"
        colItemID.MinimumWidth = 50
        colItemID.Name = "colItemID"
        colItemID.ReadOnly = True
        colItemID.Resizable = DataGridViewTriState.False
        colItemID.Width = 180
        ' 
        ' colCustomerName
        ' 
        colCustomerName.FillWeight = 160F
        colCustomerName.HeaderText = "Customer Name"
        colCustomerName.MinimumWidth = 8
        colCustomerName.Name = "colCustomerName"
        colCustomerName.ReadOnly = True
        ' 
        ' colProductName
        ' 
        colProductName.HeaderText = "Product Name"
        colProductName.MinimumWidth = 50
        colProductName.Name = "colProductName"
        colProductName.ReadOnly = True
        ' 
        ' colTotal
        ' 
        colTotal.FillWeight = 150F
        colTotal.HeaderText = "Total"
        colTotal.MinimumWidth = 50
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        ' 
        ' colQuantity
        ' 
        colQuantity.HeaderText = "Quantity"
        colQuantity.MinimumWidth = 50
        colQuantity.Name = "colQuantity"
        colQuantity.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 50
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' lblAppointmentHistory
        ' 
        lblAppointmentHistory.AutoSize = True
        lblAppointmentHistory.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppointmentHistory.Location = New Point(620, 381)
        lblAppointmentHistory.Name = "lblAppointmentHistory"
        lblAppointmentHistory.Size = New Size(297, 38)
        lblAppointmentHistory.TabIndex = 7
        lblAppointmentHistory.Text = "Appointment History"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(658, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(200, 38)
        Label3.TabIndex = 6
        Label3.Text = "Recent Orders"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Panel8)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Panel7)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(lblDashboard)
        Panel4.Controls.Add(Panel1)
        Panel4.Controls.Add(Panel2)
        Panel4.Location = New Point(-1, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1530, 212)
        Panel4.TabIndex = 7
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(PictureBox6)
        Panel8.Controls.Add(lblTotalSales)
        Panel8.Controls.Add(Label7)
        Panel8.Location = New Point(1013, 62)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(230, 128)
        Panel8.TabIndex = 10
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(13, 14)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(36, 32)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 6
        PictureBox6.TabStop = False
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.AutoSize = True
        lblTotalSales.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSales.ForeColor = Color.Black
        lblTotalSales.Location = New Point(13, 79)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(0, 38)
        lblTotalSales.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 49)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 30)
        Label7.TabIndex = 4
        Label7.Text = "Total Sales"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(PictureBox5)
        Panel6.Controls.Add(lblTotalCost)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(517, 62)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(230, 128)
        Panel6.TabIndex = 9
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(13, 14)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(36, 32)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 6
        PictureBox5.TabStop = False
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCost.ForeColor = Color.Black
        lblTotalCost.Location = New Point(13, 79)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(0, 38)
        lblTotalCost.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(174, 30)
        Label6.TabIndex = 4
        Label6.Text = "Total Sales Cost"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(PictureBox1)
        Panel7.Controls.Add(lblTotalProfit)
        Panel7.Controls.Add(lblProfit)
        Panel7.Location = New Point(271, 62)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(228, 128)
        Panel7.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(36, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' lblTotalProfit
        ' 
        lblTotalProfit.AutoSize = True
        lblTotalProfit.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalProfit.ForeColor = Color.Black
        lblTotalProfit.Location = New Point(13, 79)
        lblTotalProfit.Name = "lblTotalProfit"
        lblTotalProfit.Size = New Size(0, 38)
        lblTotalProfit.TabIndex = 5
        ' 
        ' lblProfit
        ' 
        lblProfit.AutoSize = True
        lblProfit.BackColor = Color.White
        lblProfit.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProfit.Location = New Point(13, 49)
        lblProfit.Name = "lblProfit"
        lblProfit.Size = New Size(129, 30)
        lblProfit.TabIndex = 4
        lblProfit.Text = "Total Profit"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(lblTotalRevenue)
        Panel5.Controls.Add(Label1)
        Panel5.Location = New Point(20, 62)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(228, 128)
        Panel5.TabIndex = 7
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(13, 14)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(36, 32)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' lblTotalRevenue
        ' 
        lblTotalRevenue.AutoSize = True
        lblTotalRevenue.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalRevenue.ForeColor = Color.Black
        lblTotalRevenue.Location = New Point(13, 79)
        lblTotalRevenue.Name = "lblTotalRevenue"
        lblTotalRevenue.Size = New Size(0, 38)
        lblTotalRevenue.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 30)
        Label1.TabIndex = 4
        Label1.Text = "Total Revenue"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboard.Location = New Point(620, -4)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(284, 54)
        lblDashboard.TabIndex = 6
        lblDashboard.Text = "DASHBOARD"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblTotalOrders)
        Panel1.Location = New Point(772, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(224, 128)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(15, 16)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(15, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 30)
        Label4.TabIndex = 3
        Label4.Text = "Total Order"
        ' 
        ' lblTotalOrders
        ' 
        lblTotalOrders.AutoSize = True
        lblTotalOrders.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalOrders.Location = New Point(15, 78)
        lblTotalOrders.Name = "lblTotalOrders"
        lblTotalOrders.Size = New Size(0, 38)
        lblTotalOrders.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(lblTotalAppointments)
        Panel2.Location = New Point(1263, 62)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(246, 128)
        Panel2.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(19, 17)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(36, 32)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(19, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(218, 30)
        Label5.TabIndex = 4
        Label5.Text = "Total Appointments"
        ' 
        ' lblTotalAppointments
        ' 
        lblTotalAppointments.AutoSize = True
        lblTotalAppointments.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAppointments.Location = New Point(19, 78)
        lblTotalAppointments.Name = "lblTotalAppointments"
        lblTotalAppointments.Size = New Size(0, 38)
        lblTotalAppointments.TabIndex = 2
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelMain.BorderStyle = BorderStyle.FixedSingle
        panelMain.Controls.Add(Panel4)
        panelMain.Controls.Add(Panel3)
        panelMain.Location = New Point(3, 0)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1534, 1086)
        panelMain.TabIndex = 0
        ' 
        ' UcDashboard2
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.White
        Controls.Add(panelMain)
        Name = "UcDashboard2"
        Size = New Size(1542, 1089)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvAppointment, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvRecentOrders, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        panelMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbldgvLine As Label
    Friend WithEvents dgvAppointment As DataGridView
    Friend WithEvents colClientName As DataGridViewTextBoxColumn
    Friend WithEvents ColContact As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents coldate As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents colStatuss As DataGridViewTextBoxColumn
    Friend WithEvents dgvRecentOrders As DataGridView
    Friend WithEvents colItemID As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colProductName As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents lblAppointmentHistory As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents lblProfit As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalOrders As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalAppointments As Label
    Friend WithEvents panelMain As Panel

End Class
