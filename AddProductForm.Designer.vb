<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProductForm))
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        txtProductID = New TextBox()
        txtBrand = New TextBox()
        txtName = New TextBox()
        txtStock = New TextBox()
        btnSave = New Button()
        btnCancel = New Button()
        Label5 = New Label()
        txtProductType = New TextBox()
        Label3 = New Label()
        lblTitle = New Label()
        Label6 = New Label()
        btnUploadImage = New Button()
        picProduct = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label7 = New Label()
        CType(picProduct, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(536, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 28)
        Label1.TabIndex = 0
        Label1.Text = "Product ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(536, 231)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 28)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(536, 306)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 28)
        Label4.TabIndex = 2
        Label4.Text = "Brand:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(536, 371)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 28)
        Label8.TabIndex = 4
        Label8.Text = "Stock:"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(671, 161)
        txtProductID.Multiline = True
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(282, 41)
        txtProductID.TabIndex = 5
        ' 
        ' txtBrand
        ' 
        txtBrand.Location = New Point(671, 306)
        txtBrand.Multiline = True
        txtBrand.Name = "txtBrand"
        txtBrand.Size = New Size(282, 45)
        txtBrand.TabIndex = 6
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(671, 222)
        txtName.Multiline = True
        txtName.Name = "txtName"
        txtName.Size = New Size(282, 66)
        txtName.TabIndex = 7
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(671, 368)
        txtStock.Multiline = True
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(282, 42)
        txtStock.TabIndex = 9
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LimeGreen
        btnSave.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(967, 445)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(98, 59)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(1083, 445)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(99, 59)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(536, 425)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 28)
        Label5.TabIndex = 14
        Label5.Text = "Poduct Type:"
        ' 
        ' txtProductType
        ' 
        txtProductType.Location = New Point(671, 425)
        txtProductType.Multiline = True
        txtProductType.Name = "txtProductType"
        txtProductType.Size = New Size(282, 44)
        txtProductType.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(168, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(258, 70)
        Label3.TabIndex = 18
        Label3.Text = "fessional"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Black", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblTitle.Location = New Point(49, 210)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(137, 70)
        lblTitle.TabIndex = 17
        lblTitle.Text = "Paw"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(640, 31)
        Label6.Name = "Label6"
        Label6.Size = New Size(274, 60)
        Label6.TabIndex = 19
        Label6.Text = "INVENTORY"
        ' 
        ' btnUploadImage
        ' 
        btnUploadImage.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnUploadImage.Location = New Point(967, 386)
        btnUploadImage.Name = "btnUploadImage"
        btnUploadImage.Size = New Size(98, 39)
        btnUploadImage.TabIndex = 21
        btnUploadImage.Text = "Browse"
        btnUploadImage.UseVisualStyleBackColor = False
        ' 
        ' picProduct
        ' 
        picProduct.BorderStyle = BorderStyle.FixedSingle
        picProduct.Image = My.Resources.Resources.Milk_Lactose
        picProduct.Location = New Point(967, 190)
        picProduct.Name = "picProduct"
        picProduct.Size = New Size(182, 190)
        picProduct.SizeMode = PictureBoxSizeMode.StretchImage
        picProduct.TabIndex = 0
        picProduct.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(85, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 184)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(909, 31)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(83, 69)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(969, 157)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 28)
        Label7.TabIndex = 24
        Label7.Text = "Product Image"
        ' 
        ' AddProductForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        ClientSize = New Size(1391, 703)
        Controls.Add(Label7)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(picProduct)
        Controls.Add(btnUploadImage)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(lblTitle)
        Controls.Add(txtProductType)
        Controls.Add(Label5)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(txtStock)
        Controls.Add(txtName)
        Controls.Add(txtBrand)
        Controls.Add(txtProductID)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AddProductForm"
        Text = "AddProductForm"
        CType(picProduct, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents picProduct As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label

End Class
