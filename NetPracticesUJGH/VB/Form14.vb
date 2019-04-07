Public Class Form14
    Dim A() As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ReDim A(CInt(txtN.Text) - 1)

        For i = 0 To A.Length - 1
            A(i) = InputBox("Ingrese Nota No. " & (i + 1) & ": ", "Mensaje de la Aplicación")
            lstNotas.Items.Add(A(i))
        Next
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma As Integer = 0
        Dim i As Integer = 0
        Dim prom As Double = 0

        For i = 0 To A.Length - 1
            suma += A(i)
        Next
        prom = suma / (A.Length - 1)
        txtPromedio.Text = prom
    End Sub
End Class