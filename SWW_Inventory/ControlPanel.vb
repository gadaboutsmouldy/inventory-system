Public Class ControlPanel
    Public Property role As String
    Private Sub PB_Products_Click(sender As Object, e As EventArgs) Handles PB_Products.Click
        Dim objrole As New Products : objrole.rolep = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub
    Private Sub PB_Invoice_Click(sender As Object, e As EventArgs) Handles PB_Invoice.Click
        Dim objrole As New Invoice : objrole.rolei = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub
    Private Sub PB_Customers_Click(sender As Object, e As EventArgs) Handles PB_Customers.Click
        Dim objrole As New Customers : objrole.rolec = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub

    Private Sub PB_Quotes_Click(sender As Object, e As EventArgs) Handles PB_Quotes.Click
        Dim objrole As New Quotation : objrole.roleq = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub

    Private Sub PB_Adduser_Click(sender As Object, e As EventArgs) Handles PB_Adduser.Click
        Dim objrole As New Users : objrole.roleu = Label_Role.Text : objrole.Show() : Me.Close() : End Sub

    Private Sub ControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label_Role.Text = role
        Dim objrole As New ControlPanel
        If Label_Role.Text = "Supervisor" Then : PB_Adduser.Enabled = False : Label_Role.ForeColor = Color.DarkBlue : End If
        If Label_Role.Text = "General Employee" Then : PB_Adduser.Enabled = False : PB_Products.Enabled = False : PB_Customers.Enabled = False : Label_Role.ForeColor = Color.DarkSlateGray : End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_DateCP.Text = Date.Now.ToString("MMM dd, yyyy")
        Label_TimeCP.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub PB_Products_MouseHover(sender As Object, e As EventArgs) Handles PB_Products.MouseHover
        PB_Products.Image = My.Resources.products_hover
    End Sub

    Private Sub PB_Products_MouseLeave(sender As Object, e As EventArgs) Handles PB_Products.MouseLeave
        PB_Products.Image = My.Resources.products_idle
    End Sub

    Private Sub PB_Customers_MouseHover(sender As Object, e As EventArgs) Handles PB_Customers.MouseHover
        PB_Customers.Image = My.Resources.customers_hover
    End Sub

    Private Sub PB_Customers_MouseLeave(sender As Object, e As EventArgs) Handles PB_Customers.MouseLeave
        PB_Customers.Image = My.Resources.customers_idle
    End Sub

    Private Sub PB_Invoice_MouseHover(sender As Object, e As EventArgs) Handles PB_Invoice.MouseHover
        PB_Invoice.Image = My.Resources.invoice_hover
    End Sub

    Private Sub PB_Invoice_MouseLeave(sender As Object, e As EventArgs) Handles PB_Invoice.MouseLeave
        PB_Invoice.Image = My.Resources.invoice_idle
    End Sub

    Private Sub PB_Quotes_MouseHover(sender As Object, e As EventArgs) Handles PB_Quotes.MouseHover
        PB_Quotes.Image = My.Resources.quotation_hover
    End Sub

    Private Sub PB_Quotes_MouseLeave(sender As Object, e As EventArgs) Handles PB_Quotes.MouseLeave
        PB_Quotes.Image = My.Resources.quotation_idle
    End Sub

    Private Sub PB_Adduser_MouseHover(sender As Object, e As EventArgs) Handles PB_Adduser.MouseHover
        PB_Adduser.Image = My.Resources.user_hover
    End Sub

    Private Sub PB_Adduser_MouseLeave(sender As Object, e As EventArgs) Handles PB_Adduser.MouseLeave
        PB_Adduser.Image = My.Resources.user_idle
    End Sub
    Private Sub PB_Calculator_MouseHover(sender As Object, e As EventArgs) Handles PB_Calculator.MouseHover
        PB_Calculator.Image = My.Resources.calculator_hover
    End Sub

    Private Sub PB_Calculator_MouseLeave(sender As Object, e As EventArgs) Handles PB_Calculator.MouseLeave
        PB_Calculator.Image = My.Resources.calculator_idle
    End Sub

    Private Sub PB_Calculator_Click(sender As Object, e As EventArgs) Handles PB_Calculator.Click
        Calculator.Show()
    End Sub

End Class