Imports System.Data.SqlClient

Public Class LoginPage

    Private Sub BT_SubmitLF_Click(sender As Object, e As EventArgs) Handles BT_SubmitLF.Click
        Try
            Dim objrole As New ControlPanel, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from admin where adminuser='" & TB_Username.Text & "' and adminpass= '" & TB_Password.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con) 'checks if the user/pass is case sensitive
            Dim updatee As String
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read Then
                TB_Role.Text = dr(4).ToString
                Label1.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
                updatee = "UPDATE admin SET lastlogin='" & Label1.Text & "' WHERE adminuser='" & TB_Username.Text & "' and adminpass= '" & TB_Password.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS"
                runSQL(updatee)
                objrole.role = TB_Role.Text : objrole.Show()
                Me.Close()
            Else
                Label_WrongUserLF.Text = "Wrong Username or Password" : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub runSQL(ByVal sQL As String)
        Try
            Dim SQLCmd As New SqlCommand
            konekDB()
            SQLCmd.Connection = konek
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sQL
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            konek.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BT_ClearLF_Click(sender As Object, e As EventArgs) Handles BT_ClearLF.Click
        TB_Username.Clear() : TB_Password.Clear() : TB_Username.Focus()
    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = BT_SubmitLF : CancelButton = BT_ClearLF
    End Sub
    Private Sub PB_CloseLF_Click(sender As Object, e As EventArgs) Handles PB_CloseLF.Click
        Me.Close()
    End Sub

    Private Sub PB_CloseLF_MouseHover(sender As Object, e As EventArgs) Handles PB_CloseLF.MouseHover
        PB_CloseLF.Image = My.Resources.closehover
    End Sub

    Private Sub PB_CloseLF_MouseLeave(sender As Object, e As EventArgs) Handles PB_CloseLF.MouseLeave
        PB_CloseLF.Image = My.Resources.close
    End Sub
End Class