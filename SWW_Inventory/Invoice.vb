Imports System.Data.SqlClient
Public Class Invoice
    Dim newdata As Boolean
    Public Property rolei As String
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        QuotationList.Show()
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem1.Click
        Dim objrole As New ControlPanel
        objrole.role = Label_Role.Text
        objrole.Show()
        Me.Close()
    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Role.Text = rolei
        ' If Label_Role.Text = "General Employee" Then
        'Btn_CreateInvoice.Enabled = False
        'Btn_Delete.Enabled = False
        ' Btn_Update.Enabled = False
        'End If


        Label_Save.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
        showData()
        newdata = True
        generateid()
        TB_InvoiceID.Enabled = False
        TB_QuotationID.Select()
        TB_QuotationID.Focus()
        Label_Role.Text = rolei
        If Label_Role.Text = "General Employee" Then
            Btn_CreateInvoice.Enabled = False
            Btn_Delete.Enabled = False
            Btn_Update.Enabled = False
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString)
            con.Open()
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("select * from quotation where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con) 'checks if the user/pass is case sensitive
            dr = cmd.ExecuteReader
            If TB_QuotationID.Text = "" Then
                MsgBox("Please enter a Quotation ID to search", vbInformation, "Attention")
                Exit Sub
            End If
            If dr.Read = True Then
                TB_QuotationID.Text = dr(0).ToString
                Date_QCurrentdate.Text = dr(1).ToString
                TB_QQuantity.Text = dr(2).ToString
                TB_QDescription.Text = dr(3).ToString
                TB_QUnitprice.Text = dr(4).ToString
                TB_QSubtotal.Text = dr(7).ToString
                TB_QTaxrate.Text = dr(8).ToString
                TB_QSalestax.Text = dr(9).ToString
                TB_QTotalamount.Text = dr(10).ToString
                Date_QShipdate.Text = dr(11).ToString
                TB_IShipvia.Text = dr(12).ToString
                TB_QSalesperson.Text = dr(13).ToString
                TB_QOther.Text = dr(14).ToString
                TB_QTerms.Text = dr(15).ToString
                TB_CustomerID.Text = dr(16).ToString
                TB_CCompany.Text = dr(17).ToString
                TB_CName.Text = dr(18).ToString
                TB_CAddress.Text = dr(19).ToString
                TB_CPhone.Text = dr(20).ToString
                TB_CTin.Text = dr(21).ToString
                Label_Status.Text = dr(23).ToString
                CB_Status.SelectedItem = Nothing
            Else
                cleartxt()
                MsgBox("Quotation ID not found!", vbInformation, "Search")
                TB_CCompany.Focus()
            End If

            If Label_Status.Text = "OPEN" Then
                Label_QStatus.Text = "QUOTATION STATUS:"
                Label_Status.ForeColor = Color.Yellow
            ElseIf Label_Status.Text = "CLOSED" Then
                Label_QStatus.Text = "QUOTATION STATUS:"
                Label_Status.ForeColor = Color.LawnGreen
            ElseIf Label_Status.Text = "CANCELLED" Then
                Label_QStatus.Text = "QUOTATION STATUS:"
                Label_Status.ForeColor = Color.Maroon
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "ERROR")
        End Try
    End Sub


    Private Sub Btn_CreateInvoice_Click(sender As Object, e As EventArgs) Handles Btn_CreateInvoice.Click
        Dim msg As String
        Dim savee As String

        If (TB_InvoiceID.Text = "" OrElse CB_Status.SelectedItem = "") Then
            MsgBox("Please complete the Invoice Information", vbInformation, "Invoice Information Incomplete")
            Exit Sub
        End If

        Try
            If newdata Then
                msg = MsgBox("Do you want to create this Invoice?", vbYesNo + vbInformation, "Attention!")
                If msg = vbNo Then
                    Exit Sub
                End If
                savee = "INSERT into invoice(InvoiceID,Date,Quantity,Description,UnitPrice,Subtotal,TaxRate,SalesTax,TotalAmount,ShipDate,ShipVia,SalesPerson,Other,Terms,CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,CustomerTin,InvoiceStatus,InvoiceSavedDate,InvoiceLastModify) VALUES('" & TB_InvoiceID.Text & "','" & Date_QCurrentdate.Text & "','" & TB_QQuantity.Text & "','" & TB_QDescription.Text & "','" & TB_QUnitprice.Text & "','" & TB_QSubtotal.Text & "','" & TB_QTaxrate.Text & "','" & TB_QSalestax.Text & "','" & TB_QTotalamount.Text & "','" & Date_QShipdate.Text & "','" & TB_IShipvia.Text & "','" & TB_QSalesperson.Text & "','" & TB_QOther.Text & "','" & TB_QTerms.Text & "','" & TB_CustomerID.Text & "','" & TB_CCompany.Text & "','" & TB_CName.Text & "','" & TB_CAddress.Text & "','" & TB_CPhone.Text & "','" & TB_CTin.Text & "','" & CB_Status.Text & "','" & Label_Save.Text & "','" & Label_Modify.Text & "')"
                MsgBox("Invoice Created", vbInformation, "Created")
                runSQL(savee)
                showData()
                cleartxt()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub runSQL(ByVal sQL As String)

        Dim SQLCmd As New SqlCommand
        konekDB()
        Try
            SQLCmd.Connection = konek
            SQLCmd.CommandType = CommandType.Text
            SQLCmd.CommandText = sQL
            SQLCmd.ExecuteNonQuery()
            SQLCmd.Dispose()
            konek.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "ERROR")
        End Try
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Dim updatee As String
        Dim updateq As String
        Dim msg As String
        Try
            If TB_CName.Text = "" Then
                MsgBox("Please enter a valid Invoice ID to Update", vbInformation, "Attention")
                Exit Sub

            End If
            msg = MsgBox("Are you sure you want to update the Invoice Information?", vbInformation + vbYesNo, "Attention")
            If msg = vbNo Then Exit Sub
            Label_Modify.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
            updatee = "UPDATE invoice SET InvoiceStatus='" & CB_Status.Text & "', InvoiceLastModify='" & Label_Modify.Text & "'WHERE InvoiceID='" & TB_InvoiceID.Text & "' "
            updateq = "UPDATE quotation SET QuotationStatus='" & TB_StatusQ.Text & "' WHERE QuotationID='" & TB_QuotationID.Text & "' "
            MsgBox("Invoice Status Updated", vbInformation, "Updated")
            runSQL(updatee)
            showData()
            cleartxt()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString)
            con.Open()
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("select * from invoice where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con) 'checks if the user/pass is case sensitive
            dr = cmd.ExecuteReader
            If TB_InvoiceID.Text = "" Then
                MsgBox("Please enter a Invoice ID to search", vbInformation, "Attention")
                Exit Sub
            End If
            If dr.Read = True Then
                TB_InvoiceID.Text = dr(0).ToString
                Date_QCurrentdate.Text = dr(1).ToString
                TB_QQuantity.Text = dr(2).ToString
                TB_QDescription.Text = dr(3).ToString
                TB_QUnitprice.Text = dr(4).ToString
                TB_QSubtotal.Text = dr(5).ToString
                TB_QTaxrate.Text = dr(6).ToString
                TB_QSalestax.Text = dr(7).ToString
                TB_QTotalamount.Text = dr(8).ToString
                Date_QShipdate.Text = dr(9).ToString
                TB_IShipvia.Text = dr(10).ToString
                TB_QSalesperson.Text = dr(11).ToString
                TB_QOther.Text = dr(12).ToString
                TB_QTerms.Text = dr(13).ToString
                TB_CustomerID.Text = dr(14).ToString
                TB_CCompany.Text = dr(15).ToString
                TB_CName.Text = dr(16).ToString
                TB_CAddress.Text = dr(17).ToString
                TB_CPhone.Text = dr(18).ToString
                TB_CTin.Text = dr(19).ToString
                CB_Status.Text = dr(20).ToString
                Label_Save.Text = dr(21).ToString
                Label_Modify.Text = dr(22).ToString
                '  TB_QuotationID.Text = dr(23).ToString
                '  Label_Status.Text = dr(24).ToString
                TB_QuotationID.Text = ""
            Else
                MsgBox("Invoice ID not found!", vbInformation, "Search")
                TB_InvoiceID.Focus()
            End If
            If Label_Status.Text = "OPEN" Then
                Label_Status.ForeColor = Color.Yellow
            ElseIf Label_Status.Text = "CLOSED" Then
                Label_Status.ForeColor = Color.LawnGreen

            ElseIf Label_Status.Text = "CANCELLED" Then
                Label_Status.ForeColor = Color.Maroon
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "ERROR")
        End Try
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim DeleteData As String
        Dim msg As String
        If TB_CName.Text = "" Then
            MsgBox("Please enter a valid Invoice ID to delete", vbInformation, "Attention")
            Exit Sub
        End If

        msg = MsgBox("Are you sure you want to delete this Invoice?", vbExclamation + vbYesNo, "Warning")
        If msg = vbNo Then Exit Sub
        DeleteData = "DELETE FROM invoice WHERE InvoiceID='" & TB_InvoiceID.Text & "' "
        MsgBox("Invoice Deleted", vbInformation, "Deleted")
        runSQL(DeleteData)
        showData()
        cleartxt()
    End Sub

    Public Sub cleartxt()
        TB_InvoiceID.Text = ""
        Date_QCurrentdate.Text = ""
        TB_QQuantity.Text = ""
        TB_QDescription.Text = ""
        TB_QUnitprice.Text = ""
        TB_QSubtotal.Text = ""
        TB_QTaxrate.Text = "12%"
        TB_QSalestax.Text = ""
        TB_QTotalamount.Text = ""
        Date_QShipdate.Text = ""
        TB_IShipvia.Text = ""
        TB_QSalesperson.Text = ""
        TB_QOther.Text = ""
        TB_QTerms.Text = ""
        TB_CustomerID.Text = ""
        TB_CCompany.Text = ""
        TB_CName.Text = ""
        TB_CAddress.Text = ""
        TB_CPhone.Text = ""
        TB_CTin.Text = ""
        Label_Status.Text = ""
        CB_Status.SelectedItem = Nothing
        TB_QuotationID.Text = ""
        Label_QStatus.Text = ""
        generateid()
        TB_InvoiceID.Enabled = False
        PictureBox3.Image = My.Resources.Power_Button
        TB_QuotationID.Select()
    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        cleartxt()

    End Sub
    Private Sub wtextbox(ByVal x As Integer)
        Try
            TB_InvoiceID.Text = DataGridView1.Rows(x).Cells(0).Value
            Date_QCurrentdate.Text = DataGridView1.Rows(x).Cells(1).Value
            TB_QQuantity.Text = DataGridView1.Rows(x).Cells(2).Value
            TB_QDescription.Text = DataGridView1.Rows(x).Cells(3).Value
            TB_QUnitprice.Text = DataGridView1.Rows(x).Cells(4).Value
            TB_QSubtotal.Text = DataGridView1.Rows(x).Cells(5).Value
            TB_QTaxrate.Text = DataGridView1.Rows(x).Cells(6).Value
            TB_QSalestax.Text = DataGridView1.Rows(x).Cells(7).Value
            TB_QTotalamount.Text = DataGridView1.Rows(x).Cells(8).Value
            Date_QShipdate.Text = DataGridView1.Rows(x).Cells(9).Value
            TB_IShipvia.Text = DataGridView1.Rows(x).Cells(10).Value
            TB_QSalesperson.Text = DataGridView1.Rows(x).Cells(11).Value
            TB_QOther.Text = DataGridView1.Rows(x).Cells(12).Value
            TB_QTerms.Text = DataGridView1.Rows(x).Cells(13).Value
            TB_CustomerID.Text = DataGridView1.Rows(x).Cells(14).Value
            TB_CCompany.Text = DataGridView1.Rows(x).Cells(15).Value
            TB_CName.Text = DataGridView1.Rows(x).Cells(16).Value
            TB_CAddress.Text = DataGridView1.Rows(x).Cells(17).Value
            TB_CPhone.Text = DataGridView1.Rows(x).Cells(18).Value
            TB_CTin.Text = DataGridView1.Rows(x).Cells(19).Value
            CB_Status.Text = DataGridView1.Rows(x).Cells(20).Value
            Label_Save.Text = DataGridView1.Rows(x).Cells(21).Value
            Label_Modify.Text = DataGridView1.Rows(x).Cells(22).Value
            '  TB_QuotationID.Text = DataGridView1.Rows(x).Cells(23).Value
            ' Label_Status.Text = DataGridView1.Rows(x).Cells(24).Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        wtextbox(e.RowIndex)
    End Sub
    Sub showData()
        konekDB()
        Dim dA As SqlDataAdapter = New SqlDataAdapter("SELECT InvoiceID,Date,Quantity,Description,UnitPrice,Subtotal,TaxRate,SalesTax,TotalAmount,ShipDate,ShipVia,SalesPerson,Other,Terms,CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,CustomerTin,InvoiceStatus,InvoiceSavedDate,InvoiceLastModify FROM invoice", konek)
        Dim dS As DataSet = New DataSet
        dS.Clear()
        dA.Fill(dS, "invoice")
        DataGridView1.DataSource = (dS.Tables("invoice"))
        DataGridView1.Enabled = True
        dA.Dispose()
        konek.Close()

    End Sub

    Private Sub generateid()
        Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        con.Open()

        Dim number As Integer
        cmd.CommandText = "SELECT Max(InvoiceID) FROM invoicenew"

        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TB_InvoiceID.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TB_InvoiceID.Text = number
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TB_InvoiceID.Enabled = True
        If TB_InvoiceID.Enabled = True Then
            PictureBox3.Image = My.Resources.Power_Button1
            TB_InvoiceID.Text = ""
            TB_InvoiceID.Focus()
        End If
    End Sub

    Private Sub PictureBox3_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        TB_InvoiceID.Enabled = False
        If TB_InvoiceID.Enabled = False Then
          cleartxt()
        End If
    End Sub

    Private Sub QuotationListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuotationListToolStripMenuItem.Click
        Me.Height = 949
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Height = 691
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        cleartxt()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = My.Resources.search1
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.search
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.search1
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.search
    End Sub


End Class