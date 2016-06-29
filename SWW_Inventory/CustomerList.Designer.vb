<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerList))
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
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet16 = New SWW_Inventory.inventoryDataSet16()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_Name = New System.Windows.Forms.CheckBox()
        Me.CB_Address = New System.Windows.Forms.CheckBox()
        Me.TB_Search = New System.Windows.Forms.TextBox()
        Me.CustomersTableAdapter1 = New SWW_Inventory.inventoryDataSet16TableAdapters.customersTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerCompanyDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerAddressDataGridViewTextBoxColumn, Me.CustomerPhoneDataGridViewTextBoxColumn, Me.CustomerTINDataGridViewTextBoxColumn, Me.CustomerRemarksDataGridViewTextBoxColumn, Me.CustomerSavedDataGridViewTextBoxColumn, Me.CustomerModifyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(695, 451)
        Me.DataGridView1.TabIndex = 0
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
        Me.CustomerTINDataGridViewTextBoxColumn.HeaderText = "Customer TIN"
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
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "customers"
        Me.CustomersBindingSource1.DataSource = Me.InventoryDataSet16
        '
        'InventoryDataSet16
        '
        Me.InventoryDataSet16.DataSetName = "inventoryDataSet16"
        Me.InventoryDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        '
        'CB_Name
        '
        Me.CB_Name.AutoSize = True
        Me.CB_Name.BackColor = System.Drawing.Color.Transparent
        Me.CB_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Name.Location = New System.Drawing.Point(24, 24)
        Me.CB_Name.Name = "CB_Name"
        Me.CB_Name.Size = New System.Drawing.Size(71, 22)
        Me.CB_Name.TabIndex = 1
        Me.CB_Name.Text = "Name"
        Me.CB_Name.UseVisualStyleBackColor = False
        '
        'CB_Address
        '
        Me.CB_Address.AutoSize = True
        Me.CB_Address.BackColor = System.Drawing.Color.Transparent
        Me.CB_Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Address.Location = New System.Drawing.Point(113, 24)
        Me.CB_Address.Name = "CB_Address"
        Me.CB_Address.Size = New System.Drawing.Size(88, 22)
        Me.CB_Address.TabIndex = 2
        Me.CB_Address.Text = "Address"
        Me.CB_Address.UseVisualStyleBackColor = False
        '
        'TB_Search
        '
        Me.TB_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Search.Location = New System.Drawing.Point(219, 22)
        Me.TB_Search.Name = "TB_Search"
        Me.TB_Search.Size = New System.Drawing.Size(386, 24)
        Me.TB_Search.TabIndex = 3
        '
        'CustomersTableAdapter1
        '
        Me.CustomersTableAdapter1.ClearBeforeFill = True
        '
        'CustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(695, 520)
        Me.Controls.Add(Me.TB_Search)
        Me.Controls.Add(Me.CB_Address)
        Me.Controls.Add(Me.CB_Name)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CustomerList"
        Me.Text = "Customer List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CB_Name As System.Windows.Forms.CheckBox
    Friend WithEvents CB_Address As System.Windows.Forms.CheckBox
    Friend WithEvents TB_Search As System.Windows.Forms.TextBox
    Friend WithEvents InventoryDataSet16 As inventoryDataSet16
    Friend WithEvents CustomersBindingSource1 As BindingSource
    Friend WithEvents CustomersTableAdapter1 As inventoryDataSet16TableAdapters.customersTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerCompanyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerTINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerRemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerSavedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerModifyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
