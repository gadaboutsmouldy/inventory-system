<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_QOther = New System.Windows.Forms.TextBox()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_CreateInvoice = New System.Windows.Forms.Button()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TB_QTotalamount = New System.Windows.Forms.TextBox()
        Me.TB_QTaxrate = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Date_QShipdate = New System.Windows.Forms.TextBox()
        Me.TB_IShipvia = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.TB_QSalestax = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotationListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TB_QSubtotal = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InvoiceIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.CustomerCompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceSavedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceLastModifyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet10 = New SWW_Inventory.inventoryDataSet10()
        Me.CB_Status = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label_QStatus = New System.Windows.Forms.Label()
        Me.Label_Status = New System.Windows.Forms.Label()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TB_InvoiceID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Date_QCurrentdate = New System.Windows.Forms.TextBox()
        Me.Label_Modify = New System.Windows.Forms.Label()
        Me.Label_Save = New System.Windows.Forms.Label()
        Me.InvoiceTableAdapter = New SWW_Inventory.inventoryDataSet10TableAdapters.invoiceTableAdapter()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label_Role = New System.Windows.Forms.Label()
        Me.TB_StatusQ = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(486, 532)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 18)
        Me.Label22.TabIndex = 75
        Me.Label22.Text = "Other"
        '
        'TB_QOther
        '
        Me.TB_QOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QOther.Location = New System.Drawing.Point(611, 529)
        Me.TB_QOther.Name = "TB_QOther"
        Me.TB_QOther.ReadOnly = True
        Me.TB_QOther.Size = New System.Drawing.Size(129, 24)
        Me.TB_QOther.TabIndex = 74
        Me.TB_QOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Delete.Location = New System.Drawing.Point(250, 588)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(149, 51)
        Me.Btn_Delete.TabIndex = 73
        Me.Btn_Delete.Text = "DELETE"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'Btn_CreateInvoice
        '
        Me.Btn_CreateInvoice.BackColor = System.Drawing.Color.DimGray
        Me.Btn_CreateInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_CreateInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_CreateInvoice.Location = New System.Drawing.Point(252, 529)
        Me.Btn_CreateInvoice.Name = "Btn_CreateInvoice"
        Me.Btn_CreateInvoice.Size = New System.Drawing.Size(149, 51)
        Me.Btn_CreateInvoice.TabIndex = 72
        Me.Btn_CreateInvoice.Text = "CREATE INVOICE"
        Me.Btn_CreateInvoice.UseVisualStyleBackColor = False
        '
        'Btn_New
        '
        Me.Btn_New.BackColor = System.Drawing.Color.DimGray
        Me.Btn_New.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_New.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_New.Location = New System.Drawing.Point(55, 588)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(149, 51)
        Me.Btn_New.TabIndex = 70
        Me.Btn_New.Text = "NEW"
        Me.Btn_New.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(605, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 18)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "Date"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(486, 563)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 18)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "Total Amount"
        '
        'TB_QTotalamount
        '
        Me.TB_QTotalamount.Enabled = False
        Me.TB_QTotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTotalamount.Location = New System.Drawing.Point(611, 559)
        Me.TB_QTotalamount.Name = "TB_QTotalamount"
        Me.TB_QTotalamount.ReadOnly = True
        Me.TB_QTotalamount.Size = New System.Drawing.Size(129, 24)
        Me.TB_QTotalamount.TabIndex = 67
        Me.TB_QTotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TB_QTaxrate
        '
        Me.TB_QTaxrate.Enabled = False
        Me.TB_QTaxrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTaxrate.Location = New System.Drawing.Point(611, 469)
        Me.TB_QTaxrate.Name = "TB_QTaxrate"
        Me.TB_QTaxrate.ReadOnly = True
        Me.TB_QTaxrate.Size = New System.Drawing.Size(129, 24)
        Me.TB_QTaxrate.TabIndex = 64
        Me.TB_QTaxrate.Text = "12%"
        Me.TB_QTaxrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(486, 473)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 18)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Tax Rate"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Date_QShipdate)
        Me.GroupBox2.Controls.Add(Me.TB_IShipvia)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(753, 183)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'Date_QShipdate
        '
        Me.Date_QShipdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_QShipdate.Location = New System.Drawing.Point(513, 62)
        Me.Date_QShipdate.Name = "Date_QShipdate"
        Me.Date_QShipdate.ReadOnly = True
        Me.Date_QShipdate.Size = New System.Drawing.Size(71, 24)
        Me.Date_QShipdate.TabIndex = 47
        '
        'TB_IShipvia
        '
        Me.TB_IShipvia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_IShipvia.Location = New System.Drawing.Point(512, 96)
        Me.TB_IShipvia.Name = "TB_IShipvia"
        Me.TB_IShipvia.ReadOnly = True
        Me.TB_IShipvia.Size = New System.Drawing.Size(192, 24)
        Me.TB_IShipvia.TabIndex = 46
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(706, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'TB_QTerms
        '
        Me.TB_QTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTerms.Location = New System.Drawing.Point(162, 132)
        Me.TB_QTerms.Name = "TB_QTerms"
        Me.TB_QTerms.ReadOnly = True
        Me.TB_QTerms.Size = New System.Drawing.Size(192, 24)
        Me.TB_QTerms.TabIndex = 33
        '
        'TB_QSalesperson
        '
        Me.TB_QSalesperson.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalesperson.Location = New System.Drawing.Point(513, 132)
        Me.TB_QSalesperson.Name = "TB_QSalesperson"
        Me.TB_QSalesperson.ReadOnly = True
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
        Me.TB_QQuantity.ReadOnly = True
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
        Me.TB_QuotationID.Location = New System.Drawing.Point(513, 28)
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
        Me.TB_QDescription.ReadOnly = True
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
        Me.TB_QUnitprice.ReadOnly = True
        Me.TB_QUnitprice.Size = New System.Drawing.Size(129, 24)
        Me.TB_QUnitprice.TabIndex = 17
        Me.TB_QUnitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(486, 503)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 18)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "Sales Tax"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 184)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BILL TO:"
        '
        'TB_CPhone
        '
        Me.TB_CPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CPhone.Location = New System.Drawing.Point(513, 112)
        Me.TB_CPhone.Name = "TB_CPhone"
        Me.TB_CPhone.ReadOnly = True
        Me.TB_CPhone.Size = New System.Drawing.Size(129, 24)
        Me.TB_CPhone.TabIndex = 11
        '
        'TB_CTin
        '
        Me.TB_CTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CTin.Location = New System.Drawing.Point(513, 76)
        Me.TB_CTin.Name = "TB_CTin"
        Me.TB_CTin.ReadOnly = True
        Me.TB_CTin.Size = New System.Drawing.Size(129, 24)
        Me.TB_CTin.TabIndex = 10
        '
        'TB_CustomerID
        '
        Me.TB_CustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CustomerID.Location = New System.Drawing.Point(513, 42)
        Me.TB_CustomerID.Name = "TB_CustomerID"
        Me.TB_CustomerID.ReadOnly = True
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
        Me.TB_CAddress.ReadOnly = True
        Me.TB_CAddress.Size = New System.Drawing.Size(192, 56)
        Me.TB_CAddress.TabIndex = 5
        '
        'TB_CName
        '
        Me.TB_CName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CName.Location = New System.Drawing.Point(162, 76)
        Me.TB_CName.Name = "TB_CName"
        Me.TB_CName.ReadOnly = True
        Me.TB_CName.Size = New System.Drawing.Size(192, 24)
        Me.TB_CName.TabIndex = 4
        '
        'TB_CCompany
        '
        Me.TB_CCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CCompany.Location = New System.Drawing.Point(162, 42)
        Me.TB_CCompany.Name = "TB_CCompany"
        Me.TB_CCompany.ReadOnly = True
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
        'TB_QSalestax
        '
        Me.TB_QSalestax.Enabled = False
        Me.TB_QSalestax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalestax.Location = New System.Drawing.Point(611, 499)
        Me.TB_QSalestax.Name = "TB_QSalestax"
        Me.TB_QSalestax.ReadOnly = True
        Me.TB_QSalestax.Size = New System.Drawing.Size(129, 24)
        Me.TB_QSalestax.TabIndex = 65
        Me.TB_QSalestax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StandardViewToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem, Me.DisplayReportsToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(779, 25)
        Me.MenuStrip1.TabIndex = 56
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
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'QuotationListToolStripMenuItem
        '
        Me.QuotationListToolStripMenuItem.Name = "QuotationListToolStripMenuItem"
        Me.QuotationListToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.QuotationListToolStripMenuItem.Text = "Invoice List"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(101, 21)
        Me.BackToMainMenuToolStripMenuItem.Text = "Quotation List"
        '
        'DisplayReportsToolStripMenuItem
        '
        Me.DisplayReportsToolStripMenuItem.Name = "DisplayReportsToolStripMenuItem"
        Me.DisplayReportsToolStripMenuItem.Size = New System.Drawing.Size(112, 21)
        Me.DisplayReportsToolStripMenuItem.Text = "Display Reports"
        '
        'BackToMainMenuToolStripMenuItem1
        '
        Me.BackToMainMenuToolStripMenuItem1.Name = "BackToMainMenuToolStripMenuItem1"
        Me.BackToMainMenuToolStripMenuItem1.Size = New System.Drawing.Size(132, 21)
        Me.BackToMainMenuToolStripMenuItem1.Text = "Back to Main Menu"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(486, 443)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 18)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Subtotal"
        '
        'TB_QSubtotal
        '
        Me.TB_QSubtotal.Enabled = False
        Me.TB_QSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSubtotal.Location = New System.Drawing.Point(612, 439)
        Me.TB_QSubtotal.Name = "TB_QSubtotal"
        Me.TB_QSubtotal.ReadOnly = True
        Me.TB_QSubtotal.Size = New System.Drawing.Size(129, 24)
        Me.TB_QSubtotal.TabIndex = 61
        Me.TB_QSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InvoiceIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn, Me.TaxRateDataGridViewTextBoxColumn, Me.SalesTaxDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.ShipDateDataGridViewTextBoxColumn, Me.ShipViaDataGridViewTextBoxColumn, Me.SalesPersonDataGridViewTextBoxColumn, Me.OtherDataGridViewTextBoxColumn, Me.TermsDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerCompanyDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerAddressDataGridViewTextBoxColumn, Me.CustomerPhoneDataGridViewTextBoxColumn, Me.CustomerTinDataGridViewTextBoxColumn, Me.InvoiceStatusDataGridViewTextBoxColumn, Me.InvoiceSavedDateDataGridViewTextBoxColumn, Me.InvoiceLastModifyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InvoiceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 679)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(777, 231)
        Me.DataGridView1.TabIndex = 76
        '
        'InvoiceIDDataGridViewTextBoxColumn
        '
        Me.InvoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID"
        Me.InvoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice ID"
        Me.InvoiceIDDataGridViewTextBoxColumn.Name = "InvoiceIDDataGridViewTextBoxColumn"
        Me.InvoiceIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
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
        'CustomerCompanyDataGridViewTextBoxColumn
        '
        Me.CustomerCompanyDataGridViewTextBoxColumn.DataPropertyName = "CustomerCompany"
        Me.CustomerCompanyDataGridViewTextBoxColumn.HeaderText = "Customer Company"
        Me.CustomerCompanyDataGridViewTextBoxColumn.Name = "CustomerCompanyDataGridViewTextBoxColumn"
        Me.CustomerCompanyDataGridViewTextBoxColumn.ReadOnly = True
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
        'CustomerTinDataGridViewTextBoxColumn
        '
        Me.CustomerTinDataGridViewTextBoxColumn.DataPropertyName = "CustomerTin"
        Me.CustomerTinDataGridViewTextBoxColumn.HeaderText = "Customer Tin"
        Me.CustomerTinDataGridViewTextBoxColumn.Name = "CustomerTinDataGridViewTextBoxColumn"
        Me.CustomerTinDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoiceStatusDataGridViewTextBoxColumn
        '
        Me.InvoiceStatusDataGridViewTextBoxColumn.DataPropertyName = "InvoiceStatus"
        Me.InvoiceStatusDataGridViewTextBoxColumn.HeaderText = "Invoice Status"
        Me.InvoiceStatusDataGridViewTextBoxColumn.Name = "InvoiceStatusDataGridViewTextBoxColumn"
        Me.InvoiceStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvoiceSavedDateDataGridViewTextBoxColumn
        '
        Me.InvoiceSavedDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceSavedDate"
        Me.InvoiceSavedDateDataGridViewTextBoxColumn.HeaderText = "Time & Date When the Invoice was made"
        Me.InvoiceSavedDateDataGridViewTextBoxColumn.Name = "InvoiceSavedDateDataGridViewTextBoxColumn"
        Me.InvoiceSavedDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoiceSavedDateDataGridViewTextBoxColumn.Width = 135
        '
        'InvoiceLastModifyDataGridViewTextBoxColumn
        '
        Me.InvoiceLastModifyDataGridViewTextBoxColumn.DataPropertyName = "InvoiceLastModify"
        Me.InvoiceLastModifyDataGridViewTextBoxColumn.HeaderText = "Last Modified"
        Me.InvoiceLastModifyDataGridViewTextBoxColumn.Name = "InvoiceLastModifyDataGridViewTextBoxColumn"
        Me.InvoiceLastModifyDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvoiceLastModifyDataGridViewTextBoxColumn.Width = 135
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "invoice"
        Me.InvoiceBindingSource.DataSource = Me.InventoryDataSet10
        '
        'InventoryDataSet10
        '
        Me.InventoryDataSet10.DataSetName = "inventoryDataSet10"
        Me.InventoryDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CB_Status
        '
        Me.CB_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Status.FormattingEnabled = True
        Me.CB_Status.Items.AddRange(New Object() {"UNPAID", "PAID"})
        Me.CB_Status.Location = New System.Drawing.Point(174, 469)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(148, 26)
        Me.CB_Status.TabIndex = 77
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(36, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 18)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Invoice Status:"
        '
        'Label_QStatus
        '
        Me.Label_QStatus.AutoSize = True
        Me.Label_QStatus.BackColor = System.Drawing.Color.Transparent
        Me.Label_QStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_QStatus.Location = New System.Drawing.Point(-1, 656)
        Me.Label_QStatus.Name = "Label_QStatus"
        Me.Label_QStatus.Size = New System.Drawing.Size(0, 20)
        Me.Label_QStatus.TabIndex = 80
        '
        'Label_Status
        '
        Me.Label_Status.AutoSize = True
        Me.Label_Status.BackColor = System.Drawing.Color.Transparent
        Me.Label_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Status.Location = New System.Drawing.Point(190, 656)
        Me.Label_Status.Name = "Label_Status"
        Me.Label_Status.Size = New System.Drawing.Size(0, 20)
        Me.Label_Status.TabIndex = 81
        '
        'Btn_Update
        '
        Me.Btn_Update.BackColor = System.Drawing.Color.DimGray
        Me.Btn_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Update.Location = New System.Drawing.Point(55, 529)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(149, 51)
        Me.Btn_Update.TabIndex = 82
        Me.Btn_Update.Text = "UPDATE INVOICE STATUS"
        Me.Btn_Update.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(360, 435)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'TB_InvoiceID
        '
        Me.TB_InvoiceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_InvoiceID.Location = New System.Drawing.Point(174, 435)
        Me.TB_InvoiceID.Name = "TB_InvoiceID"
        Me.TB_InvoiceID.Size = New System.Drawing.Size(148, 24)
        Me.TB_InvoiceID.TabIndex = 47
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(36, 439)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(82, 18)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Invoice ID"
        '
        'Date_QCurrentdate
        '
        Me.Date_QCurrentdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_QCurrentdate.Location = New System.Drawing.Point(655, 37)
        Me.Date_QCurrentdate.Name = "Date_QCurrentdate"
        Me.Date_QCurrentdate.ReadOnly = True
        Me.Date_QCurrentdate.Size = New System.Drawing.Size(71, 24)
        Me.Date_QCurrentdate.TabIndex = 48
        '
        'Label_Modify
        '
        Me.Label_Modify.AutoSize = True
        Me.Label_Modify.BackColor = System.Drawing.Color.Transparent
        Me.Label_Modify.Location = New System.Drawing.Point(590, 640)
        Me.Label_Modify.Name = "Label_Modify"
        Me.Label_Modify.Size = New System.Drawing.Size(0, 13)
        Me.Label_Modify.TabIndex = 85
        Me.Label_Modify.Visible = False
        '
        'Label_Save
        '
        Me.Label_Save.AutoSize = True
        Me.Label_Save.BackColor = System.Drawing.Color.Transparent
        Me.Label_Save.Location = New System.Drawing.Point(591, 611)
        Me.Label_Save.Name = "Label_Save"
        Me.Label_Save.Size = New System.Drawing.Size(0, 13)
        Me.Label_Save.TabIndex = 84
        Me.Label_Save.Visible = False
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(322, 432)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 86
        Me.PictureBox3.TabStop = False
        '
        'Label_Role
        '
        Me.Label_Role.AutoSize = True
        Me.Label_Role.Location = New System.Drawing.Point(455, 37)
        Me.Label_Role.Name = "Label_Role"
        Me.Label_Role.Size = New System.Drawing.Size(0, 13)
        Me.Label_Role.TabIndex = 87
        Me.Label_Role.Visible = False
        '
        'TB_StatusQ
        '
        Me.TB_StatusQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_StatusQ.Location = New System.Drawing.Point(174, 500)
        Me.TB_StatusQ.Name = "TB_StatusQ"
        Me.TB_StatusQ.Size = New System.Drawing.Size(148, 24)
        Me.TB_StatusQ.TabIndex = 88
        Me.TB_StatusQ.Text = "CLOSED"
        Me.TB_StatusQ.Visible = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(779, 679)
        Me.Controls.Add(Me.TB_StatusQ)
        Me.Controls.Add(Me.Label_Role)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label_Modify)
        Me.Controls.Add(Me.Label_Save)
        Me.Controls.Add(Me.Date_QCurrentdate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.TB_InvoiceID)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label_Status)
        Me.Controls.Add(Me.Label_QStatus)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TB_QOther)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_CreateInvoice)
        Me.Controls.Add(Me.Btn_New)
        Me.Controls.Add(Me.Label21)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoices"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TB_QOther As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents Btn_CreateInvoice As System.Windows.Forms.Button
    Friend WithEvents Btn_New As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TB_QTotalamount As System.Windows.Forms.TextBox
    Friend WithEvents TB_QTaxrate As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
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
    Friend WithEvents Label18 As System.Windows.Forms.Label
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
    Friend WithEvents TB_QSalestax As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotationListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TB_QSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CB_Status As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label_QStatus As System.Windows.Forms.Label
    Friend WithEvents Label_Status As System.Windows.Forms.Label
    Friend WithEvents TB_IShipvia As System.Windows.Forms.TextBox
    Friend WithEvents BackToMainMenuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TB_InvoiceID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Date_QShipdate As System.Windows.Forms.TextBox
    Friend WithEvents Date_QCurrentdate As System.Windows.Forms.TextBox
    Friend WithEvents Label_Modify As System.Windows.Forms.Label
    Friend WithEvents Label_Save As System.Windows.Forms.Label
    Friend WithEvents InventoryDataSet10 As SWW_Inventory.inventoryDataSet10
    Friend WithEvents InvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceTableAdapter As SWW_Inventory.inventoryDataSet10TableAdapters.invoiceTableAdapter
    Friend WithEvents InvoiceIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalesTaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipViaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalesPersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TermsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerCompanyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerTinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceSavedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceLastModifyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_Role As System.Windows.Forms.Label
    Friend WithEvents DisplayReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TB_StatusQ As TextBox
End Class
