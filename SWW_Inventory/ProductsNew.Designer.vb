<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsNew
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductsNew))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_DeleteProd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_UpdateProd = New System.Windows.Forms.Button()
        Me.Btn_SaveProd = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PB_Search = New System.Windows.Forms.PictureBox()
        Me.TB_EncodedData = New System.Windows.Forms.TextBox()
        Me.BTN_ClearBar = New System.Windows.Forms.Button()
        Me.Label_barcode = New System.Windows.Forms.Label()
        Me.TB_InputData = New System.Windows.Forms.TextBox()
        Me.BTN_CreateBar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_PI_ProdCateg = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_PI_ProdSize = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_PI_ProdColor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdQuant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_PI_ProdID = New System.Windows.Forms.TextBox()
        Me.Label_PI_ID = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProductListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.PB_Search)
        Me.GroupBox2.Controls.Add(Me.TB_EncodedData)
        Me.GroupBox2.Controls.Add(Me.BTN_ClearBar)
        Me.GroupBox2.Controls.Add(Me.Label_barcode)
        Me.GroupBox2.Controls.Add(Me.TB_InputData)
        Me.GroupBox2.Controls.Add(Me.BTN_CreateBar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdPrice)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CB_PI_ProdCateg)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.CB_PI_ProdSize)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CB_PI_ProdColor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdQuant)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdDesc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_PI_ProdID)
        Me.GroupBox2.Controls.Add(Me.Label_PI_ID)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(900, 395)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRODUCT INFORMATION"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_DeleteProd)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Btn_UpdateProd)
        Me.GroupBox1.Controls.Add(Me.Btn_SaveProd)
        Me.GroupBox1.Location = New System.Drawing.Point(485, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 77)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'Btn_DeleteProd
        '
        Me.Btn_DeleteProd.BackColor = System.Drawing.Color.DimGray
        Me.Btn_DeleteProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_DeleteProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_DeleteProd.Location = New System.Drawing.Point(303, 21)
        Me.Btn_DeleteProd.Name = "Btn_DeleteProd"
        Me.Btn_DeleteProd.Size = New System.Drawing.Size(93, 47)
        Me.Btn_DeleteProd.TabIndex = 61
        Me.Btn_DeleteProd.Text = "DELETE"
        Me.Btn_DeleteProd.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(6, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 47)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "NEW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_UpdateProd
        '
        Me.Btn_UpdateProd.BackColor = System.Drawing.Color.DimGray
        Me.Btn_UpdateProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_UpdateProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_UpdateProd.Location = New System.Drawing.Point(204, 21)
        Me.Btn_UpdateProd.Name = "Btn_UpdateProd"
        Me.Btn_UpdateProd.Size = New System.Drawing.Size(93, 47)
        Me.Btn_UpdateProd.TabIndex = 60
        Me.Btn_UpdateProd.Text = "UPDATE"
        Me.Btn_UpdateProd.UseVisualStyleBackColor = False
        '
        'Btn_SaveProd
        '
        Me.Btn_SaveProd.BackColor = System.Drawing.Color.DimGray
        Me.Btn_SaveProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_SaveProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_SaveProd.Location = New System.Drawing.Point(105, 21)
        Me.Btn_SaveProd.Name = "Btn_SaveProd"
        Me.Btn_SaveProd.Size = New System.Drawing.Size(93, 47)
        Me.Btn_SaveProd.TabIndex = 59
        Me.Btn_SaveProd.Text = "SAVE"
        Me.Btn_SaveProd.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(189, 207)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(245, 29)
        Me.TextBox4.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 21)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Supplier"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(189, 173)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(245, 29)
        Me.TextBox3.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 21)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Manufacturer"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(189, 348)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(195, 29)
        Me.TextBox2.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 21)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Sale Price"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(189, 312)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 29)
        Me.TextBox1.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 312)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 21)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "List Price"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(382, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PB_Search
        '
        Me.PB_Search.Image = CType(resources.GetObject("PB_Search.Image"), System.Drawing.Image)
        Me.PB_Search.Location = New System.Drawing.Point(420, 37)
        Me.PB_Search.Name = "PB_Search"
        Me.PB_Search.Size = New System.Drawing.Size(37, 29)
        Me.PB_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Search.TabIndex = 47
        Me.PB_Search.TabStop = False
        '
        'TB_EncodedData
        '
        Me.TB_EncodedData.Location = New System.Drawing.Point(679, 179)
        Me.TB_EncodedData.Name = "TB_EncodedData"
        Me.TB_EncodedData.Size = New System.Drawing.Size(188, 29)
        Me.TB_EncodedData.TabIndex = 46
        Me.TB_EncodedData.Visible = False
        '
        'BTN_ClearBar
        '
        Me.BTN_ClearBar.BackColor = System.Drawing.Color.DimGray
        Me.BTN_ClearBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ClearBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_ClearBar.Location = New System.Drawing.Point(534, 233)
        Me.BTN_ClearBar.Name = "BTN_ClearBar"
        Me.BTN_ClearBar.Size = New System.Drawing.Size(97, 49)
        Me.BTN_ClearBar.TabIndex = 45
        Me.BTN_ClearBar.Text = "CLEAR BARCODE"
        Me.BTN_ClearBar.UseVisualStyleBackColor = False
        '
        'Label_barcode
        '
        Me.Label_barcode.Font = New System.Drawing.Font("Free 3 of 9 Extended", 96.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_barcode.Location = New System.Drawing.Point(667, 184)
        Me.Label_barcode.Name = "Label_barcode"
        Me.Label_barcode.Size = New System.Drawing.Size(256, 107)
        Me.Label_barcode.TabIndex = 44
        '
        'TB_InputData
        '
        Me.TB_InputData.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_InputData.Location = New System.Drawing.Point(679, 142)
        Me.TB_InputData.Name = "TB_InputData"
        Me.TB_InputData.Size = New System.Drawing.Size(203, 29)
        Me.TB_InputData.TabIndex = 41
        '
        'BTN_CreateBar
        '
        Me.BTN_CreateBar.BackColor = System.Drawing.Color.DimGray
        Me.BTN_CreateBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CreateBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTN_CreateBar.Location = New System.Drawing.Point(534, 179)
        Me.BTN_CreateBar.Name = "BTN_CreateBar"
        Me.BTN_CreateBar.Size = New System.Drawing.Size(97, 49)
        Me.BTN_CreateBar.TabIndex = 40
        Me.BTN_CreateBar.Text = "CREATE BARCODE"
        Me.BTN_CreateBar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(516, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 21)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Barcode"
        '
        'TB_PI_ProdPrice
        '
        Me.TB_PI_ProdPrice.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdPrice.Location = New System.Drawing.Point(189, 277)
        Me.TB_PI_ProdPrice.Name = "TB_PI_ProdPrice"
        Me.TB_PI_ProdPrice.Size = New System.Drawing.Size(195, 29)
        Me.TB_PI_ProdPrice.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Cost Price"
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
        Me.Label6.Size = New System.Drawing.Size(80, 21)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Category"
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
        Me.Label5.Size = New System.Drawing.Size(41, 21)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Size"
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
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Color"
        '
        'TB_PI_ProdQuant
        '
        Me.TB_PI_ProdQuant.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdQuant.Location = New System.Drawing.Point(189, 242)
        Me.TB_PI_ProdQuant.Name = "TB_PI_ProdQuant"
        Me.TB_PI_ProdQuant.Size = New System.Drawing.Size(195, 29)
        Me.TB_PI_ProdQuant.TabIndex = 30
        Me.TB_PI_ProdQuant.Text = "   "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Quantity"
        '
        'TB_PI_ProdDesc
        '
        Me.TB_PI_ProdDesc.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdDesc.Location = New System.Drawing.Point(189, 105)
        Me.TB_PI_ProdDesc.Multiline = True
        Me.TB_PI_ProdDesc.Name = "TB_PI_ProdDesc"
        Me.TB_PI_ProdDesc.Size = New System.Drawing.Size(292, 62)
        Me.TB_PI_ProdDesc.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Description"
        '
        'TB_PI_ProdName
        '
        Me.TB_PI_ProdName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdName.Location = New System.Drawing.Point(189, 71)
        Me.TB_PI_ProdName.Name = "TB_PI_ProdName"
        Me.TB_PI_ProdName.Size = New System.Drawing.Size(292, 29)
        Me.TB_PI_ProdName.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Name"
        '
        'TB_PI_ProdID
        '
        Me.TB_PI_ProdID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PI_ProdID.Location = New System.Drawing.Point(189, 37)
        Me.TB_PI_ProdID.Name = "TB_PI_ProdID"
        Me.TB_PI_ProdID.Size = New System.Drawing.Size(195, 29)
        Me.TB_PI_ProdID.TabIndex = 24
        '
        'Label_PI_ID
        '
        Me.Label_PI_ID.AutoSize = True
        Me.Label_PI_ID.BackColor = System.Drawing.Color.Transparent
        Me.Label_PI_ID.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PI_ID.Location = New System.Drawing.Point(6, 37)
        Me.Label_PI_ID.Name = "Label_PI_ID"
        Me.Label_PI_ID.Size = New System.Drawing.Size(61, 21)
        Me.Label_PI_ID.TabIndex = 23
        Me.Label_PI_ID.Text = "Search"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewProductListToolStripMenuItem, Me.BackToMainMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(919, 25)
        Me.MenuStrip1.TabIndex = 54
        Me.MenuStrip1.Text = "Export to Excel"
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
        'ViewProductListToolStripMenuItem
        '
        Me.ViewProductListToolStripMenuItem.Name = "ViewProductListToolStripMenuItem"
        Me.ViewProductListToolStripMenuItem.Size = New System.Drawing.Size(119, 21)
        Me.ViewProductListToolStripMenuItem.Text = "View Product List"
        '
        'BackToMainMenuToolStripMenuItem
        '
        Me.BackToMainMenuToolStripMenuItem.Name = "BackToMainMenuToolStripMenuItem"
        Me.BackToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.BackToMainMenuToolStripMenuItem.Text = "Back to Main Menu"
        '
        'ProductsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SWW_Inventory.My.Resources.Resources.gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(919, 451)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductsNew"
        Me.Text = "Products"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_DeleteProd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Btn_UpdateProd As Button
    Friend WithEvents Btn_SaveProd As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PB_Search As PictureBox
    Friend WithEvents TB_EncodedData As TextBox
    Friend WithEvents BTN_ClearBar As Button
    Friend WithEvents Label_barcode As Label
    Friend WithEvents TB_InputData As TextBox
    Friend WithEvents BTN_CreateBar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TB_PI_ProdPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CB_PI_ProdCateg As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CB_PI_ProdSize As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_PI_ProdColor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_PI_ProdQuant As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_PI_ProdDesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TB_PI_ProdName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_PI_ProdID As TextBox
    Friend WithEvents Label_PI_ID As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProductListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackToMainMenuToolStripMenuItem As ToolStripMenuItem
End Class
