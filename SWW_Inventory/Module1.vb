Imports System.Data.SqlClient
Module Module1
    Public konek As SqlConnection
    Sub konekDB()
        Try
            konek = New SqlConnection("Data Source=KYLE-PC;Initial Catalog=inventory;Integrated Security=True")
            konek.Open()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub
End Module
