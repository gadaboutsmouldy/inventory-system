Public Class PrintQuotation
    Public Property QuotationID2 As String
    Private Sub PrintQuotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TB_QuotationID.Text = QuotationID2
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from quotationnew where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim da As New SqlClient.SqlDataAdapter("select * from orders where QuotationID='" & TB_QuotationID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim dt As New DataTable, ds As New DataSet
            con.Open() : dr = cmd.ExecuteReader : ds.Tables.Add(dt) : da.Fill(dt)
            Dim status As String

            If dr.Read = True Then
                status = dr(10).ToString
                If status = "CLOSED" Then : MsgBox("Status of this quotation id is already closed", vbInformation, "Attention") : Me.Close() : End If
                ListView1.Items.Clear()
                TB_QuotationID.Text = dr(0).ToString
                quo_date.Text = dr(1).ToString
                QuotationDate.Text = quo_date.Text
                TB_CCompany.Text = dr(3).ToString
                TB_CName.Text = dr(4).ToString
                TB_CAddress.Text = dr(5).ToString
                TB_CPhone.Text = dr(6).ToString
                TB_CNameS.Text = dr(7).ToString
                TB_CAddressS.Text = dr(8).ToString
                TB_CPhoneS.Text = dr(9).ToString
                TB_QTerms.Text = dr(11).ToString
                quo_ship.Text = dr(12).ToString
                Date_QShipdate.Text = quo_ship.Text
                CB_QShipvia.Text = dr(13).ToString
                TB_QSalesperson.Text = dr(14).ToString
                TB_QSubtotal.Text = dr(15).ToString
                TB_DiscountAmount.Text = dr(16).ToString
                TB_QSalestax.Text = dr(17).ToString
                TB_QOther.Text = dr(18).ToString
                TB_QTerms.ForeColor = Color.Black
                TB_QTerms.Font = New Font(TB_QTerms.Font, FontStyle.Regular)

                quo_date.Format = DateTimePickerFormat.Custom : quo_date.CustomFormat = "yyyy-MM-dd"
                quo_ship.Format = DateTimePickerFormat.Custom : quo_ship.CustomFormat = "yyyy-MM-dd"
                quo_date.Visible = False
                quo_ship.Visible = False

                Dim totalamount As Double, myRow As DataRow
                totalamount = dr(19).ToString : TB_QTotalamount.Text = totalamount.ToString("N")

                For Each myRow In dt.Rows
                    ListView1.Items.Add(myRow.Item(1))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(2))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(3))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(4))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(5))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(myRow.Item(6))
                Next
            Else : MsgBox("Quotation ID not found!", vbInformation, "Search") : con.Close() : Me.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_PRINT_Click_1(sender As Object, e As EventArgs) Handles BTN_PRINT.Click
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 60
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Bottom = 10
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 15
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 10
        BTN_PRINT.Visible = False
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Me.Close()
    End Sub

    Private Sub BTN_PRINT_MouseHover(sender As Object, e As EventArgs) Handles BTN_PRINT.MouseHover
        BTN_PRINT.Image = My.Resources.print_hover
    End Sub

    Private Sub BTN_PRINT_MouseLeave(sender As Object, e As EventArgs) Handles BTN_PRINT.MouseLeave
        BTN_PRINT.Image = My.Resources.print
    End Sub
End Class