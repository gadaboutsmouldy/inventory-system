<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Products))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Orig_ID = New System.Windows.Forms.TextBox()
        Me.TB_PI_ProdQuant = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PB_Search = New System.Windows.Forms.PictureBox()
        Me.TB_EncodedData = New System.Windows.Forms.TextBox()
        Me.Label_barcode = New System.Windows.Forms.Label()
        Me.TB_InputData = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_PI_ProdCateg = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_PI_ProdSize = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_PI_ProdColor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdID = New System.Windows.Forms.TextBox()
        Me.Label_PI_ID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBarcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet9 = New SWW_Inventory.inventoryDataSet9()
        Me.ProductsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label_Mod = New System.Windows.Forms.Label()
        Me.ProductsTableAdapter3 = New SWW_Inventory.inventoryDataSet9TableAdapters.productsTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Role = New System.Windows.Forms.Label()
        Me.Btn_SaveProd = New System.Windows.Forms.PictureBox()
        Me.Btn_DeleteProd = New System.Windows.Forms.PictureBox()
        Me.Btn_UpdateProd = New System.Windows.Forms.PictureBox()
        Me.Btn_NewProd = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Btn_SaveProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_DeleteProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_UpdateProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_NewProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Orig_ID)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdQuant)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.PB_Search)
        Me.GroupBox2.Controls.Add(Me.TB_EncodedData)
        Me.GroupBox2.Controls.Add(Me.Label_barcode)
        Me.GroupBox2.Controls.Add(Me.TB_InputData)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdPrice)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CB_PI_ProdCateg)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CB_PI_ProdSize)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CB_PI_ProdColor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdDesc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdID)
        Me.GroupBox2.Controls.Add(Me.Label_PI_ID)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(903, 296)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRODUCT INFORMATION"
        '
        'Orig_ID
        '
        Me.Orig_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orig_ID.Location = New System.Drawing.Point(153, 38)
        Me.Orig_ID.Name = "Orig_ID"
        Me.Orig_ID.Size = New System.Drawing.Size(38, 24)
        Me.Orig_ID.TabIndex = 187
        Me.Orig_ID.Visible = False
        '
        'TB_PI_ProdQuant
        '
        Me.TB_PI_ProdQuant.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdQuant.Location = New System.Drawing.Point(197, 218)
        Me.TB_PI_ProdQuant.Name = "TB_PI_ProdQuant"
        Me.TB_PI_ProdQuant.Size = New System.Drawing.Size(160, 29)
        Me.TB_PI_ProdQuant.TabIndex = 53
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(390, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Product Search Switch Button")
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(628, -18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 29)
        Me.TextBox1.TabIndex = 52
        Me.TextBox1.Visible = False
        '
        'PB_Search
        '
        Me.PB_Search.Image = Global.SWW_Inventory.My.Resources.Resources.search
        Me.PB_Search.Location = New System.Drawing.Point(428, 36)
        Me.PB_Search.Name = "PB_Search"
        Me.PB_Search.Size = New System.Drawing.Size(37, 29)
        Me.PB_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Search.TabIndex = 47
        Me.PB_Search.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PB_Search, "Product ID Search")
        '
        'TB_EncodedData
        '
        Me.TB_EncodedData.Location = New System.Drawing.Point(679, 179)
        Me.TB_EncodedData.Name = "TB_EncodedData"
        Me.TB_EncodedData.Size = New System.Drawing.Size(188, 29)
        Me.TB_EncodedData.TabIndex = 46
        Me.TB_EncodedData.Visible = False
        '
        'Label_barcode
        '
        Me.Label_barcode.Font = New System.Drawing.Font("barcode font", 80.24999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_barcode.Location = New System.Drawing.Point(504, 180)
        Me.Label_barcode.Name = "Label_barcode"
        Me.Label_barcode.Size = New System.Drawing.Size(383, 111)
        Me.Label_barcode.TabIndex = 44
        '
        'TB_InputData
        '
        Me.TB_InputData.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_InputData.Location = New System.Drawing.Point(679, 142)
        Me.TB_InputData.Name = "TB_InputData"
        Me.TB_InputData.Size = New System.Drawing.Size(203, 29)
        Me.TB_InputData.TabIndex = 41
        Me.TB_InputData.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(516, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 21)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Product Barcode"
        '
        'TB_PI_ProdPrice
        '
        Me.TB_PI_ProdPrice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdPrice.Location = New System.Drawing.Point(197, 259)
        Me.TB_PI_ProdPrice.Name = "TB_PI_ProdPrice"
        Me.TB_PI_ProdPrice.Size = New System.Drawing.Size(160, 29)
        Me.TB_PI_ProdPrice.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Product Price"
        '
        'CB_PI_ProdCateg
        '
        Me.CB_PI_ProdCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PI_ProdCateg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PI_ProdCateg.FormattingEnabled = True
        Me.CB_PI_ProdCateg.Items.AddRange(New Object() {"Food", "Miscellaneous", "Appliances", "Computer Peripherals"})
        Me.CB_PI_ProdCateg.Location = New System.Drawing.Point(679, 69)
        Me.CB_PI_ProdCateg.Name = "CB_PI_ProdCateg"
        Me.CB_PI_ProdCateg.Size = New System.Drawing.Size(203, 29)
        Me.CB_PI_ProdCateg.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(516, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Product Category"
        '
        'CB_PI_ProdSize
        '
        Me.CB_PI_ProdSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PI_ProdSize.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PI_ProdSize.FormattingEnabled = True
        Me.CB_PI_ProdSize.Items.AddRange(New Object() {"Small", "Medium", "Large", "N/A"})
        Me.CB_PI_ProdSize.Location = New System.Drawing.Point(679, 33)
        Me.CB_PI_ProdSize.Name = "CB_PI_ProdSize"
        Me.CB_PI_ProdSize.Size = New System.Drawing.Size(203, 29)
        Me.CB_PI_ProdSize.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(516, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 21)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Product Size"
        '
        'CB_PI_ProdColor
        '
        Me.CB_PI_ProdColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PI_ProdColor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PI_ProdColor.FormattingEnabled = True
        Me.CB_PI_ProdColor.Items.AddRange(New Object() {"Brown", "Yellow", "Blue", "Silver", "White", "N/A"})
        Me.CB_PI_ProdColor.Location = New System.Drawing.Point(679, 105)
        Me.CB_PI_ProdColor.Name = "CB_PI_ProdColor"
        Me.CB_PI_ProdColor.Size = New System.Drawing.Size(203, 29)
        Me.CB_PI_ProdColor.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(516, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Product Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Product Quantity"
        '
        'TB_PI_ProdDesc
        '
        Me.TB_PI_ProdDesc.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdDesc.Location = New System.Drawing.Point(197, 110)
        Me.TB_PI_ProdDesc.Multiline = True
        Me.TB_PI_ProdDesc.Name = "TB_PI_ProdDesc"
        Me.TB_PI_ProdDesc.Size = New System.Drawing.Size(292, 100)
        Me.TB_PI_ProdDesc.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Product Description"
        '
        'TB_PI_ProdName
        '
        Me.TB_PI_ProdName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdName.Location = New System.Drawing.Point(197, 73)
        Me.TB_PI_ProdName.Name = "TB_PI_ProdName"
        Me.TB_PI_ProdName.Size = New System.Drawing.Size(292, 29)
        Me.TB_PI_ProdName.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Product Name"
        '
        'TB_PI_ProdID
        '
        Me.TB_PI_ProdID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdID.Location = New System.Drawing.Point(197, 37)
        Me.TB_PI_ProdID.Name = "TB_PI_ProdID"
        Me.TB_PI_ProdID.Size = New System.Drawing.Size(195, 29)
        Me.TB_PI_ProdID.TabIndex = 24
        '
        'Label_PI_ID
        '
        Me.Label_PI_ID.AutoSize = True
        Me.Label_PI_ID.BackColor = System.Drawing.Color.Transparent
        Me.Label_PI_ID.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PI_ID.Location = New System.Drawing.Point(14, 37)
        Me.Label_PI_ID.Name = "Label_PI_ID"
        Me.Label_PI_ID.Size = New System.Drawing.Size(91, 21)
        Me.Label_PI_ID.TabIndex = 23
        Me.Label_PI_ID.Text = "Product ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductDescDataGridViewTextBoxColumn, Me.ProductQuantityDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn, Me.ProductSizeDataGridViewTextBoxColumn, Me.ProductCategoryDataGridViewTextBoxColumn, Me.ProductColorDataGridViewTextBoxColumn, Me.ProductBarcode, Me.ProductDate, Me.ProductMod})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(0, 344)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(834, 233)
        Me.DataGridView1.TabIndex = 25
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDescDataGridViewTextBoxColumn
        '
        Me.ProductDescDataGridViewTextBoxColumn.DataPropertyName = "ProductDesc"
        Me.ProductDescDataGridViewTextBoxColumn.HeaderText = "Product Descrption"
        Me.ProductDescDataGridViewTextBoxColumn.Name = "ProductDescDataGridViewTextBoxColumn"
        Me.ProductDescDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductDescDataGridViewTextBoxColumn.Width = 150
        '
        'ProductQuantityDataGridViewTextBoxColumn
        '
        Me.ProductQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity"
        Me.ProductQuantityDataGridViewTextBoxColumn.HeaderText = "Product Quantity"
        Me.ProductQuantityDataGridViewTextBoxColumn.Name = "ProductQuantityDataGridViewTextBoxColumn"
        Me.ProductQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "Product Price"
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        Me.ProductPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductSizeDataGridViewTextBoxColumn
        '
        Me.ProductSizeDataGridViewTextBoxColumn.DataPropertyName = "ProductSize"
        Me.ProductSizeDataGridViewTextBoxColumn.HeaderText = "Product Size"
        Me.ProductSizeDataGridViewTextBoxColumn.Name = "ProductSizeDataGridViewTextBoxColumn"
        Me.ProductSizeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductCategoryDataGridViewTextBoxColumn
        '
        Me.ProductCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory"
        Me.ProductCategoryDataGridViewTextBoxColumn.HeaderText = "Product Category"
        Me.ProductCategoryDataGridViewTextBoxColumn.Name = "ProductCategoryDataGridViewTextBoxColumn"
        Me.ProductCategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductCategoryDataGridViewTextBoxColumn.Width = 150
        '
        'ProductColorDataGridViewTextBoxColumn
        '
        Me.ProductColorDataGridViewTextBoxColumn.DataPropertyName = "ProductColor"
        Me.ProductColorDataGridViewTextBoxColumn.HeaderText = "Product Color"
        Me.ProductColorDataGridViewTextBoxColumn.Name = "ProductColorDataGridViewTextBoxColumn"
        Me.ProductColorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductBarcode
        '
        Me.ProductBarcode.DataPropertyName = "ProductBarcode"
        Me.ProductBarcode.HeaderText = "Product Decoded Barcode"
        Me.ProductBarcode.Name = "ProductBarcode"
        Me.ProductBarcode.ReadOnly = True
        Me.ProductBarcode.Width = 150
        '
        'ProductDate
        '
        Me.ProductDate.DataPropertyName = "ProductDate"
        Me.ProductDate.HeaderText = "Time & Date When Product is Saved"
        Me.ProductDate.Name = "ProductDate"
        Me.ProductDate.ReadOnly = True
        Me.ProductDate.Width = 135
        '
        'ProductMod
        '
        Me.ProductMod.DataPropertyName = "ProductMod"
        Me.ProductMod.HeaderText = "Last Modified"
        Me.ProductMod.Name = "ProductMod"
        Me.ProductMod.ReadOnly = True
        Me.ProductMod.Width = 135
        '
        'ProductsBindingSource3
        '
        Me.ProductsBindingSource3.DataMember = "products"
        Me.ProductsBindingSource3.DataSource = Me.InventoryDataSet9
        '
        'InventoryDataSet9
        '
        Me.InventoryDataSet9.DataSetName = "inventoryDataSet9"
        Me.InventoryDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(821, 555)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Visible = False
        '
        'Label_Mod
        '
        Me.Label_Mod.AutoSize = True
        Me.Label_Mod.BackColor = System.Drawing.Color.Transparent
        Me.Label_Mod.Location = New System.Drawing.Point(837, 559)
        Me.Label_Mod.Name = "Label_Mod"
        Me.Label_Mod.Size = New System.Drawing.Size(0, 13)
        Me.Label_Mod.TabIndex = 49
        Me.Label_Mod.Visible = False
        '
        'ProductsTableAdapter3
        '
        Me.ProductsTableAdapter3.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductListToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(903, 25)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "Export to Excel"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearAllToolStripMenuItem, Me.SaveToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ClearAllToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ProductListToolStripMenuItem
        '
        Me.ProductListToolStripMenuItem.Name = "ProductListToolStripMenuItem"
        Me.ProductListToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
        Me.ProductListToolStripMenuItem.Text = "Product List"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'Label_Role
        '
        Me.Label_Role.AutoSize = True
        Me.Label_Role.Location = New System.Drawing.Point(612, 29)
        Me.Label_Role.Name = "Label_Role"
        Me.Label_Role.Size = New System.Drawing.Size(0, 13)
        Me.Label_Role.TabIndex = 51
        Me.Label_Role.Visible = False
        '
        'Btn_SaveProd
        '
        Me.Btn_SaveProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_SaveProd.Image = CType(resources.GetObject("Btn_SaveProd.Image"), System.Drawing.Image)
        Me.Btn_SaveProd.Location = New System.Drawing.Point(834, 401)
        Me.Btn_SaveProd.Name = "Btn_SaveProd"
        Me.Btn_SaveProd.Size = New System.Drawing.Size(69, 58)
        Me.Btn_SaveProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_SaveProd.TabIndex = 3
        Me.Btn_SaveProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_SaveProd, "Save")
        '
        'Btn_DeleteProd
        '
        Me.Btn_DeleteProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_DeleteProd.Image = CType(resources.GetObject("Btn_DeleteProd.Image"), System.Drawing.Image)
        Me.Btn_DeleteProd.Location = New System.Drawing.Point(834, 519)
        Me.Btn_DeleteProd.Name = "Btn_DeleteProd"
        Me.Btn_DeleteProd.Size = New System.Drawing.Size(69, 58)
        Me.Btn_DeleteProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_DeleteProd.TabIndex = 2
        Me.Btn_DeleteProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_DeleteProd, "Delete")
        '
        'Btn_UpdateProd
        '
        Me.Btn_UpdateProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_UpdateProd.Image = CType(resources.GetObject("Btn_UpdateProd.Image"), System.Drawing.Image)
        Me.Btn_UpdateProd.Location = New System.Drawing.Point(834, 460)
        Me.Btn_UpdateProd.Name = "Btn_UpdateProd"
        Me.Btn_UpdateProd.Size = New System.Drawing.Size(69, 58)
        Me.Btn_UpdateProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_UpdateProd.TabIndex = 1
        Me.Btn_UpdateProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_UpdateProd, "Update Product Info")
        '
        'Btn_NewProd
        '
        Me.Btn_NewProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_NewProd.Image = CType(resources.GetObject("Btn_NewProd.Image"), System.Drawing.Image)
        Me.Btn_NewProd.Location = New System.Drawing.Point(834, 343)
        Me.Btn_NewProd.Name = "Btn_NewProd"
        Me.Btn_NewProd.Size = New System.Drawing.Size(69, 58)
        Me.Btn_NewProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_NewProd.TabIndex = 0
        Me.Btn_NewProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_NewProd, "Create New Product")
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(722, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(73, 29)
        Me.TextBox2.TabIndex = 53
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(801, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(81, 29)
        Me.TextBox3.TabIndex = 54
        Me.TextBox3.Visible = False
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(903, 577)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Btn_DeleteProd)
        Me.Controls.Add(Me.Btn_SaveProd)
        Me.Controls.Add(Me.Btn_UpdateProd)
        Me.Controls.Add(Me.Label_Role)
        Me.Controls.Add(Me.Label_Mod)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_NewProd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Btn_SaveProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_DeleteProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_UpdateProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_NewProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_PI_ProdPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CB_PI_ProdCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB_PI_ProdSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CB_PI_ProdColor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_PI_ProdDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_PI_ProdName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_PI_ProdID As System.Windows.Forms.TextBox
    Friend WithEvents Label_PI_ID As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TB_InputData As System.Windows.Forms.TextBox
    Friend WithEvents Label_barcode As System.Windows.Forms.Label
    Friend WithEvents ProductsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TB_EncodedData As System.Windows.Forms.TextBox
    Friend WithEvents PB_Search As System.Windows.Forms.PictureBox
    Friend WithEvents ProductsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label_Mod As System.Windows.Forms.Label
    Friend WithEvents InventoryDataSet9 As SWW_Inventory.inventoryDataSet9
    Friend WithEvents ProductsBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter3 As SWW_Inventory.inventoryDataSet9TableAdapters.productsTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_Role As System.Windows.Forms.Label
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductBarcode As DataGridViewTextBoxColumn
    Friend WithEvents ProductDate As DataGridViewTextBoxColumn
    Friend WithEvents ProductMod As DataGridViewTextBoxColumn
    Friend WithEvents Btn_SaveProd As PictureBox
    Friend WithEvents Btn_DeleteProd As PictureBox
    Friend WithEvents Btn_UpdateProd As PictureBox
    Friend WithEvents Btn_NewProd As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ProductListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TB_PI_ProdQuant As TextBox
    Friend WithEvents Orig_ID As TextBox
End Class
