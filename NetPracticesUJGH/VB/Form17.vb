Public Class Form17
    Dim n As Integer
    Dim suma As Double = 0

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim i As Integer

        n = CType(TxtN.Text, Integer)
        For i = 1 To n Step 1
            suma = suma + Math.Pow(i, i)
            lstIteraciones.Items.Add(suma)
        Next
    End Sub

    Private Sub btnCalcular2_Click(sender As Object, e As EventArgs) Handles btnCalcular2.Click
        Dim i As Integer

        n = CType(TxtN.Text, Integer)
        i = 1
        While (i <= n)
            suma += Math.Pow(i, i)
            lstIteraciones.Items.Add(suma)
            i += 1
        End While
    End Sub

    Private Sub bntCalcular3_Click(sender As Object, e As EventArgs) Handles bntCalcular3.Click
        Dim i As Integer

        n = CType(TxtN.Text, Integer)
        i = 1
        Do
            suma += Math.Pow(i, i)
            lstIteraciones.Items.Add(suma)
            i += 1
        Loop Until (i > n)
    End Sub

    Private Sub btnCalcular4_Click(sender As Object, e As EventArgs) Handles btnCalcular4.Click
        Dim i As Integer

        n = CType(TxtN.Text, Integer)
        i = 1
        Do
            suma += Math.Pow(i, i)
            lstIteraciones.Items.Add(suma)
            i += 1
        Loop While (i <= n)
    End Sub
End Class