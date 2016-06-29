<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_QTerms = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TB_CAddress = New System.Windows.Forms.TextBox()
        Me.TB_CName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_CPhone = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_QSalesperson = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Date_QShipdate = New System.Windows.Forms.DateTimePicker()
        Me.CB_QShipvia = New System.Windows.Forms.ComboBox()
        Me.TB_CCompany = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_CNameS = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_CAddressS = New System.Windows.Forms.TextBox()
        Me.TB_CPhoneS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PB_QuotationSearch = New System.Windows.Forms.PictureBox()
        Me.TB_QuotationID = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CB_InvoiceStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_CurrentQuoInvoStats = New System.Windows.Forms.TextBox()
        Me.TB_QuoInvoStats = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TB_QSubtotal = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_DiscountAmount = New System.Windows.Forms.TextBox()
        Me.TB_QSalestax = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TB_QTaxrate = New System.Windows.Forms.TextBox()
        Me.TB_QOther = New System.Windows.Forms.TextBox()
        Me.TB_QTotalamount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PB_SearchInvoice = New System.Windows.Forms.PictureBox()
        Me.TB_InvoiceID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_Delete = New System.Windows.Forms.PictureBox()
        Me.PB_New = New System.Windows.Forms.PictureBox()
        Me.Btn_Save = New System.Windows.Forms.PictureBox()
        Me.BTN_QUpdate = New System.Windows.Forms.PictureBox()
        Me.Label_Role = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ProductID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProdName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ProductStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CurrentStock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CB_Status = New System.Windows.Forms.TextBox()
        Me.Date_QCurrentdate = New System.Windows.Forms.DateTimePicker()
        Me.InvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.L1 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Orig_ID = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PB_QuotationSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_SearchInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BTN_Delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_New, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTN_QUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem, Me.DisplayReportsToolStripMenuItem, Me.PrintToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(845, 25)
        Me.MenuStrip1.TabIndex = 132
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(101, 21)
        Me.BackToMainMenuToolStripMenuItem.Text = "Quotation List"
        '
        'DisplayReportsToolStripMenuItem
        '
        Me.DisplayReportsToolStripMenuItem.Name = "DisplayReportsToolStripMenuItem"
        Me.DisplayReportsToolStripMenuItem.Size = New System.Drawing.Size(83, 21)
        Me.DisplayReportsToolStripMenuItem.Text = "Invoice List"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(135, 21)
        Me.PrintToolStripMenuItem.Text = "View && Print Invoice"
        '
        'BackToMainMenuToolStripMenuItem1
        '
        Me.BackToMainMenuToolStripMenuItem1.Name = "BackToMainMenuToolStripMenuItem1"
        Me.BackToMainMenuToolStripMenuItem1.Size = New System.Drawing.Size(132, 21)
        Me.BackToMainMenuToolStripMenuItem1.Text = "Back to Main Menu"
        '
        'TB_QTerms
        '
        Me.TB_QTerms.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTerms.Location = New System.Drawing.Point(585, 207)
        Me.TB_QTerms.Name = "TB_QTerms"
        Me.TB_QTerms.Size = New System.Drawing.Size(231, 24)
        Me.TB_QTerms.TabIndex = 159
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(449, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Comments"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TB_CAddress)
        Me.GroupBox3.Controls.Add(Me.TB_CName)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TB_CPhone)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TB_QSalesperson)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Date_QShipdate)
        Me.GroupBox3.Controls.Add(Me.CB_QShipvia)
        Me.GroupBox3.Controls.Add(Me.TB_QTerms)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TB_CCompany)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TB_CNameS)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TB_CAddressS)
        Me.GroupBox3.Controls.Add(Me.TB_CPhoneS)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(1, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(843, 273)
        Me.GroupBox3.TabIndex = 157
        Me.GroupBox3.TabStop = False
        '
        'TB_CAddress
        '
        Me.TB_CAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAddress.Location = New System.Drawing.Point(156, 113)
        Me.TB_CAddress.Multiline = True
        Me.TB_CAddress.Name = "TB_CAddress"
        Me.TB_CAddress.Size = New System.Drawing.Size(231, 59)
        Me.TB_CAddress.TabIndex = 5
        '
        'TB_CName
        '
        Me.TB_CName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CName.Location = New System.Drawing.Point(156, 84)
        Me.TB_CName.Name = "TB_CName"
        Me.TB_CName.Size = New System.Drawing.Size(231, 24)
        Me.TB_CName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 116)
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
        Me.Label2.Location = New System.Drawing.Point(18, 87)
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
        Me.Label4.Location = New System.Drawing.Point(18, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Phone"
        '
        'TB_CPhone
        '
        Me.TB_CPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CPhone.Location = New System.Drawing.Point(156, 177)
        Me.TB_CPhone.Name = "TB_CPhone"
        Me.TB_CPhone.Size = New System.Drawing.Size(145, 24)
        Me.TB_CPhone.TabIndex = 11
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(18, 58)
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
        Me.Label7.Location = New System.Drawing.Point(17, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "BILLING ADDRESS:"
        '
        'TB_QSalesperson
        '
        Me.TB_QSalesperson.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalesperson.Location = New System.Drawing.Point(585, 237)
        Me.TB_QSalesperson.Name = "TB_QSalesperson"
        Me.TB_QSalesperson.Size = New System.Drawing.Size(192, 24)
        Me.TB_QSalesperson.TabIndex = 165
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(449, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 18)
        Me.Label13.TabIndex = 164
        Me.Label13.Text = "Sales Person"
        '
        'Date_QShipdate
        '
        Me.Date_QShipdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_QShipdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_QShipdate.Location = New System.Drawing.Point(156, 208)
        Me.Date_QShipdate.Name = "Date_QShipdate"
        Me.Date_QShipdate.Size = New System.Drawing.Size(129, 24)
        Me.Date_QShipdate.TabIndex = 166
        '
        'CB_QShipvia
        '
        Me.CB_QShipvia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_QShipvia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_QShipvia.FormattingEnabled = True
        Me.CB_QShipvia.Items.AddRange(New Object() {"DHL", "FEDEX", "UPS", "LBC", "PICKUP IN STORE", "C.O.D"})
        Me.CB_QShipvia.Location = New System.Drawing.Point(156, 238)
        Me.CB_QShipvia.Name = "CB_QShipvia"
        Me.CB_QShipvia.Size = New System.Drawing.Size(164, 26)
        Me.CB_QShipvia.TabIndex = 167
        '
        'TB_CCompany
        '
        Me.TB_CCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CCompany.Location = New System.Drawing.Point(156, 55)
        Me.TB_CCompany.Name = "TB_CCompany"
        Me.TB_CCompany.Size = New System.Drawing.Size(253, 24)
        Me.TB_CCompany.TabIndex = 98
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 241)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 18)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "Ship Via"
        '
        'TB_CNameS
        '
        Me.TB_CNameS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CNameS.Location = New System.Drawing.Point(585, 55)
        Me.TB_CNameS.Name = "TB_CNameS"
        Me.TB_CNameS.Size = New System.Drawing.Size(231, 24)
        Me.TB_CNameS.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 212)
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
        Me.Label12.Location = New System.Drawing.Point(447, 87)
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
        Me.Label11.Location = New System.Drawing.Point(447, 58)
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
        Me.Label9.Location = New System.Drawing.Point(447, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Phone"
        '
        'TB_CAddressS
        '
        Me.TB_CAddressS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CAddressS.Location = New System.Drawing.Point(585, 84)
        Me.TB_CAddressS.Multiline = True
        Me.TB_CAddressS.Name = "TB_CAddressS"
        Me.TB_CAddressS.Size = New System.Drawing.Size(231, 59)
        Me.TB_CAddressS.TabIndex = 79
        '
        'TB_CPhoneS
        '
        Me.TB_CPhoneS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CPhoneS.Location = New System.Drawing.Point(585, 148)
        Me.TB_CPhoneS.Name = "TB_CPhoneS"
        Me.TB_CPhoneS.Size = New System.Drawing.Size(145, 24)
        Me.TB_CPhoneS.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(446, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "SHIPPING ADDRESS:"
        '
        'PB_QuotationSearch
        '
        Me.PB_QuotationSearch.BackColor = System.Drawing.Color.Transparent
        Me.PB_QuotationSearch.Image = Global.SWW_Inventory.My.Resources.Resources.search
        Me.PB_QuotationSearch.Location = New System.Drawing.Point(278, 47)
        Me.PB_QuotationSearch.Name = "PB_QuotationSearch"
        Me.PB_QuotationSearch.Size = New System.Drawing.Size(38, 28)
        Me.PB_QuotationSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_QuotationSearch.TabIndex = 147
        Me.PB_QuotationSearch.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PB_QuotationSearch, "Quotation ID Search")
        '
        'TB_QuotationID
        '
        Me.TB_QuotationID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QuotationID.Location = New System.Drawing.Point(164, 49)
        Me.TB_QuotationID.Name = "TB_QuotationID"
        Me.TB_QuotationID.Size = New System.Drawing.Size(111, 24)
        Me.TB_QuotationID.TabIndex = 146
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 53)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 18)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "Quotation ID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(518, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 18)
        Me.Label16.TabIndex = 144
        Me.Label16.Text = "Quotation Save Date"
        '
        'CB_InvoiceStatus
        '
        Me.CB_InvoiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_InvoiceStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_InvoiceStatus.FormattingEnabled = True
        Me.CB_InvoiceStatus.Items.AddRange(New Object() {"UNPAID", "PAID", "VOID"})
        Me.CB_InvoiceStatus.Location = New System.Drawing.Point(141, 703)
        Me.CB_InvoiceStatus.Name = "CB_InvoiceStatus"
        Me.CB_InvoiceStatus.Size = New System.Drawing.Size(145, 26)
        Me.CB_InvoiceStatus.TabIndex = 141
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 18)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Quotation Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TB_CurrentQuoInvoStats)
        Me.GroupBox1.Controls.Add(Me.TB_QuoInvoStats)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.TB_QSubtotal)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TB_DiscountAmount)
        Me.GroupBox1.Controls.Add(Me.TB_QSalestax)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TB_QTaxrate)
        Me.GroupBox1.Controls.Add(Me.TB_QOther)
        Me.GroupBox1.Controls.Add(Me.TB_QTotalamount)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Location = New System.Drawing.Point(366, 656)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 167)
        Me.GroupBox1.TabIndex = 168
        Me.GroupBox1.TabStop = False
        '
        'TB_CurrentQuoInvoStats
        '
        Me.TB_CurrentQuoInvoStats.Enabled = False
        Me.TB_CurrentQuoInvoStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CurrentQuoInvoStats.Location = New System.Drawing.Point(42, 16)
        Me.TB_CurrentQuoInvoStats.Name = "TB_CurrentQuoInvoStats"
        Me.TB_CurrentQuoInvoStats.Size = New System.Drawing.Size(129, 24)
        Me.TB_CurrentQuoInvoStats.TabIndex = 74
        Me.TB_CurrentQuoInvoStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TB_CurrentQuoInvoStats.Visible = False
        '
        'TB_QuoInvoStats
        '
        Me.TB_QuoInvoStats.Enabled = False
        Me.TB_QuoInvoStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QuoInvoStats.Location = New System.Drawing.Point(42, 0)
        Me.TB_QuoInvoStats.Name = "TB_QuoInvoStats"
        Me.TB_QuoInvoStats.Size = New System.Drawing.Size(129, 24)
        Me.TB_QuoInvoStats.TabIndex = 73
        Me.TB_QuoInvoStats.Text = "Yes"
        Me.TB_QuoInvoStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TB_QuoInvoStats.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(70, 64)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(91, 25)
        Me.Label29.TabIndex = 72
        Me.Label29.Text = "Amount"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(244, 142)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 18)
        Me.Label28.TabIndex = 71
        Me.Label28.Text = "Amount"
        '
        'TB_QSubtotal
        '
        Me.TB_QSubtotal.Enabled = False
        Me.TB_QSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSubtotal.Location = New System.Drawing.Point(336, 12)
        Me.TB_QSubtotal.Name = "TB_QSubtotal"
        Me.TB_QSubtotal.Size = New System.Drawing.Size(129, 24)
        Me.TB_QSubtotal.TabIndex = 57
        Me.TB_QSubtotal.Text = "0.00"
        Me.TB_QSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(238, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(70, 18)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Subtotal"
        '
        'TB_DiscountAmount
        '
        Me.TB_DiscountAmount.Enabled = False
        Me.TB_DiscountAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_DiscountAmount.Location = New System.Drawing.Point(336, 130)
        Me.TB_DiscountAmount.Name = "TB_DiscountAmount"
        Me.TB_DiscountAmount.Size = New System.Drawing.Size(129, 24)
        Me.TB_DiscountAmount.TabIndex = 70
        Me.TB_DiscountAmount.Text = "0.00"
        Me.TB_DiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TB_QSalestax
        '
        Me.TB_QSalestax.Enabled = False
        Me.TB_QSalestax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QSalestax.Location = New System.Drawing.Point(336, 70)
        Me.TB_QSalestax.Name = "TB_QSalestax"
        Me.TB_QSalestax.Size = New System.Drawing.Size(129, 24)
        Me.TB_QSalestax.TabIndex = 61
        Me.TB_QSalestax.Text = "0.00"
        Me.TB_QSalestax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(239, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 18)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Sales Tax"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(239, 124)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 18)
        Me.Label27.TabIndex = 69
        Me.Label27.Text = "Discount"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(238, 45)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 18)
        Me.Label18.TabIndex = 58
        Me.Label18.Text = "Tax Rate"
        '
        'TB_QTaxrate
        '
        Me.TB_QTaxrate.Enabled = False
        Me.TB_QTaxrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTaxrate.Location = New System.Drawing.Point(336, 41)
        Me.TB_QTaxrate.Name = "TB_QTaxrate"
        Me.TB_QTaxrate.Size = New System.Drawing.Size(129, 24)
        Me.TB_QTaxrate.TabIndex = 60
        Me.TB_QTaxrate.Text = "12%"
        Me.TB_QTaxrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TB_QOther
        '
        Me.TB_QOther.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QOther.Location = New System.Drawing.Point(336, 100)
        Me.TB_QOther.Name = "TB_QOther"
        Me.TB_QOther.Size = New System.Drawing.Size(129, 24)
        Me.TB_QOther.TabIndex = 65
        Me.TB_QOther.Text = "0.00"
        Me.TB_QOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TB_QTotalamount
        '
        Me.TB_QTotalamount.Enabled = False
        Me.TB_QTotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_QTotalamount.Location = New System.Drawing.Point(20, 92)
        Me.TB_QTotalamount.Name = "TB_QTotalamount"
        Me.TB_QTotalamount.Size = New System.Drawing.Size(189, 38)
        Me.TB_QTotalamount.TabIndex = 63
        Me.TB_QTotalamount.Text = "0.00"
        Me.TB_QTotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(82, 42)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 25)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Total"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(238, 102)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 18)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Other Fees"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.SWW_Inventory.My.Resources.Resources.Power_Button
        Me.PictureBox3.Location = New System.Drawing.Point(284, 668)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 175
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Invoice Search Switch Button")
        '
        'PB_SearchInvoice
        '
        Me.PB_SearchInvoice.BackColor = System.Drawing.Color.Transparent
        Me.PB_SearchInvoice.Image = Global.SWW_Inventory.My.Resources.Resources.search
        Me.PB_SearchInvoice.Location = New System.Drawing.Point(322, 670)
        Me.PB_SearchInvoice.Name = "PB_SearchInvoice"
        Me.PB_SearchInvoice.Size = New System.Drawing.Size(38, 28)
        Me.PB_SearchInvoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_SearchInvoice.TabIndex = 174
        Me.PB_SearchInvoice.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PB_SearchInvoice, "Invoice ID Search")
        '
        'TB_InvoiceID
        '
        Me.TB_InvoiceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_InvoiceID.Location = New System.Drawing.Point(141, 672)
        Me.TB_InvoiceID.Name = "TB_InvoiceID"
        Me.TB_InvoiceID.Size = New System.Drawing.Size(145, 24)
        Me.TB_InvoiceID.TabIndex = 173
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 675)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Invoice ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 706)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 18)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "Invoice Status"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BTN_Delete)
        Me.GroupBox2.Controls.Add(Me.PB_New)
        Me.GroupBox2.Controls.Add(Me.Btn_Save)
        Me.GroupBox2.Controls.Add(Me.BTN_QUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 767)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(359, 56)
        Me.GroupBox2.TabIndex = 176
        Me.GroupBox2.TabStop = False
        '
        'BTN_Delete
        '
        Me.BTN_Delete.Image = CType(resources.GetObject("BTN_Delete.Image"), System.Drawing.Image)
        Me.BTN_Delete.Location = New System.Drawing.Point(269, 8)
        Me.BTN_Delete.Name = "BTN_Delete"
        Me.BTN_Delete.Size = New System.Drawing.Size(89, 47)
        Me.BTN_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_Delete.TabIndex = 2
        Me.BTN_Delete.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BTN_Delete, "Delete")
        '
        'PB_New
        '
        Me.PB_New.Image = CType(resources.GetObject("PB_New.Image"), System.Drawing.Image)
        Me.PB_New.Location = New System.Drawing.Point(2, 8)
        Me.PB_New.Name = "PB_New"
        Me.PB_New.Size = New System.Drawing.Size(89, 47)
        Me.PB_New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_New.TabIndex = 0
        Me.PB_New.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PB_New, "Create New Invoice")
        '
        'Btn_Save
        '
        Me.Btn_Save.Image = CType(resources.GetObject("Btn_Save.Image"), System.Drawing.Image)
        Me.Btn_Save.Location = New System.Drawing.Point(91, 8)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(89, 47)
        Me.Btn_Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_Save.TabIndex = 3
        Me.Btn_Save.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_Save, "Save")
        '
        'BTN_QUpdate
        '
        Me.BTN_QUpdate.Image = CType(resources.GetObject("BTN_QUpdate.Image"), System.Drawing.Image)
        Me.BTN_QUpdate.Location = New System.Drawing.Point(180, 8)
        Me.BTN_QUpdate.Name = "BTN_QUpdate"
        Me.BTN_QUpdate.Size = New System.Drawing.Size(89, 47)
        Me.BTN_QUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTN_QUpdate.TabIndex = 1
        Me.BTN_QUpdate.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BTN_QUpdate, "Update Invoice")
        '
        'Label_Role
        '
        Me.Label_Role.AutoSize = True
        Me.Label_Role.Location = New System.Drawing.Point(472, 49)
        Me.Label_Role.Name = "Label_Role"
        Me.Label_Role.Size = New System.Drawing.Size(0, 13)
        Me.Label_Role.TabIndex = 177
        Me.Label_Role.Visible = False
        '
        'ListView1
        '
        Me.ListView1.AutoArrange = False
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductID, Me.ProdName, Me.Description, Me.Quantity, Me.Price, Me.Total, Me.ProductStock, Me.CurrentStock})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(1, 380)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(844, 273)
        Me.ListView1.TabIndex = 178
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ProductID
        '
        Me.ProductID.Text = "PRODUCT ID"
        Me.ProductID.Width = 106
        '
        'ProdName
        '
        Me.ProdName.Text = "PRODUCT NAME"
        Me.ProdName.Width = 169
        '
        'Description
        '
        Me.Description.Text = "DESCRIPTION"
        Me.Description.Width = 202
        '
        'Quantity
        '
        Me.Quantity.Text = "QUANTITY"
        Me.Quantity.Width = 96
        '
        'Price
        '
        Me.Price.Text = "PRICE"
        Me.Price.Width = 116
        '
        'Total
        '
        Me.Total.Text = "TOTAL"
        Me.Total.Width = 149
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
        'CB_Status
        '
        Me.CB_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Status.Location = New System.Drawing.Point(164, 80)
        Me.CB_Status.Name = "CB_Status"
        Me.CB_Status.Size = New System.Drawing.Size(145, 24)
        Me.CB_Status.TabIndex = 179
        '
        'Date_QCurrentdate
        '
        Me.Date_QCurrentdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_QCurrentdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_QCurrentdate.Location = New System.Drawing.Point(688, 80)
        Me.Date_QCurrentdate.Name = "Date_QCurrentdate"
        Me.Date_QCurrentdate.Size = New System.Drawing.Size(129, 24)
        Me.Date_QCurrentdate.TabIndex = 180
        '
        'InvoiceDate
        '
        Me.InvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.InvoiceDate.Location = New System.Drawing.Point(141, 737)
        Me.InvoiceDate.Name = "InvoiceDate"
        Me.InvoiceDate.Size = New System.Drawing.Size(129, 24)
        Me.InvoiceDate.TabIndex = 182
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.Transparent
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(32, 730)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(61, 18)
        Me.L1.TabIndex = 181
        Me.L1.Text = "Invoice"
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.BackColor = System.Drawing.Color.Transparent
        Me.L2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(21, 749)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(85, 18)
        Me.L2.TabIndex = 183
        Me.L2.Text = "Save Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(688, 49)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 24)
        Me.DateTimePicker1.TabIndex = 185
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(578, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 18)
        Me.Label17.TabIndex = 184
        Me.Label17.Text = "Current Date"
        '
        'Orig_ID
        '
        Me.Orig_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orig_ID.Location = New System.Drawing.Point(325, 704)
        Me.Orig_ID.Name = "Orig_ID"
        Me.Orig_ID.Size = New System.Drawing.Size(38, 24)
        Me.Orig_ID.TabIndex = 186
        Me.Orig_ID.Visible = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SWW_Inventory.My.Resources.Resources.gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 828)
        Me.Controls.Add(Me.Orig_ID)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.InvoiceDate)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Date_QCurrentdate)
        Me.Controls.Add(Me.CB_Status)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label_Role)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PB_SearchInvoice)
        Me.Controls.Add(Me.TB_InvoiceID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PB_QuotationSearch)
        Me.Controls.Add(Me.TB_QuotationID)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CB_InvoiceStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Invoice"
        Me.Text = "Invoice"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PB_QuotationSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_SearchInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.BTN_Delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_New, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTN_QUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TB_QTerms As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TB_CAddress As TextBox
    Friend WithEvents TB_CName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_CPhone As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TB_CCompany As TextBox
    Friend WithEvents TB_CNameS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_CAddressS As TextBox
    Friend WithEvents TB_CPhoneS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PB_QuotationSearch As PictureBox
    Friend WithEvents TB_QuotationID As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CB_InvoiceStatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents TB_DiscountAmount As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TB_QOther As TextBox
    Friend WithEvents TB_QSubtotal As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TB_QSalestax As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TB_QTaxrate As TextBox
    Friend WithEvents TB_QTotalamount As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Date_QShipdate As DateTimePicker
    Friend WithEvents CB_QShipvia As ComboBox
    Friend WithEvents TB_QSalesperson As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PB_SearchInvoice As PictureBox
    Friend WithEvents TB_InvoiceID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Save As PictureBox
    Friend WithEvents BTN_Delete As PictureBox
    Friend WithEvents BTN_QUpdate As PictureBox
    Friend WithEvents PB_New As PictureBox
    Friend WithEvents TB_QuoInvoStats As TextBox
    Friend WithEvents TB_CurrentQuoInvoStats As TextBox
    Friend WithEvents Label_Role As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ProductID As ColumnHeader
    Friend WithEvents ProdName As ColumnHeader
    Friend WithEvents Description As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents CB_Status As TextBox
    Friend WithEvents ProductStock As ColumnHeader
    Friend WithEvents CurrentStock As ColumnHeader
    Friend WithEvents Date_QCurrentdate As DateTimePicker
    Friend WithEvents InvoiceDate As DateTimePicker
    Friend WithEvents L1 As Label
    Friend WithEvents L2 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Orig_ID As TextBox
End Class
