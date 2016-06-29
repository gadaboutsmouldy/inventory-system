Imports System.Drawing.Printing

Public Class PrintInvoice
    Public Property InvoiceID2 As String

    Private Sub PrintInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TB_InvoiceID.Text = InvoiceID2
            Dim con As New SqlClient.SqlConnection(MyConnection.MyConnectionString), dr As SqlClient.SqlDataReader, cmd As New SqlClient.SqlCommand("select * from invoicenew where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con)
            Dim da As New SqlClient.SqlDataAdapter("select * from ordersinvoice where InvoiceID='" & TB_InvoiceID.Text & "' COLLATE SQL_Latin1_General_CP1_CS_AS", con), dt As New DataTable, ds As New DataSet
            con.Open() : dr = cmd.ExecuteReader
            ds.Tables.Add(dt) : da.Fill(dt)

            If dr.Read = True Then
                ListView1.Items.Clear()
                TB_InvoiceID.Text = dr(0).ToString
                TB_CCompany.Text = dr(3).ToString
                TB_CName.Text = dr(4).ToString
                TB_CAddress.Text = dr(5).ToString
                TB_CPhone.Text = dr(6).ToString
                TB_CNameS.Text = dr(7).ToString
                TB_CAddressS.Text = dr(8).ToString
                TB_CPhoneS.Text = dr(9).ToString
                TB_QTerms.Text = dr(11).ToString
                invo_date.Text = dr(12).ToString
                Date_QShipdate.Text = invo_date.Text
                CB_QShipvia.Text = dr(13).ToString
                TB_QSalesperson.Text = dr(14).ToString
                invo_date.Text = dr(20).ToString
                InvoiceDate.Text = invo_date.Text

                invo_date.Format = DateTimePickerFormat.Custom : invo_date.CustomFormat = "yyyy-MM-dd"
                invo_ship.Format = DateTimePickerFormat.Custom : invo_ship.CustomFormat = "yyyy-MM-dd"
                invo_date.Visible = False
                invo_ship.Visible = False


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
            Else : MsgBox("Invoice ID not found!", vbInformation, "Search") : con.Close() : End If : con.Close()
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub BTN_PRINT_Click(sender As Object, e As EventArgs) Handles BTN_PRINT.Click
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