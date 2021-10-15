Public Class Form4
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim x As Integer = CInt(TextBox1.Text)
        Dim A As Double = 1


        TextBox3.Text = Str(CType(squareRoot(x, A), Double))
        TextBox2.Text = Str(A)
    End Sub

    Public Function squareRoot(ByRef x As Integer, ByRef A As Double) As Double
        Dim aprox As Double
        Dim test As Double
        For i = 1 To 10
            MsgBox("Valor de i " + Str(i))
            MsgBox("Valor de A " + Str(A))
            MsgBox("Valor de aprox " + Str(aprox))
            aprox = (A + (x / A)) / 2
            test = A
            A = aprox
        Next

        A = test
        Return aprox
    End Function

End Class