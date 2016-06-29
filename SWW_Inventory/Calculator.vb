Public Class Calculator

    Dim f As Double, s As Double, a As Double, op As String, n As Int64

    Private Sub math_function(sender As Object, e As EventArgs) Handles Btn_Add.Click, Btn_Multiply.Click, Btn_Mod.Click, Btn_Minus.Click, Btn_Exp.Click, Btn_Divide.Click
        Try
            Dim ops As Button = sender
            f = Label_Main.Text
            Label_Indicator.Text = Label_Main.Text
            Label_Main.Text = ""
            op = ops.Text
            Label_Indicator.Text = Label_Indicator.Text + " " + op
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_Equal_Click(sender As Object, e As EventArgs) Handles Btn_Equal.Click
        Try
            s = Label_Main.Text
            If op = "+" Then : a = f + s : Label_Main.Text = a : Label_Indicator.Text = ""
            ElseIf op = "-" Then : a = f - s : Label_Main.Text = a : Label_Indicator.Text = ""
            ElseIf op = "*" Then : a = f * s : Label_Main.Text = a : Label_Indicator.Text = ""
            ElseIf op = "/" Then : a = f / s : Label_Main.Text = a : Label_Indicator.Text = ""
            ElseIf op = "Mod" Then : a = f Mod s : Label_Main.Text = a : Label_Indicator.Text = ""
            ElseIf op = "Exp" Then : a = f ^ s : Label_Main.Text = a : Label_Indicator.Text = "" : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'UNIT CONVERSION
        Try
            Dim convertt As Double
            If TB_Conversion.Text = "" Then : MsgBox("Please put a data to convert", vbInformation, "Attention") : Exit Sub : End If
            If CB_calculator.Text = "Celsius to Fahrenheit" Then : convertt = (9 / 5 * TB_Conversion.Text) + 32 : Label_conversion.Text = (convertt) & " °F"
            ElseIf CB_calculator.Text = "Fahrenheit to Celsius" Then : convertt = 5 / 9 * (TB_Conversion.Text - 32) : Label_conversion.Text = convertt & " °C"
            ElseIf CB_calculator.Text = "Miles to Kilometers" Then : convertt = (TB_Conversion.Text * 1.609344) : Label_conversion.Text = convertt & " KM"
            ElseIf CB_calculator.Text = "Kilometers to Miles" Then : convertt = (TB_Conversion.Text / 1.609344) : Label_conversion.Text = convertt & " M" : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Btn_1.Click, Btn_period.Click, Btn_9.Click, Btn_8.Click, Btn_7.Click, Btn_6.Click, Btn_5.Click, Btn_4.Click, Btn_3.Click, Btn_2.Click, Btn_0.Click
        Dim b As Button = sender
        If Label_Main.Text = "0" Then : Label_Main.Text = b.Text
        Else : Label_Main.Text = Label_Main.Text + b.Text : End If
    End Sub

    Private Sub Btn_C_Click(sender As Object, e As EventArgs) Handles Btn_C.Click
        Label_Main.Text = "0" : Label_Indicator.Text = ""
    End Sub

    Private Sub Btn_CE_Click(sender As Object, e As EventArgs) Handles Btn_CE.Click
        If Label_Main.Text.Length > 0 Then : Label_Main.Text = Label_Main.Text.Remove(Label_Main.Text.Length - 1, 1) : End If
    End Sub
    Private Sub Btn_Bin_Click(sender As Object, e As EventArgs) Handles Btn_Bin.Click
        Try
            If Int64.TryParse(Label_Main.Text, n) Then : Label_Main.Text = Convert.ToString(n, 2)
            Else : Label_Main.Text = "" : End If
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_Sin_Click(sender As Object, e As EventArgs) Handles Btn_Sin.Click
        Try
            a = Math.Sin(Label_Main.Text) : Label_Main.Text = a : Label_Indicator.Text = ""
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_Cos_Click(sender As Object, e As EventArgs) Handles Btn_Cos.Click
        Try
            a = Math.Cos(Label_Main.Text) : Label_Main.Text = a : Label_Indicator.Text = ""
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_Tan_Click(sender As Object, e As EventArgs) Handles Btn_Tan.Click
        Try
            a = Math.Tan(Label_Main.Text) : Label_Main.Text = a : Label_Indicator.Text = ""
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Btn_Log_Click(sender As Object, e As EventArgs) Handles Btn_Log.Click
        Try
            a = Math.Log(Label_Main.Text) : Label_Main.Text = a : Label_Indicator.Text = ""
        Catch ex As Exception : MsgBox(ex.Message, vbInformation, "ERROR") : End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CB_calculator.Text = Nothing : Label_conversion.Text = "" : TB_Conversion.Text = ""
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Width = 515 : Label_Main.Width = 470 : Btn_Equal.Width = 238
        Btn_Equal.Location = New Point(244, 305)
        Btn_CE.Width = 226 : Btn_CE.Location = New Point(12, 305)
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConversionToolStripMenuItem.Click
        Me.Width = 778 : Label_Main.Width = 470
        Btn_Equal.Width = 238 : Btn_Equal.Location = New Point(244, 305)
        Btn_CE.Width = 226 : Btn_CE.Location = New Point(12, 305)
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Width = 348 : Label_Main.Width = 303
        Btn_Equal.Width = 148 : Btn_Equal.Location = New Point(167, 305)
        Btn_CE.Width = 149 : Btn_CE.Location = New Point(12, 305)
    End Sub
End Class