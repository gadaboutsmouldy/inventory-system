Imports System.Data.SqlClient

Public Class InvoiceList

    Private Sub InvoiceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Current_date.Format = DateTimePickerFormat.Custom : Current_date.CustomFormat = "yyyy-MM-dd"
        Current_date1.Format = DateTimePickerFormat.Custom : Current_date1.CustomFormat = "yyyy-MM-dd"
        TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic)
        Me.InvoicenewTableAdapter.Fill(Me.InventoryDataSet.invoicenew)
    End Sub

    Private Sub CB_Name_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Name.CheckedChanged
        If CB_Name.CheckState = CheckState.Checked Then : CB_Address.CheckState = CheckState.Unchecked : End If
        If CB_Name.CheckState = CheckState.Unchecked Then : Call BTN_Clear_Click(sender, e) : End If
    End Sub

    Private Sub CB_Address_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Address.CheckedChanged
        If CB_Address.CheckState = CheckState.Checked Then : CB_Name.CheckState = CheckState.Unchecked : End If
        If CB_Address.CheckState = CheckState.Unchecked Then : Call BTN_Clear_Click(sender, e) : End If
    End Sub
    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        'LIKE @CustomerName + '%'      add     query
        Try
            CB_Status.SelectedItem = "NONE"
            If CB_Name.CheckState = CheckState.Checked Then : Me.InvoicenewTableAdapter.FillByCustomerName(Me.InventoryDataSet.invoicenew, TB_Search.Text)
            ElseIf CB_Address.CheckState = CheckState.Checked Then : Me.InvoicenewTableAdapter.FillByCustomerAddress(Me.InventoryDataSet.invoicenew, TB_Search.Text) : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub CB_Status_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_Status.SelectedValueChanged
        Try
            Me.InvoicenewTableAdapter.FillByInvoiceStatus(Me.InventoryDataSet.invoicenew, CB_Status.SelectedItem)
            If CB_Name.CheckState = CheckState.Checked Then : Me.InvoicenewTableAdapter.FillByNameStats(Me.InventoryDataSet.invoicenew, TB_Search.Text, CB_Status.SelectedItem) : End If
            If CB_Address.CheckState = CheckState.Checked Then : Me.InvoicenewTableAdapter.FillByAddressStats(Me.InventoryDataSet.invoicenew, TB_Search.Text, CB_Status.SelectedItem) : End If
            If CB_Status.SelectedItem = Nothing Then : Exit Sub : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub
    Private Sub TB_Search_GotFocus(sender As Object, e As EventArgs) Handles TB_Search.GotFocus
        'PLACEHOLDER
        If TB_Search.Text = "Type a keyword to search" Then : TB_Search.ForeColor = Color.Black : TB_Search.Text = "" : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Regular) : End If
    End Sub

    Private Sub TB_Search_LostFocus(sender As Object, e As EventArgs) Handles TB_Search.LostFocus
        'PLACEHOLDER
        If TB_Search.Text = "" Then : TB_Search.ForeColor = Color.Gray : TB_Search.Text = "Type a keyword to search" : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic) : End If
    End Sub

    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
        Try
            If Current_date.Text > Current_date1.Text Then : MsgBox("Invalid date range", vbInformation, "Attention") : Exit Sub : End If
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString)
            con.Open()
            Dim com As String = "select * from invoicenew where Date between '" & Current_date.Text & "' and '" & Current_date1.Text & "'"
            Dim Adpt As New SqlDataAdapter(com, con), ds As New DataSet()
            Adpt.Fill(ds, "Invoice") : InvoicenewDataGridView.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "Error") : End Try
    End Sub


    Private Sub Btn_DeleteProd_MouseLeave(sender As Object, e As EventArgs)
        BTN_Clear.Image = My.Resources.delete
    End Sub

    Private Sub BTN_Clear_Click(sender As Object, e As EventArgs) Handles BTN_Clear.Click
        CB_Name.CheckState = CheckState.Unchecked : CB_Address.CheckState = CheckState.Unchecked
        TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic)
        CB_Status.SelectedItem = Nothing
        Me.InvoicenewTableAdapter.Fill(Me.InventoryDataSet.invoicenew)
    End Sub
End Class