Public Class Form18
    Dim C, I As Double
    Dim A As Integer = 0
    Dim R As Double = 0

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        C = CDbl(TxtCapital.Text)
        I = ((1 + CDbl(TxtInteres.Text)) ^ (1 / 12) - 1)

        While (R <= C)
            R += C * I
            A += 1
            'Agregar valores a los cuadros de lista
            LstAnios.Items.Add(A)
            LstIntereses.Items.Add(FormatNumber(R, 2))
            LstTotales.Items.Add(FormatNumber(C + R, 2))
        End While
        TxtTotal.Text = FormatNumber(C + R, 2)
    End Sub

    Private Sub btnCalcular2_Click(sender As Object, e As EventArgs) Handles btnCalcular2.Click
        C = CDbl(TxtCapital.Text)
        I = ((1 + CDbl(TxtInteres.Text)) ^ (1 / 12) - 1)

        Do
            R += C * I
            A += 1
            'Agregar valores a los cuadros de lista
            LstAnios.Items.Add(A)
            LstIntereses.Items.Add(FormatNumber(R, 2))
            LstTotales.Items.Add(FormatNumber(C + R, 2))
        Loop Until (R >= C)
        TxtTotal.Text = FormatNumber(C + R, 2)
    End Sub

    Private Sub btnCalcular3_Click(sender As Object, e As EventArgs) Handles btnCalcular3.Click
        C = CDbl(TxtCapital.Text)
        I = ((1 + CDbl(TxtInteres.Text)) ^ (1 / 12) - 1)

        Do
            R += C * I
            A += 1
            'Agregar valores a los cuadros de lista
            LstAnios.Items.Add(A)
            LstIntereses.Items.Add(FormatNumber(R, 2))
            LstTotales.Items.Add(FormatNumber(C + R, 2))
        Loop While (R <= C)
        TxtTotal.Text = FormatNumber(C + R, 2)
    End Sub
End Class