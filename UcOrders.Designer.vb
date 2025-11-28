<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcOrders
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcOrders))
        panelMain = New Panel()
        dgvOrders = New DataGridView()
        colCustomerName = New DataGridViewTextBoxColumn()
        colProductName = New DataGridViewTextBoxColumn()
        ColQuantity = New DataGridViewTextBoxColumn()
        colAmount = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        panelHeader = New Panel()
        btnCancel = New Button()
        btnSearch = New Button()
        btnComplete = New Button()
        txtSearch = New TextBox()
        btnDelete = New Button()
        panelCanceledOrders = New Panel()
        PictureBox4 = New PictureBox()
        lblCanceledordersSubtext = New Label()
        lblCanceledOrders = New Label()
        lblCanceledOrdersTitle = New Label()
        panelCompletedOrders = New Panel()
        lblCompletedOrdersSubtext = New Label()
        PictureBox2 = New PictureBox()
        lblCompletedOrders = New Label()
        lblCompletedOrdersTitle = New Label()
        panelNewOrders = New Panel()
        PictureBox1 = New PictureBox()
        lblNewOrderSubtext = New Label()
        lblNewOrders = New Label()
        lblNewOrdersTitle = New Label()
        lblLineHeader = New Label()
        lblTitle = New Label()
        panelTotalOrders = New Panel()
        lblTotalOrderSubtext = New Label()
        PictureBox3 = New PictureBox()
        lblTotalOrders = New Label()
        lblTotalOrder = New Label()
        cmbProductType = New ComboBox()
        lblProductType = New Label()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        panelMain.SuspendLayout()
        CType(dgvOrders, ComponentModel.ISupportInitialize).BeginInit()
        panelHeader.SuspendLayout()
        panelCanceledOrders.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        panelCompletedOrders.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        panelNewOrders.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelTotalOrders.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.White
        panelMain.BorderStyle = BorderStyle.FixedSingle
        panelMain.Controls.Add(dgvOrders)
        panelMain.Controls.Add(panelHeader)
        panelMain.Location = New Point(3, 3)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1534, 945)
        panelMain.TabIndex = 0
        ' 
        ' dgvOrders
        ' 
        dgvOrders.AllowUserToAddRows = False
        dgvOrders.AllowUserToDeleteRows = False
        dgvOrders.AllowUserToResizeColumns = False
        dgvOrders.AllowUserToResizeRows = False
        dgvOrders.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(31), CByte(42), CByte(68))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(51), CByte(62), CByte(88))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvOrders.ColumnHeadersHeight = 40
        dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvOrders.Columns.AddRange(New DataGridViewColumn() {colCustomerName, colProductName, ColQuantity, colAmount, colStatus})
        dgvOrders.EnableHeadersVisualStyles = False
        dgvOrders.GridColor = Color.Gray
        dgvOrders.Location = New Point(-1, 301)
        dgvOrders.MultiSelect = False
        dgvOrders.Name = "dgvOrders"
        dgvOrders.RowHeadersVisible = False
        dgvOrders.RowHeadersWidth = 62
        dgvOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvOrders.ScrollBars = ScrollBars.Vertical
        dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOrders.Size = New Size(1530, 639)
        dgvOrders.TabIndex = 9
        ' 
        ' colCustomerName
        ' 
        colCustomerName.FillWeight = 180F
        colCustomerName.HeaderText = "Customer Name"
        colCustomerName.MinimumWidth = 50
        colCustomerName.Name = "colCustomerName"
        colCustomerName.ReadOnly = True
        colCustomerName.Width = 500
        ' 
        ' colProductName
        ' 
        colProductName.FillWeight = 180F
        colProductName.HeaderText = "Product Name"
        colProductName.MinimumWidth = 50
        colProductName.Name = "colProductName"
        colProductName.ReadOnly = True
        colProductName.Width = 499
        ' 
        ' ColQuantity
        ' 
        ColQuantity.FillWeight = 60F
        ColQuantity.HeaderText = "Quantity"
        ColQuantity.MinimumWidth = 50
        ColQuantity.Name = "ColQuantity"
        ColQuantity.ReadOnly = True
        ColQuantity.Width = 167
        ' 
        ' colAmount
        ' 
        colAmount.FillWeight = 60F
        colAmount.HeaderText = "Total Amount"
        colAmount.MinimumWidth = 50
        colAmount.Name = "colAmount"
        colAmount.ReadOnly = True
        colAmount.Width = 167
        ' 
        ' colStatus
        ' 
        colStatus.FillWeight = 70F
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 50
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 194
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.White
        panelHeader.BorderStyle = BorderStyle.FixedSingle
        panelHeader.Controls.Add(btnCancel)
        panelHeader.Controls.Add(btnSearch)
        panelHeader.Controls.Add(btnComplete)
        panelHeader.Controls.Add(txtSearch)
        panelHeader.Controls.Add(btnDelete)
        panelHeader.Controls.Add(panelCanceledOrders)
        panelHeader.Controls.Add(panelCompletedOrders)
        panelHeader.Controls.Add(panelNewOrders)
        panelHeader.Controls.Add(lblLineHeader)
        panelHeader.Controls.Add(lblTitle)
        panelHeader.Controls.Add(panelTotalOrders)
        panelHeader.Controls.Add(cmbProductType)
        panelHeader.Controls.Add(lblProductType)
        panelHeader.Controls.Add(lblStatus)
        panelHeader.Controls.Add(cmbStatus)
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(1529, 299)
        panelHeader.TabIndex = 8
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(1209, 20)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(118, 59)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.Window
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(553, 34)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(48, 35)
        btnSearch.TabIndex = 2
        btnSearch.Text = "🔍"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnComplete
        ' 
        btnComplete.BackColor = Color.Green
        btnComplete.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnComplete.ForeColor = Color.White
        btnComplete.Location = New Point(1065, 20)
        btnComplete.Name = "btnComplete"
        btnComplete.Size = New Size(118, 58)
        btnComplete.TabIndex = 13
        btnComplete.Text = "Complete"
        btnComplete.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.WhiteSmoke
        txtSearch.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Black
        txtSearch.Location = New Point(230, 31)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search here..."
        txtSearch.Size = New Size(371, 39)
        txtSearch.TabIndex = 1
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Black
        btnDelete.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(1348, 20)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 60)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' panelCanceledOrders
        ' 
        panelCanceledOrders.Controls.Add(PictureBox4)
        panelCanceledOrders.Controls.Add(lblCanceledordersSubtext)
        panelCanceledOrders.Controls.Add(lblCanceledOrders)
        panelCanceledOrders.Controls.Add(lblCanceledOrdersTitle)
        panelCanceledOrders.Location = New Point(1160, 117)
        panelCanceledOrders.Name = "panelCanceledOrders"
        panelCanceledOrders.Size = New Size(300, 161)
        panelCanceledOrders.TabIndex = 11
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(20, 13)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(39, 35)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' lblCanceledordersSubtext
        ' 
        lblCanceledordersSubtext.AutoSize = True
        lblCanceledordersSubtext.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCanceledordersSubtext.ForeColor = Color.Gray
        lblCanceledordersSubtext.Location = New Point(20, 120)
        lblCanceledordersSubtext.Name = "lblCanceledordersSubtext"
        lblCanceledordersSubtext.Size = New Size(171, 30)
        lblCanceledordersSubtext.TabIndex = 2
        lblCanceledordersSubtext.Text = "for last 365 days"
        ' 
        ' lblCanceledOrders
        ' 
        lblCanceledOrders.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCanceledOrders.Location = New Point(20, 82)
        lblCanceledOrders.Name = "lblCanceledOrders"
        lblCanceledOrders.Size = New Size(85, 38)
        lblCanceledOrders.TabIndex = 1
        ' 
        ' lblCanceledOrdersTitle
        ' 
        lblCanceledOrdersTitle.AutoSize = True
        lblCanceledOrdersTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCanceledOrdersTitle.Location = New Point(20, 51)
        lblCanceledOrdersTitle.Name = "lblCanceledOrdersTitle"
        lblCanceledOrdersTitle.Size = New Size(190, 30)
        lblCanceledOrdersTitle.TabIndex = 0
        lblCanceledOrdersTitle.Text = "Cancelled Orders"
        ' 
        ' panelCompletedOrders
        ' 
        panelCompletedOrders.Controls.Add(lblCompletedOrdersSubtext)
        panelCompletedOrders.Controls.Add(PictureBox2)
        panelCompletedOrders.Controls.Add(lblCompletedOrders)
        panelCompletedOrders.Controls.Add(lblCompletedOrdersTitle)
        panelCompletedOrders.Location = New Point(804, 117)
        panelCompletedOrders.Name = "panelCompletedOrders"
        panelCompletedOrders.Size = New Size(300, 161)
        panelCompletedOrders.TabIndex = 10
        ' 
        ' lblCompletedOrdersSubtext
        ' 
        lblCompletedOrdersSubtext.AutoSize = True
        lblCompletedOrdersSubtext.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCompletedOrdersSubtext.ForeColor = Color.Gray
        lblCompletedOrdersSubtext.Location = New Point(20, 119)
        lblCompletedOrdersSubtext.Name = "lblCompletedOrdersSubtext"
        lblCompletedOrdersSubtext.Size = New Size(171, 30)
        lblCompletedOrdersSubtext.TabIndex = 2
        lblCompletedOrdersSubtext.Text = "for last 365 days"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(32, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' lblCompletedOrders
        ' 
        lblCompletedOrders.AutoSize = True
        lblCompletedOrders.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompletedOrders.Location = New Point(20, 81)
        lblCompletedOrders.Name = "lblCompletedOrders"
        lblCompletedOrders.Size = New Size(0, 38)
        lblCompletedOrders.TabIndex = 1
        ' 
        ' lblCompletedOrdersTitle
        ' 
        lblCompletedOrdersTitle.AutoSize = True
        lblCompletedOrdersTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompletedOrdersTitle.Location = New Point(20, 51)
        lblCompletedOrdersTitle.Name = "lblCompletedOrdersTitle"
        lblCompletedOrdersTitle.Size = New Size(204, 30)
        lblCompletedOrdersTitle.TabIndex = 0
        lblCompletedOrdersTitle.Text = "Completed Orders"
        ' 
        ' panelNewOrders
        ' 
        panelNewOrders.Controls.Add(PictureBox1)
        panelNewOrders.Controls.Add(lblNewOrderSubtext)
        panelNewOrders.Controls.Add(lblNewOrders)
        panelNewOrders.Controls.Add(lblNewOrdersTitle)
        panelNewOrders.Location = New Point(415, 117)
        panelNewOrders.Name = "panelNewOrders"
        panelNewOrders.Size = New Size(320, 161)
        panelNewOrders.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(20, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 41)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' lblNewOrderSubtext
        ' 
        lblNewOrderSubtext.AutoSize = True
        lblNewOrderSubtext.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNewOrderSubtext.ForeColor = Color.Gray
        lblNewOrderSubtext.Location = New Point(20, 120)
        lblNewOrderSubtext.Name = "lblNewOrderSubtext"
        lblNewOrderSubtext.Size = New Size(158, 30)
        lblNewOrderSubtext.TabIndex = 2
        lblNewOrderSubtext.Text = "Today's Orders"
        ' 
        ' lblNewOrders
        ' 
        lblNewOrders.AutoSize = True
        lblNewOrders.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewOrders.Location = New Point(20, 81)
        lblNewOrders.Name = "lblNewOrders"
        lblNewOrders.Size = New Size(0, 38)
        lblNewOrders.TabIndex = 1
        ' 
        ' lblNewOrdersTitle
        ' 
        lblNewOrdersTitle.AutoSize = True
        lblNewOrdersTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNewOrdersTitle.Location = New Point(20, 51)
        lblNewOrdersTitle.Name = "lblNewOrdersTitle"
        lblNewOrdersTitle.Size = New Size(137, 30)
        lblNewOrdersTitle.TabIndex = 0
        lblNewOrdersTitle.Text = "New Orders"
        ' 
        ' lblLineHeader
        ' 
        lblLineHeader.BackColor = Color.Black
        lblLineHeader.Location = New Point(-2, 87)
        lblLineHeader.Name = "lblLineHeader"
        lblLineHeader.Size = New Size(1526, 2)
        lblLineHeader.TabIndex = 8
        lblLineHeader.Text = """"""
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(12, 26)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(212, 48)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Orders List"
        ' 
        ' panelTotalOrders
        ' 
        panelTotalOrders.Controls.Add(lblTotalOrderSubtext)
        panelTotalOrders.Controls.Add(PictureBox3)
        panelTotalOrders.Controls.Add(lblTotalOrders)
        panelTotalOrders.Controls.Add(lblTotalOrder)
        panelTotalOrders.Location = New Point(44, 117)
        panelTotalOrders.Name = "panelTotalOrders"
        panelTotalOrders.Size = New Size(307, 161)
        panelTotalOrders.TabIndex = 7
        ' 
        ' lblTotalOrderSubtext
        ' 
        lblTotalOrderSubtext.AutoSize = True
        lblTotalOrderSubtext.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalOrderSubtext.ForeColor = Color.Gray
        lblTotalOrderSubtext.Location = New Point(20, 120)
        lblTotalOrderSubtext.Name = "lblTotalOrderSubtext"
        lblTotalOrderSubtext.Size = New Size(171, 30)
        lblTotalOrderSubtext.TabIndex = 2
        lblTotalOrderSubtext.Text = "for last 365 days"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(20, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(39, 35)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' lblTotalOrders
        ' 
        lblTotalOrders.AutoSize = True
        lblTotalOrders.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalOrders.Location = New Point(20, 79)
        lblTotalOrders.Name = "lblTotalOrders"
        lblTotalOrders.Size = New Size(0, 38)
        lblTotalOrders.TabIndex = 1
        ' 
        ' lblTotalOrder
        ' 
        lblTotalOrder.AutoSize = True
        lblTotalOrder.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalOrder.Location = New Point(20, 51)
        lblTotalOrder.Name = "lblTotalOrder"
        lblTotalOrder.Size = New Size(131, 30)
        lblTotalOrder.TabIndex = 0
        lblTotalOrder.Text = "Total Order"
        ' 
        ' cmbProductType
        ' 
        cmbProductType.BackColor = Color.WhiteSmoke
        cmbProductType.FormattingEnabled = True
        cmbProductType.Items.AddRange(New Object() {"All", "Food", "Medicine", "Accessories"})
        cmbProductType.Location = New Point(824, 37)
        cmbProductType.Name = "cmbProductType"
        cmbProductType.Size = New Size(182, 33)
        cmbProductType.TabIndex = 4
        ' 
        ' lblProductType
        ' 
        lblProductType.AutoSize = True
        lblProductType.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProductType.Location = New Point(824, 9)
        lblProductType.Name = "lblProductType"
        lblProductType.Size = New Size(110, 21)
        lblProductType.TabIndex = 6
        lblProductType.Text = "Product Type"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(655, 9)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(57, 21)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.WhiteSmoke
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Pending", "Completed", "Canceled"})
        cmbStatus.Location = New Point(655, 37)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(144, 33)
        cmbStatus.TabIndex = 3
        ' 
        ' UcOrders
        ' 
        AutoScaleDimensions = New SizeF(144F, 144F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        BackColor = Color.White
        Controls.Add(panelMain)
        Name = "UcOrders"
        Size = New Size(1542, 1103)
        panelMain.ResumeLayout(False)
        CType(dgvOrders, ComponentModel.ISupportInitialize).EndInit()
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        panelCanceledOrders.ResumeLayout(False)
        panelCanceledOrders.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        panelCompletedOrders.ResumeLayout(False)
        panelCompletedOrders.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        panelNewOrders.ResumeLayout(False)
        panelNewOrders.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelTotalOrders.ResumeLayout(False)
        panelTotalOrders.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbProductType As ComboBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblProductType As Label
    Friend WithEvents panelTotalOrders As Panel
    Friend WithEvents lblTotalOrder As Label
    Friend WithEvents lblTotalOrders As Label
    Friend WithEvents lblTotalOrderSubtext As Label
    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelNewOrders As Panel
    Friend WithEvents lblNewOrderSubtext As Label
    Friend WithEvents lblNewOrders As Label
    Friend WithEvents lblNewOrdersTitle As Label
    Friend WithEvents lblLineHeader As Label
    Friend WithEvents panelCompletedOrders As Panel
    Friend WithEvents lblCompletedOrdersSubtext As Label
    Friend WithEvents lblCompletedOrders As Label
    Friend WithEvents lblCompletedOrdersTitle As Label
    Friend WithEvents panelCanceledOrders As Panel
    Friend WithEvents lblCanceledordersSubtext As Label
    Friend WithEvents lblCanceledOrders As Label
    Friend WithEvents lblCanceledOrdersTitle As Label
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnComplete As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colProductName As DataGridViewTextBoxColumn
    Friend WithEvents ColQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn

End Class
