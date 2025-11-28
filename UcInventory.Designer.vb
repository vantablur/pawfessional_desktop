<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcInventory
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
        panelMain = New Panel()
        panelContainer = New Panel()
        lbldgvLine = New Label()
        dgvInventory = New DataGridView()
        colImage = New DataGridViewImageColumn()
        colProductID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colBrand = New DataGridViewTextBoxColumn()
        colStock = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        panelFilters = New Panel()
        btnDeleteProduct = New Button()
        btnEditProduct = New Button()
        btnAddProduct = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        Label1 = New Label()
        lblBrand = New Label()
        chkOutOfStock = New CheckBox()
        cmbType = New ComboBox()
        cmbBrand = New ComboBox()
        labelTitle = New Label()
        panelMain.SuspendLayout()
        panelContainer.SuspendLayout()
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        panelFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.White
        panelMain.BorderStyle = BorderStyle.FixedSingle
        panelMain.Controls.Add(panelContainer)
        panelMain.Controls.Add(panelFilters)
        panelMain.Controls.Add(labelTitle)
        panelMain.Dock = DockStyle.Fill
        panelMain.Location = New Point(0, 0)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1473, 1103)
        panelMain.TabIndex = 0
        ' 
        ' panelContainer
        ' 
        panelContainer.BackColor = Color.White
        panelContainer.BorderStyle = BorderStyle.FixedSingle
        panelContainer.Controls.Add(lbldgvLine)
        panelContainer.Controls.Add(dgvInventory)
        panelContainer.Location = New Point(3, 196)
        panelContainer.Name = "panelContainer"
        panelContainer.Size = New Size(1460, 906)
        panelContainer.TabIndex = 3
        ' 
        ' lbldgvLine
        ' 
        lbldgvLine.BackColor = Color.Orange
        lbldgvLine.Location = New Point(-1, 10)
        lbldgvLine.Name = "lbldgvLine"
        lbldgvLine.Size = New Size(1460, 5)
        lbldgvLine.TabIndex = 3
        ' 
        ' dgvInventory
        ' 
        dgvInventory.AllowUserToAddRows = False
        dgvInventory.AllowUserToDeleteRows = False
        dgvInventory.AllowUserToResizeColumns = False
        dgvInventory.AllowUserToResizeRows = False
        dgvInventory.BackgroundColor = SystemColors.Window
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(31), CByte(42), CByte(68))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(51), CByte(62), CByte(88))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvInventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvInventory.ColumnHeadersHeight = 32
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvInventory.Columns.AddRange(New DataGridViewColumn() {colImage, colProductID, colName, colBrand, colStock, colType})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Thistle
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvInventory.DefaultCellStyle = DataGridViewCellStyle2
        dgvInventory.EnableHeadersVisualStyles = False
        dgvInventory.GridColor = Color.LightGray
        dgvInventory.Location = New Point(-1, 35)
        dgvInventory.MultiSelect = False
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowHeadersVisible = False
        dgvInventory.RowHeadersWidth = 62
        dgvInventory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        dgvInventory.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvInventory.ScrollBars = ScrollBars.Vertical
        dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInventory.Size = New Size(1456, 870)
        dgvInventory.TabIndex = 2
        ' 
        ' colImage
        ' 
        colImage.HeaderText = "Image"
        colImage.ImageLayout = DataGridViewImageCellLayout.Zoom
        colImage.MinimumWidth = 50
        colImage.Name = "colImage"
        colImage.Width = 203
        ' 
        ' colProductID
        ' 
        colProductID.HeaderText = "Product ID"
        colProductID.MinimumWidth = 50
        colProductID.Name = "colProductID"
        colProductID.ReadOnly = True
        colProductID.Width = 174
        ' 
        ' colName
        ' 
        colName.FillWeight = 250F
        colName.HeaderText = "Name"
        colName.MinimumWidth = 50
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.Width = 390
        ' 
        ' colBrand
        ' 
        colBrand.FillWeight = 190F
        colBrand.HeaderText = "Brand"
        colBrand.MinimumWidth = 50
        colBrand.Name = "colBrand"
        colBrand.ReadOnly = True
        colBrand.Width = 350
        ' 
        ' colStock
        ' 
        colStock.FillWeight = 80F
        colStock.HeaderText = "Stock"
        colStock.MinimumWidth = 50
        colStock.Name = "colStock"
        colStock.Width = 170
        ' 
        ' colType
        ' 
        colType.FillWeight = 130F
        colType.HeaderText = "Product Type"
        colType.MinimumWidth = 50
        colType.Name = "colType"
        colType.ReadOnly = True
        colType.Width = 240
        ' 
        ' panelFilters
        ' 
        panelFilters.BackColor = Color.White
        panelFilters.BorderStyle = BorderStyle.FixedSingle
        panelFilters.Controls.Add(btnDeleteProduct)
        panelFilters.Controls.Add(btnEditProduct)
        panelFilters.Controls.Add(btnAddProduct)
        panelFilters.Controls.Add(btnSearch)
        panelFilters.Controls.Add(txtSearch)
        panelFilters.Controls.Add(Label1)
        panelFilters.Controls.Add(lblBrand)
        panelFilters.Controls.Add(chkOutOfStock)
        panelFilters.Controls.Add(cmbType)
        panelFilters.Controls.Add(cmbBrand)
        panelFilters.Location = New Point(3, 68)
        panelFilters.Name = "panelFilters"
        panelFilters.Size = New Size(1460, 122)
        panelFilters.TabIndex = 1
        ' 
        ' btnDeleteProduct
        ' 
        btnDeleteProduct.BackColor = Color.Red
        btnDeleteProduct.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteProduct.ForeColor = Color.White
        btnDeleteProduct.Location = New Point(747, 31)
        btnDeleteProduct.Name = "btnDeleteProduct"
        btnDeleteProduct.Size = New Size(170, 67)
        btnDeleteProduct.TabIndex = 13
        btnDeleteProduct.Text = "Delete Product"
        btnDeleteProduct.UseVisualStyleBackColor = False
        ' 
        ' btnEditProduct
        ' 
        btnEditProduct.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnEditProduct.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditProduct.ForeColor = Color.White
        btnEditProduct.Location = New Point(590, 31)
        btnEditProduct.Name = "btnEditProduct"
        btnEditProduct.Size = New Size(151, 67)
        btnEditProduct.TabIndex = 12
        btnEditProduct.Text = "Edit Product"
        btnEditProduct.UseVisualStyleBackColor = False
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnAddProduct.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Location = New Point(434, 31)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(150, 67)
        btnAddProduct.TabIndex = 11
        btnAddProduct.Text = "Add Product"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.Window
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(365, 41)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(42, 39)
        btnSearch.TabIndex = 10
        btnSearch.Text = "🔍"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.WhiteSmoke
        txtSearch.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.Black
        txtSearch.Location = New Point(16, 38)
        txtSearch.Multiline = True
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search here..."
        txtSearch.Size = New Size(391, 42)
        txtSearch.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1289, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 21)
        Label1.TabIndex = 6
        Label1.Text = "Product Type"
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBrand.Location = New Point(943, 20)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(55, 21)
        lblBrand.TabIndex = 5
        lblBrand.Text = "Brand"
        ' 
        ' chkOutOfStock
        ' 
        chkOutOfStock.BackColor = Color.WhiteSmoke
        chkOutOfStock.Location = New Point(1119, 43)
        chkOutOfStock.Name = "chkOutOfStock"
        chkOutOfStock.Size = New Size(145, 38)
        chkOutOfStock.TabIndex = 3
        chkOutOfStock.Text = "Out of Stock"
        chkOutOfStock.UseVisualStyleBackColor = False
        ' 
        ' cmbType
        ' 
        cmbType.BackColor = Color.WhiteSmoke
        cmbType.FormattingEnabled = True
        cmbType.Items.AddRange(New Object() {"Food", "Vitamin", "Pet Supplies"})
        cmbType.Location = New Point(1289, 48)
        cmbType.Name = "cmbType"
        cmbType.Size = New Size(144, 33)
        cmbType.TabIndex = 2
        ' 
        ' cmbBrand
        ' 
        cmbBrand.BackColor = Color.WhiteSmoke
        cmbBrand.FormattingEnabled = True
        cmbBrand.Items.AddRange(New Object() {"Whiskas", "Royal", "Jerky"})
        cmbBrand.Location = New Point(943, 47)
        cmbBrand.Name = "cmbBrand"
        cmbBrand.Size = New Size(158, 33)
        cmbBrand.TabIndex = 1
        ' 
        ' labelTitle
        ' 
        labelTitle.AutoSize = True
        labelTitle.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitle.Location = New Point(3, 11)
        labelTitle.Name = "labelTitle"
        labelTitle.Size = New Size(260, 54)
        labelTitle.TabIndex = 0
        labelTitle.Text = "INVENTORY"
        ' 
        ' UcInventory
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(panelMain)
        Name = "UcInventory"
        Size = New Size(1473, 1103)
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        panelContainer.ResumeLayout(False)
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        panelFilters.ResumeLayout(False)
        panelFilters.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents panelFilters As Panel
    Friend WithEvents labelTitle As Label
    Friend WithEvents chkOutOfStock As CheckBox
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents lbldgvLine As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents panelContainer As Panel
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnEditProduct As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents colImage As DataGridViewImageColumn
    Friend WithEvents colProductID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colBrand As DataGridViewTextBoxColumn
    Friend WithEvents colStock As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn

End Class
