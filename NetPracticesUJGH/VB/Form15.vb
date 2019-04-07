Public Class Form15
    Dim A() As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ReDim A(CInt(txtN.Text) - 1)

        For i = 0 To A.Length - 1
            A(i) = InputBox("Ingrese Valor Numérico No. " & (i + 1) & ": ", "Mensaje de la Aplicación")
            lstNumeros.Items.Add(A(i))
        Next
    End Sub

    Private Sub btnVImpares_Click(sender As Object, e As EventArgs) Handles btnVImpares.Click
        Dim nimp As Integer = 0
        Dim i As Integer = 0

        For i = 0 To A.Length - 1
            If (A(i) Mod 2 <> 0) Then
                nimp += 1
            End If
        Next
        txtVImpares.Text = nimp
    End Sub

    Private Sub btnVPares_Click(sender As Object, e As EventArgs) Handles btnVPares.Click
        Dim npar As Integer = 0
        Dim i As Integer = 0

        For i = 0 To A.Length - 1
            If (A(i) Mod 2 = 0) Then
                npar += 1
            End If
        Next
        txtVPares.Text = npar
    End Sub

    Private Sub btnVNulos_Click(sender As Object, e As EventArgs) Handles btnVNulos.Click
        Dim nnulo As Integer = 0
        Dim i As Integer = 0

        For i = 0 To A.Length - 1
            If (A(i) = 0) Then
                nnulo += 1
            End If
        Next
        txtVNulos.Text = nnulo
    End Sub

    Private Sub btnVRepetidos_Click(sender As Object, e As EventArgs) Handles btnVRepetidos.Click
        Dim i, j As Integer
        Dim nRep As Integer = 0

        For i = 0 To A.Length - 2
            For j = A.Length - 1 To i + 1 Step -1
                If (A(i) = A(j)) Then
                    nRep += 1
                End If
            Next j
        Next i
        txtVRepetidos.Text = nRep
    End Sub
End Class