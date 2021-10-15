Public Class Form3
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim number1, number2 As Integer

        number1 = CInt(TextBox1.Text)
        number2 = CInt(TextBox2.Text)

        exchange(number1, number2)

        TextBox3.Text = Str(number1)
        TextBox4.Text = Str(number2)
    End Sub

    Public Sub exchange(ByRef number1 As Integer, ByRef number2 As Integer)
        Dim aux As Integer
        aux = number1
        number1 = number2
        number2 = aux
    End Sub
End Class