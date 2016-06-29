Imports System.Data.SqlClient

Public Class Products
    Public Property rolep As String
    Dim newdata As Boolean

    Public Sub cleartxt()
        newdata = True
        TB_PI_ProdID.Clear()
        TB_PI_ProdName.Clear()
        TB_PI_ProdPrice.Clear()
        TB_PI_ProdDesc.Clear()
        TB_PI_ProdQuant.Clear()
        CB_PI_ProdCateg.SelectedItem = Nothing
        CB_PI_ProdColor.SelectedItem = Nothing
        CB_PI_ProdSize.SelectedItem = Nothing
        TB_InputData.Text = ""
        Label_barcode.Text = ""
        TB_PI_ProdID.Enabled = False
        PictureBox1.Image = My.Resources.Power_Button
        generateid()
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newdata = True
        TB_PI_ProdID.Enabled = False
        TB_InputData.Enabled = False
        Label9.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
        showData()
        generateid()
        PictureBox1.Image = My.Resources.Power_Button
        Label_Role.Text = rolep
        If Label_Role.Text = "General Employee" Then : Btn_SaveProd.Enabled = False : Btn_UpdateProd.Enabled = False : Btn_DeleteProd.Enabled = False : End If
    End Sub
    Private Sub generateid()
        Try
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), cmd As New SqlCommand, number As Integer
            cmd.Connection = con : con.Open() : cmd.CommandText = "SELECT Max(ProductID) FROM products"
            If IsDBNull(cmd.ExecuteScalar) Then : number = 1001 : TB_PI_ProdID.Text = number
            Else : number = cmd.ExecuteScalar + 1 : TB_PI_ProdID.Text = number : End If
            cmd.Dispose() : con.Close() : con.Dispose()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub
    Sub showData()
        konekDB()
        Dim dA As SqlDataAdapter = New SqlDataAdapter("SELECT ProductID,ProductName,ProductDesc,ProductQuantity,ProductPrice,ProductSize,ProductCategory,ProductColor,ProductBarcode,ProductDate,ProductMod FROM products", konek)
        Dim dS As DataSet = New DataSet
        dS.Clear() : dA.Fill(dS, "products") : DataGridView1.DataSource = (dS.Tables("products")) : DataGridView1.Enabled = True
        dA.Dispose() : konek.Close()
    End Sub

    Private Sub barcode()
        Try
            If IsNumeric(TB_PI_ProdID.Text) = False Then : generateid() : Exit Sub : End If
            If CB_PI_ProdSize.SelectedItem = Nothing OrElse CB_PI_ProdCateg.SelectedItem = Nothing OrElse CB_PI_ProdColor.SelectedItem = Nothing Then : MsgBox("Please complete the Product Information", vbInformation, "Attention") : Exit Sub : End If
            Dim size As String = Nothing, category As String = Nothing, color As String = Nothing
            Dim sizes As String, categorys As String, colors As String
            size = CB_PI_ProdSize.SelectedItem : category = CB_PI_ProdCateg.SelectedItem : color = CB_PI_ProdColor.SelectedItem
            Select Case size
                Case "Small" : sizes = "1" : TextBox1.Text = sizes
                Case "Medium" : sizes = "2" : TextBox1.Text = sizes
                Case "Large" : sizes = "3" : TextBox1.Text = sizes
                Case "N/A" : sizes = "4" : TextBox1.Text = sizes
            End Select
            Select Case category
                Case "Food" : categorys = "1" : TextBox2.Text = categorys
                Case "Miscellaneous" : categorys = "2" : TextBox2.Text = categorys
                Case "Appliances" : categorys = "3" : TextBox2.Text = categorys
                Case "Computer Peripherals" : categorys = "4" : TextBox2.Text = categorys
            End Select
            Select Case color
                Case "Brown" : colors = "1" : TextBox3.Text = colors
                Case "Yellow" : colors = "2" : TextBox3.Text = colors
                Case "Blue" : colors = "3" : TextBox3.Text = colors
                Case "Silver" : colors = "4" : TextBox3.Text = colors
                Case "White" : colors = "5" : TextBox3.Text = colors
                Case "N/A" : colors = "6" : TextBox3.Text = colors
            End Select
            Dim barc As String
            barc = Date.Now.ToString("yyyyMMdd") & TextBox1.Text & TextBox2.Text & TextBox3.Text & TB_PI_ProdID.Text
            TB_InputData.Text = barc : TB_EncodedData.Text = "!" + TB_InputData.Text + "!" : Label_barcode.Text = TB_EncodedData.Text
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub
    Private Sub wtextbox(ByVal x As Integer)
        Try
            Orig_ID.Text = DataGridView1.Rows(x).Cells(0).Value
            TB_PI_ProdID.Text = DataGridView1.Rows(x).Cells(0).Value
            TB_PI_ProdName.Text = DataGridView1.Rows(x).Cells(1).Value
            TB_PI_ProdDesc.Text = DataGridView1.Rows(x).Cells(2).Value
            TB_PI_ProdQuant.Text = DataGridView1.Rows(x).Cells(3).Value
            CB_PI_ProdColor.Text = DataGridView1.Rows(x).Cells(7).Value
            CB_PI_ProdSize.Text = DataGridView1.Rows(x).Cells(5).Value
            CB_PI_ProdCateg.Text = DataGridView1.Rows(x).Cells(6).Value
            TB_PI_ProdPrice.Text = DataGridView1.Rows(x).Cells(4).Value
            Label_barcode.Text = DataGridView1.Rows(x).Cells(8).Value
            TB_InputData.Text = ""
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


    Private Sub BTN_CreateBar_Click(sender As Object, e As EventArgs)
        Try
            If CB_PI_ProdSize.SelectedItem = Nothing OrElse CB_PI_ProdCateg.SelectedItem = Nothing OrElse CB_PI_ProdColor.SelectedItem = Nothing Then : MsgBox("Please complete the Product Information", vbInformation, "Attention") : Exit Sub : End If
            Dim size As String = Nothing, category As String = Nothing, color As String = Nothing
            Dim sizes As String, categorys As String, colors As String
            size = CB_PI_ProdSize.SelectedItem : category = CB_PI_ProdCateg.SelectedItem : color = CB_PI_ProdColor.SelectedItem
            Select Case size
                Case "Small" : sizes = "1" : TextBox1.Text = sizes
                Case "Medium" : sizes = "2" : TextBox1.Text = sizes
                Case "Large" : sizes = "3" : TextBox1.Text = sizes
                Case "N/A" : sizes = "4" : TextBox1.Text = sizes
            End Select
            Select Case category
                Case "Food" : categorys = "1" : TextBox2.Text = categorys
                Case "Miscellaneous" : categorys = "2" : TextBox2.Text = categorys
                Case "Appliances" : categorys = "3" : TextBox2.Text = categorys
                Case "Computer Peripherals" : categorys = "4" : TextBox2.Text = categorys
            End Select
            Select Case color
                Case "Brown" : colors = "1" : TextBox3.Text = colors
                Case "Yellow" : colors = "2" : TextBox3.Text = colors
                Case "Blue" : colors = "3" : TextBox3.Text = colors
                Case "Silver" : colors = "4" : TextBox3.Text = colors
                Case "White" : colors = "5" : TextBox3.Text = colors
                Case "N/A" : colors = "6" : TextBox3.Text = colors
            End Select
            Dim barc As String
            barc = Date.Now.ToString("yyyyMMdd") & TextBox1.Text & TextBox2.Text & TextBox3.Text & TB_PI_ProdID.Text
            TB_InputData.Text = barc : TB_EncodedData.Text = "!" + TB_InputData.Text + "!" : Label_barcode.Text = TB_EncodedData.Text
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub PB_Search_Click(sender As Object, e As EventArgs) Handles PB_Search.Click
        Try
            If TB_PI_ProdID.Enabled = False Then : MsgBox("Please turn on the Product Search Switch Button first", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_PI_ProdID.Text) = False Then : MsgBox("Please enter a valid Product ID", vbInformation, "Attention") : Exit Sub : End If
            If TB_PI_ProdID.Text = "" Then : MsgBox("Please enter a Product ID to search", vbInformation, "Attention") : Exit Sub : End If
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from products where ProductID='" & TB_PI_ProdID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then
                Orig_ID.Text = dr(0).ToString
                TB_PI_ProdID.Text = dr(0).ToString
                TB_PI_ProdName.Text = dr(1).ToString
                TB_PI_ProdDesc.Text = dr(2).ToString
                TB_PI_ProdQuant.Text = dr(3).ToString
                CB_PI_ProdColor.Text = dr(4).ToString
                CB_PI_ProdSize.Text = dr(5).ToString
                CB_PI_ProdCateg.Text = dr(6).ToString
                TB_PI_ProdPrice.Text = dr(7).ToString
                Label_barcode.Text = dr(8).ToString

            Else : MsgBox("Product ID not found!", vbInformation, "Search") : TB_PI_ProdID.Focus() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_SaveProd.Click
        Try
            If IsNumeric(TB_PI_ProdID.Text) = False Then : generateid() : Exit Sub : End If
            Dim msg As String, savee As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from products where ProductID='" & TB_PI_ProdID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = True Then : msg = MsgBox("This product is already in the database, Would you like to update it instead?", vbInformation + vbYesNo, "Attention")
                If msg = vbYes Then : Call BTN_QUpdate_Click(sender, e) : Exit Sub
                Else : msg = vbNo : Exit Sub : End If
            End If
            If IsNumeric(TB_PI_ProdID.Text) = False Then : MsgBox("Please enter a valid product id", vbInformation, "Attention") : generateid() : Exit Sub : End If
            If (TB_PI_ProdID.Text = "" OrElse TB_PI_ProdName.Text = "" OrElse TB_PI_ProdQuant.Text = "" OrElse TB_PI_ProdPrice.Text = "" OrElse CB_PI_ProdSize.SelectedItem = "" OrElse CB_PI_ProdCateg.SelectedItem = "" OrElse CB_PI_ProdColor.SelectedItem = "") Then
                MsgBox("Please complete the Product Information", vbInformation, "Product Information Incomplete") : Exit Sub : End If
            If IsNumeric(TB_PI_ProdQuant.Text) = False Then : MsgBox("Please enter a valid quantity", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_PI_ProdPrice.Text) = False Then : MsgBox("Please enter a valid price", vbInformation, "Attention") : Exit Sub : End If
            '  If TB_InputData.Text = "" Then : MsgBox("Please create a barcode for this product", vbInformation, "Attention") : Exit Sub : End If
            If newdata Then : msg = MsgBox("Do you want to save this Product Information?", vbYesNo + vbInformation, "Attention!")
                generateid() : barcode()
                If msg = vbNo Then : Exit Sub : End If
                savee = "INSERT into products(ProductID,ProductName,ProductDesc,ProductQuantity,ProductPrice,ProductSize,ProductCategory,ProductColor,ProductBarcode,ProductDate) VALUES('" & TB_PI_ProdID.Text & "','" & TB_PI_ProdName.Text & "','" & TB_PI_ProdDesc.Text & "','" & TB_PI_ProdQuant.Text & "','" & TB_PI_ProdPrice.Text & "', '" & CB_PI_ProdSize.Text & "','" & CB_PI_ProdCateg.Text & "','" & CB_PI_ProdColor.Text & "','" & Label_barcode.Text & "','" & Label9.Text & "')" : MsgBox("Product Information Saved", vbInformation, "Saved")
                runSQL(savee) : showData() : cleartxt() : generateid() : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_QUpdate_Click(sender As Object, e As EventArgs) Handles Btn_UpdateProd.Click
        Try
            Dim updatee As String, msg As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from products where ProductID='" & TB_PI_ProdID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If dr.Read = False Then : MsgBox("Please use the save button instead if you want to save this product", vbInformation, "Attention") : Exit Sub : End If
            If Label_barcode.Text = "" Then : MsgBox("Not Allowed", vbInformation, "Attention") : cleartxt() : Exit Sub : End If
            If Orig_ID.Text <> TB_PI_ProdID.Text Then : TB_PI_ProdID.Text = Orig_ID.Text : End If
            If IsNumeric(TB_PI_ProdPrice.Text) = False Then : MsgBox("Please enter a valid price", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_PI_ProdQuant.Text) = False Then : MsgBox("Please enter a valid quantity", vbInformation, "Attention") : Exit Sub : End If
            If IsNumeric(TB_PI_ProdID.Text) = False OrElse TB_PI_ProdID.Text = "" Then : MsgBox("Please enter a valid Product ID to update", vbInformation, "Attention") : Exit Sub : End If
            msg = MsgBox("Are you sure you want to update the Product Information?", vbInformation + vbYesNo, "Attention")
            If msg = vbNo Then Exit Sub
            Label_Mod.Text = Date.Now.ToString("hh:mm tt, MMM dd, yyyy")
            updatee = "UPDATE products SET ProductName='" & TB_PI_ProdName.Text & "', ProductDesc='" & TB_PI_ProdDesc.Text & "', ProductQuantity='" & TB_PI_ProdQuant.Text & "', ProductPrice='" & TB_PI_ProdPrice.Text & "', ProductSize='" & CB_PI_ProdSize.Text & "', ProductCategory='" & CB_PI_ProdCateg.Text & "', ProductColor='" & CB_PI_ProdColor.Text & "', ProductBarcode='" & Label_barcode.Text & "', ProductMod='" & Label_Mod.Text & "' WHERE ProductID='" & TB_PI_ProdID.Text & "' " : MsgBox("Product Information Updated", vbInformation, "Updated")
            runSQL(updatee) : showData() : cleartxt() : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_Delete_Click(sender As Object, e As EventArgs) Handles Btn_DeleteProd.Click
        Try
            Dim DeleteData As String, msg As String, con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from products where ProductID='" & TB_PI_ProdID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            con.Open() : dr = cmd.ExecuteReader
            If IsNumeric(TB_PI_ProdID.Text) = False OrElse TB_PI_ProdID.Text = "" OrElse dr.Read = False Then : MsgBox("Please enter a valid Product ID to delete", vbInformation, "Attention") : Exit Sub : End If
            msg = MsgBox("Are you sure you want to delete this Product Information?", vbExclamation + vbYesNo, "Warning")
            If msg = vbNo Then Exit Sub
            DeleteData = "DELETE FROM products WHERE ProductID='" & TB_PI_ProdID.Text & "' " : MsgBox("Product Information Deleted", vbInformation, "Deleted")
            runSQL(DeleteData) : showData() : cleartxt() : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_ClearBar_Click(sender As Object, e As EventArgs)
        TB_InputData.Text = "" : Label_barcode.Text = ""
    End Sub
    Private Sub PB_Search_MouseHover(sender As Object, e As EventArgs) Handles PB_Search.MouseHover
        PB_Search.Image = My.Resources.search1
    End Sub

    Private Sub PB_Search_MouseLeave(sender As Object, e As EventArgs) Handles PB_Search.MouseLeave
        PB_Search.Image = My.Resources.search
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cleartxt() : TB_PI_ProdID.Enabled = True : PictureBox1.Image = My.Resources.Power_Button1 : TB_PI_ProdID.Text = "" : TB_PI_ProdID.Focus()
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        TB_PI_ProdID.Enabled = False : cleartxt()
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        'USER ROLES
        Dim objrole As New ControlPanel : objrole.role = Label_Role.Text : objrole.Show() : Me.Close()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        cleartxt()
    End Sub

    Private Sub PB_New_Click(sender As Object, e As EventArgs) Handles Btn_NewProd.Click
        cleartxt() : generateid()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'FILLS THE DATAGRIDVIEW
        wtextbox(e.RowIndex)
    End Sub

    Private Sub Btn_NewProd_Click(sender As Object, e As EventArgs)
        cleartxt() : generateid()
    End Sub

    Private Sub Btn_BackProd_Click(sender As Object, e As EventArgs)
        'BACK TO MAINMENU
        ControlPanel.Show() : Me.Hide()
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
        Call Btn_Save_Click(sender, e)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Call BTN_QUpdate_Click(sender, e)
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Call BTN_Delete_Click(sender, e)
    End Sub
    Private Sub TB_PI_ProdID_KeyDown(sender As Object, e As KeyEventArgs) Handles TB_PI_ProdID.KeyDown
        If e.KeyCode = Keys.Enter Then : Call PB_Search_Click(sender, e) : End If
    End Sub

    Private Sub ProductListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click
        ProductList.Show()
    End Sub

End Class
