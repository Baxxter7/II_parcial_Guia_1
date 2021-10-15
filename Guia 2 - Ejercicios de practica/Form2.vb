'Programador: Josue Isaias Martinez
'N° cuenta: 20201002923
'Descripción: 
'3. Desarrolle un programa que reciba dos valores enteros positivos mediante textboxes, los envíe 
'a un procedimiento y los intercambie. i.e. Si a=3 y b=7, después de terminar el procedimiento, 
'las variables deberían tener a=7 y b = 3


Public Class Form2
    Private Sub btnAccion_Click(sender As Object, e As EventArgs) Handles btnAccion.Click
        Dim n, result1, result2 As Integer
        Dim answer As Boolean

        n = CInt(TextBox1.Text)

        result1 = sum(n)
        result2 = summation(n)

        answer = equal(result1, result2)

        If answer = True Then
            MsgBox("Correct")
        Else
            MsgBox("Incorrect")
        End If
    End Sub
    'Funcion de Forma vulgar
    Public Function sum(n As Integer) As Integer
        Dim result, i As Integer

        For i = 1 To n
            result += i
        Next

        Return result
    End Function
    'Sumatoria de Gauss
    Public Function summation(n As Integer) As Integer
        Dim result As Integer
        result = CInt((n * (n + 1)) / 2)

        Return result
    End Function

    Public Function equal(n As Integer, m As Integer) As Boolean
        If n = m Then
            Return True
        Else
            Return False
        End If
    End Function
End Class