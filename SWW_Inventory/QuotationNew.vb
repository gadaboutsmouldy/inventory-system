Imports System.Data.SqlClient
Public Class Quotation
    Dim newdata As Boolean, BTN_Delete_Clicked As Boolean = False, PictureBox3_Clicked As Boolean = False
    Public Property roleq As String
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'SEARCH FOR CUSTOMER ID
        Try
            If PictureBox3_Clicked = True Then : MsgBox("Please turn off the quotation search switch button first", vbInformation, "Attention") : Exit Sub : End If
            TB_PI_ProdID.Focus()
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from customers where CustomerID='" & TB_CustomerID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If IsNumeric(TB_CustomerID.Text) = False Then : MsgBox("Please enter a valid Customer ID", vbInformation, "Attention") : TB_CustomerID.Focus() : Exit Sub : End If
            If TB_CustomerID.Text = "" Then : MsgBox("Please enter a Customer ID to search", vbInformation, "Attention") : Exit Sub : End If
            If dr.Read = True Then
                TB_CustomerID.Text = dr(0).ToString
                TB_CCompany.Text = dr(1).ToString
                TB_CName.Text = dr(2).ToString
                TB_CAddress.Text = dr(3).ToString
                TB_CPhone.Text = dr(4).ToString
                TB_CNameS.Text = dr(2).ToString
                TB_CAddressS.Text = dr(3).ToString
                TB_CPhoneS.Text = dr(4).ToString
                CB_Status.SelectedItem = "OPEN"
                CB_Status.Enabled = False
            Else : MsgBox("Customer ID not found!", vbInformation, "Search") : TB_CustomerID.Focus() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Public Sub PB_SearchP_Click(sender As Object, e As EventArgs) Handles PB_SearchP.Click
        Try
            If TB_CustomerID.Text = "" OrElse TB_CName.Text = "" OrElse TB_CAddress.Text = "" Then : MsgBox("Please enter the customer information first", vbInformation, "Attention") : TB_PI_ProdID.Text = "" : TB_CustomerID.Focus() : TB_CustomerID.Select() : Exit Sub : End If
            TB_QQuantity.Focus()
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from products where ProductID='" & TB_PI_ProdID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If IsNumeric(TB_PI_ProdID.Text) = False Then : MsgBox("Please enter a valid Product ID", vbInformation, "Attention") : TB_PI_ProdID.Text = "" : TB_PI_ProdID.Focus() : Exit Sub : End If
            If TB_PI_ProdID.Text = "" Then : MsgBox("Please enter a Product ID to search", vbInformation, "Attention") : Exit Sub : End If
            If dr.Read = True Then
                TB_PI_ProdID.Text = dr(0).ToString
                TB_PI_ProdName.Text = dr(1).ToString
                TB_PI_ProdDesc.Text = dr(2).ToString
                TB_PI_ProdStock.Text = dr(3).ToString
                TB_PI_ProdPrice.Text = dr(7).ToString
                TB_QQuantity.Enabled = True
                TB_QQuantity.Text = ""
                TB_QQuantity.Focus()
            Else : MsgBox("Product ID not found!", vbInformation, "Search") : TB_PI_ProdID.Text = "" : TB_PI_ProdID.Focus() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub PB_AddP_Click(sender As Object, e As EventArgs) Handles PB_AddP.Click
        Try
            'THIS CODE IS TO COMPUTE PRODUCT QUANTITY, dirty quickfix
            'Dim val1 As Double
            'Dim val2 As Double
            'Dim curstock As Double         
            'i.SubItems.Add(TB_PI_ProdStock.Text)
            'val1 = TB_QQuantity.Text
            'val2 = TB_PI_ProdStock.Text
            'curstock = val2 - val1
            'i.SubItems.Add(curstock)

            ' add product item in the listview
            TB_PI_ProdID.Focus()
            Dim TotalSumList As Double = 0, TempNode As ListViewItem, TempDbl As Double, salestax As Double, totalamount As Double, discount As Double, i As ListViewItem, subtotal As Double

            If TB_QQuantity.Text = "" Then : MsgBox("Please input the Quantity of the Product", vbInformation, "Attention") : Exit Sub : End If
            If TB_PI_ProdName.Text = "" Then : MsgBox("Please input the Product Name", vbInformation, "Attention") : Exit Sub : End If
            subtotal = Val(TB_QQuantity.Text) * Val(TB_PI_ProdPrice.Text)

            Dim x As Integer : x = ListView1.Items.Count : If Not x = 11 Then
                If IsNumeric(TB_QQuantity.Text) = False Then : MsgBox("Please enter a valid quantity", vbInformation, "Attention") : TB_QQuantity.Text = "" : TB_QQuantity.Focus() : Exit Sub : End If
                i = ListView1.Items.Add(TB_PI_ProdID.Text)
                i.SubItems.Add(TB_PI_ProdName.Text)
                i.SubItems.Add(TB_PI_ProdDesc.Text)
                i.SubItems.Add(TB_QQuantity.Text)
                i.SubItems.Add(TB_PI_ProdPrice.Text)
                i.SubItems.Add(subtotal)

                MsgBox("Product Item Added", vbInformation, "Attention") : Call Button1_Click(sender, e)
                For Each TempNode In ListView1.Items : If Double.TryParse(TempNode.SubItems.Item(5).Text, TempDbl) Then : TotalSumList += TempDbl : End If : Next

                TB_QSubtotal.Text = (TotalSumList)
                salestax = Val(TB_QSubtotal.Text) * 0.12
                discount = Val(TB_QSubtotal.Text) * Val(TB_Discount.Text)
                TB_DiscountAmount.Text = discount
                TB_QSalestax.Text = (salestax)
                totalamount = (Val(TB_QSubtotal.Text) - Val(TB_DiscountAmount.Text)) + Val(TB_QSalestax.Text) + Val(TB_QOther.Text)
                TB_QTotalamount.Text = totalamount.ToString("N")
            Else : MsgBox("You can't add more items", vbInformation, "Attention") : Exit Sub : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub compute()
        'COMPUTES ALL
        Try
            Dim TotalSumList As Double = 0, TempNode As ListViewItem, TempDbl As Double, salestax As Double, totalamount As Double, discount As Double
            For Each TempNode In ListView1.Items : If Double.TryParse(TempNode.SubItems.Item(5).Text, TempDbl) Then : TotalSumList += TempDbl : End If : Next
            TB_QSubtotal.Text = (TotalSumList)
            salestax = Val(TB_QSubtotal.Text) * 0.12
            discount = Val(TB_QSubtotal.Text) * Val(TB_Discount.Text)
            TB_DiscountAmount.Text = discount
            TB_QSalestax.Text = (salestax)
            totalamount = (Val(TB_QSubtotal.Text) - Val(TB_DiscountAmount.Text)) + Val(TB_QSalestax.Text) + Val(TB_QOther.Text)
            TB_QTotalamount.Text = totalamount.ToString("N")
            If TB_QOther.Text = "" Then : TB_QOther.Text = "0.00" : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_Compute()
        'COMPUTE DISCOUNT
        Try
            Dim msg As String, discountchoice As String = Nothing, discount As Double
            discountchoice = CB_Discount.SelectedItem
            If CB_Discount.SelectedItem = Nothing Then : TB_Discount.Text = "" : Exit Sub : End If
            Select Case discountchoice
                Case "None" : discount = 0.0 : TB_Discount.Text = discount
                Case "5%" : discount = 0.05 : TB_Discount.Text = discount
                Case "10%" : discount = 0.1 : TB_Discount.Text = discount
                Case "15%" : discount = 0.15 : TB_Discount.Text = discount
                Case "20%" : discount = 0.2 : TB_Discount.Text = discount
                Case "25%" : discount = 0.25 : TB_Discount.Text = discount
                Case "30%" : discount = 0.3 : TB_Discount.Text = discount
                Case "35%" : discount = 0.35 : TB_Discount.Text = discount
                Case "40%" : discount = 0.4 : TB_Discount.Text = discount
                Case "45%" : discount = 0.45 : TB_Discount.Text = discount
                Case "50%" : discount = 0.5 : TB_Discount.Text = discount
            End Select
            If IsNumeric(TB_QOther.Text) = False Then : MsgBox("Please enter a valid amount for other fees", vbInformation, "Attention") : TB_QOther.Text = "0.00" : CB_Discount.SelectedItem = Nothing : Exit Sub : End If
            If CB_Discount.SelectedItem = "None" Then : compute() : MsgBox("Discount has been removed!", vbInformation, "Attention") : Exit Sub : End If
            msg = MsgBox("Do you really want to add Discount?", vbInformation + vbYesNo, "Attention")
            If msg = vbYes Then : compute() : MsgBox("Discount has been added!", vbInformation, "Attention") : Exit Sub
            Else : If msg = vbNo Then CB_Discount.SelectedItem = Nothing Exit Sub : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub QuotationNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewPrintQuotationToolStripMenuItem.Enabled = False
        newdata = True
        Label_SaveDate.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
        TB_CustomerID.Focus()
        TB_CustomerID.Select()
        generateid()
        TB_QuotationID.Enabled = False
        TB_PI_ProdName.Enabled = False
        TB_CCompany.Enabled = False
        TB_CName.Enabled = False
        TB_CAddress.Enabled = False
        TB_CPhone.Enabled = False
        TB_CNameS.Enabled = False
        TB_CAddressS.Enabled = False
        TB_CPhoneS.Enabled = False
        TB_Discount.Text = "%"
        Date_QCurrentdate.Enabled = False
        TB_QQuantity.Enabled = False
        Label_QSD1.Visible = False
        Label_QSD2.Visible = False
        Date_QCurrentdate.Visible = False
        Current_date.Enabled = False
        Label_Role.Text = roleq
        If Label_Role.Text = "General Employee" Then : BTN_QUpdate.Enabled = False : BTN_Delete.Enabled = False : Btn_Save.Enabled = False : End If
        Call TB_QTerms_LostFocus(sender, e)
    End Sub

    Private Sub generateid()
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), cmd As New SqlCommand, number As Integer
            cmd.Connection = con : con.Open()
            cmd.CommandText = "SELECT Max(QuotationID) FROM quotationnew"
            If IsDBNull(cmd.ExecuteScalar) Then : number = 1001 : TB_QuotationID.Text = number
            Else : number = cmd.ExecuteScalar + 1 : TB_QuotationID.Text = number : End If
            cmd.Dispose() : con.Close() : con.Dispose()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub
    Public Sub cleartxt()
        TB_QuotationID.Text = ""
        Date_QCurrentdate.Text = ""
        TB_QQuantity.Text = ""
        TB_QSubtotal.Text = "0.00"
        TB_QTaxrate.Text = "12%"
        TB_QSalestax.Text = "0.00"
        Date_QShipdate.Text = ""
        CB_QShipvia.SelectedItem = Nothing
        TB_QSalesperson.Text = ""
        TB_QOther.Text = "0.00"
        CB_Status.SelectedItem = Nothing
        generateid()
        TB_QuotationID.Enabled = False
        TB_CustomerID.Text = ""
        TB_CCompany.Text = ""
        TB_CName.Text = ""
        TB_CAddress.Text = ""
        TB_CPhone.Text = ""
        TB_CNameS.Text = ""
        TB_CAddressS.Text = ""
        TB_CPhoneS.Text = ""
        TB_QTerms.Text = "Optional"
        TB_QTerms.ForeColor = Color.Gray
        TB_PI_ProdID.Text = ""
        TB_PI_ProdName.Text = ""
        TB_QQuantity.Text = ""
        TB_DiscountAmount.Text = ""
        CB_Discount.SelectedItem = Nothing
        ListView1.Items.Clear()
        PictureBox3.Image = My.Resources.Power_Button
        TB_CNameS.Enabled = False
        TB_CAddressS.Enabled = False
        TB_CPhoneS.Enabled = False
        TB_CustomerID.Enabled = True
        Date_QCurrentdate.Enabled = True
        PB_AddP.Enabled = True
        PB_DeleteP.Enabled = True
        Btn_Save.Enabled = True
        BTN_QUpdate.Enabled = True
        PictureBox6.Enabled = True
        PB_EditShip.Enabled = True
        CB_Status.Enabled = True
        TB_QTerms.Enabled = True
        Date_QShipdate.Enabled = True
        CB_QShipvia.Enabled = True
        TB_QSalesperson.Enabled = True
        TB_Discount.Enabled = True
        Date_QCurrentdate.Enabled = False
        PictureBox3_Clicked = False
        TB_QQuantity.Enabled = False
        TB_CustomerID.Focus()
        TB_CustomerID.Select()
        CB_Discount.SelectedItem = Nothing
        TB_Discount.Text = ""
        TB_QTotalamount.Text = "0.00"
        TB_QOther.Enabled = True
        CB_Discount.Enabled = True
        Label_QSD1.Visible = False
        Label_QSD2.Visible = False
        Date_QCurrentdate.Visible = False
        ViewPrintQuotationToolStripMenuItem.Enabled = False
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

    Private Sub PB_DeleteP_Click(sender As Object, e As EventArgs) Handles PB_DeleteP.Click
        Try
            Dim i As ListViewItem
            If ListView1.SelectedItems.Count = 0 Then : MsgBox("Please select a Product Item to delete", vbInformation, "Attention") : Exit Sub
            Else : i = ListView1.SelectedItems(0) : i.Remove() : compute() : MsgBox("Selected product item has been removed", vbInformation, "Attention")
                If ListView1.Items.Count = 0 Then : TB_QOther.Text = "" : TB_Discount.Text = "" : compute() : TB_PI_ProdID.Text = "" : TB_PI_ProdID.Focus() : TB_PI_ProdID.Select() : End If
            End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Try
            Dim msg As String, savee As String, saveq As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from quotationnew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then : msg = MsgBox("This quotation is already in the database, Would you like to update it instead?", vbInformation + vbYesNo, "Attention")
                If msg = vbYes Then : Call BTN_QUpdate_Click(sender, e) : Exit Sub
                Else : msg = vbNo : Exit Sub : End If
            End If
            If (TB_CustomerID.Text = "" OrElse TB_CCompany.Text = "" OrElse TB_CName.Text = "" OrElse TB_CAddress.Text = "" OrElse TB_CNameS.Text = "" OrElse TB_CAddressS.Text = "" OrElse TB_QuotationID.Text = "" OrElse CB_QShipvia.SelectedItem = "" OrElse TB_QSalesperson.Text = "" OrElse CB_Status.SelectedItem = "" OrElse TB_QTotalamount.Text = "0.00") Then : MsgBox("Please complete the quotation information", vbInformation, "Quotation Information Incomplete") : Exit Sub : End If
            If ListView1.Items.Count = 0 Then : MsgBox("Please complete the Quotation Information", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_QOther.Text) = False Then : MsgBox("Please enter a valid amount for other fees", vbInformation, "Attention") : TB_QOther.Text = "0.00" : Exit Sub : End If
            If newdata Then : msg = MsgBox("Do you want to save the data to the database?", vbYesNo + vbInformation, "Attention!")
                If msg = vbNo Then : Exit Sub : End If
                If ListView1.Items.Count > 0 Then
                    For i = 0 To ListView1.Items.Count - 1
                        savee = "INSERT into orders(QuotationID,ProductID,ProductName,Description,Quantity,Price,Total) VALUES('" & TB_QuotationID.Text & "','" & ListView1.Items(i).Text & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "','" & ListView1.Items(i).SubItems(5).Text & "')" : runSQL(savee)
                    Next
                    CB_Status.SelectedItem = "OPEN"
                    If TB_QTerms.Text = "Optional" Then : TB_QTerms.Text = "None" : End If
                    saveq = "INSERT into quotationnew(QuotationID,Date,CustomerID,CustomerCompany,CustomerName,CustomerAddress,CustomerPhone,RecipientName,RecipientAddress,RecipientPhone,QuotationStatus,Terms,ShipDate,ShipVia,SalesPerson,SubTotal,DiscountAmount,SalesTax,Other,TotalAmount) VALUES('" & TB_QuotationID.Text & "','" & Date_QCurrentdate.Text & "','" & TB_CustomerID.Text & "','" & TB_CCompany.Text & "','" & TB_CName.Text & "','" & TB_CAddress.Text & "','" & TB_CPhone.Text & "','" & TB_CNameS.Text & "','" & TB_CAddressS.Text & "','" & TB_CPhoneS.Text & "','" & CB_Status.SelectedItem & "','" & TB_QTerms.Text & "','" & Date_QShipdate.Text & "','" & CB_QShipvia.SelectedItem & "','" & TB_QSalesperson.Text & "','" & TB_QSubtotal.Text & "','" & TB_DiscountAmount.Text & "','" & TB_QSalestax.Text & "','" & TB_QOther.Text & "','" & TB_QTotalamount.Text & "')"
                    MsgBox("Quotation Information Saved", vbInformation, "Saved")
                    runSQL(saveq) : cleartxt()
                End If
            End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Public Sub listinfo()
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from quotationnew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim da As New SqlClient.SqlDataAdapter("select * from orders where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim dt As New DataTable, ds As New DataSet
            con.Open() : dr = cmd.ExecuteReader : ds.Tables.Add(dt) : da.Fill(dt)
            If dr.Read = True Then : CB_Status.SelectedItem = dr(10).ToString
                If CB_Status.SelectedItem = "CLOSED" Then : MsgBox("You cannot make any changes in this quotation because it's status is already closed", vbInformation, "Attention") : disablee() : End If
                If CB_Status.SelectedItem = "OPEN" Then : ViewPrintQuotationToolStripMenuItem.Enabled = True : End If

                ListView1.Items.Clear()
                TB_CustomerID.Enabled = False
                TB_PI_ProdID.Text = ""
                TB_PI_ProdName.Text = ""
                TB_QQuantity.Text = ""
                Date_QCurrentdate.Enabled = False
                Orig_QID.Text = dr(0).ToString
                TB_QuotationID.Text = dr(0).ToString
                Date_QCurrentdate.Text = dr(1).ToString
                TB_CustomerID.Text = dr(2).ToString
                TB_CCompany.Text = dr(3).ToString
                TB_CName.Text = dr(4).ToString
                TB_CAddress.Text = dr(5).ToString
                TB_CPhone.Text = dr(6).ToString
                TB_CNameS.Text = dr(7).ToString
                TB_CAddressS.Text = dr(8).ToString
                TB_CPhoneS.Text = dr(9).ToString
                CB_Status.SelectedItem = dr(10).ToString
                TB_QTerms.Text = dr(11).ToString
                Date_QShipdate.Text = dr(12).ToString
                CB_QShipvia.SelectedItem = dr(13).ToString
                TB_QSalesperson.Text = dr(14).ToString
                TB_QSubtotal.Text = dr(15).ToString
                TB_DiscountAmount.Text = dr(16).ToString
                TB_QSalestax.Text = dr(17).ToString
                TB_QOther.Text = dr(18).ToString
                TB_QTerms.ForeColor = Color.Black
                TB_QTerms.Font = New Font(TB_QTerms.Font, FontStyle.Regular)
                Label_QSD1.Visible = True
                Label_QSD2.Visible = True
                Date_QCurrentdate.Visible = True
                CB_Discount.SelectedItem = Nothing

                Dim totalamount As Double, discountz As Double, myRow As DataRow
                totalamount = dr(19).ToString : TB_QTotalamount.Text = totalamount.ToString("N")
                discountz = TB_DiscountAmount.Text / TB_QSubtotal.Text : TB_Discount.Text = discountz

                For Each myRow In dt.Rows
                    ListView1.Items.Add(myRow.Item(1))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(2))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(3))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(4))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(5))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(6))
                Next

            Else : MsgBox("Quotation ID not found!", vbInformation, "Search") : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Public Sub disablee()
        'WHEN QUOTATION STATUS IS CLOSED, DISABLES ALL THE CODES BELOW
        PB_AddP.Enabled = False
        PB_DeleteP.Enabled = False
        Btn_Save.Enabled = False
        BTN_QUpdate.Enabled = False
        PictureBox6.Enabled = False
        PB_EditShip.Enabled = False
        CB_Status.Enabled = False
        TB_QTerms.Enabled = False
        Date_QShipdate.Enabled = False
        CB_QShipvia.Enabled = False
        TB_QSalesperson.Enabled = False
        TB_PI_ProdID.Enabled = False
        TB_QQuantity.Enabled = False
        PB_SearchP.Enabled = False
        BTN_Delete.Enabled = False
        TB_QOther.Enabled = False
        CB_Discount.Enabled = False
        ViewPrintQuotationToolStripMenuItem.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'SEARCH BUTTON
        Try
            If TB_QuotationID.Enabled = False Then : MsgBox("Please turn on the Quotation Search Switch Button first", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_QuotationID.Text) = False Then : MsgBox("Please enter a valid Quotation ID", vbInformation, "Attention") : Exit Sub : End If
            If TB_QuotationID.Text = "" Then : MsgBox("Please enter a Quotation ID to search", vbInformation, "Attention") : Exit Sub : End If
            listinfo()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_QUpdate_Click(sender As Object, e As EventArgs) Handles BTN_QUpdate.Click
        Try
            Dim updateq As String, DeleteOrders As String, savee As String, msg As String
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from quotationnew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = False Then : MsgBox("Please use the save button instead if you want to save this quotation", vbInformation, "Attention") : Exit Sub : End If
            If ListView1.Items.Count = 0 Then : MsgBox("Please complete the Quotation Information", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_QOther.Text) = False Then : MsgBox("Please enter a valid amount for other fees", vbInformation, "Attention") : TB_QOther.Text = "0.00" : Exit Sub : End If
            'returns original value of quotation id if the user changed it
            If Orig_QID.Text <> TB_QuotationID.Text Then : TB_QuotationID.Text = Orig_QID.Text : End If
            msg = MsgBox("Are you sure you want to update the quotation information?", vbInformation + vbYesNo, "Attention")
            If msg = vbNo Then Exit Sub
            DeleteOrders = "DELETE FROM orders WHERE QuotationID='" & TB_QuotationID.Text & "' " : runSQL(DeleteOrders)
            If ListView1.Items.Count > 0 Then
                For i = 0 To ListView1.Items.Count - 1
                    savee = "INSERT into orders(QuotationID,ProductID,ProductName,Description,Quantity,Price,Total) VALUES('" & TB_QuotationID.Text & "','" & ListView1.Items(i).Text & "','" & ListView1.Items(i).SubItems(1).Text & "','" & ListView1.Items(i).SubItems(2).Text & "','" & ListView1.Items(i).SubItems(3).Text & "','" & ListView1.Items(i).SubItems(4).Text & "','" & ListView1.Items(i).SubItems(5).Text & "')" : runSQL(savee)
                Next
                '    Label_modify.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
                If CB_Status.SelectedItem = "CLOSED" Then : MsgBox("You can only choose OPEN or CANCELLED for this quotation", vbInformation, "Attention") : CB_Status.SelectedItem = "OPEN" : Exit Sub : End If
                If TB_QTerms.Text = "Optional" Then : TB_QTerms.Text = "None" : End If
                updateq = "UPDATE quotationnew SET QuotationID='" & TB_QuotationID.Text & "',Date='" & Date_QCurrentdate.Text & "',CustomerID='" & TB_CustomerID.Text & "',CustomerCompany='" & TB_CCompany.Text & "',CustomerName='" & TB_CName.Text & "',CustomerAddress='" & TB_CAddress.Text & "',CustomerPhone='" & TB_CPhone.Text & "',RecipientName='" & TB_CNameS.Text & "',RecipientAddress='" & TB_CAddressS.Text & "',RecipientPhone='" & TB_CPhoneS.Text & "',QuotationStatus='" & CB_Status.SelectedItem & "',Terms='" & TB_QTerms.Text & "',ShipDate='" & Date_QShipdate.Text & "',ShipVia='" & CB_QShipvia.SelectedItem & "',SalesPerson='" & TB_QSalesperson.Text & "',SubTotal='" & TB_QSubtotal.Text & "',DiscountAmount='" & TB_DiscountAmount.Text & "',SalesTax='" & TB_QSalestax.Text & "',Other='" & TB_QOther.Text & "',TotalAmount='" & TB_QTotalamount.Text & "' WHERE QuotationID='" & TB_QuotationID.Text & "' " : MsgBox("Quotation Information Updated", vbInformation, "Updated")
                runSQL(updateq) : cleartxt() : con.Close()
            End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles BTN_Delete.Click
        Try
            BTN_Delete_Clicked = True
            Dim DeleteData As String, DeleteOrders As String, msg As String
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from quotationnew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If IsNumeric(TB_QuotationID.Text) = False OrElse TB_QuotationID.Text = "" OrElse dr.Read = False Then : msg = MsgBox("Please enter a valid Quotation ID to delete", vbInformation, "Attention")
            Else : listinfo()
                If CB_Status.SelectedItem = "CLOSED" Then : disablee() : Exit Sub : End If
                msg = MsgBox("Are you sure you want to delete the data from the database?", vbExclamation + vbYesNo, "Warning")
                If msg = vbNo Then Exit Sub
                DeleteData = "DELETE FROM quotationnew WHERE QuotationID='" & TB_QuotationID.Text & "' "
                DeleteOrders = "DELETE FROM orders WHERE QuotationID='" & TB_QuotationID.Text & "' "
                MsgBox("Quotation Information Deleted", vbInformation, "Deleted")
                runSQL(DeleteData) : runSQL(DeleteOrders) : cleartxt() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub TB_QuotationID_TextChanged(sender As Object, e As EventArgs) Handles TB_QuotationID.TextChanged
        If CB_Status.SelectedItem = "OPEN" Then : CB_Status.Enabled = True : End If
        If PictureBox3_Clicked = True Then
            If TB_QuotationID.Text = "" Then
                TB_CustomerID.Enabled = False
                Date_QCurrentdate.Text = ""
                TB_QQuantity.Text = ""
                TB_QSubtotal.Text = "0.00"
                TB_QTaxrate.Text = "12%"
                TB_QSalestax.Text = "0.00"
                Date_QShipdate.Text = ""
                CB_QShipvia.SelectedItem = Nothing
                TB_QSalesperson.Text = ""
                TB_QOther.Text = "0.00"
                CB_Status.SelectedItem = Nothing
                TB_CCompany.Focus()
                TB_CCompany.Select()
                TB_CustomerID.Text = ""
                TB_CCompany.Text = ""
                TB_CName.Text = ""
                TB_CAddress.Text = ""
                TB_CPhone.Text = ""
                TB_CNameS.Text = ""
                TB_CAddressS.Text = ""
                TB_CPhoneS.Text = ""
                TB_QTerms.Text = ""
                TB_PI_ProdID.Text = ""
                TB_PI_ProdName.Text = ""
                TB_QQuantity.Text = ""
                TB_DiscountAmount.Text = ""
                TB_Discount.Text = ""
                ListView1.Items.Clear()
                TB_CNameS.Enabled = False
                TB_CAddressS.Enabled = False
                TB_CPhoneS.Enabled = False
                PB_AddP.Enabled = True
                PB_DeleteP.Enabled = True
                Btn_Save.Enabled = True
                BTN_QUpdate.Enabled = True
                PictureBox6.Enabled = True
                PB_EditShip.Enabled = True
                CB_Status.Enabled = True
                TB_QTerms.Enabled = True
                Date_QShipdate.Enabled = True
                CB_QShipvia.Enabled = True
                TB_QSalesperson.Enabled = True
                TB_PI_ProdID.Enabled = True
                PB_SearchP.Enabled = True
                BTN_Delete.Enabled = True
                TB_QOther.Enabled = True
                CB_Discount.Enabled = True
                TB_QTotalamount.Text = "0.00"
                Label_QSD1.Visible = False
                Label_QSD2.Visible = False
                Date_QCurrentdate.Visible = False
                ViewPrintQuotationToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'TURNS ON Quotation Search Switch Button
        PictureBox3_Clicked = True : TB_QuotationID.Enabled = True : TB_QuotationID.Focus()
        If TB_QuotationID.Enabled = True Then : PictureBox3.Image = My.Resources.Power_Button1 : TB_QuotationID.Text = "" : TB_CustomerID.Enabled = False : End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CLEAR PRODUCT ITEMS
        TB_PI_ProdID.Text = "" : TB_PI_ProdName.Text = "" : TB_QQuantity.Text = ""
    End Sub
    Private Sub TB_PI_ProdID_TextChanged(sender As Object, e As EventArgs) Handles TB_PI_ProdID.TextChanged
        'CLEARS THE CODE BELOW WHEN TEXT IS CHANGED
        If TB_PI_ProdID.Text = "" Then : TB_PI_ProdName.Text = "" : TB_QQuantity.Text = "" : TB_QQuantity.Enabled = False : End If
    End Sub
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        'FOR USER ROLES
        Dim objrole As New ControlPanel : objrole.role = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub
    Private Sub PB_SearchP_MouseHover(sender As Object, e As EventArgs) Handles PB_SearchP.MouseHover
        PB_SearchP.Image = My.Resources.search1
    End Sub

    Private Sub PB_SearchP_MouseLeave(sender As Object, e As EventArgs) Handles PB_SearchP.MouseLeave
        PB_SearchP.Image = My.Resources.search
    End Sub

    Private Sub PB_AddP_MouseHover(sender As Object, e As EventArgs) Handles PB_AddP.MouseHover
        PB_AddP.Image = My.Resources.add_1_iconhover
    End Sub

    Private Sub PB_AddP_MouseLeave(sender As Object, e As EventArgs) Handles PB_AddP.MouseLeave
        PB_AddP.Image = My.Resources.add_1_icon
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        CustomerList.Show()
    End Sub

    Private Sub ProductListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click
        ProductList.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Calculator.Show()
    End Sub
    Private Sub PB_New_Click(sender As Object, e As EventArgs) Handles PB_New.Click
        cleartxt()
    End Sub

    Private Sub PB_EditShip_MouseHover(sender As Object, e As EventArgs) Handles PB_EditShip.MouseHover
        PB_EditShip.Image = My.Resources.editshiphover
    End Sub

    Private Sub PB_EditShip_MouseLeave(sender As Object, e As EventArgs) Handles PB_EditShip.MouseLeave
        PB_EditShip.Image = My.Resources.editship
    End Sub

    Private Sub PB_EditShip_Click(sender As Object, e As EventArgs) Handles PB_EditShip.Click
        'ENABLE EDIT SHIPPING ADDRESS
        If TB_CustomerID.Text = "" OrElse TB_CName.Text = "" OrElse TB_CAddress.Text = "" Then : MsgBox("Please enter the billing address first", vbInformation, "Attention") : Exit Sub : End If
        TB_CNameS.Enabled = True : TB_CAddressS.Enabled = True : TB_CPhoneS.Enabled = True
    End Sub

    Private Sub PB_EditShip_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PB_EditShip.MouseDoubleClick
        'DISABLE EDIT SHIPPING ADDRESS
        TB_CNameS.Enabled = False : TB_CAddressS.Enabled = False : TB_CPhoneS.Enabled = False
    End Sub

    Private Sub PB_DeleteP_MouseHover(sender As Object, e As EventArgs) Handles PB_DeleteP.MouseHover
        PB_DeleteP.Image = My.Resources.deletephover
    End Sub

    Private Sub PB_DeleteP_MouseLeave(sender As Object, e As EventArgs) Handles PB_DeleteP.MouseLeave
        PB_DeleteP.Image = My.Resources.deletep
    End Sub
    Private Sub PictureBox3_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        'TURN OFF QUOTATION SWITCH SEARCH BUTTON
        TB_CustomerID.Enabled = True : TB_QuotationID.Enabled = False
        If TB_QuotationID.Enabled = False Then : cleartxt() : End If
    End Sub

    Private Sub TB_QOther_Leave(sender As Object, e As EventArgs) Handles TB_QOther.Leave
        If TB_QOther.Text = "" Then : TB_QOther.Text = "0.00" : End If
    End Sub

    Private Sub TB_Discount_Leave(sender As Object, e As EventArgs) Handles TB_Discount.Leave
        If TB_Discount.Text = "" Then : TB_Discount.Text = "%" : End If
    End Sub

    Private Sub TB_QOther_Enter(sender As Object, e As EventArgs) Handles TB_QOther.Enter
        If TB_QOther.Text = "0.00" Then : TB_QOther.Text = "" : End If
    End Sub

    Private Sub TB_Discount_Enter(sender As Object, e As EventArgs) Handles TB_Discount.Enter
        If TB_Discount.Text = "%" Then : TB_Discount.Text = "" : End If
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.search1
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.search
    End Sub

    Private Sub PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        PictureBox6.Image = My.Resources.search1
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Image = My.Resources.search
    End Sub
    Private Sub TB_QuotationID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_QuotationID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PictureBox2_Click(sender, e) : End If
    End Sub

    Private Sub TB_CustomerID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_CustomerID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PictureBox6_Click(sender, e) : End If
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then : Call Btn_Save_Click(sender, e) : End If
        If (e.KeyCode = Keys.U AndAlso e.Modifiers = Keys.Control) Then : Call BTN_QUpdate_Click(sender, e) : End If
    End Sub

    Private Sub TB_PI_ProdID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_PI_ProdID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PB_SearchP_Click(sender, e) : End If
    End Sub

    Private Sub QuotationNew_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        TB_CustomerID.Focus() : TB_CustomerID.Select()
    End Sub

    Private Sub TB_QQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_QQuantity.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PB_AddP_Click(sender, e) : End If
    End Sub

    Private Sub TB_Discount_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_Discount.KeyDown
        If e.KeyCode = Keys.Enter Then : BTN_Compute() : End If
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Delete Then : Call PB_DeleteP_Click(sender, e) : End If
    End Sub

    Private Sub TB_QTerms_GotFocus(sender As Object, e As EventArgs) Handles TB_QTerms.GotFocus
        'PLACEHOLDER
        If TB_QTerms.Text = "Optional" Then : TB_QTerms.ForeColor = Color.Black : TB_QTerms.Text = "" : TB_QTerms.Font = New Font(TB_QTerms.Font, FontStyle.Regular) : End If
    End Sub

    Private Sub TB_QTerms_LostFocus(sender As Object, e As EventArgs) Handles TB_QTerms.LostFocus
        'PLACEHOLDER
        If TB_QTerms.Text = "" Then : TB_QTerms.ForeColor = Color.Gray : TB_QTerms.Text = "Optional" : TB_QTerms.Font = New Font(TB_QTerms.Font, FontStyle.Italic) : End If
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

    Private Sub TB_QOther_TextChanged(sender As Object, e As EventArgs) Handles TB_QOther.TextChanged
        Dim totalamount As Double
        totalamount = (Val(TB_QSubtotal.Text) - Val(TB_DiscountAmount.Text)) + Val(TB_QSalestax.Text) + Val(TB_QOther.Text)
        TB_QTotalamount.Text = totalamount.ToString("N")
    End Sub

    Private Sub QuotationListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuotationListToolStripMenuItem1.Click
        QuotationList.Show()
    End Sub

    Private Sub ViewPrintQuotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPrintQuotationToolStripMenuItem.Click
        Dim TB_QuotationID1 As New PrintQuotation
        TB_QuotationID1.QuotationID2 = TB_QuotationID.Text
        cleartxt()
        TB_QuotationID1.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CB_Discount_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Discount.SelectedValueChanged
        BTN_Compute()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
    End Sub
End Class


