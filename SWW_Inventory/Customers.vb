Imports System.Data.SqlClient
Public Class Customers

    Dim newdata As Boolean
    Public Property rolec As String

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Dim objrole As New ControlPanel : objrole.role = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub
    Private Sub generateid()
        Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), cmd As New SqlCommand, number As Integer
        cmd.Connection = con : con.Open() : cmd.CommandText = "SELECT Max(CustomerID) FROM customers"
        If IsDBNull(cmd.ExecuteScalar) Then : number = 1001 : TB_CustID.Text = number
        Else : number = cmd.ExecuteScalar + 1 : TB_CustID.Text = number : End If
        cmd.Dispose() : con.Close() : con.Dispose()
    End Sub

    Sub showData()
        konekDB()
        Dim dA As SqlDataAdapter = New SqlDataAdapter("SELECT CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,CustomerTIN,CustomerRemarks,CustomerSaved,CustomerModify FROM customers", konek), dS As DataSet = New DataSet
        dS.Clear() : dA.Fill(dS, "customers")
        DataGridView1.DataSource = (dS.Tables("customers")) : DataGridView1.Enabled = True
        dA.Dispose() : konek.Close()
    End Sub

    Private Sub wtextbox(ByVal x As Integer)
        Try
            Orig_ID.Text = DataGridView1.Rows(x).Cells(0).Value
            TB_CustID.Text = DataGridView1.Rows(x).Cells(0).Value
            TB_Company.Text = DataGridView1.Rows(x).Cells(1).Value
            TB_Name.Text = DataGridView1.Rows(x).Cells(2).Value
            TB_Address.Text = DataGridView1.Rows(x).Cells(3).Value
            TB_Phone.Text = DataGridView1.Rows(x).Cells(4).Value
            TB_Tin.Text = DataGridView1.Rows(x).Cells(5).Value
            TB_Remarks.Text = DataGridView1.Rows(x).Cells(6).Value
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        wtextbox(e.RowIndex)
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

    Public Sub cleartxt()
        TB_CustID.Clear() : TB_Company.Clear() : TB_Name.Clear() : TB_Address.Clear() : TB_Phone.Clear() : TB_Tin.Text = "" : TB_Remarks.Text = "" : TB_CustID.Enabled = False
        newdata = True : generateid() : PB_Power.Image = My.Resources.Power_Button
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_CustID.Enabled = False : Label_Save.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
        showData() : newdata = True : generateid()
        PB_Power.Image = My.Resources.Power_Button
        Label_Role.Text = rolec
        If Label_Role.Text = "General Employee" Then : Btn_SaveProd.Enabled = False : Btn_UpdateProd.Enabled = False : Btn_DeleteProd.Enabled = False : End If
    End Sub

    Private Sub PB_Search_Click(sender As Object, e As EventArgs) Handles PB_Search.Click
        Try
            If TB_CustID.Enabled = False Then : MsgBox("Please turn on the Customer Search Switch Button first", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_CustID.Text) = False Then : MsgBox("Please enter a valid Customer ID", vbInformation, "Attention") : Exit Sub : End If
            If TB_CustID.Text = "" Then : MsgBox("Please enter a Customer ID to search", vbInformation, "Attention") : Exit Sub : End If
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString)
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("select * from customers where CustomerID='" & TB_CustID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con) 'checks if the user/pass is case sensitive
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then : Orig_ID.Text = dr(0).ToString : TB_CustID.Text = dr(0).ToString : TB_Company.Text = dr(1).ToString : TB_Name.Text = dr(2).ToString : TB_Address.Text = dr(3).ToString : TB_Phone.Text = dr(4).ToString : TB_Tin.Text = dr(5).ToString : TB_Remarks.Text = dr(6).ToString
            Else : MsgBox("Customer ID not found!", vbInformation, "Search") : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_SaveProd_Click(sender As Object, e As EventArgs) Handles Btn_SaveProd.Click
        Try
            Dim msg As String, savee As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from customers where CustomerID='" & TB_CustID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con) 'checks if the user/pass is case sensitive
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then
                msg = MsgBox("This customer is already in the database, Would you like to update it instead?", vbInformation + vbYesNo, "Attention")
                If msg = vbYes Then : Call Btn_UpdateProd_Click(sender, e) : Exit Sub
                Else : msg = vbNo : Exit Sub : End If
            End If
            If IsNumeric(TB_CustID.Text) = False OrElse TB_CustID.Text = "" Then : MsgBox("Please enter a valid Customer ID", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_Phone.Text) = False Then : MsgBox("Please enter a valid phone number", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_Tin.Text) = False Then : MsgBox("Please enter a valid TIN number", vbInformation, "Attention") : Exit Sub : End If
            If TB_CustID.Text = "" OrElse TB_Company.Text = "" OrElse TB_Name.Text = "" OrElse TB_Address.Text = "" Then : MsgBox("Please complete the Customer Information", vbInformation, "Customer Information Incomplete") : Exit Sub : End If
            If newdata Then : msg = MsgBox("Do you want to save this Customer Information?", vbYesNo + vbInformation, "Attention!")
                generateid()
                If msg = vbNo Then : Exit Sub : End If
                savee = "INSERT into customers(CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,CustomerTIN,CustomerRemarks,CustomerSaved) VALUES('" & TB_CustID.Text & "','" & TB_Company.Text & "','" & TB_Name.Text & "','" & TB_Address.Text & "','" & TB_Phone.Text & "', '" & TB_Tin.Text & "','" & TB_Remarks.Text & "','" & Label_Save.Text & "')"
                MsgBox("Customer Information Saved", vbInformation, "Saved")
                runSQL(savee) : showData() : cleartxt() : generateid() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_UpdateProd_Click(sender As Object, e As EventArgs) Handles Btn_UpdateProd.Click
        Try
            Dim updatee As String, msg As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from customers where CustomerID='" & TB_CustID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = False Then : MsgBox("Please use the save button instead if you want to save this customer", vbInformation, "Attention") : Exit Sub : End If
            If Orig_ID.Text <> TB_CustID.Text Then : TB_CustID.Text = Orig_ID.Text : End If
            If IsNumeric(TB_CustID.Text) = False OrElse TB_CustID.Text = "" Then : MsgBox("Please enter a valid Customer ID", vbInformation, "Attention") : Exit Sub : End If
            msg = MsgBox("Are you sure you want to update the Customer Information?", vbInformation + vbYesNo, "Attention")
            If msg = vbNo Then Exit Sub
            Label_Modify.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
            updatee = "UPDATE customers SET CustomerCompany='" & TB_Company.Text & "', CustomerName='" & TB_Name.Text & "', CustomerAddress='" & TB_Address.Text & "', CustomerPhone='" & TB_Phone.Text & "', CustomerTIN='" & TB_Tin.Text & "', CustomerRemarks='" & TB_Remarks.Text & "', CustomerModify='" & Label_Modify.Text & "' WHERE CustomerID='" & TB_CustID.Text & "' " : MsgBox("Product Information Updated", vbInformation, "Updated")
            runSQL(updatee) : showData() : cleartxt() : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_DeleteProd_Click(sender As Object, e As EventArgs) Handles Btn_DeleteProd.Click
        Try
            Dim DeleteData As String, msg As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from customers where CustomerID='" & TB_CustID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If IsNumeric(TB_CustID.Text) = False OrElse TB_CustID.Text = "" OrElse dr.Read = False Then : MsgBox("Please enter a valid Customer ID to delete", vbInformation, "Attention") : Exit Sub : End If
            msg = MsgBox("Are you sure you want to delete this Customer Information?", vbExclamation + vbYesNo, "Warning")
            If msg = vbNo Then Exit Sub
            DeleteData = "DELETE FROM customers WHERE CustomerID='" & TB_CustID.Text & "' " : MsgBox("Customer Information Deleted", vbInformation, "Deleted")
            runSQL(DeleteData) : showData() : cleartxt()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub PB_Power_Click(sender As Object, e As EventArgs) Handles PB_Power.Click
        TB_CustID.Enabled = True : PB_Power.Image = My.Resources.Power_Button1 : TB_CustID.Text = "" : TB_CustID.Focus() : TB_Company.Clear() : TB_Name.Clear() : TB_Address.Clear() : TB_Phone.Clear() : TB_Tin.Text = "" : TB_Remarks.Text = ""
    End Sub
    Private Sub PB_Power_DoubleClick(sender As Object, e As EventArgs) Handles PB_Power.DoubleClick
        TB_CustID.Enabled = False : cleartxt()
    End Sub
    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        cleartxt()
    End Sub
    Private Sub Btn_NewProd_Click(sender As Object, e As EventArgs) Handles Btn_NewProd.Click
        cleartxt()
    End Sub
    Private Sub Btn_NewProd_MouseHover(sender As Object, e As EventArgs) Handles Btn_NewProd.MouseHover
        Btn_NewProd.Image = My.Resources.newhover
    End Sub
    Private Sub Btn_NewProd_MouseLeave(sender As Object, e As EventArgs) Handles Btn_NewProd.MouseLeave
        Btn_NewProd.Image = My.Resources.neww
    End Sub
    Private Sub Btn_SaveProd_MouseHover(sender As Object, e As EventArgs) Handles Btn_SaveProd.MouseHover
        Btn_SaveProd.Image = My.Resources.savehover
    End Sub
    Private Sub Btn_SaveProd_MouseLeave(sender As Object, e As EventArgs) Handles Btn_SaveProd.MouseLeave
        Btn_SaveProd.Image = My.Resources.save
    End Sub
    Private Sub Btn_UpdateProd_MouseHover(sender As Object, e As EventArgs) Handles Btn_UpdateProd.MouseHover
        Btn_UpdateProd.Image = My.Resources.edithover
    End Sub
    Private Sub Btn_UpdateProd_MouseLeave(sender As Object, e As EventArgs) Handles Btn_UpdateProd.MouseLeave
        Btn_UpdateProd.Image = My.Resources.edit
    End Sub
    Private Sub Btn_DeleteProd_MouseHover(sender As Object, e As EventArgs) Handles Btn_DeleteProd.MouseHover
        Btn_DeleteProd.Image = My.Resources.deletehover
    End Sub
    Private Sub Btn_DeleteProd_MouseLeave(sender As Object, e As EventArgs) Handles Btn_DeleteProd.MouseLeave
        Btn_DeleteProd.Image = My.Resources.delete
    End Sub
    Private Sub PB_Search_MouseHover(sender As Object, e As EventArgs) Handles PB_Search.MouseHover
        PB_Search.Image = My.Resources.search1
    End Sub
    Private Sub PB_Search_MouseLeave(sender As Object, e As EventArgs) Handles PB_Search.MouseLeave
        PB_Search.Image = My.Resources.search
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Call Btn_DeleteProd_Click(sender, e)
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Call Btn_UpdateProd_Click(sender, e)
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call Btn_SaveProd_Click(sender, e)
    End Sub
    Private Sub TB_CustID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CustID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PB_Search_Click(sender, e) : End If
    End Sub
    Private Sub CustomerListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerListToolStripMenuItem.Click
        CustomerList.Show()
    End Sub

End Class