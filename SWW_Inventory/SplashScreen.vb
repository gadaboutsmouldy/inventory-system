Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_Timer.Text = Label_Timer.Text - 1
        If Label_Timer.Text = 0 Then : LoginPage.Show() : Me.Hide() : End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start() : End Sub
End Class
