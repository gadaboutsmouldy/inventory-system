<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Me.TB_Username = New System.Windows.Forms.TextBox()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.BT_SubmitLF = New System.Windows.Forms.Button()
        Me.PB_CloseLF = New System.Windows.Forms.PictureBox()
        Me.Label_WrongUserLF = New System.Windows.Forms.Label()
        Me.Label_WelcomeLogin = New System.Windows.Forms.Label()
        Me.Label_UsrnameLogin = New System.Windows.Forms.Label()
        Me.Label_PassLogin = New System.Windows.Forms.Label()
        Me.BT_ClearLF = New System.Windows.Forms.Button()
        Me.GB_Login = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Role = New System.Windows.Forms.TextBox()
        CType(Me.PB_CloseLF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'TB_Username
        '
        Me.TB_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Username.Location = New System.Drawing.Point(141, 53)
        Me.TB_Username.Name = "TB_Username"
        Me.TB_Username.Size = New System.Drawing.Size(216, 24)
        Me.TB_Username.TabIndex = 1
        '
        'TB_Password
        '
        Me.TB_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_Password.Location = New System.Drawing.Point(141, 97)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(216, 24)
        Me.TB_Password.TabIndex = 2
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'BT_SubmitLF
        '
        Me.BT_SubmitLF.BackColor = System.Drawing.Color.Teal
        Me.BT_SubmitLF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SubmitLF.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BT_SubmitLF.Location = New System.Drawing.Point(141, 156)
        Me.BT_SubmitLF.Name = "BT_SubmitLF"
        Me.BT_SubmitLF.Size = New System.Drawing.Size(89, 33)
        Me.BT_SubmitLF.TabIndex = 3
        Me.BT_SubmitLF.Text = "LOGIN"
        Me.BT_SubmitLF.UseVisualStyleBackColor = False
        '
        'PB_CloseLF
        '
        Me.PB_CloseLF.BackColor = System.Drawing.Color.Transparent
        Me.PB_CloseLF.Image = CType(resources.GetObject("PB_CloseLF.Image"), System.Drawing.Image)
        Me.PB_CloseLF.Location = New System.Drawing.Point(492, 0)
        Me.PB_CloseLF.Name = "PB_CloseLF"
        Me.PB_CloseLF.Size = New System.Drawing.Size(45, 45)
        Me.PB_CloseLF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PB_CloseLF.TabIndex = 4
        Me.PB_CloseLF.TabStop = False
        '
        'Label_WrongUserLF
        '
        Me.Label_WrongUserLF.AutoSize = True
        Me.Label_WrongUserLF.BackColor = System.Drawing.Color.Transparent
        Me.Label_WrongUserLF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_WrongUserLF.ForeColor = System.Drawing.Color.Maroon
        Me.Label_WrongUserLF.Location = New System.Drawing.Point(80, 16)
        Me.Label_WrongUserLF.Name = "Label_WrongUserLF"
        Me.Label_WrongUserLF.Size = New System.Drawing.Size(0, 20)
        Me.Label_WrongUserLF.TabIndex = 5
        '
        'Label_WelcomeLogin
        '
        Me.Label_WelcomeLogin.AutoSize = True
        Me.Label_WelcomeLogin.BackColor = System.Drawing.Color.Transparent
        Me.Label_WelcomeLogin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_WelcomeLogin.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_WelcomeLogin.Location = New System.Drawing.Point(68, 45)
        Me.Label_WelcomeLogin.Name = "Label_WelcomeLogin"
        Me.Label_WelcomeLogin.Size = New System.Drawing.Size(127, 25)
        Me.Label_WelcomeLogin.TabIndex = 6
        Me.Label_WelcomeLogin.Text = "Welcome!"
        '
        'Label_UsrnameLogin
        '
        Me.Label_UsrnameLogin.AutoSize = True
        Me.Label_UsrnameLogin.BackColor = System.Drawing.Color.Transparent
        Me.Label_UsrnameLogin.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_UsrnameLogin.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label_UsrnameLogin.Location = New System.Drawing.Point(22, 56)
        Me.Label_UsrnameLogin.Name = "Label_UsrnameLogin"
        Me.Label_UsrnameLogin.Size = New System.Drawing.Size(92, 18)
        Me.Label_UsrnameLogin.TabIndex = 8
        Me.Label_UsrnameLogin.Text = "Username"
        '
        'Label_PassLogin
        '
        Me.Label_PassLogin.AutoSize = True
        Me.Label_PassLogin.BackColor = System.Drawing.Color.Transparent
        Me.Label_PassLogin.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_PassLogin.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Label_PassLogin.Location = New System.Drawing.Point(22, 100)
        Me.Label_PassLogin.Name = "Label_PassLogin"
        Me.Label_PassLogin.Size = New System.Drawing.Size(88, 18)
        Me.Label_PassLogin.TabIndex = 9
        Me.Label_PassLogin.Text = "Password"
        '
        'BT_ClearLF
        '
        Me.BT_ClearLF.BackColor = System.Drawing.Color.IndianRed
        Me.BT_ClearLF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ClearLF.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BT_ClearLF.Location = New System.Drawing.Point(268, 156)
        Me.BT_ClearLF.Name = "BT_ClearLF"
        Me.BT_ClearLF.Size = New System.Drawing.Size(89, 33)
        Me.BT_ClearLF.TabIndex = 10
        Me.BT_ClearLF.Text = "CLEAR"
        Me.BT_ClearLF.UseVisualStyleBackColor = False
        '
        'GB_Login
        '
        Me.GB_Login.BackColor = System.Drawing.Color.Transparent
        Me.GB_Login.Controls.Add(Me.TB_Username)
        Me.GB_Login.Controls.Add(Me.BT_ClearLF)
        Me.GB_Login.Controls.Add(Me.Label_WrongUserLF)
        Me.GB_Login.Controls.Add(Me.TB_Password)
        Me.GB_Login.Controls.Add(Me.Label_PassLogin)
        Me.GB_Login.Controls.Add(Me.Label_UsrnameLogin)
        Me.GB_Login.Controls.Add(Me.BT_SubmitLF)
        Me.GB_Login.Location = New System.Drawing.Point(73, 73)
        Me.GB_Login.Name = "GB_Login"
        Me.GB_Login.Size = New System.Drawing.Size(394, 236)
        Me.GB_Login.TabIndex = 11
        Me.GB_Login.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(390, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Visible = False
        '
        'TB_Role
        '
        Me.TB_Role.Location = New System.Drawing.Point(437, 342)
        Me.TB_Role.Name = "TB_Role"
        Me.TB_Role.Size = New System.Drawing.Size(100, 20)
        Me.TB_Role.TabIndex = 13
        Me.TB_Role.Visible = False
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(536, 361)
        Me.Controls.Add(Me.TB_Role)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GB_Login)
        Me.Controls.Add(Me.Label_WelcomeLogin)
        Me.Controls.Add(Me.PB_CloseLF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PB_CloseLF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Login.ResumeLayout(False)
        Me.GB_Login.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_Username As System.Windows.Forms.TextBox
    Friend WithEvents TB_Password As System.Windows.Forms.TextBox
    Friend WithEvents BT_SubmitLF As System.Windows.Forms.Button
    Friend WithEvents PB_CloseLF As System.Windows.Forms.PictureBox
    Friend WithEvents Label_WrongUserLF As System.Windows.Forms.Label
    Friend WithEvents Label_WelcomeLogin As System.Windows.Forms.Label
    Friend WithEvents Label_UsrnameLogin As System.Windows.Forms.Label
    Friend WithEvents Label_PassLogin As System.Windows.Forms.Label
    Friend WithEvents BT_ClearLF As System.Windows.Forms.Button
    Friend WithEvents GB_Login As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_Role As System.Windows.Forms.TextBox
End Class
