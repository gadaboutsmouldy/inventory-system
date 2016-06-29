Public Class CustomerList
    Private Sub CustomerList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic)
        Me.CustomersTableAdapter1.Fill(Me.InventoryDataSet16.customers)
    End Sub

    Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
        'LIKE @CustomerName + '%'      add     query
        If CB_Name.CheckState = CheckState.Checked Then : Me.CustomersTableAdapter1.FillByCustomerName(Me.InventoryDataSet16.customers, TB_Search.Text)
        ElseIf CB_Address.CheckState = CheckState.Checked Then : Me.CustomersTableAdapter1.FillByCustomerAddress(Me.InventoryDataSet16.customers, TB_Search.Text) : End If
    End Sub
    Private Sub CB_Name_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Name.CheckedChanged
        If CB_Name.CheckState = CheckState.Checked Then : CB_Address.CheckState = CheckState.Unchecked : End If
        If CB_Name.CheckState = CheckState.Unchecked Then : CB_Address.CheckState = CheckState.Unchecked : TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic) : Me.CustomersTableAdapter1.Fill(Me.InventoryDataSet16.customers) : End If
    End Sub
    Private Sub CB_Address_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Address.CheckedChanged
        If CB_Address.CheckState = CheckState.Checked Then : CB_Name.CheckState = CheckState.Unchecked : End If
        If CB_Address.CheckState = CheckState.Unchecked Then : CB_Name.CheckState = CheckState.Unchecked : TB_Search.Text = "Type a keyword to search" : TB_Search.ForeColor = Color.Gray : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic) : Me.CustomersTableAdapter1.Fill(Me.InventoryDataSet16.customers) : End If
    End Sub
    Private Sub TB_Search_GotFocus(sender As Object, e As EventArgs) Handles TB_Search.GotFocus
        'PLACEHOLDER
        If TB_Search.Text = "Type a keyword to search" Then : TB_Search.ForeColor = Color.Black : TB_Search.Text = "" : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Regular) : End If
    End Sub

    Private Sub TB_Search_LostFocus(sender As Object, e As EventArgs) Handles TB_Search.LostFocus
        'PLACEHOLDER
        If TB_Search.Text = "" Then : TB_Search.ForeColor = Color.Gray : TB_Search.Text = "Type a keyword to search" : TB_Search.Font = New Font(TB_Search.Font, FontStyle.Italic) : End If
    End Sub
End Class
