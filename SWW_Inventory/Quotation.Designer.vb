<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quotation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quotation))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotationListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PB_Search = New System.Windows.Forms.PictureBox()
        Me.TB_CPhone = New System.Windows.Forms.TextBox()
        Me.TB_CTin = New System.Windows.Forms.TextBox()
        Me.TB_CustomerID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_CAddress = New System.Windows.Forms.TextBox()
        Me.TB_CName = New System.Windows.Forms.TextBox()
        Me.TB_CCompany = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Date_QShipdate = New System.Windows.Forms.DateTimePicker()
        Me.CB_QShipvia = New System.Windows.Forms.ComboBox()
        Me.TB_QTerms = New System.Windows.Forms.TextBox()
        Me.TB_QSalesperson = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_QQuantity = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_QuotationID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_QDescription = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_QUnitprice = New System.Windows.Forms.TextBox()
        Me.TB_QTaxrate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TB_QSalestax = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_QSubtotal = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TB_QTotalamount = New System.Windows.Forms.TextBox()
        Me.Date_QCurrentdate = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaxRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesTaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipViaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TermsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerCompany = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotationSavedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotationStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotationLastModify = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuotationBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet8 = New SWW_Inventory.inventoryDataSet8()
        Me.QuotationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet4 = New SWW_Inventory.inventoryDataSet4()
        Me.BTN_Compute = New System.Windows.Forms.Button()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.BTN_QUpdate = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.BTN_Delete = New System.Windows.Forms.Button()
        Me.TB_QOther = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.QuotationTableAdapter = New SWW_Inventory.inventoryDataSet4TableAdapters.quotationTableAdapter()
        Me.InventoryDataSet5 = New SWW_Inventory.inventoryDataSet5()
        Me.QuotationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotationTableAdapter1 = New SWW_Inventory.inventoryDataSet5TableAdapters.quotationTableAdapter()
        Me.Label_SaveDate = New System.Windows.Forms.Label()
        Me.InventoryDataSet7 = New SWW_Inventory.inventoryDataSet7()
        Me.QuotationBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuotationTableAdapter2 = New SWW_Inventory.inventoryDataSet7TableAdapters.quotationTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_Status = New System.Windows.Forms.ComboBox()
        Me.Label_modify = New System.Windows.Forms.Label()
        Me.QuotationTableAdapter3 = New SWW_Inventory.inventoryDataSet8TableAdapters.quotationTableAdapter()
        Me.Label_Role = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotationBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StandardViewToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProductListToolStripMenuItem, Me.CalculatorToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(830, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearAllToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'StandardViewToolStripMenuItem
        '
        Me.StandardViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.QuotationListToolStripMenuItem})
        Me.StandardViewToolStripMenuItem.Name = "StandardViewToolStripMenuItem"
        Me.StandardViewToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.StandardViewToolStripMenuItem.Text = "View"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'QuotationListToolStripMenuItem
        '
        Me.QuotationListToolStripMenuItem.Name = "QuotationListToolStripMenuItem"
        Me.QuotationListToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.QuotationListToolStripMenuItem.Text = "Quotation List"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(99, 21)
        Me.ToolStripMenuItem1.Text = "Customer List"
        '
        'ProductListToolStripMenuItem
        '
        Me.ProductListToolStripMenuItem.Name = "ProductListToolStripMenuItem"
        Me.ProductListToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
        Me.ProductListToolStripMenuItem.Text = "Product List"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(78, 21)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.PB_Search)
        Me.GroupBox1.Controls.Add(Me.TB_CPhone)
        Me.GroupBox1.Controls.Add(Me.TB_CTin)
        Me.GroupBox1.Controls.Add(Me.TB_CustomerID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TB_CAddress)
        Me.GroupBox1.Controls.Add(Me.TB_CName)
        Me.GroupBox1.Controls.Add(Me.TB_CCompany)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QUOTATION FOR:"
        '
        'PB_Search
        '
        Me.PB_Search.BackColor = System.Drawing.Color.Transparent
        Me.PB_Search.Image = CType(resources.GetObject("PB_Search.Image"), System.Drawing.Image)
        Me.PB_Search.Location = New System.Drawing.Point(706, 42)
        Me.PB_Search.Name = "PB_Search"
        Me.PB_Search.Size = New System.Drawing.Size(38, 28)
        Me.PB_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Search.TabIndex = 44
        Me.PB_Search.TabStop = False
        '
        'TB_CPhone
        '
        Me.TB_CPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CPhone.Location = New System.Drawing.Point(513, 112)
        Me.TB_CPhone.Name = "TB_CPhone"
        Me.TB_CPhone.Size = New System.Drawing.Size(129, 24)
        Me.TB_CPhone.TabIndex = 11
        '
        'TB_CTin
        '
        Me.TB_CTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CTin.Location = New System.Drawing.Point(513, 76)
        Me.TB_CTin.Name = "TB_CTin"
        Me.TB_CTin.Size = New System.Drawing.Size(129, 24)
        Me.TB_CTin.TabIndex = 10
        '
        'TB_CustomerID
        '
        Me.TB_CustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CustomerID.Location = New System.Drawing.Point(513, 42)
        Me.TB_CustomerID.Name = "TB_CustomerID"
        Me.TB_CustomerID.Size = New System.Drawing.Size(192, 24)
        Me.TB_CustomerID.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(381, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TIN No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(381, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Customer ID"
        '
        'TB_CAddress
        '
        Me.TB_CAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAddress.Location = New System.Drawing.Point(162, 112)
        Me.TB_CAddress.Multiline = True
        Me.TB_CAddress.Name = "TB_CAddress"
        Me.TB_CAddress.Size = New System.Drawing.Size(192, 59)
        Me.TB_CAddress.TabIndex = 5
        '
        'TB_CName
        '
        Me.TB_CName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CName.Location = New System.Drawing.Point(162, 76)
        Me.TB_CName.Name = "TB_CName"
        Me.TB_CName.Size = New System.Drawing.Size(192, 24)
        Me.TB_CName.TabIndex = 4
        '
        'TB_CCompany
        '
        Me.TB_CCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CCompany.Location = New System.Drawing.Point(162, 42)
        Me.TB_CCompany.Name = "TB_CCompany"
        Me.TB_CCompany.Size = New System.Drawing.Size(192, 24)
        Me.TB_CCompany.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Date_QShipdate)
        Me.GroupBox2.Controls.Add(Me.CB_QShipvia)
        Me.GroupBox2.Controls.Add(Me.TB_QTerms)
        Me.GroupBox2.Controls.Add(Me.TB_QSalesperson)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TB_QQuantity)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TB_QuotationID)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TB_QDescription)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TB_QUnitprice)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 183)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.SWW_Inventory.My.Resources.Resources.Power_Button
        Me.PictureBox3.Location = New System.Drawing.Point(706, 25)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 46
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(744, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'Date_QShipdate
        '
        Me.Date_QShipdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_QShipdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_QShipdate.Location = New System.Drawing.Point(513, 62)
        Me.Date_QShipdate.Name = "Date_QShipdate"
        Me.Date_QShipdate.Size = New System.Drawing.Size(129, 24)
        Me.Date_QShipdate.TabIndex = 34
        '
        'CB_QShipvia
        '
        Me.CB_QShipvia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_QShipvia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_QShipvia.FormattingEnabled = True
        Me.CB_QShipvia.Items.AddRange(New Object() {"DHL", "FEDEX", "UPS", "LBC", "PICKUP IN STORE"})
        Me.CB_QShipvia.Location = New System.Drawing.Point(514, 97)
        Me.CB_QShipvia.Name = "CB_QShipvia"
        Me.CB_QShipvia.Size = New System.Drawing.Size(191, 26)
        Me.CB_QShipvia.TabIndex = 35
        '
        'TB_QTerms
        '
        Me.TB_QTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTerms.Location = New System.Drawing.Point(162, 132)
        Me.TB_QTerms.Name = "TB_QTerms"
        Me.TB_QTerms.Size = New System.Drawing.Size(192, 24)
        Me.TB_QTerms.TabIndex = 33
        '
        'TB_QSalesperson
        '
        Me.TB_QSalesperson.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalesperson.Location = New System.Drawing.Point(513, 132)
        Me.TB_QSalesperson.Name = "TB_QSalesperson"
        Me.TB_QSalesperson.Size = New System.Drawing.Size(192, 24)
        Me.TB_QSalesperson.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 18)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Terms"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(381, 135)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 18)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Sales Person"
        '
        'TB_QQuantity
        '
        Me.TB_QQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QQuantity.Location = New System.Drawing.Point(162, 28)
        Me.TB_QQuantity.Name = "TB_QQuantity"
        Me.TB_QQuantity.Size = New System.Drawing.Size(192, 24)
        Me.TB_QQuantity.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Quantity"
        '
        'TB_QuotationID
        '
        Me.TB_QuotationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QuotationID.Location = New System.Drawing.Point(514, 28)
        Me.TB_QuotationID.Name = "TB_QuotationID"
        Me.TB_QuotationID.Size = New System.Drawing.Size(192, 24)
        Me.TB_QuotationID.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 18)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(381, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Ship Via"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Unit Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(381, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Ship Date"
        '
        'TB_QDescription
        '
        Me.TB_QDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QDescription.Location = New System.Drawing.Point(162, 62)
        Me.TB_QDescription.Name = "TB_QDescription"
        Me.TB_QDescription.Size = New System.Drawing.Size(192, 24)
        Me.TB_QDescription.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(381, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Quotation ID"
        '
        'TB_QUnitprice
        '
        Me.TB_QUnitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QUnitprice.Location = New System.Drawing.Point(162, 98)
        Me.TB_QUnitprice.Name = "TB_QUnitprice"
        Me.TB_QUnitprice.Size = New System.Drawing.Size(129, 24)
        Me.TB_QUnitprice.TabIndex = 17
        Me.TB_QUnitprice.Text = "0.00"
        Me.TB_QUnitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TB_QTaxrate
        '
        Me.TB_QTaxrate.Enabled = False
        Me.TB_QTaxrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTaxrate.Location = New System.Drawing.Point(665, 463)
        Me.TB_QTaxrate.Name = "TB_QTaxrate"
        Me.TB_QTaxrate.Size = New System.Drawing.Size(129, 24)
        Me.TB_QTaxrate.TabIndex = 40
        Me.TB_QTaxrate.Text = "12%"
        Me.TB_QTaxrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(540, 467)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 18)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Tax Rate"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(540, 497)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 18)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Sales Tax"
        '
        'TB_QSalestax
        '
        Me.TB_QSalestax.Enabled = False
        Me.TB_QSalestax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalestax.Location = New System.Drawing.Point(665, 493)
        Me.TB_QSalestax.Name = "TB_QSalestax"
        Me.TB_QSalestax.Size = New System.Drawing.Size(129, 24)
        Me.TB_QSalestax.TabIndex = 41
        Me.TB_QSalestax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(540, 437)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 18)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Subtotal"
        '
        'TB_QSubtotal
        '
        Me.TB_QSubtotal.Enabled = False
        Me.TB_QSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSubtotal.Location = New System.Drawing.Point(666, 433)
        Me.TB_QSubtotal.Name = "TB_QSubtotal"
        Me.TB_QSubtotal.Size = New System.Drawing.Size(129, 24)
        Me.TB_QSubtotal.TabIndex = 37
        Me.TB_QSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(540, 557)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 18)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Total Amount"
        '
        'TB_QTotalamount
        '
        Me.TB_QTotalamount.Enabled = False
        Me.TB_QTotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTotalamount.Location = New System.Drawing.Point(665, 553)
        Me.TB_QTotalamount.Name = "TB_QTotalamount"
        Me.TB_QTotalamount.Size = New System.Drawing.Size(129, 24)
        Me.TB_QTotalamount.TabIndex = 43
        Me.TB_QTotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Date_QCurrentdate
        '
        Me.Date_QCurrentdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_QCurrentdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_QCurrentdate.Location = New System.Drawing.Point(665, 28)
        Me.Date_QCurrentdate.Name = "Date_QCurrentdate"
        Me.Date_QCurrentdate.Size = New System.Drawing.Size(129, 24)
        Me.Date_QCurrentdate.TabIndex = 36
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(615, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 18)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Date"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateDataGridViewTextBoxColumn, Me.QuotationIDDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.TaxRateDataGridViewTextBoxColumn, Me.SalesTaxDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.ShipDateDataGridViewTextBoxColumn, Me.ShipViaDataGridViewTextBoxColumn, Me.SalesPersonDataGridViewTextBoxColumn, Me.OtherDataGridViewTextBoxColumn, Me.TermsDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerCompany, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerAddressDataGridViewTextBoxColumn, Me.CustomerPhoneDataGridViewTextBoxColumn, Me.CustomerTin, Me.QuotationSavedDate, Me.QuotationStatus, Me.QuotationLastModify})
        Me.DataGridView.DataSource = Me.QuotationBindingSource3
        Me.DataGridView.Location = New System.Drawing.Point(0, 643)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.Size = New System.Drawing.Size(830, 237)
        Me.DataGridView.TabIndex = 46
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuotationIDDataGridViewTextBoxColumn
        '
        Me.QuotationIDDataGridViewTextBoxColumn.DataPropertyName = "QuotationID"
        Me.QuotationIDDataGridViewTextBoxColumn.HeaderText = "Quotation ID"
        Me.QuotationIDDataGridViewTextBoxColumn.Name = "QuotationIDDataGridViewTextBoxColumn"
        Me.QuotationIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TaxRateDataGridViewTextBoxColumn
        '
        Me.TaxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate"
        Me.TaxRateDataGridViewTextBoxColumn.HeaderText = "Tax Rate"
        Me.TaxRateDataGridViewTextBoxColumn.Name = "TaxRateDataGridViewTextBoxColumn"
        Me.TaxRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesTaxDataGridViewTextBoxColumn
        '
        Me.SalesTaxDataGridViewTextBoxColumn.DataPropertyName = "SalesTax"
        Me.SalesTaxDataGridViewTextBoxColumn.HeaderText = "Sales Tax"
        Me.SalesTaxDataGridViewTextBoxColumn.Name = "SalesTaxDataGridViewTextBoxColumn"
        Me.SalesTaxDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipDateDataGridViewTextBoxColumn
        '
        Me.ShipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate"
        Me.ShipDateDataGridViewTextBoxColumn.HeaderText = "Ship Date"
        Me.ShipDateDataGridViewTextBoxColumn.Name = "ShipDateDataGridViewTextBoxColumn"
        Me.ShipDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ShipViaDataGridViewTextBoxColumn
        '
        Me.ShipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia"
        Me.ShipViaDataGridViewTextBoxColumn.HeaderText = "Ship Via"
        Me.ShipViaDataGridViewTextBoxColumn.Name = "ShipViaDataGridViewTextBoxColumn"
        Me.ShipViaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesPersonDataGridViewTextBoxColumn
        '
        Me.SalesPersonDataGridViewTextBoxColumn.DataPropertyName = "SalesPerson"
        Me.SalesPersonDataGridViewTextBoxColumn.HeaderText = "Sales Person"
        Me.SalesPersonDataGridViewTextBoxColumn.Name = "SalesPersonDataGridViewTextBoxColumn"
        Me.SalesPersonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OtherDataGridViewTextBoxColumn
        '
        Me.OtherDataGridViewTextBoxColumn.DataPropertyName = "Other"
        Me.OtherDataGridViewTextBoxColumn.HeaderText = "Other"
        Me.OtherDataGridViewTextBoxColumn.Name = "OtherDataGridViewTextBoxColumn"
        Me.OtherDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TermsDataGridViewTextBoxColumn
        '
        Me.TermsDataGridViewTextBoxColumn.DataPropertyName = "Terms"
        Me.TermsDataGridViewTextBoxColumn.HeaderText = "Terms"
        Me.TermsDataGridViewTextBoxColumn.Name = "TermsDataGridViewTextBoxColumn"
        Me.TermsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerCompany
        '
        Me.CustomerCompany.DataPropertyName = "CustomerCompany"
        Me.CustomerCompany.HeaderText = "Customer Company"
        Me.CustomerCompany.Name = "CustomerCompany"
        Me.CustomerCompany.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerAddressDataGridViewTextBoxColumn
        '
        Me.CustomerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress"
        Me.CustomerAddressDataGridViewTextBoxColumn.HeaderText = "Customer Address"
        Me.CustomerAddressDataGridViewTextBoxColumn.Name = "CustomerAddressDataGridViewTextBoxColumn"
        Me.CustomerAddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerPhoneDataGridViewTextBoxColumn
        '
        Me.CustomerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone"
        Me.CustomerPhoneDataGridViewTextBoxColumn.HeaderText = "Customer Phone"
        Me.CustomerPhoneDataGridViewTextBoxColumn.Name = "CustomerPhoneDataGridViewTextBoxColumn"
        Me.CustomerPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerTin
        '
        Me.CustomerTin.DataPropertyName = "CustomerTin"
        Me.CustomerTin.HeaderText = "Customer Tin"
        Me.CustomerTin.Name = "CustomerTin"
        Me.CustomerTin.ReadOnly = True
        '
        'QuotationSavedDate
        '
        Me.QuotationSavedDate.DataPropertyName = "QuotationSavedDate"
        Me.QuotationSavedDate.HeaderText = "Time & Date When Quotation is Saved"
        Me.QuotationSavedDate.Name = "QuotationSavedDate"
        Me.QuotationSavedDate.ReadOnly = True
        Me.QuotationSavedDate.Width = 135
        '
        'QuotationStatus
        '
        Me.QuotationStatus.DataPropertyName = "QuotationStatus"
        Me.QuotationStatus.HeaderText = "Quotation Status"
        Me.QuotationStatus.Name = "QuotationStatus"
        Me.QuotationStatus.ReadOnly = True
        '
        'QuotationLastModify
        '
        Me.QuotationLastModify.DataPropertyName = "QuotationLastModify"
        Me.QuotationLastModify.HeaderText = "Last Modified"
        Me.QuotationLastModify.Name = "QuotationLastModify"
        Me.QuotationLastModify.ReadOnly = True
        Me.QuotationLastModify.Width = 130
        '
        'QuotationBindingSource3
        '
        Me.QuotationBindingSource3.DataMember = "quotation"
        Me.QuotationBindingSource3.DataSource = Me.InventoryDataSet8
        '
        'InventoryDataSet8
        '
        Me.InventoryDataSet8.DataSetName = "inventoryDataSet8"
        Me.InventoryDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuotationBindingSource
        '
        Me.QuotationBindingSource.DataMember = "quotation"
        Me.QuotationBindingSource.DataSource = Me.InventoryDataSet4
        '
        'InventoryDataSet4
        '
        Me.InventoryDataSet4.DataSetName = "inventoryDataSet4"
        Me.InventoryDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTN_Compute
        '
        Me.BTN_Compute.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Compute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Compute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Compute.Location = New System.Drawing.Point(665, 585)
        Me.BTN_Compute.Name = "BTN_Compute"
        Me.BTN_Compute.Size = New System.Drawing.Size(129, 39)
        Me.BTN_Compute.TabIndex = 48
        Me.BTN_Compute.Text = "COMPUTE"
        Me.BTN_Compute.UseVisualStyleBackColor = False
        '
        'Btn_New
        '
        Me.Btn_New.BackColor = System.Drawing.Color.DimGray
        Me.Btn_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_New.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_New.Location = New System.Drawing.Point(75, 500)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(149, 51)
        Me.Btn_New.TabIndex = 49
        Me.Btn_New.Text = "NEW"
        Me.Btn_New.UseVisualStyleBackColor = False
        '
        'BTN_QUpdate
        '
        Me.BTN_QUpdate.BackColor = System.Drawing.Color.DimGray
        Me.BTN_QUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_QUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_QUpdate.Location = New System.Drawing.Point(283, 500)
        Me.BTN_QUpdate.Name = "BTN_QUpdate"
        Me.BTN_QUpdate.Size = New System.Drawing.Size(149, 51)
        Me.BTN_QUpdate.TabIndex = 50
        Me.BTN_QUpdate.Text = "UPDATE"
        Me.BTN_QUpdate.UseVisualStyleBackColor = False
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Save.Location = New System.Drawing.Point(75, 567)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(149, 51)
        Me.Btn_Save.TabIndex = 51
        Me.Btn_Save.Text = "SAVE"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'BTN_Delete
        '
        Me.BTN_Delete.BackColor = System.Drawing.Color.DimGray
        Me.BTN_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_Delete.Location = New System.Drawing.Point(283, 567)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(149, 51)
        Me.BTN_Delete.TabIndex = 52
        Me.BTN_Delete.Text = "DELETE"
        Me.BTN_Delete.UseVisualStyleBackColor = False
        '
        'TB_QOther
        '
        Me.TB_QOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QOther.Location = New System.Drawing.Point(665, 523)
        Me.TB_QOther.Name = "TB_QOther"
        Me.TB_QOther.Size = New System.Drawing.Size(129, 24)
        Me.TB_QOther.TabIndex = 54
        Me.TB_QOther.Text = "0.00"
        Me.TB_QOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(540, 526)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 18)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Other"
        '
        'QuotationTableAdapter
        '
        Me.QuotationTableAdapter.ClearBeforeFill = True
        '
        'InventoryDataSet5
        '
        Me.InventoryDataSet5.DataSetName = "inventoryDataSet5"
        Me.InventoryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuotationBindingSource1
        '
        Me.QuotationBindingSource1.DataMember = "quotation"
        Me.QuotationBindingSource1.DataSource = Me.InventoryDataSet5
        '
        'QuotationTableAdapter1
        '
        Me.QuotationTableAdapter1.ClearBeforeFill = True
        '
        'Label_SaveDate
        '
        Me.Label_SaveDate.AutoSize = True
        Me.Label_SaveDate.BackColor = System.Drawing.Color.Transparent
        Me.Label_SaveDate.Location = New System.Drawing.Point(12, 612)
        Me.Label_SaveDate.Name = "Label_SaveDate"
        Me.Label_SaveDate.Size = New System.Drawing.Size(0, 13)
        Me.Label_SaveDate.TabIndex = 56
        Me.Label_SaveDate.Visible = False
        '
        'InventoryDataSet7
        '
        Me.InventoryDataSet7.DataSetName = "inventoryDataSet7"
        Me.InventoryDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QuotationBindingSource2
        '
        Me.QuotationBindingSource2.DataMember = "quotation"
        Me.QuotationBindingSource2.DataSource = Me.InventoryDataSet7
        '
        'QuotationTableAdapter2
        '
        Me.QuotationTableAdapter2.ClearBeforeFill = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(37, 433)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "STATUS:"
        '
        'CB_Status
        '
        Me.CB_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Status.FormattingEnabled = True
        Me.CB_Status.Items.AddRange(New Object() {"OPEN", "CLOSED", "CANCELLED"})
        Me.CB_Status.Location = New System.Drawing.Point(113, 430)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(148, 26)
        Me.CB_Status.TabIndex = 46
        '
        'Label_modify
        '
        Me.Label_modify.AutoSize = True
        Me.Label_modify.BackColor = System.Drawing.Color.Transparent
        Me.Label_modify.Location = New System.Drawing.Point(389, 614)
        Me.Label_modify.Name = "Label_modify"
        Me.Label_modify.Size = New System.Drawing.Size(0, 13)
        Me.Label_modify.TabIndex = 57
        Me.Label_modify.Visible = False
        '
        'QuotationTableAdapter3
        '
        Me.QuotationTableAdapter3.ClearBeforeFill = True
        '
        'Label_Role
        '
        Me.Label_Role.AutoSize = True
        Me.Label_Role.Location = New System.Drawing.Point(452, 25)
        Me.Label_Role.Name = "Label_Role"
        Me.Label_Role.Size = New System.Drawing.Size(0, 13)
        Me.Label_Role.TabIndex = 58
        Me.Label_Role.Visible = False
        '
        'Quotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(830, 641)
        Me.Controls.Add(Me.Label_Role)
        Me.Controls.Add(Me.Label_modify)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label_SaveDate)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TB_QOther)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.BTN_QUpdate)
        Me.Controls.Add(Me.Btn_New)
        Me.Controls.Add(Me.BTN_Compute)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Date_QCurrentdate)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TB_QTotalamount)
        Me.Controls.Add(Me.TB_QTaxrate)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TB_QSalestax)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TB_QSubtotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Quotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quotations"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotationBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_CPhone As System.Windows.Forms.TextBox
    Friend WithEvents TB_CTin As System.Windows.Forms.TextBox
    Friend WithEvents TB_CustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_CAddress As System.Windows.Forms.TextBox
    Friend WithEvents TB_CName As System.Windows.Forms.TextBox
    Friend WithEvents TB_CCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_QShipvia As System.Windows.Forms.ComboBox
    Friend WithEvents Date_QShipdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TB_QTerms As System.Windows.Forms.TextBox
    Friend WithEvents TB_QSalesperson As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TB_QQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TB_QuotationID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_QDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TB_QUnitprice As System.Windows.Forms.TextBox
    Friend WithEvents TB_QTaxrate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TB_QSalestax As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TB_QSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TB_QTotalamount As System.Windows.Forms.TextBox
    Friend WithEvents PB_Search As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Date_QCurrentdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BTN_Compute As System.Windows.Forms.Button
    Friend WithEvents Btn_New As System.Windows.Forms.Button
    Friend WithEvents BTN_QUpdate As System.Windows.Forms.Button
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents BTN_Delete As System.Windows.Forms.Button
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TB_QOther As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotationListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryDataSet4 As SWW_Inventory.inventoryDataSet4
    Friend WithEvents QuotationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuotationTableAdapter As SWW_Inventory.inventoryDataSet4TableAdapters.quotationTableAdapter
    Friend WithEvents InventoryDataSet5 As SWW_Inventory.inventoryDataSet5
    Friend WithEvents QuotationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents QuotationTableAdapter1 As SWW_Inventory.inventoryDataSet5TableAdapters.quotationTableAdapter
    Friend WithEvents Label_SaveDate As System.Windows.Forms.Label
    Friend WithEvents InventoryDataSet7 As SWW_Inventory.inventoryDataSet7
    Friend WithEvents QuotationBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents QuotationTableAdapter2 As SWW_Inventory.inventoryDataSet7TableAdapters.quotationTableAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CB_Status As System.Windows.Forms.ComboBox
    Friend WithEvents Label_modify As System.Windows.Forms.Label
    Friend WithEvents InventoryDataSet8 As SWW_Inventory.inventoryDataSet8
    Friend WithEvents QuotationBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents QuotationTableAdapter3 As SWW_Inventory.inventoryDataSet8TableAdapters.quotationTableAdapter
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_Role As System.Windows.Forms.Label
    Friend WithEvents ProductListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuotationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaxRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesTaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ShipViaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesPersonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OtherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TermsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerCompany As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerTin As DataGridViewTextBoxColumn
    Friend WithEvents QuotationSavedDate As DataGridViewTextBoxColumn
    Friend WithEvents QuotationStatus As DataGridViewTextBoxColumn
    Friend WithEvents QuotationLastModify As DataGridViewTextBoxColumn
End Class
