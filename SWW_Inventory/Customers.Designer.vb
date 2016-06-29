<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Orig_ID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_DeleteProd = New System.Windows.Forms.PictureBox()
        Me.Btn_NewProd = New System.Windows.Forms.PictureBox()
        Me.Btn_SaveProd = New System.Windows.Forms.PictureBox()
        Me.Btn_UpdateProd = New System.Windows.Forms.PictureBox()
        Me.Label_Modify = New System.Windows.Forms.Label()
        Me.Label_Save = New System.Windows.Forms.Label()
        Me.TB_Remarks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Tin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PB_Power = New System.Windows.Forms.PictureBox()
        Me.PB_Search = New System.Windows.Forms.PictureBox()
        Me.TB_Phone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_Address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Company = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_CustID = New System.Windows.Forms.TextBox()
        Me.Label_PI_ID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerCompanyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerRemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerSavedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerModifyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet12 = New SWW_Inventory.inventoryDataSet12()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersTableAdapter = New SWW_Inventory.inventoryDataSet12TableAdapters.customersTableAdapter()
        Me.Label_Role = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Btn_DeleteProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_NewProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_SaveProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_UpdateProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Power, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Orig_ID)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.Label_Modify)
        Me.GroupBox2.Controls.Add(Me.Label_Save)
        Me.GroupBox2.Controls.Add(Me.TB_Remarks)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TB_Tin)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.PB_Power)
        Me.GroupBox2.Controls.Add(Me.PB_Search)
        Me.GroupBox2.Controls.Add(Me.TB_Phone)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TB_Address)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TB_Name)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TB_Company)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_CustID)
        Me.GroupBox2.Controls.Add(Me.Label_PI_ID)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(861, 248)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUSTOMER INFORMATION"
        '
        'Orig_ID
        '
        Me.Orig_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orig_ID.Location = New System.Drawing.Point(146, 49)
        Me.Orig_ID.Name = "Orig_ID"
        Me.Orig_ID.Size = New System.Drawing.Size(38, 24)
        Me.Orig_ID.TabIndex = 188
        Me.Orig_ID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_DeleteProd)
        Me.GroupBox1.Controls.Add(Me.Btn_NewProd)
        Me.GroupBox1.Controls.Add(Me.Btn_SaveProd)
        Me.GroupBox1.Controls.Add(Me.Btn_UpdateProd)
        Me.GroupBox1.Location = New System.Drawing.Point(478, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 85)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'Btn_DeleteProd
        '
        Me.Btn_DeleteProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_DeleteProd.Image = CType(resources.GetObject("Btn_DeleteProd.Image"), System.Drawing.Image)
        Me.Btn_DeleteProd.Location = New System.Drawing.Point(279, 11)
        Me.Btn_DeleteProd.Name = "Btn_DeleteProd"
        Me.Btn_DeleteProd.Size = New System.Drawing.Size(92, 74)
        Me.Btn_DeleteProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_DeleteProd.TabIndex = 57
        Me.Btn_DeleteProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_DeleteProd, "Delete Customer")
        '
        'Btn_NewProd
        '
        Me.Btn_NewProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_NewProd.Image = CType(resources.GetObject("Btn_NewProd.Image"), System.Drawing.Image)
        Me.Btn_NewProd.Location = New System.Drawing.Point(0, 11)
        Me.Btn_NewProd.Name = "Btn_NewProd"
        Me.Btn_NewProd.Size = New System.Drawing.Size(92, 74)
        Me.Btn_NewProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_NewProd.TabIndex = 55
        Me.Btn_NewProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_NewProd, "Create New Customer")
        '
        'Btn_SaveProd
        '
        Me.Btn_SaveProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_SaveProd.Image = CType(resources.GetObject("Btn_SaveProd.Image"), System.Drawing.Image)
        Me.Btn_SaveProd.Location = New System.Drawing.Point(93, 11)
        Me.Btn_SaveProd.Name = "Btn_SaveProd"
        Me.Btn_SaveProd.Size = New System.Drawing.Size(92, 74)
        Me.Btn_SaveProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_SaveProd.TabIndex = 58
        Me.Btn_SaveProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_SaveProd, "Save")
        '
        'Btn_UpdateProd
        '
        Me.Btn_UpdateProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_UpdateProd.Image = CType(resources.GetObject("Btn_UpdateProd.Image"), System.Drawing.Image)
        Me.Btn_UpdateProd.Location = New System.Drawing.Point(186, 11)
        Me.Btn_UpdateProd.Name = "Btn_UpdateProd"
        Me.Btn_UpdateProd.Size = New System.Drawing.Size(92, 74)
        Me.Btn_UpdateProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_UpdateProd.TabIndex = 56
        Me.Btn_UpdateProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_UpdateProd, "Update Customer Info")
        '
        'Label_Modify
        '
        Me.Label_Modify.AutoSize = True
        Me.Label_Modify.Location = New System.Drawing.Point(653, 194)
        Me.Label_Modify.Name = "Label_Modify"
        Me.Label_Modify.Size = New System.Drawing.Size(0, 22)
        Me.Label_Modify.TabIndex = 54
        Me.Label_Modify.Visible = False
        '
        'Label_Save
        '
        Me.Label_Save.AutoSize = True
        Me.Label_Save.Location = New System.Drawing.Point(576, 194)
        Me.Label_Save.Name = "Label_Save"
        Me.Label_Save.Size = New System.Drawing.Size(0, 22)
        Me.Label_Save.TabIndex = 53
        Me.Label_Save.Visible = False
        '
        'TB_Remarks
        '
        Me.TB_Remarks.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Remarks.Location = New System.Drawing.Point(655, 122)
        Me.TB_Remarks.Name = "TB_Remarks"
        Me.TB_Remarks.Size = New System.Drawing.Size(195, 29)
        Me.TB_Remarks.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(474, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Customer Remarks"
        '
        'TB_Tin
        '
        Me.TB_Tin.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Tin.Location = New System.Drawing.Point(655, 84)
        Me.TB_Tin.Name = "TB_Tin"
        Me.TB_Tin.Size = New System.Drawing.Size(195, 29)
        Me.TB_Tin.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(474, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 21)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Customer TIN"
        '
        'PB_Power
        '
        Me.PB_Power.Image = CType(resources.GetObject("PB_Power.Image"), System.Drawing.Image)
        Me.PB_Power.Location = New System.Drawing.Point(383, 46)
        Me.PB_Power.Name = "PB_Power"
        Me.PB_Power.Size = New System.Drawing.Size(37, 31)
        Me.PB_Power.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Power.TabIndex = 48
        Me.PB_Power.TabStop = False
        '
        'PB_Search
        '
        Me.PB_Search.Image = Global.SWW_Inventory.My.Resources.Resources.search
        Me.PB_Search.Location = New System.Drawing.Point(421, 47)
        Me.PB_Search.Name = "PB_Search"
        Me.PB_Search.Size = New System.Drawing.Size(37, 29)
        Me.PB_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Search.TabIndex = 47
        Me.PB_Search.TabStop = False
        '
        'TB_Phone
        '
        Me.TB_Phone.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Phone.Location = New System.Drawing.Point(655, 48)
        Me.TB_Phone.Name = "TB_Phone"
        Me.TB_Phone.Size = New System.Drawing.Size(195, 29)
        Me.TB_Phone.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(474, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Customer Phone"
        '
        'TB_Address
        '
        Me.TB_Address.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Address.Location = New System.Drawing.Point(190, 159)
        Me.TB_Address.Multiline = True
        Me.TB_Address.Name = "TB_Address"
        Me.TB_Address.Size = New System.Drawing.Size(268, 79)
        Me.TB_Address.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Customer Address"
        '
        'TB_Name
        '
        Me.TB_Name.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Name.Location = New System.Drawing.Point(190, 121)
        Me.TB_Name.Name = "TB_Name"
        Me.TB_Name.Size = New System.Drawing.Size(268, 29)
        Me.TB_Name.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Customer Name"
        '
        'TB_Company
        '
        Me.TB_Company.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Company.Location = New System.Drawing.Point(190, 84)
        Me.TB_Company.Name = "TB_Company"
        Me.TB_Company.Size = New System.Drawing.Size(268, 29)
        Me.TB_Company.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Customer Company"
        '
        'TB_CustID
        '
        Me.TB_CustID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CustID.Location = New System.Drawing.Point(190, 48)
        Me.TB_CustID.Name = "TB_CustID"
        Me.TB_CustID.Size = New System.Drawing.Size(195, 29)
        Me.TB_CustID.TabIndex = 24
        '
        'Label_PI_ID
        '
        Me.Label_PI_ID.AutoSize = True
        Me.Label_PI_ID.BackColor = System.Drawing.Color.Transparent
        Me.Label_PI_ID.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PI_ID.Location = New System.Drawing.Point(9, 48)
        Me.Label_PI_ID.Name = "Label_PI_ID"
        Me.Label_PI_ID.Size = New System.Drawing.Size(104, 21)
        Me.Label_PI_ID.TabIndex = 23
        Me.Label_PI_ID.Text = "Customer ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerCompanyDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerAddressDataGridViewTextBoxColumn, Me.CustomerPhoneDataGridViewTextBoxColumn, Me.CustomerTINDataGridViewTextBoxColumn, Me.CustomerRemarksDataGridViewTextBoxColumn, Me.CustomerSavedDataGridViewTextBoxColumn, Me.CustomerModifyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(859, 219)
        Me.DataGridView1.TabIndex = 26
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
        Me.CustomerAddressDataGridViewTextBoxColumn.Width = 150
        '
        'CustomerPhoneDataGridViewTextBoxColumn
        '
        Me.CustomerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone"
        Me.CustomerPhoneDataGridViewTextBoxColumn.HeaderText = "Customer Phone"
        Me.CustomerPhoneDataGridViewTextBoxColumn.Name = "CustomerPhoneDataGridViewTextBoxColumn"
        Me.CustomerPhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerTINDataGridViewTextBoxColumn
        '
        Me.CustomerTINDataGridViewTextBoxColumn.DataPropertyName = "CustomerTIN"
        Me.CustomerTINDataGridViewTextBoxColumn.HeaderText = "Customer  TIN"
        Me.CustomerTINDataGridViewTextBoxColumn.Name = "CustomerTINDataGridViewTextBoxColumn"
        Me.CustomerTINDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerRemarksDataGridViewTextBoxColumn
        '
        Me.CustomerRemarksDataGridViewTextBoxColumn.DataPropertyName = "CustomerRemarks"
        Me.CustomerRemarksDataGridViewTextBoxColumn.HeaderText = "Customer Remarks"
        Me.CustomerRemarksDataGridViewTextBoxColumn.Name = "CustomerRemarksDataGridViewTextBoxColumn"
        Me.CustomerRemarksDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerRemarksDataGridViewTextBoxColumn.Width = 150
        '
        'CustomerSavedDataGridViewTextBoxColumn
        '
        Me.CustomerSavedDataGridViewTextBoxColumn.DataPropertyName = "CustomerSaved"
        Me.CustomerSavedDataGridViewTextBoxColumn.HeaderText = "Time & Date when Customer Info is saved"
        Me.CustomerSavedDataGridViewTextBoxColumn.Name = "CustomerSavedDataGridViewTextBoxColumn"
        Me.CustomerSavedDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerSavedDataGridViewTextBoxColumn.Width = 135
        '
        'CustomerModifyDataGridViewTextBoxColumn
        '
        Me.CustomerModifyDataGridViewTextBoxColumn.DataPropertyName = "CustomerModify"
        Me.CustomerModifyDataGridViewTextBoxColumn.HeaderText = "Last Modified"
        Me.CustomerModifyDataGridViewTextBoxColumn.Name = "CustomerModifyDataGridViewTextBoxColumn"
        Me.CustomerModifyDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerModifyDataGridViewTextBoxColumn.Width = 135
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.InventoryDataSet12
        '
        'InventoryDataSet12
        '
        Me.InventoryDataSet12.DataSetName = "inventoryDataSet12"
        Me.InventoryDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerListToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(863, 25)
        Me.MenuStrip1.TabIndex = 0
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
        'CustomerListToolStripMenuItem
        '
        Me.CustomerListToolStripMenuItem.Name = "CustomerListToolStripMenuItem"
        Me.CustomerListToolStripMenuItem.Size = New System.Drawing.Size(99, 21)
        Me.CustomerListToolStripMenuItem.Text = "Customer List"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'Label_Role
        '
        Me.Label_Role.AutoSize = True
        Me.Label_Role.Location = New System.Drawing.Point(521, 25)
        Me.Label_Role.Name = "Label_Role"
        Me.Label_Role.Size = New System.Drawing.Size(0, 13)
        Me.Label_Role.TabIndex = 52
        Me.Label_Role.Visible = False
        '
        'Customers
        '
        Me.AccessibleName = "96"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 517)
        Me.Controls.Add(Me.Label_Role)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Customers"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Btn_DeleteProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_NewProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_SaveProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_UpdateProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Power, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_Tin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PB_Power As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Search As System.Windows.Forms.PictureBox
    Friend WithEvents TB_Phone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_Address As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_Company As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_CustID As System.Windows.Forms.TextBox
    Friend WithEvents Label_PI_ID As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_Modify As System.Windows.Forms.Label
    Friend WithEvents Label_Save As System.Windows.Forms.Label
    Friend WithEvents InventoryDataSet12 As SWW_Inventory.inventoryDataSet12
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As SWW_Inventory.inventoryDataSet12TableAdapters.customersTableAdapter
    Friend WithEvents Label_Role As System.Windows.Forms.Label
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerCompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerTINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerRemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerSavedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerModifyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_DeleteProd As PictureBox
    Friend WithEvents Btn_SaveProd As PictureBox
    Friend WithEvents Btn_UpdateProd As PictureBox
    Friend WithEvents Btn_NewProd As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Orig_ID As TextBox
End Class
