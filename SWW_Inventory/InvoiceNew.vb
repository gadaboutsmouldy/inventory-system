Imports System.Data.SqlClient
Public Class Invoice
    Dim newdata As Boolean, PictureBox3_Clicked As Boolean = False
    Public Property rolei As String

    Private Sub PB_QuotationSearch_Click(sender As Object, e As EventArgs) Handles PB_QuotationSearch.Click
        Try
            If PictureBox3_Clicked = True Then : MsgBox("Please turn off the Invoice Search Switch Button first", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_QuotationID.Text) = False Then : MsgBox("Please enter a valid Quotation ID", vbInformation, "Attention") : Exit Sub : End If
            If TB_QuotationID.Text = "" Then : MsgBox("Please enter a Quotation ID to search", vbInformation, "Attention") : Exit Sub : End If

            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from quotationnew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim con1 As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr1 As SqlClient.SqlDataReader, cmd1 As New SqlClient.SqlCommand("select * from invoicenew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim da As New SqlClient.SqlDataAdapter("select * from orders where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con), dt As New DataTable, ds As New DataSet
            con.Open() : con1.Open() : dr = cmd.ExecuteReader : dr1 = cmd1.ExecuteReader
            ds.Tables.Add(dt) : da.Fill(dt)

            If dr.Read = True Then : TB_CurrentQuoInvoStats.Text = dr(20).ToString
                If dr1.Read = True Then : dr1(0).ToString() : End If
                If TB_CurrentQuoInvoStats.Text = "Yes" Then : MsgBox("An invoice has already been issued for this quotation." & vbCrLf & "Invoice ID No. " + dr1(0).ToString, vbInformation, "Attention") : Exit Sub : End If
                ListView1.Items.Clear()
                Date_QCurrentdate.Enabled = False
                Label16.Visible = True
                Date_QCurrentdate.Visible = True

                TB_QuotationID.Text = dr(0).ToString
                Date_QCurrentdate.Text = dr(1).ToString
                TB_CCompany.Text = dr(3).ToString
                TB_CName.Text = dr(4).ToString
                TB_CAddress.Text = dr(5).ToString
                TB_CPhone.Text = dr(6).ToString
                TB_CNameS.Text = dr(7).ToString
                TB_CAddressS.Text = dr(8).ToString
                TB_CPhoneS.Text = dr(9).ToString
                CB_Status.Text = dr(10).ToString
                TB_QTerms.Text = dr(11).ToString
                Date_QShipdate.Text = dr(12).ToString
                CB_QShipvia.SelectedItem = dr(13).ToString
                TB_QSalesperson.Text = dr(14).ToString

                Dim subtotal As Double, discountamount As Double, salestax As Double, others As Double, totalamount As Double
                subtotal = dr(15).ToString : TB_QSubtotal.Text = subtotal.ToString("N")
                discountamount = dr(16).ToString : TB_DiscountAmount.Text = discountamount.ToString("N")
                salestax = dr(17).ToString : TB_QSalestax.Text = salestax.ToString("N")
                others = dr(18).ToString : TB_QOther.Text = others.ToString("N")
                totalamount = dr(19).ToString : TB_QTotalamount.Text = totalamount.ToString("N")

                Dim myRow As DataRow
                For Each myRow In dt.Rows
                    ListView1.Items.Add(myRow.Item(1))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(2))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(3))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(4))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(5))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(6))
                Next
            Else : MsgBox("Quotation ID not found!", vbInformation, "Search") : cleartxt() : con.Close() : con1.Close() : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Public Sub listinfo()
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from invoicenew where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim da As New SqlClient.SqlDataAdapter("select * from ordersinvoice where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con), dt As New DataTable, ds As New DataSet
            con.Open() : dr = cmd.ExecuteReader
            ds.Tables.Add(dt) : da.Fill(dt)

            If dr.Read = True Then
                PrintToolStripMenuItem.Enabled = True
                ListView1.Items.Clear()
                TB_QuotationID.Enabled = False
                Date_QCurrentdate.Enabled = False
                Orig_ID.Text = dr(0).ToString
                TB_InvoiceID.Text = dr(0).ToString
                TB_QuotationID.Text = dr(1).ToString
                Date_QCurrentdate.Text = dr(2).ToString
                TB_CCompany.Text = dr(3).ToString
                TB_CName.Text = dr(4).ToString
                TB_CAddress.Text = dr(5).ToString
                TB_CPhone.Text = dr(6).ToString
                TB_CNameS.Text = dr(7).ToString
                TB_CAddressS.Text = dr(8).ToString
                TB_CPhoneS.Text = dr(9).ToString
                CB_InvoiceStatus.SelectedItem = dr(10).ToString
                TB_QTerms.Text = dr(11).ToString
                Date_QShipdate.Text = dr(12).ToString
                CB_QShipvia.SelectedItem = dr(13).ToString
                TB_QSalesperson.Text = dr(14).ToString

                Dim subtotal As Double, discountamount As Double, salestax As Double, others As Double, totalamount As Double
                subtotal = dr(15).ToString : TB_QSubtotal.Text = subtotal.ToString("N")
                discountamount = dr(16).ToString : TB_DiscountAmount.Text = discountamount.ToString("N")
                salestax = dr(17).ToString : TB_QSalestax.Text = salestax.ToString("N")
                others = dr(18).ToString : TB_QOther.Text = others.ToString("N")
                totalamount = dr(19).ToString : TB_QTotalamount.Text = totalamount.ToString("N")
                L1.Visible = True : L2.Visible = True : InvoiceDate.Visible = True : InvoiceDate.Text = dr(20).ToString
                Dim myRow As DataRow
                For Each myRow In dt.Rows
                    ListView1.Items.Add(myRow.Item(1))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(2))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(3))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(4))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(5))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(6))
                Next
            Else : MsgBox("Invoice ID not found!", vbInformation, "Search") : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub InvoiceNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintToolStripMenuItem.Enabled = False
        newdata = True
        generateid()
        TB_QuotationID.Focus()
        TB_QuotationID.Select()
        TB_InvoiceID.Enabled = False
        CB_Status.Enabled = False
        TB_CCompany.Enabled = False
        TB_CName.Enabled = False
        TB_CAddress.Enabled = False
        TB_CPhone.Enabled = False
        TB_CNameS.Enabled = False
        TB_CAddressS.Enabled = False
        TB_CPhoneS.Enabled = False
        Date_QShipdate.Enabled = False
        CB_QShipvia.Enabled = False
        TB_QTerms.Enabled = False
        TB_QSalesperson.Enabled = False
        TB_QOther.Enabled = False
        Date_QCurrentdate.Enabled = False
        InvoiceDate.Enabled = False
        L1.Visible = False
        L2.Visible = False
        InvoiceDate.Visible = False
        Label16.Visible = False
        Date_QCurrentdate.Visible = False
        Label_Role.Text = rolei

        ' If Label_Role.Text = "General Employee" Then
        'Btn_CreateInvoice.Enabled = False
        'BTN_Delete.Enabled = False
        ' Btn_Update.Enabled = False
        'End If
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try
            Dim msg As String, savee As String, saveq As String, hasinvoicestats As String
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from invoicenew where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then : msg = MsgBox("This invoice is already in the database, Would you like to update it instead?", vbInformation + vbYesNo, "Attention")
                If msg = vbYes Then : Call BTN_QUpdate_Click(sender, e) : Exit Sub
                Else : msg = vbNo : Exit Sub : End If
            End If

            If ListView1.Items.Count = 0 OrElse CB_InvoiceStatus.Text = "" Then : MsgBox("Please complete the Invoice Information", vbInformation, "Attention") : Exit Sub : End If
            If newdata Then : msg = MsgBox("Do you want to issue an invoice for this quotation?" & vbCrLf & "Once you issued an invoice for this, It's quotation will no longer be editable", vbYesNo + vbExclamation, "Attention")
                If msg = vbNo Then : Exit Sub : End If
                If ListView1.Items.Count > 0 Then
                    For i = 0 To ListView1.Items.Count - 1
                        savee = "INSERT into ordersinvoice(InvoiceID,ProductID,ProductName,Description,Quantity,Price,Total) VALUES('" & TB_InvoiceID.Text & "','" & ListView1.Items(i).Text & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "','" & ListView1.Items(i).SubItems(5).Text & "')" : runSQL(savee) : Next
                    CB_Status.Text = "CLOSED"
                    saveq = "INSERT into invoicenew(InvoiceID,QuotationID,Date,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,RecipientName,RecipientAddress,RecipientPhone,InvoiceStatus,Terms,ShipDate,ShipVia,SalesPerson,SubTotal,DiscountAmount,SalesTax,Other,TotalAmount,InvoiceSaveDate) VALUES('" & TB_InvoiceID.Text & "','" & TB_QuotationID.Text & "','" & Date_QCurrentdate.Text & "','" & TB_CCompany.Text & "','" & TB_CName.Text & "','" & TB_CAddress.Text & "','" & TB_CPhone.Text & "','" & TB_CNameS.Text & "','" & TB_CAddressS.Text & "','" & TB_CPhoneS.Text & "','" & CB_InvoiceStatus.SelectedItem & "','" & TB_QTerms.Text & "','" & Date_QShipdate.Text & "','" & CB_QShipvia.SelectedItem & "','" & TB_QSalesperson.Text & "','" & TB_QSubtotal.Text & "','" & TB_DiscountAmount.Text & "','" & TB_QSalestax.Text & "','" & TB_QOther.Text & "','" & TB_QTotalamount.Text & "','" & InvoiceDate.Text & "')"
                    hasinvoicestats = "UPDATE quotationnew SET HasInvoice='" & TB_QuoInvoStats.Text & "',QuotationStatus='" & CB_Status.Text & "' WHERE QuotationID='" & TB_QuotationID.Text & "' "
                    MsgBox("Invoice Information Saved", vbInformation, "Saved")
                    runSQL(saveq) : runSQL(hasinvoicestats) : cleartxt() : con.Close() : End If
            End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub generateid()
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), cmd As New SqlCommand, number As Integer
            cmd.Connection = con : con.Open() : cmd.CommandText = "SELECT Max(InvoiceID) FROM invoicenew"
            If IsDBNull(cmd.ExecuteScalar) Then : number = 1001 : TB_InvoiceID.Text = number
            Else : number = cmd.ExecuteScalar + 1 : TB_InvoiceID.Text = number : End If
            cmd.Dispose() : con.Close() : con.Dispose()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Public Sub quotationquery()
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from quotationnew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then : CB_Status.Text = dr(10).ToString : con.Close() : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub
    Public Sub cleartxt()
        Date_QCurrentdate.Text = ""
        TB_QSubtotal.Text = "0.00"
        TB_QTaxrate.Text = "12%"
        TB_QSalestax.Text = "0.00"
        TB_QTotalamount.Text = "0.00"
        TB_DiscountAmount.Text = "0.00"
        Date_QShipdate.Text = ""
        CB_QShipvia.SelectedItem = Nothing
        TB_QSalesperson.Text = ""
        TB_QOther.Text = "0.00"
        CB_Status.Text = ""
        generateid()
        TB_CCompany.Text = ""
        TB_CName.Text = ""
        TB_CAddress.Text = ""
        TB_CPhone.Text = ""
        TB_CNameS.Text = ""
        TB_CAddressS.Text = ""
        TB_CPhoneS.Text = ""
        TB_QTerms.Text = ""
        ListView1.Items.Clear()
        PictureBox3.Image = My.Resources.Power_Button
        CB_InvoiceStatus.SelectedItem = Nothing
        TB_InvoiceID.Enabled = False
        L1.Visible = False
        L2.Visible = False
        InvoiceDate.Visible = False
        TB_QuotationID.Enabled = True
        TB_QuotationID.Text = ""
        TB_QuotationID.Focus()
        TB_QuotationID.Select()
        Label16.Visible = False
        Date_QCurrentdate.Visible = False
        PrintToolStripMenuItem.Enabled = False
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

    Private Sub PB_SearchInvoice_Click(sender As Object, e As EventArgs) Handles PB_SearchInvoice.Click
        Try
            If TB_InvoiceID.Enabled = False Then : MsgBox("Please turn on the Invoice Search Switch Button first", vbInformation, "Attention") : PrintToolStripMenuItem.Enabled = False : Exit Sub : End If
            If IsNumeric(TB_InvoiceID.Text) = False Then : MsgBox("Please enter a valid Invoice ID", vbInformation, "Attention") : PrintToolStripMenuItem.Enabled = False : Exit Sub : End If
            If TB_InvoiceID.Text = "" Then : MsgBox("Please enter an Invoice ID to search", vbInformation, "Attention") : PrintToolStripMenuItem.Enabled = False : Exit Sub : End If
            listinfo() : quotationquery()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Try
            Dim DeleteData As String, DeleteOrders As String, msg As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from invoicenew where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = False Then : msg = MsgBox("Please enter a valid Invoice ID to delete", vbInformation, "Attention")
            Else : listinfo() : msg = MsgBox("Are you sure you want to delete the data from the database?", vbExclamation + vbYesNo, "Warning")
                If msg = vbNo Then Exit Sub
                DeleteData = "DELETE FROM invoicenew WHERE InvoiceID='" & TB_InvoiceID.Text & "' "
                DeleteOrders = "DELETE FROM ordersinvoice WHERE InvoiceID='" & TB_InvoiceID.Text & "' "
                MsgBox("Invoice Information Deleted", vbInformation, "Deleted")
                runSQL(DeleteData) : runSQL(DeleteOrders) : cleartxt() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_QUpdate_Click(sender As Object, e As EventArgs) Handles BTN_QUpdate.Click
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd1 As New SqlClient.SqlCommand("select * from invoicenew where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd1.ExecuteReader
            If dr.Read = False Then : MsgBox("Please use the save button instead if you want to save this quotation", vbInformation, "Attention") : Exit Sub : End If
            Dim da As New SqlClient.SqlDataAdapter("select * from ordersinvoice where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con), dt As New DataTable, ds As New DataSet
            ds.Tables.Add(dt) : da.Fill(dt)
            Dim invoicestats As String, msg As String
            If Orig_ID.Text <> TB_InvoiceID.Text Then : TB_InvoiceID.Text = Orig_ID.Text : End If
            If CB_InvoiceStatus.Text = "" Then : MsgBox("Please complete the invoice information", vbInformation, "Information") : Exit Sub : End If
            msg = MsgBox("Are you sure you want to update this invoice status?", vbInformation + vbYesNo, "Attention")
            If msg = vbNo Then Exit Sub

            Dim myRow As DataRow
            For Each myRow In dt.Rows
                invoicestats = "UPDATE invoicenew SET InvoiceStatus='" & CB_InvoiceStatus.SelectedItem & "' WHERE InvoiceID='" & TB_InvoiceID.Text & "' "
                runSQL(invoicestats) : ListView1.Items.Clear() : listinfo() : Next
            MsgBox("Invoice Information Updated", vbInformation, "Updated") : cleartxt() : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub TB_InvoiceID_TextChanged(sender As Object, e As EventArgs) Handles TB_InvoiceID.TextChanged
        TB_QuotationID.Text = ""
        Date_QCurrentdate.Text = ""
        TB_QSubtotal.Text = "0.00"
        TB_QTaxrate.Text = "12%"
        TB_QSalestax.Text = "0.00"
        TB_QTotalamount.Text = "0.00"
        TB_DiscountAmount.Text = "0.00"
        Date_QShipdate.Text = ""
        CB_QShipvia.SelectedItem = Nothing
        TB_QSalesperson.Text = ""
        TB_QOther.Text = "0.00"
        CB_Status.Text = ""
        TB_CCompany.Text = ""
        TB_CName.Text = ""
        TB_CAddress.Text = ""
        TB_CPhone.Text = ""
        TB_CNameS.Text = ""
        TB_CAddressS.Text = ""
        TB_CPhoneS.Text = ""
        TB_QTerms.Text = ""
        ListView1.Items.Clear()
        CB_InvoiceStatus.SelectedItem = Nothing
        L1.Visible = False
        L2.Visible = False
        InvoiceDate.Visible = False
        Label16.Visible = False
        Date_QCurrentdate.Visible = False
        PrintToolStripMenuItem.Enabled = False
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem1.Click
        'USER ROLES BACK TO MAINMENU
        Dim objrole As New ControlPanel : objrole.role = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub
    Private Sub TB_QuotationID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_QuotationID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PB_QuotationSearch_Click(sender, e) : End If
    End Sub

    Private Sub TB_InvoiceID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_InvoiceID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PB_SearchInvoice_Click(sender, e) : End If
    End Sub

    Private Sub PB_New_Click(sender As Object, e As EventArgs) Handles PB_New.Click
        cleartxt()
    End Sub
    Private Sub PB_QuotationSearch_MouseHover(sender As Object, e As EventArgs) Handles PB_QuotationSearch.MouseHover
        PB_QuotationSearch.Image = My.Resources.search1
    End Sub

    Private Sub PB_QuotationSearch_MouseLeave(sender As Object, e As EventArgs) Handles PB_QuotationSearch.MouseLeave
        PB_QuotationSearch.Image = My.Resources.search
    End Sub

    Private Sub TB_QuotationID_TextChanged(sender As Object, e As EventArgs) Handles TB_QuotationID.TextChanged
        If TB_QuotationID.Text = "" Then : Call TB_InvoiceID_TextChanged(sender, e) : End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3_Clicked = True : TB_QuotationID.Enabled = False : TB_InvoiceID.Enabled = True : TB_InvoiceID.Focus() : PictureBox3.Image = My.Resources.Power_Button1 : TB_InvoiceID.Text = ""
    End Sub

    Private Sub PictureBox3_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        PictureBox3_Clicked = False : TB_QuotationID.Enabled = True : TB_InvoiceID.Enabled = False : cleartxt() : TB_QuotationID.Focus() : TB_QuotationID.Select()
    End Sub

    Private Sub PB_New_MouseHover(sender As Object, e As EventArgs) Handles PB_New.MouseHover
        PB_New.Image = My.Resources.newhover
    End Sub

    Private Sub PB_New_MouseLeave(sender As Object, e As EventArgs) Handles PB_New.MouseLeave
        PB_New.Image = My.Resources.neww
    End Sub

    Private Sub PB_Save_MouseHover(sender As Object, e As EventArgs) Handles Btn_Save.MouseHover
        Btn_Save.Image = My.Resources.savehover
    End Sub

    Private Sub PB_Save_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Save.MouseLeave
        Btn_Save.Image = My.Resources.save
    End Sub
    Private Sub PB_Update_MouseHover(sender As Object, e As EventArgs) Handles BTN_QUpdate.MouseHover
        BTN_QUpdate.Image = My.Resources.edithover
    End Sub

    Private Sub PB_Update_MouseLeave(sender As Object, e As EventArgs) Handles BTN_QUpdate.MouseLeave
        BTN_QUpdate.Image = My.Resources.edit
    End Sub
    Private Sub PB_Delete_MouseHover(sender As Object, e As EventArgs) Handles BTN_Delete.MouseHover
        BTN_Delete.Image = My.Resources.deletehover
    End Sub

    Private Sub PB_Delete_MouseLeave(sender As Object, e As EventArgs) Handles BTN_Delete.MouseLeave
        BTN_Delete.Image = My.Resources.delete
    End Sub
    Private Sub PB_SearchInvoice_MouseHover(sender As Object, e As EventArgs) Handles PB_SearchInvoice.MouseHover
        PB_SearchInvoice.Image = My.Resources.search1
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        QuotationList.Show()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        cleartxt()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call Btn_Save_Click(sender, e)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Call BTN_QUpdate_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Call BTN_Delete_Click(sender, e)
    End Sub

    Private Sub DisplayReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayReportsToolStripMenuItem.Click
        InvoiceList.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim TB_InvoiceID1 As New PrintInvoice
        TB_InvoiceID1.InvoiceID2 = TB_InvoiceID.Text
        cleartxt()
        TB_InvoiceID1.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PB_SearchInvoice.MouseLeave
        PB_SearchInvoice.Image = My.Resources.search
    End Sub

End Class