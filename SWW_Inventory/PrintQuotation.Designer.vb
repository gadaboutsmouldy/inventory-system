<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintQuotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintQuotation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_QuotationID = New System.Windows.Forms.Label()
        Me.QuotationDate = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProdName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CurrentStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TB_QTerms = New System.Windows.Forms.Label()
        Me.TB_QSalesperson = New System.Windows.Forms.Label()
        Me.TB_CNameS = New System.Windows.Forms.Label()
        Me.TB_CAddressS = New System.Windows.Forms.Label()
        Me.TB_CPhoneS = New System.Windows.Forms.Label()
        Me.TB_CCompany = New System.Windows.Forms.Label()
        Me.TB_CName = New System.Windows.Forms.Label()
        Me.TB_CAddress = New System.Windows.Forms.Label()
        Me.TB_CPhone = New System.Windows.Forms.Label()
        Me.CB_QShipvia = New System.Windows.Forms.Label()
        Me.Date_QShipdate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_QTotalamount = New System.Windows.Forms.Label()
        Me.TB_DiscountAmount = New System.Windows.Forms.Label()
        Me.TB_QOther = New System.Windows.Forms.Label()
        Me.TB_QSalestax = New System.Windows.Forms.Label()
        Me.TB_QTaxrate = New System.Windows.Forms.Label()
        Me.TB_QSubtotal = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.quo_date = New System.Windows.Forms.DateTimePicker()
        Me.quo_ship = New System.Windows.Forms.DateTimePicker()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.BTN_PRINT = New System.Windows.Forms.PictureBox()
        Me.BTN_Delete = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BTN_PRINT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(541, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 25)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "QUOTATION #"
        '
        'TB_QuotationID
        '
        Me.TB_QuotationID.AutoSize = True
        Me.TB_QuotationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QuotationID.Location = New System.Drawing.Point(702, 42)
        Me.TB_QuotationID.Name = "TB_QuotationID"
        Me.TB_QuotationID.Size = New System.Drawing.Size(77, 25)
        Me.TB_QuotationID.TabIndex = 218
        Me.TB_QuotationID.Text = "Label1"
        '
        'QuotationDate
        '
        Me.QuotationDate.AutoSize = True
        Me.QuotationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuotationDate.Location = New System.Drawing.Point(655, 9)
        Me.QuotationDate.Name = "QuotationDate"
        Me.QuotationDate.Size = New System.Drawing.Size(77, 25)
        Me.QuotationDate.TabIndex = 217
        Me.QuotationDate.Text = "Label1"
        '
        'ListView1
        '
        Me.ListView1.AutoArrange = False
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProdName, Me.Description, Me.Quantity, Me.Price, Me.Total, Me.ProductStock, Me.CurrentStock})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(1, 384)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Scrollable = False
        Me.ListView1.Size = New System.Drawing.Size(783, 290)
        Me.ListView1.TabIndex = 215
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        Me.ProductID.Text = "PROD. ID"
        Me.ProductID.Width = 92
        '
        'ProdName
        '
        Me.ProdName.Text = "PRODUCT NAME"
        Me.ProdName.Width = 202
        '
        'Description
        '
        Me.Description.Text = "DESCRIPTION"
        Me.Description.Width = 210
        '
        'Quantity
        '
        Me.Quantity.Text = "QTY"
        Me.Quantity.Width = 69
        '
        'Price
        '
        Me.Price.Text = "PRICE"
        Me.Price.Width = 98
        '
        'Total
        '
        Me.Total.Text = "TOTAL"
        Me.Total.Width = 111
        '
        'ProductStock
        '
        Me.ProductStock.Text = "Product Stock"
        Me.ProductStock.Width = 0
        '
        'CurrentStock
        '
        Me.CurrentStock.Text = "Current Stock"
        Me.CurrentStock.Width = 0
        '
        'TB_QTerms
        '
        Me.TB_QTerms.AutoSize = True
        Me.TB_QTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTerms.Location = New System.Drawing.Point(541, 302)
        Me.TB_QTerms.MaximumSize = New System.Drawing.Size(235, 24)
        Me.TB_QTerms.Name = "TB_QTerms"
        Me.TB_QTerms.Size = New System.Drawing.Size(51, 18)
        Me.TB_QTerms.TabIndex = 205
        Me.TB_QTerms.Text = "Label1"
        '
        'TB_QSalesperson
        '
        Me.TB_QSalesperson.AutoSize = True
        Me.TB_QSalesperson.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalesperson.Location = New System.Drawing.Point(541, 350)
        Me.TB_QSalesperson.MaximumSize = New System.Drawing.Size(235, 24)
        Me.TB_QSalesperson.Name = "TB_QSalesperson"
        Me.TB_QSalesperson.Size = New System.Drawing.Size(51, 18)
        Me.TB_QSalesperson.TabIndex = 204
        Me.TB_QSalesperson.Text = "Label1"
        '
        'TB_CNameS
        '
        Me.TB_CNameS.AutoSize = True
        Me.TB_CNameS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CNameS.Location = New System.Drawing.Point(541, 167)
        Me.TB_CNameS.MaximumSize = New System.Drawing.Size(235, 24)
        Me.TB_CNameS.Name = "TB_CNameS"
        Me.TB_CNameS.Size = New System.Drawing.Size(51, 18)
        Me.TB_CNameS.TabIndex = 203
        Me.TB_CNameS.Text = "Label1"
        '
        'TB_CAddressS
        '
        Me.TB_CAddressS.AutoSize = True
        Me.TB_CAddressS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAddressS.Location = New System.Drawing.Point(541, 197)
        Me.TB_CAddressS.MaximumSize = New System.Drawing.Size(229, 56)
        Me.TB_CAddressS.Name = "TB_CAddressS"
        Me.TB_CAddressS.Size = New System.Drawing.Size(51, 18)
        Me.TB_CAddressS.TabIndex = 202
        Me.TB_CAddressS.Text = "Label1"
        '
        'TB_CPhoneS
        '
        Me.TB_CPhoneS.AutoSize = True
        Me.TB_CPhoneS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CPhoneS.Location = New System.Drawing.Point(541, 261)
        Me.TB_CPhoneS.MaximumSize = New System.Drawing.Size(235, 24)
        Me.TB_CPhoneS.Name = "TB_CPhoneS"
        Me.TB_CPhoneS.Size = New System.Drawing.Size(51, 18)
        Me.TB_CPhoneS.TabIndex = 201
        Me.TB_CPhoneS.Text = "Label1"
        '
        'TB_CCompany
        '
        Me.TB_CCompany.AutoSize = True
        Me.TB_CCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CCompany.Location = New System.Drawing.Point(157, 167)
        Me.TB_CCompany.MaximumSize = New System.Drawing.Size(235, 24)
        Me.TB_CCompany.Name = "TB_CCompany"
        Me.TB_CCompany.Size = New System.Drawing.Size(51, 18)
        Me.TB_CCompany.TabIndex = 200
        Me.TB_CCompany.Text = "Label1"
        '
        'TB_CName
        '
        Me.TB_CName.AutoSize = True
        Me.TB_CName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CName.Location = New System.Drawing.Point(157, 195)
        Me.TB_CName.MaximumSize = New System.Drawing.Size(235, 24)
        Me.TB_CName.Name = "TB_CName"
        Me.TB_CName.Size = New System.Drawing.Size(51, 18)
        Me.TB_CName.TabIndex = 199
        Me.TB_CName.Text = "Label1"
        '
        'TB_CAddress
        '
        Me.TB_CAddress.AutoSize = True
        Me.TB_CAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAddress.Location = New System.Drawing.Point(157, 225)
        Me.TB_CAddress.MaximumSize = New System.Drawing.Size(229, 56)
        Me.TB_CAddress.Name = "TB_CAddress"
        Me.TB_CAddress.Size = New System.Drawing.Size(51, 18)
        Me.TB_CAddress.TabIndex = 198
        Me.TB_CAddress.Text = "Label1"
        '
        'TB_CPhone
        '
        Me.TB_CPhone.AutoSize = True
        Me.TB_CPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CPhone.Location = New System.Drawing.Point(157, 289)
        Me.TB_CPhone.MaximumSize = New System.Drawing.Size(235, 24)
        Me.TB_CPhone.Name = "TB_CPhone"
        Me.TB_CPhone.Size = New System.Drawing.Size(51, 18)
        Me.TB_CPhone.TabIndex = 197
        Me.TB_CPhone.Text = "Label1"
        '
        'CB_QShipvia
        '
        Me.CB_QShipvia.AutoSize = True
        Me.CB_QShipvia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_QShipvia.Location = New System.Drawing.Point(157, 350)
        Me.CB_QShipvia.MaximumSize = New System.Drawing.Size(235, 24)
        Me.CB_QShipvia.Name = "CB_QShipvia"
        Me.CB_QShipvia.Size = New System.Drawing.Size(51, 18)
        Me.CB_QShipvia.TabIndex = 196
        Me.CB_QShipvia.Text = "Label1"
        '
        'Date_QShipdate
        '
        Me.Date_QShipdate.AutoSize = True
        Me.Date_QShipdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_QShipdate.Location = New System.Drawing.Point(157, 321)
        Me.Date_QShipdate.MaximumSize = New System.Drawing.Size(235, 24)
        Me.Date_QShipdate.Name = "Date_QShipdate"
        Me.Date_QShipdate.Size = New System.Drawing.Size(51, 18)
        Me.Date_QShipdate.TabIndex = 195
        Me.Date_QShipdate.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 167)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 18)
        Me.Label25.TabIndex = 97
        Me.Label25.Text = "Company"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "BILLING ADDRESS:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(429, 350)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 18)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Sales Person"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(429, 302)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Comments"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 18)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "Ship Via"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 321)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 18)
        Me.Label15.TabIndex = 162
        Me.Label15.Text = "Ship Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(429, 197)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 18)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(429, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 18)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Recipient"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(429, 261)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Phone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(428, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "SHIPPING ADDRESS:"
        '
        'TB_QTotalamount
        '
        Me.TB_QTotalamount.AutoSize = True
        Me.TB_QTotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTotalamount.Location = New System.Drawing.Point(656, 854)
        Me.TB_QTotalamount.Name = "TB_QTotalamount"
        Me.TB_QTotalamount.Size = New System.Drawing.Size(63, 20)
        Me.TB_QTotalamount.TabIndex = 234
        Me.TB_QTotalamount.Text = "Label1"
        '
        'TB_DiscountAmount
        '
        Me.TB_DiscountAmount.AutoSize = True
        Me.TB_DiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DiscountAmount.Location = New System.Drawing.Point(657, 813)
        Me.TB_DiscountAmount.Name = "TB_DiscountAmount"
        Me.TB_DiscountAmount.Size = New System.Drawing.Size(59, 18)
        Me.TB_DiscountAmount.TabIndex = 233
        Me.TB_DiscountAmount.Text = "Label23"
        '
        'TB_QOther
        '
        Me.TB_QOther.AutoSize = True
        Me.TB_QOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QOther.Location = New System.Drawing.Point(657, 780)
        Me.TB_QOther.Name = "TB_QOther"
        Me.TB_QOther.Size = New System.Drawing.Size(59, 18)
        Me.TB_QOther.TabIndex = 232
        Me.TB_QOther.Text = "Label17"
        '
        'TB_QSalestax
        '
        Me.TB_QSalestax.AutoSize = True
        Me.TB_QSalestax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalestax.Location = New System.Drawing.Point(657, 751)
        Me.TB_QSalestax.Name = "TB_QSalestax"
        Me.TB_QSalestax.Size = New System.Drawing.Size(59, 18)
        Me.TB_QSalestax.TabIndex = 231
        Me.TB_QSalestax.Text = "Label16"
        '
        'TB_QTaxrate
        '
        Me.TB_QTaxrate.AutoSize = True
        Me.TB_QTaxrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTaxrate.Location = New System.Drawing.Point(657, 721)
        Me.TB_QTaxrate.Name = "TB_QTaxrate"
        Me.TB_QTaxrate.Size = New System.Drawing.Size(37, 18)
        Me.TB_QTaxrate.TabIndex = 230
        Me.TB_QTaxrate.Text = "12%"
        '
        'TB_QSubtotal
        '
        Me.TB_QSubtotal.AutoSize = True
        Me.TB_QSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSubtotal.Location = New System.Drawing.Point(657, 692)
        Me.TB_QSubtotal.Name = "TB_QSubtotal"
        Me.TB_QSubtotal.Size = New System.Drawing.Size(51, 18)
        Me.TB_QSubtotal.TabIndex = 229
        Me.TB_QSubtotal.Text = "Label1"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(586, 866)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 18)
        Me.Label29.TabIndex = 227
        Me.Label29.Text = "Amount"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(587, 822)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 18)
        Me.Label28.TabIndex = 226
        Me.Label28.Text = "Amount"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(581, 692)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 18)
        Me.Label21.TabIndex = 220
        Me.Label21.Text = "Subtotal"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(569, 751)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 18)
        Me.Label19.TabIndex = 222
        Me.Label19.Text = "Sales Tax"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(577, 804)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 18)
        Me.Label27.TabIndex = 225
        Me.Label27.Text = "Discount"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(559, 779)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 18)
        Me.Label22.TabIndex = 224
        Me.Label22.Text = "Other Fees"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(577, 721)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 18)
        Me.Label18.TabIndex = 221
        Me.Label18.Text = "Tax Rate"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(605, 848)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 18)
        Me.Label20.TabIndex = 223
        Me.Label20.Text = "Total"
        '
        'quo_date
        '
        Me.quo_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quo_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.quo_date.Location = New System.Drawing.Point(298, 29)
        Me.quo_date.Name = "quo_date"
        Me.quo_date.Size = New System.Drawing.Size(129, 24)
        Me.quo_date.TabIndex = 235
        '
        'quo_ship
        '
        Me.quo_ship.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quo_ship.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.quo_ship.Location = New System.Drawing.Point(298, 57)
        Me.quo_ship.Name = "quo_ship"
        Me.quo_ship.Size = New System.Drawing.Size(129, 24)
        Me.quo_ship.TabIndex = 236
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'BTN_PRINT
        '
        Me.BTN_PRINT.Image = CType(resources.GetObject("BTN_PRINT.Image"), System.Drawing.Image)
        Me.BTN_PRINT.Location = New System.Drawing.Point(1, 826)
        Me.BTN_PRINT.Name = "BTN_PRINT"
        Me.BTN_PRINT.Size = New System.Drawing.Size(86, 69)
        Me.BTN_PRINT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_PRINT.TabIndex = 237
        Me.BTN_PRINT.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BTN_PRINT, "Print")
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Image = Global.SWW_Inventory.My.Resources.Resources.logoKO
        Me.BTN_Delete.Location = New System.Drawing.Point(16, 0)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(193, 82)
        Me.BTN_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_Delete.TabIndex = 216
        Me.BTN_Delete.TabStop = False
        '
        'PrintQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(783, 897)
        Me.Controls.Add(Me.BTN_PRINT)
        Me.Controls.Add(Me.TB_QTerms)
        Me.Controls.Add(Me.quo_ship)
        Me.Controls.Add(Me.TB_QSalesperson)
        Me.Controls.Add(Me.TB_CNameS)
        Me.Controls.Add(Me.quo_date)
        Me.Controls.Add(Me.TB_CAddressS)
        Me.Controls.Add(Me.TB_QTotalamount)
        Me.Controls.Add(Me.TB_CPhoneS)
        Me.Controls.Add(Me.TB_DiscountAmount)
        Me.Controls.Add(Me.TB_CCompany)
        Me.Controls.Add(Me.TB_QOther)
        Me.Controls.Add(Me.TB_CName)
        Me.Controls.Add(Me.TB_QSalestax)
        Me.Controls.Add(Me.TB_CAddress)
        Me.Controls.Add(Me.TB_CPhone)
        Me.Controls.Add(Me.TB_QTaxrate)
        Me.Controls.Add(Me.CB_QShipvia)
        Me.Controls.Add(Me.TB_QSubtotal)
        Me.Controls.Add(Me.Date_QShipdate)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TB_QuotationID)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.QuotationDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BTN_Delete)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PrintQuotation"
        Me.Text = "Print Quotation"
        CType(Me.BTN_PRINT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TB_QuotationID As Label
    Friend WithEvents QuotationDate As Label
    Friend WithEvents BTN_Delete As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents ProductStock As ColumnHeader
    Friend WithEvents CurrentStock As ColumnHeader
    Friend WithEvents TB_QTerms As Label
    Friend WithEvents TB_QSalesperson As Label
    Friend WithEvents TB_CNameS As Label
    Friend WithEvents TB_CAddressS As Label
    Friend WithEvents TB_CPhoneS As Label
    Friend WithEvents TB_CCompany As Label
    Friend WithEvents TB_CName As Label
    Friend WithEvents TB_CAddress As Label
    Friend WithEvents TB_CPhone As Label
    Friend WithEvents CB_QShipvia As Label
    Friend WithEvents Date_QShipdate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_QTotalamount As Label
    Friend WithEvents TB_DiscountAmount As Label
    Friend WithEvents TB_QOther As Label
    Friend WithEvents TB_QSalestax As Label
    Friend WithEvents TB_QTaxrate As Label
    Friend WithEvents TB_QSubtotal As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents quo_date As DateTimePicker
    Friend WithEvents quo_ship As DateTimePicker
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents BTN_PRINT As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
