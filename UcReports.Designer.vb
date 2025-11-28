<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcChartSales
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UcChartSales))
        panelMain = New Panel()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        ColRank = New DataGridViewTextBoxColumn()
        ColProduct = New DataGridViewTextBoxColumn()
        ColSoldqty = New DataGridViewTextBoxColumn()
        ColSales = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel6 = New Panel()
        Chart3 = New DataVisualization.Charting.Chart()
        Panel2 = New Panel()
        Chart1 = New DataVisualization.Charting.Chart()
        Panel5 = New Panel()
        Chart2 = New DataVisualization.Charting.Chart()
        Panel1 = New Panel()
        PanelC = New Panel()
        lblCancellationRateValue = New Label()
        PictureBox5 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        dtpDate = New DateTimePicker()
        PanelD = New Panel()
        PictureBox4 = New PictureBox()
        lblTotalCost = New Label()
        Label1 = New Label()
        PanelB = New Panel()
        PictureBox3 = New PictureBox()
        lblTotalProfit = New Label()
        lblProfit = New Label()
        PanelA = New Panel()
        PictureBox2 = New PictureBox()
        lblTotalSales = New Label()
        lblSales = New Label()
        Label2 = New Label()
        panelMain.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(Chart3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(Chart2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PanelC.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PanelD.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PanelB.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        PanelA.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.White
        panelMain.BorderStyle = BorderStyle.FixedSingle
        panelMain.Controls.Add(Label6)
        panelMain.Controls.Add(DataGridView1)
        panelMain.Controls.Add(Label5)
        panelMain.Controls.Add(Label4)
        panelMain.Controls.Add(Label3)
        panelMain.Controls.Add(Panel6)
        panelMain.Controls.Add(Panel2)
        panelMain.Controls.Add(Panel5)
        panelMain.Controls.Add(Panel1)
        panelMain.Location = New Point(3, 0)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1537, 1103)
        panelMain.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(969, 667)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 38)
        Label6.TabIndex = 13
        Label6.Text = "TOP SALES"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(31), CByte(42), CByte(68))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColRank, ColProduct, ColSoldqty, ColSales})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(31), CByte(42), CByte(68))
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(634, 717)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.White
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.ScrollBars = ScrollBars.Vertical
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(813, 353)
        DataGridView1.TabIndex = 12
        ' 
        ' ColRank
        ' 
        ColRank.FillWeight = 50F
        ColRank.HeaderText = "Rank"
        ColRank.MinimumWidth = 8
        ColRank.Name = "ColRank"
        ColRank.ReadOnly = True
        ' 
        ' ColProduct
        ' 
        ColProduct.FillWeight = 130F
        ColProduct.HeaderText = "Product"
        ColProduct.MinimumWidth = 8
        ColProduct.Name = "ColProduct"
        ColProduct.ReadOnly = True
        ' 
        ' ColSoldqty
        ' 
        ColSoldqty.FillWeight = 60F
        ColSoldqty.HeaderText = "Sold Qty"
        ColSoldqty.MinimumWidth = 8
        ColSoldqty.Name = "ColSoldqty"
        ColSoldqty.ReadOnly = True
        ' 
        ' ColSales
        ' 
        ColSales.FillWeight = 70F
        ColSales.HeaderText = "Sales ₱"
        ColSales.MinimumWidth = 8
        ColSales.Name = "ColSales"
        ColSales.ReadOnly = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(262, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(242, 38)
        Label5.TabIndex = 11
        Label5.Text = "MONTHLY SALES"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(993, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(258, 38)
        Label4.TabIndex = 10
        Label4.Text = "PROFIT AND LOSS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(223, 667)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 38)
        Label3.TabIndex = 9
        Label3.Text = "PRODUCT SALE"
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Chart3)
        Panel6.Location = New Point(56, 717)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(542, 355)
        Panel6.TabIndex = 8
        ' 
        ' Chart3
        ' 
        Chart3.BorderlineColor = Color.Black
        ChartArea1.Name = "ChartArea1"
        Chart3.ChartAreas.Add(ChartArea1)
        Chart3.Dock = DockStyle.Fill
        Legend1.Name = "Legend1"
        Chart3.Legends.Add(Legend1)
        Chart3.Location = New Point(0, 0)
        Chart3.Name = "Chart3"
        Chart3.Palette = DataVisualization.Charting.ChartColorPalette.Fire
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Chart3.Series.Add(Series1)
        Chart3.Size = New Size(540, 353)
        Chart3.TabIndex = 3
        Chart3.Text = "Chart3"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Chart1)
        Panel2.Location = New Point(55, 282)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(661, 368)
        Panel2.TabIndex = 7
        ' 
        ' Chart1
        ' 
        Chart1.BorderlineColor = Color.Black
        ChartArea2.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea2)
        Chart1.Dock = DockStyle.Fill
        Legend2.Name = "Legend1"
        Chart1.Legends.Add(Legend2)
        Chart1.Location = New Point(0, 0)
        Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Chart1.Series.Add(Series2)
        Chart1.Size = New Size(659, 366)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Chart2)
        Panel5.Location = New Point(805, 283)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(642, 369)
        Panel5.TabIndex = 6
        ' 
        ' Chart2
        ' 
        Chart2.BorderlineColor = Color.Black
        ChartArea3.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea3)
        Chart2.Dock = DockStyle.Fill
        Legend3.Name = "Legend1"
        Chart2.Legends.Add(Legend3)
        Chart2.Location = New Point(0, 0)
        Chart2.Name = "Chart2"
        Chart2.Palette = DataVisualization.Charting.ChartColorPalette.EarthTones
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Chart2.Series.Add(Series3)
        Chart2.Size = New Size(640, 367)
        Chart2.TabIndex = 0
        Chart2.Text = "Chart2"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PanelC)
        Panel1.Controls.Add(dtpDate)
        Panel1.Controls.Add(PanelD)
        Panel1.Controls.Add(PanelB)
        Panel1.Controls.Add(PanelA)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1529, 234)
        Panel1.TabIndex = 4
        ' 
        ' PanelC
        ' 
        PanelC.Controls.Add(lblCancellationRateValue)
        PanelC.Controls.Add(PictureBox5)
        PanelC.Controls.Add(Label7)
        PanelC.Controls.Add(Label8)
        PanelC.Location = New Point(950, 65)
        PanelC.Name = "PanelC"
        PanelC.Size = New Size(277, 145)
        PanelC.TabIndex = 11
        ' 
        ' lblCancellationRateValue
        ' 
        lblCancellationRateValue.AutoSize = True
        lblCancellationRateValue.Location = New Point(19, 106)
        lblCancellationRateValue.Name = "lblCancellationRateValue"
        lblCancellationRateValue.Size = New Size(0, 25)
        lblCancellationRateValue.TabIndex = 7
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(18, 15)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(45, 36)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 6
        PictureBox5.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(14, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 45)
        Label7.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(11, 65)
        Label8.Name = "Label8"
        Label8.Size = New Size(213, 32)
        Label8.TabIndex = 4
        Label8.Text = "Cancellation Rate"
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(1130, 12)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(300, 31)
        dtpDate.TabIndex = 10
        ' 
        ' PanelD
        ' 
        PanelD.Controls.Add(PictureBox4)
        PanelD.Controls.Add(lblTotalCost)
        PanelD.Controls.Add(Label1)
        PanelD.Location = New Point(645, 65)
        PanelD.Name = "PanelD"
        PanelD.Size = New Size(269, 145)
        PanelD.TabIndex = 9
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(20, 15)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 36)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalCost.Location = New Point(20, 97)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(0, 38)
        lblTotalCost.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(20, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 32)
        Label1.TabIndex = 1
        Label1.Text = "Sales Cost"
        ' 
        ' PanelB
        ' 
        PanelB.Controls.Add(PictureBox3)
        PanelB.Controls.Add(lblTotalProfit)
        PanelB.Controls.Add(lblProfit)
        PanelB.Location = New Point(343, 65)
        PanelB.Name = "PanelB"
        PanelB.Size = New Size(262, 145)
        PanelB.TabIndex = 5
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(23, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(42, 36)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' lblTotalProfit
        ' 
        lblTotalProfit.AutoSize = True
        lblTotalProfit.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalProfit.Location = New Point(23, 97)
        lblTotalProfit.Name = "lblTotalProfit"
        lblTotalProfit.Size = New Size(0, 38)
        lblTotalProfit.TabIndex = 6
        ' 
        ' lblProfit
        ' 
        lblProfit.AutoSize = True
        lblProfit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProfit.ForeColor = Color.Black
        lblProfit.Location = New Point(14, 65)
        lblProfit.Name = "lblProfit"
        lblProfit.Size = New Size(79, 32)
        lblProfit.TabIndex = 0
        lblProfit.Text = "Profit"
        ' 
        ' PanelA
        ' 
        PanelA.Controls.Add(PictureBox2)
        PanelA.Controls.Add(lblTotalSales)
        PanelA.Controls.Add(lblSales)
        PanelA.Location = New Point(29, 65)
        PanelA.Name = "PanelA"
        PanelA.Size = New Size(277, 145)
        PanelA.TabIndex = 4
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 36)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.AutoSize = True
        lblTotalSales.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSales.Location = New Point(14, 97)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(0, 38)
        lblTotalSales.TabIndex = 5
        ' 
        ' lblSales
        ' 
        lblSales.AutoSize = True
        lblSales.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSales.ForeColor = Color.Black
        lblSales.Location = New Point(11, 65)
        lblSales.Name = "lblSales"
        lblSales.Size = New Size(71, 32)
        lblSales.TabIndex = 4
        lblSales.Text = "Sales"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1067, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 28)
        Label2.TabIndex = 3
        Label2.Text = "Date"
        ' 
        ' UcChartSales
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(panelMain)
        Name = "UcChartSales"
        Size = New Size(1542, 1103)
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(Chart3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(Chart2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelC.ResumeLayout(False)
        PanelC.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PanelD.ResumeLayout(False)
        PanelD.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PanelB.ResumeLayout(False)
        PanelB.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        PanelA.ResumeLayout(False)
        PanelA.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelA As Panel
    Friend WithEvents lblSales As Label
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents PanelB As Panel
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents lblProfit As Label
    Friend WithEvents PanelD As Panel
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents ColRank As DataGridViewTextBoxColumn
    Friend WithEvents ColProduct As DataGridViewTextBoxColumn
    Friend WithEvents ColSoldqty As DataGridViewTextBoxColumn
    Friend WithEvents ColSales As DataGridViewTextBoxColumn
    Friend WithEvents PanelC As Panel
    Friend WithEvents lblCancellationRateValue As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
