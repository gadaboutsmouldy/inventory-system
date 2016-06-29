<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryDataSet20 = New SWW_Inventory.inventoryDataSet20()
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Orig_ID = New System.Windows.Forms.TextBox()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L1 = New System.Windows.Forms.Label()
        Me.CB_Roles = New System.Windows.Forms.ComboBox()
        Me.PB_Power = New System.Windows.Forms.PictureBox()
        Me.PB_Search = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_UName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_UserID = New System.Windows.Forms.TextBox()
        Me.Label_PI_ID = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_Save = New System.Windows.Forms.Label()
        Me.Label_Modify = New System.Windows.Forms.Label()
        Me.Label_Role = New System.Windows.Forms.Label()
        Me.AdminTableAdapter1 = New SWW_Inventory.inventoryDataSet20TableAdapters.adminTableAdapter()
        Me.Btn_DeleteProd = New System.Windows.Forms.PictureBox()
        Me.Btn_SaveProd = New System.Windows.Forms.PictureBox()
        Me.Btn_UpdateProd = New System.Windows.Forms.PictureBox()
        Me.Btn_NewProd = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryDataSet20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PB_Power, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Btn_DeleteProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_SaveProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_UpdateProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_NewProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView1.DataSource = Me.AdminBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 358)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(349, 234)
        Me.DataGridView1.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "adminid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "adminuser"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "adminpass"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "lastlogin"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Last Login"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "adminroles"
        Me.DataGridViewTextBoxColumn5.HeaderText = "User Role"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "adminsaved"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Time & Date When the Info was saved"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "adminmodify"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Last Modified"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'AdminBindingSource1
        '
        Me.AdminBindingSource1.DataMember = "admin"
        Me.AdminBindingSource1.DataSource = Me.InventoryDataSet20
        '
        'InventoryDataSet20
        '
        Me.InventoryDataSet20.DataSetName = "inventoryDataSet20"
        Me.InventoryDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Orig_ID)
        Me.GroupBox2.Controls.Add(Me.L2)
        Me.GroupBox2.Controls.Add(Me.L1)
        Me.GroupBox2.Controls.Add(Me.CB_Roles)
        Me.GroupBox2.Controls.Add(Me.PB_Power)
        Me.GroupBox2.Controls.Add(Me.PB_Search)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TB_Pass)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TB_UName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_UserID)
        Me.GroupBox2.Controls.Add(Me.Label_PI_ID)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 236)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "USER INFORMATION"
        '
        'Orig_ID
        '
        Me.Orig_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Orig_ID.Location = New System.Drawing.Point(83, 50)
        Me.Orig_ID.Name = "Orig_ID"
        Me.Orig_ID.Size = New System.Drawing.Size(38, 24)
        Me.Orig_ID.TabIndex = 189
        Me.Orig_ID.Visible = False
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.BackColor = System.Drawing.Color.Transparent
        Me.L2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L2.Location = New System.Drawing.Point(138, 197)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(111, 21)
        Me.L2.TabIndex = 57
        Me.L2.Text = "Last Logged in"
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.Transparent
        Me.L1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.Location = New System.Drawing.Point(17, 197)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(124, 21)
        Me.L1.TabIndex = 56
        Me.L1.Text = "Last Logged in:"
        '
        'CB_Roles
        '
        Me.CB_Roles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Roles.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Roles.FormattingEnabled = True
        Me.CB_Roles.Items.AddRange(New Object() {"Administrator", "Supervisor", "General Employee"})
        Me.CB_Roles.Location = New System.Drawing.Point(123, 159)
        Me.CB_Roles.Name = "CB_Roles"
        Me.CB_Roles.Size = New System.Drawing.Size(200, 26)
        Me.CB_Roles.TabIndex = 55
        '
        'PB_Power
        '
        Me.PB_Power.Image = CType(resources.GetObject("PB_Power.Image"), System.Drawing.Image)
        Me.PB_Power.Location = New System.Drawing.Point(248, 47)
        Me.PB_Power.Name = "PB_Power"
        Me.PB_Power.Size = New System.Drawing.Size(37, 31)
        Me.PB_Power.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Power.TabIndex = 48
        Me.PB_Power.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PB_Power, "User Search Switch Button")
        '
        'PB_Search
        '
        Me.PB_Search.Image = Global.SWW_Inventory.My.Resources.Resources.search
        Me.PB_Search.Location = New System.Drawing.Point(286, 48)
        Me.PB_Search.Name = "PB_Search"
        Me.PB_Search.Size = New System.Drawing.Size(37, 29)
        Me.PB_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Search.TabIndex = 47
        Me.PB_Search.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PB_Search, "Search User ID")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "User Role"
        '
        'TB_Pass
        '
        Me.TB_Pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Pass.Location = New System.Drawing.Point(124, 123)
        Me.TB_Pass.Name = "TB_Pass"
        Me.TB_Pass.Size = New System.Drawing.Size(201, 24)
        Me.TB_Pass.TabIndex = 28
        Me.TB_Pass.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Password"
        '
        'TB_UName
        '
        Me.TB_UName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_UName.Location = New System.Drawing.Point(123, 86)
        Me.TB_UName.Name = "TB_UName"
        Me.TB_UName.Size = New System.Drawing.Size(202, 24)
        Me.TB_UName.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Username"
        '
        'TB_UserID
        '
        Me.TB_UserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_UserID.Location = New System.Drawing.Point(123, 50)
        Me.TB_UserID.Name = "TB_UserID"
        Me.TB_UserID.Size = New System.Drawing.Size(124, 24)
        Me.TB_UserID.TabIndex = 24
        '
        'Label_PI_ID
        '
        Me.Label_PI_ID.AutoSize = True
        Me.Label_PI_ID.BackColor = System.Drawing.Color.Transparent
        Me.Label_PI_ID.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PI_ID.Location = New System.Drawing.Point(17, 52)
        Me.Label_PI_ID.Name = "Label_PI_ID"
        Me.Label_PI_ID.Size = New System.Drawing.Size(65, 21)
        Me.Label_PI_ID.TabIndex = 23
        Me.Label_PI_ID.Text = "User ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(350, 25)
        Me.MenuStrip1.TabIndex = 36
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
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'Label_Save
        '
        Me.Label_Save.AutoSize = True
        Me.Label_Save.BackColor = System.Drawing.Color.Transparent
        Me.Label_Save.Location = New System.Drawing.Point(258, 31)
        Me.Label_Save.Name = "Label_Save"
        Me.Label_Save.Size = New System.Drawing.Size(0, 13)
        Me.Label_Save.TabIndex = 43
        Me.Label_Save.Visible = False
        '
        'Label_Modify
        '
        Me.Label_Modify.AutoSize = True
        Me.Label_Modify.BackColor = System.Drawing.Color.Transparent
        Me.Label_Modify.Location = New System.Drawing.Point(322, 31)
        Me.Label_Modify.Name = "Label_Modify"
        Me.Label_Modify.Size = New System.Drawing.Size(0, 13)
        Me.Label_Modify.TabIndex = 44
        Me.Label_Modify.Visible = False
        '
        'Label_Role
        '
        Me.Label_Role.AutoSize = True
        Me.Label_Role.Location = New System.Drawing.Point(361, 34)
        Me.Label_Role.Name = "Label_Role"
        Me.Label_Role.Size = New System.Drawing.Size(0, 13)
        Me.Label_Role.TabIndex = 59
        Me.Label_Role.Visible = False
        '
        'AdminTableAdapter1
        '
        Me.AdminTableAdapter1.ClearBeforeFill = True
        '
        'Btn_DeleteProd
        '
        Me.Btn_DeleteProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_DeleteProd.Image = CType(resources.GetObject("Btn_DeleteProd.Image"), System.Drawing.Image)
        Me.Btn_DeleteProd.Location = New System.Drawing.Point(261, 9)
        Me.Btn_DeleteProd.Name = "Btn_DeleteProd"
        Me.Btn_DeleteProd.Size = New System.Drawing.Size(84, 60)
        Me.Btn_DeleteProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_DeleteProd.TabIndex = 62
        Me.Btn_DeleteProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_DeleteProd, "Delete")
        '
        'Btn_SaveProd
        '
        Me.Btn_SaveProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_SaveProd.Image = CType(resources.GetObject("Btn_SaveProd.Image"), System.Drawing.Image)
        Me.Btn_SaveProd.Location = New System.Drawing.Point(90, 9)
        Me.Btn_SaveProd.Name = "Btn_SaveProd"
        Me.Btn_SaveProd.Size = New System.Drawing.Size(84, 60)
        Me.Btn_SaveProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_SaveProd.TabIndex = 63
        Me.Btn_SaveProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_SaveProd, "Save")
        '
        'Btn_UpdateProd
        '
        Me.Btn_UpdateProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_UpdateProd.Image = CType(resources.GetObject("Btn_UpdateProd.Image"), System.Drawing.Image)
        Me.Btn_UpdateProd.Location = New System.Drawing.Point(175, 9)
        Me.Btn_UpdateProd.Name = "Btn_UpdateProd"
        Me.Btn_UpdateProd.Size = New System.Drawing.Size(84, 60)
        Me.Btn_UpdateProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_UpdateProd.TabIndex = 61
        Me.Btn_UpdateProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_UpdateProd, "Update User Info")
        '
        'Btn_NewProd
        '
        Me.Btn_NewProd.BackColor = System.Drawing.Color.Transparent
        Me.Btn_NewProd.Image = CType(resources.GetObject("Btn_NewProd.Image"), System.Drawing.Image)
        Me.Btn_NewProd.Location = New System.Drawing.Point(4, 9)
        Me.Btn_NewProd.Name = "Btn_NewProd"
        Me.Btn_NewProd.Size = New System.Drawing.Size(84, 60)
        Me.Btn_NewProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_NewProd.TabIndex = 60
        Me.Btn_NewProd.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_NewProd, "Create New User")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Btn_NewProd)
        Me.GroupBox1.Controls.Add(Me.Btn_DeleteProd)
        Me.GroupBox1.Controls.Add(Me.Btn_SaveProd)
        Me.GroupBox1.Controls.Add(Me.Btn_UpdateProd)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 71)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(350, 592)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_Role)
        Me.Controls.Add(Me.Label_Modify)
        Me.Controls.Add(Me.Label_Save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Manage Users"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryDataSet20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PB_Power, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Btn_DeleteProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_SaveProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_UpdateProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_NewProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_Roles As System.Windows.Forms.ComboBox
    Friend WithEvents PB_Power As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Search As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_UName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_UserID As System.Windows.Forms.TextBox
    Friend WithEvents Label_PI_ID As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_Save As System.Windows.Forms.Label
    Friend WithEvents Label_Modify As System.Windows.Forms.Label
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label_Role As System.Windows.Forms.Label
    Friend WithEvents AdminidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminuserDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminpassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastloginDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminrolesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminsavedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdminmodifyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryDataSet20 As inventoryDataSet20
    Friend WithEvents AdminBindingSource1 As BindingSource
    Friend WithEvents AdminTableAdapter1 As inventoryDataSet20TableAdapters.adminTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Btn_DeleteProd As PictureBox
    Friend WithEvents Btn_SaveProd As PictureBox
    Friend WithEvents Btn_UpdateProd As PictureBox
    Friend WithEvents Btn_NewProd As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents L2 As Label
    Friend WithEvents L1 As Label
    Friend WithEvents Orig_ID As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
