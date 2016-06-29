Imports System.Data.SqlClient
Public Class Users
    Dim newdata As Boolean
    Public Property roleu As String

    Private Sub generateid()
        Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), cmd As New SqlCommand, number As Integer
        cmd.Connection = con : con.Open() : cmd.CommandText = "SELECT Max(adminid) FROM admin"
        If IsDBNull(cmd.ExecuteScalar) Then : number = 1001 : TB_UserID.Text = number
        Else : number = cmd.ExecuteScalar + 1 : TB_UserID.Text = number : End If
        cmd.Dispose() : con.Close() : con.Dispose()
    End Sub
    Sub showData()
        konekDB()
        Dim dA As SqlDataAdapter = New SqlDataAdapter("SELECT adminid,adminuser,adminpass,lastlogin,adminroles,adminsaved,adminmodify FROM admin", konek)
        Dim dS As DataSet = New DataSet
        dS.Clear() : dA.Fill(dS, "users") : DataGridView1.DataSource = (dS.Tables("users")) : DataGridView1.Enabled = True
        dA.Dispose() : konek.Close()
    End Sub
    Private Sub wtextbox(ByVal x As Integer)
        Try
            L1.Visible = True : L2.Visible = True
            '    If DataGridView1.Rows(x).Cells(3).Value = "" Then : L1.Visible = False : L2.Visible = "None" : End If
            Orig_ID.Text = DataGridView1.Rows(x).Cells(0).Value
            TB_UserID.Text = DataGridView1.Rows(x).Cells(0).Value
            TB_UName.Text = DataGridView1.Rows(x).Cells(1).Value
            TB_Pass.Text = DataGridView1.Rows(x).Cells(2).Value
            L2.Text = DataGridView1.Rows(x).Cells(3).Value
            CB_Roles.Text = DataGridView1.Rows(x).Cells(4).Value
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR1") : End Try
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
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR2") : End Try
    End Sub

    Public Sub cleartxt()
        newdata = True
        TB_UName.Clear()
        TB_UserID.Clear()
        TB_Pass.Clear()
        CB_Roles.SelectedItem = Nothing
        TB_UserID.Enabled = False
        generateid()
        PB_Power.Image = My.Resources.Power_Button
        L1.Visible = False : L2.Text = ""
    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newdata = True
        Me.AdminTableAdapter1.Fill(Me.InventoryDataSet20.admin)
        TB_UserID.Enabled = False
        Label_Save.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
        showData() : generateid()
        PB_Power.Image = My.Resources.Power_Button
        Label_Role.Text = roleu
        L1.Visible = False : L2.Visible = False
    End Sub

    Private Sub PB_Search_Click(sender As Object, e As EventArgs) Handles PB_Search.Click
        Try
            If TB_UserID.Enabled = False Then : MsgBox("Please turn on the User Search Switch Button first", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_UserID.Text) = False Then : MsgBox("Please enter a valid User ID", vbInformation, "Attention") : Exit Sub : End If
            If TB_UserID.Text = "" Then : MsgBox("Please enter a User ID to search", vbInformation, "Attention") : Exit Sub : End If
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from admin where adminid='" & TB_UserID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            L1.Visible = True : L2.Visible = True
            If dr.Read = True Then
                Orig_ID.Text = dr(0).ToString
                TB_UserID.Text = dr(0).ToString
                TB_UName.Text = dr(1).ToString
                TB_Pass.Text = dr(2).ToString
                If dr(3).ToString = "" Then : L1.Visible = False : L2.Visible = "" : End If
                L2.Text = dr(3).ToString
                CB_Roles.Text = dr(4).ToString
            Else : MsgBox("User ID not found!", vbInformation, "Search") : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR3") : End Try
    End Sub

    Private Sub Btn_SaveProd_Click(sender As Object, e As EventArgs) Handles Btn_SaveProd.Click
        Try
            Dim msg As String, savee As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from admin where adminid='" & TB_UserID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then : msg = MsgBox("This user is already in the database, Would you like to update it instead?", vbInformation + vbYesNo, "Attention")
                If msg = vbYes Then : Call Btn_UpdateProd_Click(sender, e) : Exit Sub
                Else : msg = vbNo : Exit Sub : End If
            End If
            If (TB_UserID.Text = "" OrElse TB_UName.Text = "" OrElse TB_Pass.Text = "" OrElse CB_Roles.SelectedItem = Nothing) Then : MsgBox("Please complete the User Information", vbInformation, "User Information Incomplete") : Exit Sub : End If
            If newdata Then : msg = MsgBox("Do you want to save this User Information?", vbYesNo + vbInformation, "Attention!")
                generateid()
                If msg = vbNo Then : Exit Sub : End If
                savee = "INSERT into admin(adminid,adminuser,adminpass,adminroles,adminsaved) VALUES('" & TB_UserID.Text & "','" & TB_UName.Text & "','" & TB_Pass.Text & "','" & CB_Roles.Text & "','" & Label_Save.Text & "')"
                MsgBox("User Information Saved", vbInformation, "Saved")
                runSQL(savee) : showData() : cleartxt() : generateid() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR4") : End Try
    End Sub

    Private Sub Btn_UpdateProd_Click(sender As Object, e As EventArgs) Handles Btn_UpdateProd.Click
        Try
            Dim updatee As String, msg As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from admin where adminid='" & TB_UserID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = False Then : MsgBox("Please use the save button instead if you want to save this user", vbInformation, "Attention") : Exit Sub : End If
            If Orig_ID.Text <> TB_UserID.Text Then : TB_UserID.Text = Orig_ID.Text : End If
            If IsNumeric(TB_UserID.Text) = False OrElse TB_UserID.Text = "" Then : MsgBox("Please enter a valid User ID", vbInformation, "Attention") : Exit Sub : End If
            msg = MsgBox("Are you sure you want to update the User Information?", vbInformation + vbYesNo, "Attention")
            If msg = vbNo Then Exit Sub
            Label_Modify.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
            updatee = "UPDATE admin SET adminuser='" & TB_UName.Text & "', adminpass='" & TB_Pass.Text & "', adminroles='" & CB_Roles.Text & "', adminmodify='" & Label_Modify.Text & "' WHERE adminid='" & TB_UserID.Text & "' " : MsgBox("User Information Updated", vbInformation, "Updated")
            runSQL(updatee) : showData() : cleartxt() : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_DeleteProd_Click(sender As Object, e As EventArgs) Handles Btn_DeleteProd.Click
        Try
            Dim DeleteData As String, msg As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from admin where adminid='" & TB_UserID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If IsNumeric(TB_UserID.Text) = False OrElse TB_UserID.Text = "" OrElse dr.Read = False Then : MsgBox("Please enter a valid User ID to delete", vbInformation, "Attention") : Exit Sub : End If
            msg = MsgBox("Are you sure you want to delete this User Information?", vbExclamation + vbYesNo, "Warning")
            If msg = vbNo Then Exit Sub
            DeleteData = "DELETE FROM admin WHERE adminid='" & TB_UserID.Text & "' " : MsgBox("User Information Deleted", vbInformation, "Deleted")
            runSQL(DeleteData) : showData() : cleartxt() : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub PB_Search_MouseHover(sender As Object, e As EventArgs) Handles PB_Search.MouseHover
        PB_Search.Image = My.Resources.search1
    End Sub

    Private Sub PB_Search_MouseLeave(sender As Object, e As EventArgs) Handles PB_Search.MouseLeave
        PB_Search.Image = My.Resources.search
    End Sub

    Private Sub PB_Power_Click(sender As Object, e As EventArgs) Handles PB_Power.Click
        TB_UserID.Enabled = True : PB_Power.Image = My.Resources.Power_Button1 : TB_UserID.Text = "" : TB_UserID.Focus() : TB_UName.Clear() : TB_Pass.Clear() : CB_Roles.SelectedItem = Nothing : L2.Text = "" : L1.Visible = False
    End Sub

    Private Sub PB_Power_DoubleClick(sender As Object, e As EventArgs) Handles PB_Power.DoubleClick
        TB_UserID.Enabled = False : cleartxt()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        cleartxt()
    End Sub

    Private Sub Btn_NewProd_Click(sender As Object, e As EventArgs) Handles Btn_NewProd.Click
        cleartxt()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        wtextbox(e.RowIndex)
    End Sub
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        'USER ROLES
        Dim objrole As New ControlPanel : objrole.role = Label_Role.Text : objrole.Show() : Me.Close()
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

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call Btn_SaveProd_Click(sender, e)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Call Btn_UpdateProd_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Call Btn_DeleteProd_Click(sender, e)
    End Sub

    Private Sub TB_UserID_TextChanged(sender As Object, e As EventArgs) Handles TB_UserID.TextChanged
        '   TB_UName.Clear()
        ' TB_Pass.Clear()
        '  CB_Roles.SelectedItem = Nothing
        '  L2.Text = ""
    End Sub

    Private Sub TB_UserID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_UserID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PB_Search_Click(sender, e) : End If
    End Sub


End Class