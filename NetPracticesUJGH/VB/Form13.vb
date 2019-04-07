Public Class Form13
    Dim A(10) As Integer

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim i As Integer = 0
        For i = 0 To A.Length - 1
            A(i) = InputBox("Ingrese elemento No. " & (i + 1) & ": ", "Mensaje de la Aplicación")
        Next
    End Sub

    Private Sub btnComprobar_Click(sender As Object, e As EventArgs) Handles btnComprobar.Click
        Dim i As Integer = 0
        Dim TNegativos As Integer = 0
        Dim TNulos As Integer = 0
        Dim TPositivos As Integer = 0

        For i = 0 To A.Length - 1
            If A(i) = 0 Then
                lstNulos.Items.Add(A(i))
                TNulos += 1
            ElseIf (A(i) < 0) Then
                lstNegativos.Items.Add(A(i))
                TNegativos += 1
            Else
                lstPositivos.Items.Add(A(i))
                TPositivos += 1
            End If
        Next
        LblTNulos.Text = TNulos
        LblTNegativos.Text = TNegativos
        LblTPositivos.Text = TPositivos
    End Sub
End Class