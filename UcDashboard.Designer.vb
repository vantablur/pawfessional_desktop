<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcDashboard))
        panelMain = New Panel()
        panelContainer = New Panel()
        Chart1 = New DataVisualization.Charting.Chart()
        lblRecentOrders = New Label()
        dgvRecentOrders = New DataGridView()
        colItemID = New DataGridViewTextBoxColumn()
        colProductName = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        panelHeader = New Panel()
        Panel1 = New Panel()
        lblLine = New Label()
        lblTopSales = New Label()
        picProfile = New PictureBox()
        lblName = New Label()
        panelAppoinments = New Panel()
        lblTotalAppointments = New Label()
        lblAppointmentsTitle = New Label()
        lblRole = New Label()
        lblDashboard = New Label()
        panelOrders = New Panel()
        lblTotalOrders = New Label()
        lblOrdersTitle = New Label()
        panelMain.SuspendLayout()
        panelContainer.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvRecentOrders, ComponentModel.ISupportInitialize).BeginInit()
        panelHeader.SuspendLayout()
        Panel1.SuspendLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        panelAppoinments.SuspendLayout()
        panelOrders.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        panelMain.Controls.Add(panelContainer)
        panelMain.Controls.Add(panelHeader)
        panelMain.Dock = DockStyle.Fill
        panelMain.ForeColor = Color.Black
        panelMain.Location = New Point(0, 0)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1351, 747)
        panelMain.TabIndex = 0
        ' 
        ' panelContainer
        ' 
        panelContainer.BackColor = Color.White
        panelContainer.Controls.Add(Chart1)
        panelContainer.Controls.Add(lblRecentOrders)
        panelContainer.Controls.Add(dgvRecentOrders)
        panelContainer.Location = New Point(12, 273)
        panelContainer.Name = "panelContainer"
        panelContainer.Size = New Size(1319, 452)
        panelContainer.TabIndex = 2
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(28, 94)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(450, 320)
        Chart1.TabIndex = 13
        Chart1.Text = "Chart1"
        ' 
        ' lblRecentOrders
        ' 
        lblRecentOrders.AutoSize = True
        lblRecentOrders.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRecentOrders.Location = New Point(796, 11)
        lblRecentOrders.Name = "lblRecentOrders"
        lblRecentOrders.Size = New Size(230, 45)
        lblRecentOrders.TabIndex = 12
        lblRecentOrders.Text = "Recent Orders"
        ' 
        ' dgvRecentOrders
        ' 
        dgvRecentOrders.AllowUserToAddRows = False
        dgvRecentOrders.AllowUserToResizeColumns = False
        dgvRecentOrders.AllowUserToResizeRows = False
        dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentOrders.BackgroundColor = Color.White
        dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentOrders.Columns.AddRange(New DataGridViewColumn() {colItemID, colProductName, colPrice, colQuantity, colStatus})
        dgvRecentOrders.Location = New Point(511, 69)
        dgvRecentOrders.Name = "dgvRecentOrders"
        dgvRecentOrders.RowHeadersWidth = 62
        dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentOrders.Size = New Size(784, 365)
        dgvRecentOrders.TabIndex = 11
        ' 
        ' colItemID
        ' 
        colItemID.FillWeight = 83.80678F
        colItemID.HeaderText = "Item ID"
        colItemID.MinimumWidth = 8
        colItemID.Name = "colItemID"
        ' 
        ' colProductName
        ' 
        colProductName.FillWeight = 164.772766F
        colProductName.HeaderText = "Product Name"
        colProductName.MinimumWidth = 6
        colProductName.Name = "colProductName"
        ' 
        ' colPrice
        ' 
        colPrice.FillWeight = 83.80678F
        colPrice.HeaderText = "Price"
        colPrice.MinimumWidth = 8
        colPrice.Name = "colPrice"
        ' 
        ' colQuantity
        ' 
        colQuantity.FillWeight = 83.80678F
        colQuantity.HeaderText = "Quantity"
        colQuantity.MinimumWidth = 8
        colQuantity.Name = "colQuantity"
        ' 
        ' colStatus
        ' 
        colStatus.FillWeight = 83.80678F
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 8
        colStatus.Name = "colStatus"
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.White
        panelHeader.Controls.Add(Panel1)
        panelHeader.Controls.Add(picProfile)
        panelHeader.Controls.Add(lblName)
        panelHeader.Controls.Add(panelAppoinments)
        panelHeader.Controls.Add(lblRole)
        panelHeader.Controls.Add(lblDashboard)
        panelHeader.Controls.Add(panelOrders)
        panelHeader.Location = New Point(12, 24)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(1319, 234)
        panelHeader.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblLine)
        Panel1.Controls.Add(lblTopSales)
        Panel1.Location = New Point(857, 66)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(438, 150)
        Panel1.TabIndex = 7
        ' 
        ' lblLine
        ' 
        lblLine.BackColor = Color.Black
        lblLine.Location = New Point(21, 60)
        lblLine.Name = "lblLine"
        lblLine.Size = New Size(396, 1)
        lblLine.TabIndex = 1
        lblLine.Text = """"""
        ' 
        ' lblTopSales
        ' 
        lblTopSales.AutoSize = True
        lblTopSales.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTopSales.Location = New Point(12, 21)
        lblTopSales.Name = "lblTopSales"
        lblTopSales.Size = New Size(91, 25)
        lblTopSales.TabIndex = 0
        lblTopSales.Text = "Top Sales"
        ' 
        ' picProfile
        ' 
        picProfile.Image = CType(resources.GetObject("picProfile.Image"), Image)
        picProfile.Location = New Point(12, 16)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(100, 100)
        picProfile.SizeMode = PictureBoxSizeMode.Zoom
        picProfile.TabIndex = 1
        picProfile.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(112, 16)
        lblName.Name = "lblName"
        lblName.Size = New Size(338, 32)
        lblName.TabIndex = 2
        lblName.Text = "Mrs. Cellie Mae U. Rombaon"
        ' 
        ' panelAppoinments
        ' 
        panelAppoinments.BackColor = Color.White
        panelAppoinments.BorderStyle = BorderStyle.FixedSingle
        panelAppoinments.Controls.Add(lblTotalAppointments)
        panelAppoinments.Controls.Add(lblAppointmentsTitle)
        panelAppoinments.Location = New Point(520, 91)
        panelAppoinments.Name = "panelAppoinments"
        panelAppoinments.Size = New Size(262, 125)
        panelAppoinments.TabIndex = 6
        ' 
        ' lblTotalAppointments
        ' 
        lblTotalAppointments.AutoSize = True
        lblTotalAppointments.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalAppointments.ForeColor = Color.Black
        lblTotalAppointments.Location = New Point(21, 71)
        lblTotalAppointments.Name = "lblTotalAppointments"
        lblTotalAppointments.Size = New Size(0, 38)
        lblTotalAppointments.TabIndex = 1
        ' 
        ' lblAppointmentsTitle
        ' 
        lblAppointmentsTitle.AutoSize = True
        lblAppointmentsTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAppointmentsTitle.Location = New Point(21, 23)
        lblAppointmentsTitle.Name = "lblAppointmentsTitle"
        lblAppointmentsTitle.Size = New Size(165, 25)
        lblAppointmentsTitle.TabIndex = 0
        lblAppointmentsTitle.Text = "Total Appoinment"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(118, 48)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(82, 25)
        lblRole.TabIndex = 3
        lblRole.Text = "Manager"
        ' 
        ' lblDashboard
        ' 
        lblDashboard.AutoSize = True
        lblDashboard.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDashboard.Location = New Point(575, 16)
        lblDashboard.Name = "lblDashboard"
        lblDashboard.Size = New Size(272, 54)
        lblDashboard.TabIndex = 0
        lblDashboard.Text = "DASHBOARD"
        ' 
        ' panelOrders
        ' 
        panelOrders.BackColor = Color.White
        panelOrders.BorderStyle = BorderStyle.FixedSingle
        panelOrders.Controls.Add(lblTotalOrders)
        panelOrders.Controls.Add(lblOrdersTitle)
        panelOrders.Location = New Point(191, 91)
        panelOrders.Name = "panelOrders"
        panelOrders.Size = New Size(270, 125)
        panelOrders.TabIndex = 5
        ' 
        ' lblTotalOrders
        ' 
        lblTotalOrders.AutoSize = True
        lblTotalOrders.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalOrders.ForeColor = Color.Black
        lblTotalOrders.Location = New Point(19, 71)
        lblTotalOrders.Name = "lblTotalOrders"
        lblTotalOrders.Size = New Size(0, 38)
        lblTotalOrders.TabIndex = 1
        ' 
        ' lblOrdersTitle
        ' 
        lblOrdersTitle.AutoSize = True
        lblOrdersTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrdersTitle.Location = New Point(19, 23)
        lblOrdersTitle.Name = "lblOrdersTitle"
        lblOrdersTitle.Size = New Size(116, 25)
        lblOrdersTitle.TabIndex = 0
        lblOrdersTitle.Text = "Total Orders"
        ' 
        ' UcDashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        Controls.Add(panelMain)
        Name = "UcDashboard"
        Size = New Size(1351, 747)
        panelMain.ResumeLayout(False)
        panelContainer.ResumeLayout(False)
        panelContainer.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvRecentOrders, ComponentModel.ISupportInitialize).EndInit()
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        panelAppoinments.ResumeLayout(False)
        panelAppoinments.PerformLayout()
        panelOrders.ResumeLayout(False)
        panelOrders.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents panelOrders As Panel
    Friend WithEvents lblTotalOrders As Label
    Friend WithEvents lblOrdersTitle As Label
    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelContainer As Panel
    Friend WithEvents dgvRecentOrders As DataGridView
    Friend WithEvents lblRecentOrders As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLine As Label
    Friend WithEvents lblTopSales As Label
    Friend WithEvents panelAppoinments As Panel
    Friend WithEvents lblTotalAppointments As Label
    Friend WithEvents lblAppointmentsTitle As Label
    Friend WithEvents colItemID As DataGridViewTextBoxColumn
    Friend WithEvents colProductName As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents FormsPlot1 As ScottPlot.WinForms.FormsPlot
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart

End Class
