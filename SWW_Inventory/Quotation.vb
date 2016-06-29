Imports System.Data.SqlClient
Public Class Quotation
    Dim newdata As Boolean
    Public Property roleq As String

    Private Sub Quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  
        Label_SaveDate.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
        showData()
        newdata = True
        TB_CCompany.Focus()
        TB_CCompany.Select()
        generateid()
        TB_QuotationID.Enabled = False
        Label_Role.Text = roleq
        If Label_Role.Text = "General Employee" Then
            BTN_QUpdate.Enabled = False
            BTN_Delete.Enabled = False
            Btn_Save.Enabled = False
            BTN_Compute.Enabled = False
        End If


    End Sub

    Public Sub cleartxt()
        TB_CustomerID.Text = ""
        TB_CCompany.Text = ""
        TB_CName.Text = ""
        TB_CAddress.Text = ""
        TB_CPhone.Text = ""
        TB_CTin.Text = ""
        TB_QuotationID.Text = ""
        Date_QCurrentdate.Text = ""
        TB_QQuantity.Text = ""
        TB_QDescription.Text = ""
        TB_QUnitprice.Text = "0.00"
        TB_QSubtotal.Text = "0.00"
        TB_QTaxrate.Text = "12%"
        TB_QSalestax.Text = "0.00"
        TB_QTotalamount.Text = "0.00"
        Date_QShipdate.Text = ""
        CB_QShipvia.SelectedItem = Nothing
        TB_QSalesperson.Text = ""
        TB_QOther.Text = "0.00"
        TB_QTerms.Text = ""
        CB_Status.SelectedItem = Nothing
        TB_CCompany.Focus()
        TB_CCompany.Select()
        generateid()
        TB_QuotationID.Enabled = False
        PictureBox3.Image = My.Resources.Power_Button
    End Sub
    Sub showData()
        konekDB()

        '  Dim dA As SqlDataAdapter = New SqlDataAdapter("SELECT CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,QuotationID,Date,Quantity,Description,UnitPrice,Taxes,Amount,Subtotal,TaxRate,SalesTax,TotalAmount,ShipDate,ShipVia,SalesPerson,Other,Terms,CustomerTIN FROM customers CROSS JOIN quotation", konek)
        Dim dA As SqlDataAdapter = New SqlDataAdapter("SELECT Date,QuotationID,Quantity,Description,UnitPrice,Subtotal,TaxRate,SalesTax,TotalAmount,ShipDate,ShipVia,SalesPerson,Other,Terms,CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,CustomerTIN,QuotationStatus,QuotationSavedDate,QuotationLastModify FROM quotation", konek)
        Dim dS As DataSet = New DataSet
        dS.Clear()
        dA.Fill(dS, "quotation")
        DataGridView.DataSource = (dS.Tables("quotation"))
        DataGridView.Enabled = True
        dA.Dispose()
        konek.Close()

    End Sub
    Private Sub wtextbox(ByVal x As Integer)
        Try
            Date_QCurrentdate.Text = DataGridView.Rows(x).Cells(0).Value
            TB_QuotationID.Text = DataGridView.Rows(x).Cells(1).Value
            TB_QQuantity.Text = DataGridView.Rows(x).Cells(2).Value
            TB_QDescription.Text = DataGridView.Rows(x).Cells(3).Value
            TB_QUnitprice.Text = DataGridView.Rows(x).Cells(4).Value
            TB_QSubtotal.Text = DataGridView.Rows(x).Cells(5).Value
            TB_QTaxrate.Text = DataGridView.Rows(x).Cells(6).Value
            TB_QSalestax.Text = DataGridView.Rows(x).Cells(7).Value
            TB_QTotalamount.Text = DataGridView.Rows(x).Cells(8).Value
            Date_QShipdate.Text = DataGridView.Rows(x).Cells(9).Value
            CB_QShipvia.Text = DataGridView.Rows(x).Cells(10).Value
            TB_QSalesperson.Text = DataGridView.Rows(x).Cells(11).Value
            TB_QOther.Text = DataGridView.Rows(x).Cells(12).Value
            TB_QTerms.Text = DataGridView.Rows(x).Cells(13).Value
            TB_CustomerID.Text = DataGridView.Rows(x).Cells(14).Value
            TB_CCompany.Text = DataGridView.Rows(x).Cells(15).Value
            TB_CName.Text = DataGridView.Rows(x).Cells(16).Value
            TB_CAddress.Text = DataGridView.Rows(x).Cells(17).Value
            TB_CPhone.Text = DataGridView.Rows(x).Cells(18).Value
            TB_CTin.Text = DataGridView.Rows(x).Cells(19).Value
            Label_SaveDate.Text = DataGridView.Rows(x).Cells(20).Value
            CB_Status.Text = DataGridView.Rows(x).Cells(21).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        wtextbox(e.RowIndex)
    End Sub


    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        cleartxt()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        cleartxt()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cleartxt()
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PB_Search.MouseHover
        PB_Search.Image = My.Resources.search1
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PB_Search.MouseLeave
        PB_Search.Image = My.Resources.search
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.search1
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.search
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Dim objrole As New ControlPanel
        objrole.role = Label_Role.Text
        objrole.Show()
        Me.Close()
    End Sub

    Private Sub QuotationListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuotationListToolStripMenuItem.Click
        Me.Height = 919
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Height = 679
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim msg As String
        Dim savee As String

        If (TB_QuotationID.Text = "" OrElse TB_CCompany.Text = "" OrElse TB_CName.Text = "" OrElse TB_CAddress.Text = "" OrElse TB_CustomerID.Text = "" OrElse TB_QQuantity.Text = "" OrElse TB_QUnitprice.Text = "" OrElse CB_Status.SelectedItem = "" OrElse TB_QTotalamount.Text = "0.00") Then
            MsgBox("Please complete the Quotation Information", vbInformation, "Quotation Information Incomplete")
            Exit Sub
        End If
        If newdata Then
            msg = MsgBox("Do you want to save the data to the database?", vbYesNo + vbInformation, "Attention!")
            If msg = vbNo Then
                Exit Sub
            End If
            TB_QTaxrate.Text = "12"
            savee = "INSERT into quotation(CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,QuotationID,Date,Quantity,Description,UnitPrice,Subtotal,TaxRate,SalesTax,TotalAmount,ShipDate,ShipVia,SalesPerson,Other,Terms,CustomerTIN,QuotationSavedDate,QuotationStatus) VALUES('" & TB_CustomerID.Text & "','" & TB_CCompany.Text & "','" & TB_CName.Text & "','" & TB_CAddress.Text & "','" & TB_CPhone.Text & "', '" & TB_QuotationID.Text & "','" & Date_QCurrentdate.Text & "','" & TB_QQuantity.Text & "','" & TB_QDescription.Text & "','" & TB_QUnitprice.Text & "','" & TB_QSubtotal.Text & "','" & TB_QTaxrate.Text & "','" & TB_QSalestax.Text & "','" & TB_QTotalamount.Text & "','" & Date_QShipdate.Text & "','" & CB_QShipvia.Text & "','" & TB_QSalesperson.Text & "','" & TB_QOther.Text & "','" & TB_QTerms.Text & "','" & TB_CTin.Text & "','" & Label_SaveDate.Text & "','" & CB_Status.Text & "')"
            MsgBox("Quotation Information Saved", vbInformation, "Saved")
            runSQL(savee)
            showData()
            cleartxt()
        End If

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

    Private Sub TB_QUnitprice_Enter(sender As Object, e As EventArgs) Handles TB_QUnitprice.Enter
        If TB_QUnitprice.Text = "0.00" Then
            TB_QUnitprice.Text = ""
        End If
    End Sub

    Private Sub TB_QOther_Enter(sender As Object, e As EventArgs) Handles TB_QOther.Enter
        If TB_QOther.Text = "0.00" Then
            TB_QOther.Text = ""
        End If
    End Sub

    Private Sub BTN_QUpdate_Click(sender As Object, e As EventArgs) Handles BTN_QUpdate.Click
        Dim updatee As String
        Dim msg As String
        Try
            If TB_CName.Text = "" OrElse TB_QQuantity.Text = "" OrElse TB_QTotalamount.Text = "" OrElse TB_CustomerID.Text = "" Then
                MsgBox("Please enter a valid Quotation ID to update", vbInformation, "Attention")
                Exit Sub

            End If
            msg = MsgBox("Are you sure you want to update the Quotation Information?", vbInformation + vbYesNo, "Attention")
            If msg = vbNo Then Exit Sub
            Label_modify.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
            updatee = "UPDATE quotation SET Date='" & Date_QCurrentdate.Text & "', CustomerCompany='" & TB_CCompany.Text & "', CustomerName='" & TB_CName.Text & "', CustomerAddress='" & TB_CAddress.Text & "', CustomerID='" & TB_CustomerID.Text & "', CustomerTin='" & TB_CTin.Text & "', CustomerPhone='" & TB_CPhone.Text & "', Quantity='" & TB_QQuantity.Text & "', Description='" & TB_QDescription.Text & "', UnitPrice='" & TB_QUnitprice.Text & "', QuotationID='" & TB_QuotationID.Text & "', ShipDate='" & Date_QShipdate.Text & "', ShipVia='" & CB_QShipvia.Text & "', SalesPerson='" & TB_QSalesperson.Text & "', Terms='" & TB_QTerms.Text & "', Subtotal='" & TB_QSubtotal.Text & "', TaxRate='" & TB_QTaxrate.Text & "', SalesTax='" & TB_QSalestax.Text & "', Other='" & TB_QOther.Text & "', TotalAmount='" & TB_QTotalamount.Text & "', QuotationLastModify='" & Label_modify.Text & "', QuotationStatus='" & CB_Status.Text & "' WHERE QuotationID='" & TB_QuotationID.Text & "' "
            MsgBox("Quotation Information Updated", vbInformation, "Updated")
            runSQL(updatee)
            showData()
            cleartxt()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Dim DeleteData As String
        Dim msg As String
        If TB_CName.Text = "" OrElse TB_QQuantity.Text = "" OrElse TB_QTotalamount.Text = "" OrElse TB_CustomerID.Text = "" Then
            MsgBox("Please enter a valid Quotation ID to delete", vbInformation, "Attention")
            Exit Sub
        End If

        msg = MsgBox("Are you sure you want to delete the data from the database?", vbExclamation + vbYesNo, "Warning")
        If msg = vbNo Then Exit Sub
        DeleteData = "DELETE FROM quotation WHERE QuotationID='" & TB_QuotationID.Text & "' "
        MsgBox("Quotation Information Deleted", vbInformation, "Deleted")
        runSQL(DeleteData)
        showData()
        cleartxt()
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
                CB_QShipvia.Text = dr(12).ToString
                TB_QSalesperson.Text = dr(13).ToString
                TB_QOther.Text = dr(14).ToString
                TB_QTerms.Text = dr(15).ToString
                TB_CustomerID.Text = dr(16).ToString
                TB_CCompany.Text = dr(17).ToString
                TB_CName.Text = dr(18).ToString
                TB_CAddress.Text = dr(19).ToString
                TB_CPhone.Text = dr(20).ToString
                TB_CTin.Text = dr(21).ToString
                CB_Status.Text = dr(23).ToString
                Label_modify.Text = dr(24).ToString
            Else
                MsgBox("Quotation ID not found!", vbInformation, "Search")
                TB_CCompany.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "ERROR")
        End Try

    End Sub

    Private Sub BTN_Compute_Click(sender As Object, e As EventArgs) Handles BTN_Compute.Click

        Dim subtotal As Double
        Dim salestax As Double
        Dim totalamount As Double

        If TB_QQuantity.Text = "" Then
            MsgBox("Please enter the quantity of the product", vbInformation, "Attention")
            Exit Sub
        End If

        If TB_QUnitprice.Text = "0.00" Then
            MsgBox("Please enter the price of the product", vbInformation, "Attention")
            Exit Sub
        End If

        subtotal = Val(TB_QQuantity.Text) * Val(TB_QUnitprice.Text)
        TB_QSubtotal.Text = (subtotal)
        salestax = Val(TB_QSubtotal.Text) * 0.12
        TB_QSalestax.Text = (salestax)
        totalamount = Val(TB_QSubtotal.Text) + Val(TB_QSalestax.Text) + Val(TB_QOther.Text)
        TB_QTotalamount.Text = (totalamount)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TB_QuotationID.Enabled = True
        If TB_QuotationID.Enabled = True Then
            PictureBox3.Image = My.Resources.Power_Button1
            TB_QuotationID.Text = ""
            TB_QuotationID.Focus()
        End If
    End Sub

    Private Sub PictureBox3_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        TB_QuotationID.Enabled = False
        If TB_QuotationID.Enabled = False Then
            cleartxt()

        End If
    End Sub
    Private Sub generateid()
        Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString)
        Dim cmd As New SqlCommand
        cmd.Connection = con
        con.Open()

        Dim number As Integer
        cmd.CommandText = "SELECT Max(QuotationID) FROM quotation"

        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TB_QuotationID.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TB_QuotationID.Text = number
        End If
        cmd.Dispose()
        con.Close()
        con.Dispose()
    End Sub

    Private Sub PB_Search_Click(sender As Object, e As EventArgs) Handles PB_Search.Click
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString)
            con.Open()
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand("select * from customers where CustomerID='" & TB_CustomerID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con) 'checks if the user/pass is case sensitive
            dr = cmd.ExecuteReader
            If TB_CustomerID.Text = "" Then
                MsgBox("Please enter a Customer ID to search", vbInformation, "Attention")
                Exit Sub
            End If
            If dr.Read = True Then
                TB_CustomerID.Text = dr(0).ToString
                TB_CCompany.Text = dr(1).ToString
                TB_CName.Text = dr(2).ToString
                TB_CAddress.Text = dr(3).ToString
                TB_CPhone.Text = dr(4).ToString
                TB_CTin.Text = dr(5).ToString

            Else
                MsgBox("Customer ID not found!", vbInformation, "Search")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "ERROR")
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        CustomerList.Show()
    End Sub

    Private Sub ProductListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click
        ProductList.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Calculator.Show()

    End Sub

    Private Sub TB_QUnitprice_Leave(sender As Object, e As EventArgs) Handles TB_QUnitprice.Leave
        If String.IsNullOrEmpty(TB_QUnitprice.Text) Then
            TB_QUnitprice.Text = "0.00"
        End If
    End Sub

    Private Sub TB_QOther_Leave(sender As Object, e As EventArgs) Handles TB_QOther.Leave
        If String.IsNullOrEmpty(TB_QOther.Text) Then
            TB_QOther.Text = "0.00"
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class