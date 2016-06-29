<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPanel))
        Me.PB_Products = New System.Windows.Forms.PictureBox()
        Me.PB_Customers = New System.Windows.Forms.PictureBox()
        Me.PB_Invoice = New System.Windows.Forms.PictureBox()
        Me.PB_Quotes = New System.Windows.Forms.PictureBox()
        Me.PB_Adduser = New System.Windows.Forms.PictureBox()
        Me.Label_DateCP = New System.Windows.Forms.Label()
        Me.Label_TimeCP = New System.Windows.Forms.Label()
        Me.PB_Calculator = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_Day_CP = New System.Windows.Forms.Label()
        Me.Label_Day1_CP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_Welcome_CP = New System.Windows.Forms.Label()
        Me.Label_Role = New System.Windows.Forms.Label()
        CType(Me.PB_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Quotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Adduser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Calculator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_Products
        '
        Me.PB_Products.BackColor = System.Drawing.Color.Transparent
        Me.PB_Products.Image = CType(resources.GetObject("PB_Products.Image"), System.Drawing.Image)
        Me.PB_Products.Location = New System.Drawing.Point(25, 110)
        Me.PB_Products.Name = "PB_Products"
        Me.PB_Products.Size = New System.Drawing.Size(198, 107)
        Me.PB_Products.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Products.TabIndex = 0
        Me.PB_Products.TabStop = False
        '
        'PB_Customers
        '
        Me.PB_Customers.BackColor = System.Drawing.Color.Transparent
        Me.PB_Customers.Image = CType(resources.GetObject("PB_Customers.Image"), System.Drawing.Image)
        Me.PB_Customers.Location = New System.Drawing.Point(229, 223)
        Me.PB_Customers.Name = "PB_Customers"
        Me.PB_Customers.Size = New System.Drawing.Size(198, 107)
        Me.PB_Customers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Customers.TabIndex = 1
        Me.PB_Customers.TabStop = False
        '
        'PB_Invoice
        '
        Me.PB_Invoice.BackColor = System.Drawing.Color.Transparent
        Me.PB_Invoice.Image = CType(resources.GetObject("PB_Invoice.Image"), System.Drawing.Image)
        Me.PB_Invoice.Location = New System.Drawing.Point(25, 223)
        Me.PB_Invoice.Name = "PB_Invoice"
        Me.PB_Invoice.Size = New System.Drawing.Size(198, 107)
        Me.PB_Invoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Invoice.TabIndex = 2
        Me.PB_Invoice.TabStop = False
        '
        'PB_Quotes
        '
        Me.PB_Quotes.BackColor = System.Drawing.Color.Transparent
        Me.PB_Quotes.Image = CType(resources.GetObject("PB_Quotes.Image"), System.Drawing.Image)
        Me.PB_Quotes.Location = New System.Drawing.Point(229, 110)
        Me.PB_Quotes.Name = "PB_Quotes"
        Me.PB_Quotes.Size = New System.Drawing.Size(198, 107)
        Me.PB_Quotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Quotes.TabIndex = 3
        Me.PB_Quotes.TabStop = False
        '
        'PB_Adduser
        '
        Me.PB_Adduser.BackColor = System.Drawing.Color.Transparent
        Me.PB_Adduser.Image = CType(resources.GetObject("PB_Adduser.Image"), System.Drawing.Image)
        Me.PB_Adduser.Location = New System.Drawing.Point(433, 110)
        Me.PB_Adduser.Name = "PB_Adduser"
        Me.PB_Adduser.Size = New System.Drawing.Size(198, 107)
        Me.PB_Adduser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Adduser.TabIndex = 4
        Me.PB_Adduser.TabStop = False
        '
        'Label_DateCP
        '
        Me.Label_DateCP.AutoSize = True
        Me.Label_DateCP.BackColor = System.Drawing.Color.Transparent
        Me.Label_DateCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DateCP.Location = New System.Drawing.Point(516, 21)
        Me.Label_DateCP.Name = "Label_DateCP"
        Me.Label_DateCP.Size = New System.Drawing.Size(0, 20)
        Me.Label_DateCP.TabIndex = 5
        '
        'Label_TimeCP
        '
        Me.Label_TimeCP.AutoSize = True
        Me.Label_TimeCP.BackColor = System.Drawing.Color.Transparent
        Me.Label_TimeCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TimeCP.Location = New System.Drawing.Point(516, 51)
        Me.Label_TimeCP.Name = "Label_TimeCP"
        Me.Label_TimeCP.Size = New System.Drawing.Size(0, 20)
        Me.Label_TimeCP.TabIndex = 6
        '
        'PB_Calculator
        '
        Me.PB_Calculator.BackColor = System.Drawing.Color.Transparent
        Me.PB_Calculator.Image = CType(resources.GetObject("PB_Calculator.Image"), System.Drawing.Image)
        Me.PB_Calculator.Location = New System.Drawing.Point(433, 223)
        Me.PB_Calculator.Name = "PB_Calculator"
        Me.PB_Calculator.Size = New System.Drawing.Size(198, 107)
        Me.PB_Calculator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Calculator.TabIndex = 7
        Me.PB_Calculator.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label_Day_CP
        '
        Me.Label_Day_CP.AutoSize = True
        Me.Label_Day_CP.BackColor = System.Drawing.Color.Transparent
        Me.Label_Day_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Day_CP.Location = New System.Drawing.Point(21, 51)
        Me.Label_Day_CP.Name = "Label_Day_CP"
        Me.Label_Day_CP.Size = New System.Drawing.Size(0, 20)
        Me.Label_Day_CP.TabIndex = 8
        '
        'Label_Day1_CP
        '
        Me.Label_Day1_CP.AutoSize = True
        Me.Label_Day1_CP.BackColor = System.Drawing.Color.Transparent
        Me.Label_Day1_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Day1_CP.Location = New System.Drawing.Point(89, 51)
        Me.Label_Day1_CP.Name = "Label_Day1_CP"
        Me.Label_Day1_CP.Size = New System.Drawing.Size(0, 20)
        Me.Label_Day1_CP.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Time:"
        '
        'Label_Welcome_CP
        '
        Me.Label_Welcome_CP.AutoSize = True
        Me.Label_Welcome_CP.BackColor = System.Drawing.Color.Transparent
        Me.Label_Welcome_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Welcome_CP.Location = New System.Drawing.Point(21, 21)
        Me.Label_Welcome_CP.Name = "Label_Welcome_CP"
        Me.Label_Welcome_CP.Size = New System.Drawing.Size(87, 20)
        Me.Label_Welcome_CP.TabIndex = 12
        Me.Label_Welcome_CP.Text = "Welcome!"
        '
        'Label_Role
        '
        Me.Label_Role.AutoSize = True
        Me.Label_Role.BackColor = System.Drawing.Color.Transparent
        Me.Label_Role.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Role.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label_Role.Location = New System.Drawing.Point(114, 21)
        Me.Label_Role.Name = "Label_Role"
        Me.Label_Role.Size = New System.Drawing.Size(0, 20)
        Me.Label_Role.TabIndex = 13
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 376)
        Me.Controls.Add(Me.Label_Role)
        Me.Controls.Add(Me.Label_Welcome_CP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_Day1_CP)
        Me.Controls.Add(Me.Label_Day_CP)
        Me.Controls.Add(Me.PB_Calculator)
        Me.Controls.Add(Me.Label_TimeCP)
        Me.Controls.Add(Me.Label_DateCP)
        Me.Controls.Add(Me.PB_Adduser)
        Me.Controls.Add(Me.PB_Quotes)
        Me.Controls.Add(Me.PB_Invoice)
        Me.Controls.Add(Me.PB_Customers)
        Me.Controls.Add(Me.PB_Products)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ControlPanel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PB_Products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Invoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Quotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Adduser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Calculator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PB_Products As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Customers As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Invoice As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Quotes As System.Windows.Forms.PictureBox
    Friend WithEvents PB_Adduser As System.Windows.Forms.PictureBox
    Friend WithEvents Label_DateCP As System.Windows.Forms.Label
    Friend WithEvents Label_TimeCP As System.Windows.Forms.Label
    Friend WithEvents PB_Calculator As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label_Day_CP As System.Windows.Forms.Label
    Friend WithEvents Label_Day1_CP As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_Welcome_CP As System.Windows.Forms.Label
    Friend WithEvents Label_Role As System.Windows.Forms.Label
End Class
