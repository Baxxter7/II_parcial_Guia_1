'Programador: Josue Isaias Martinez
'N° cuenta: 20201002923
'Descripción: 
'1. Desarrolle una función que retorne la suma los números enteros positivos desde 1 hasta n, 
'donde n es un valor ingresado por medio de un textbox. 
'i.e.Si la entrada es 4, la salida de su programa debe ser:  10 (1+2+3+4=10) 
' Si la entrada es 6, la salida de su programa debe ser: 21 (1+2+3+4+5+6=21)

Public Class Form1
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim number, result As Integer

        number = CInt(TextBox1.Text)
        result = sum(number)

        MsgBox(result)
    End Sub

    Public Function sum(n As Integer) As Integer
        Dim result, i As Integer

        For i = 1 To n
            result += i
        Next

        Return result
    End Function
End Class