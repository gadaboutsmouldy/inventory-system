<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductList))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_Search = New System.Windows.Forms.TextBox()
        Me.CB_Address = New System.Windows.Forms.CheckBox()
        Me.CB_Name = New System.Windows.Forms.CheckBox()
        Me.CB_PI_ProdCateg = New System.Windows.Forms.ComboBox()
        Me.CB_PI_ProdSize = New System.Windows.Forms.ComboBox()
        Me.CB_PI_ProdColor = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductColorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductModDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet18 = New SWW_Inventory.inventoryDataSet18()
        Me.ProductsTableAdapter2 = New SWW_Inventory.inventoryDataSet18TableAdapters.productsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.ProductDescDataGridViewTextBoxColumn, Me.ProductQuantityDataGridViewTextBoxColumn, Me.ProductColorDataGridViewTextBoxColumn, Me.ProductSizeDataGridViewTextBoxColumn, Me.ProductCategoryDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn, Me.ProductDateDataGridViewTextBoxColumn, Me.ProductModDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(0, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(697, 372)
        Me.DataGridView1.TabIndex = 0
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "products"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        '
        'TB_Search
        '
        Me.TB_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Search.Location = New System.Drawing.Point(28, 84)
        Me.TB_Search.Name = "TB_Search"
        Me.TB_Search.Size = New System.Drawing.Size(307, 24)
        Me.TB_Search.TabIndex = 6
        '
        'CB_Address
        '
        Me.CB_Address.AutoSize = True
        Me.CB_Address.BackColor = System.Drawing.Color.Transparent
        Me.CB_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Address.Location = New System.Drawing.Point(28, 49)
        Me.CB_Address.Name = "CB_Address"
        Me.CB_Address.Size = New System.Drawing.Size(113, 22)
        Me.CB_Address.TabIndex = 5
        Me.CB_Address.Text = "Description"
        Me.CB_Address.UseVisualStyleBackColor = False
        '
        'CB_Name
        '
        Me.CB_Name.AutoSize = True
        Me.CB_Name.BackColor = System.Drawing.Color.Transparent
        Me.CB_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Name.Location = New System.Drawing.Point(28, 24)
        Me.CB_Name.Name = "CB_Name"
        Me.CB_Name.Size = New System.Drawing.Size(135, 22)
        Me.CB_Name.TabIndex = 4
        Me.CB_Name.Text = "Product Name"
        Me.CB_Name.UseVisualStyleBackColor = False
        '
        'CB_PI_ProdCateg
        '
        Me.CB_PI_ProdCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PI_ProdCateg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PI_ProdCateg.FormattingEnabled = True
        Me.CB_PI_ProdCateg.Items.AddRange(New Object() {"Food", "Miscellaneous", "Appliances", "Computer Peripherals"})
        Me.CB_PI_ProdCateg.Location = New System.Drawing.Point(485, 57)
        Me.CB_PI_ProdCateg.Name = "CB_PI_ProdCateg"
        Me.CB_PI_ProdCateg.Size = New System.Drawing.Size(185, 29)
        Me.CB_PI_ProdCateg.TabIndex = 39
        '
        'CB_PI_ProdSize
        '
        Me.CB_PI_ProdSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PI_ProdSize.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PI_ProdSize.FormattingEnabled = True
        Me.CB_PI_ProdSize.Items.AddRange(New Object() {"Small", "Medium", "Large", "N/A"})
        Me.CB_PI_ProdSize.Location = New System.Drawing.Point(485, 21)
        Me.CB_PI_ProdSize.Name = "CB_PI_ProdSize"
        Me.CB_PI_ProdSize.Size = New System.Drawing.Size(185, 29)
        Me.CB_PI_ProdSize.TabIndex = 38
        '
        'CB_PI_ProdColor
        '
        Me.CB_PI_ProdColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PI_ProdColor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_PI_ProdColor.FormattingEnabled = True
        Me.CB_PI_ProdColor.Items.AddRange(New Object() {"Brown", "Yellow", "Blue", "Silver", "White", "N/A"})
        Me.CB_PI_ProdColor.Location = New System.Drawing.Point(485, 94)
        Me.CB_PI_ProdColor.Name = "CB_PI_ProdColor"
        Me.CB_PI_ProdColor.Size = New System.Drawing.Size(185, 29)
        Me.CB_PI_ProdColor.TabIndex = 37
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(403, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 18)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "Size"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Color"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ProductDescDataGridViewTextBoxColumn.HeaderText = "Product Description"
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
        'ProductColorDataGridViewTextBoxColumn
        '
        Me.ProductColorDataGridViewTextBoxColumn.DataPropertyName = "ProductColor"
        Me.ProductColorDataGridViewTextBoxColumn.HeaderText = "Product Color"
        Me.ProductColorDataGridViewTextBoxColumn.Name = "ProductColorDataGridViewTextBoxColumn"
        Me.ProductColorDataGridViewTextBoxColumn.ReadOnly = True
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
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "Product Price"
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        Me.ProductPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDateDataGridViewTextBoxColumn
        '
        Me.ProductDateDataGridViewTextBoxColumn.DataPropertyName = "ProductDate"
        Me.ProductDateDataGridViewTextBoxColumn.HeaderText = "Time & Date when Product Information was saved"
        Me.ProductDateDataGridViewTextBoxColumn.Name = "ProductDateDataGridViewTextBoxColumn"
        Me.ProductDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductDateDataGridViewTextBoxColumn.Width = 135
        '
        'ProductModDataGridViewTextBoxColumn
        '
        Me.ProductModDataGridViewTextBoxColumn.DataPropertyName = "ProductMod"
        Me.ProductModDataGridViewTextBoxColumn.HeaderText = "Last Modified"
        Me.ProductModDataGridViewTextBoxColumn.Name = "ProductModDataGridViewTextBoxColumn"
        Me.ProductModDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductModDataGridViewTextBoxColumn.Width = 135
        '
        'ProductsBindingSource2
        '
        Me.ProductsBindingSource2.DataMember = "products"
        Me.ProductsBindingSource2.DataSource = Me.InventoryDataSet18
        '
        'InventoryDataSet18
        '
        Me.InventoryDataSet18.DataSetName = "inventoryDataSet18"
        Me.InventoryDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter2
        '
        Me.ProductsTableAdapter2.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "RESET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(695, 520)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.CB_PI_ProdCateg)
        Me.Controls.Add(Me.CB_PI_ProdSize)
        Me.Controls.Add(Me.CB_PI_ProdColor)
        Me.Controls.Add(Me.TB_Search)
        Me.Controls.Add(Me.CB_Address)
        Me.Controls.Add(Me.CB_Name)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ProductList"
        Me.Text = "Product List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents TB_Search As System.Windows.Forms.TextBox
    Friend WithEvents CB_Address As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Name As System.Windows.Forms.CheckBox
    Friend WithEvents ProductsBindingSource1 As BindingSource
    Friend WithEvents InventoryDataSet18 As inventoryDataSet18
    Friend WithEvents ProductsBindingSource2 As BindingSource
    Friend WithEvents ProductsTableAdapter2 As inventoryDataSet18TableAdapters.productsTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductModDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CB_PI_ProdCateg As ComboBox
    Friend WithEvents CB_PI_ProdSize As ComboBox
    Friend WithEvents CB_PI_ProdColor As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
