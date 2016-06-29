Public Class ProductList
    Private Sub ProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductsTableAdapter2.Fill(Me.InventoryDataSet18.products)
        TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic)
    End Sub
    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        'LIKE @CustomerName + '%'      add     query
        If CB_Name.CheckState = CheckState.Checked Then
            Me.ProductsTableAdapter2.FillByProductName(Me.InventoryDataSet18.products, TB_Search.Text)
        ElseIf CB_Address.CheckState = CheckState.Checked Then
            Me.ProductsTableAdapter2.FillByProductDesc(Me.InventoryDataSet18.products, TB_Search.Text)
        End If
    End Sub
    Private Sub CB_Name_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Name.CheckedChanged
        If CB_Name.CheckState = CheckState.Checked Then : CB_Address.CheckState = CheckState.Unchecked : End If
        If CB_Name.CheckState = CheckState.Unchecked Then : CB_Address.CheckState = CheckState.Unchecked : TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic) : Me.ProductsTableAdapter2.Fill(Me.InventoryDataSet18.products) : End If
    End Sub
    Private Sub CB_Address_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Address.CheckedChanged
        If CB_Address.CheckState = CheckState.Checked Then : CB_Name.CheckState = CheckState.Unchecked : End If
        If CB_Address.CheckState = CheckState.Unchecked Then : CB_Name.CheckState = CheckState.Unchecked : TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic) : Me.ProductsTableAdapter2.Fill(Me.InventoryDataSet18.products) : End If
    End Sub
    Private Sub TB_Search_GotFocus(sender As Object, e As EventArgs) Handles TB_Search.GotFocus
        'PLACEHOLDER
        If TB_Search.Text = "Type a keyword to search" Then : TB_Search.ForeColor = Color.Black : TB_Search.Text = "" : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Regular) : End If
    End Sub

    Private Sub TB_Search_LostFocus(sender As Object, e As EventArgs) Handles TB_Search.LostFocus
        'PLACEHOLDER
        If TB_Search.Text = "" Then : TB_Search.ForeColor = Color.Gray : TB_Search.Text = "Type a keyword to search" : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic) : End If
    End Sub

    Private Sub CB_PI_ProdSize_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_PI_ProdSize.SelectedValueChanged
        Try
            Me.ProductsTableAdapter2.FillBySize(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem)
            If CB_PI_ProdSize.SelectedItem <> Nothing And CB_PI_ProdCateg.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillBySizeCat(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem, CB_PI_ProdCateg.SelectedItem)
            End If

            If CB_PI_ProdSize.SelectedItem <> Nothing And CB_PI_ProdColor.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillBySizeColor(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem, CB_PI_ProdColor.SelectedItem)
            End If

            If CB_PI_ProdSize.SelectedItem <> Nothing And CB_PI_ProdCateg.SelectedItem <> Nothing And CB_PI_ProdColor.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillBySizeCatColor(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem, CB_PI_ProdCateg.SelectedItem, CB_PI_ProdColor.SelectedItem)
            End If

        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub CB_PI_ProdCateg_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_PI_ProdCateg.SelectedValueChanged
        Try
            Me.ProductsTableAdapter2.FillByCategory(Me.InventoryDataSet18.products, CB_PI_ProdCateg.SelectedItem)
            If CB_PI_ProdSize.SelectedItem <> Nothing And CB_PI_ProdCateg.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillBySizeCat(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem, CB_PI_ProdCateg.SelectedItem)
            End If

            If CB_PI_ProdCateg.SelectedItem <> Nothing And CB_PI_ProdColor.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillByColorCat(Me.InventoryDataSet18.products, CB_PI_ProdColor.SelectedItem, CB_PI_ProdCateg.SelectedItem)
            End If

            If CB_PI_ProdSize.SelectedItem <> Nothing And CB_PI_ProdCateg.SelectedItem <> Nothing And CB_PI_ProdColor.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillBySizeCatColor(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem, CB_PI_ProdCateg.SelectedItem, CB_PI_ProdColor.SelectedItem)
            End If

        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub CB_PI_ProdColor_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_PI_ProdColor.SelectedValueChanged
        Try
            Me.ProductsTableAdapter2.FillByColor(Me.InventoryDataSet18.products, CB_PI_ProdColor.SelectedItem)
            If CB_PI_ProdSize.SelectedItem <> Nothing And CB_PI_ProdColor.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillBySizeColor(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem, CB_PI_ProdColor.SelectedItem)
            End If

            If CB_PI_ProdCateg.SelectedItem <> Nothing And CB_PI_ProdColor.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillByColorCat(Me.InventoryDataSet18.products, CB_PI_ProdColor.SelectedItem, CB_PI_ProdCateg.SelectedItem)
            End If

            If CB_PI_ProdSize.SelectedItem <> Nothing And CB_PI_ProdCateg.SelectedItem <> Nothing And CB_PI_ProdColor.SelectedItem <> Nothing Then
                Me.ProductsTableAdapter2.FillBySizeCatColor(Me.InventoryDataSet18.products, CB_PI_ProdSize.SelectedItem, CB_PI_ProdCateg.SelectedItem, CB_PI_ProdColor.SelectedItem)
            End If

        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ProductsTableAdapter2.Fill(Me.InventoryDataSet18.products)
    End Sub
End Class