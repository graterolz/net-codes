Public Class Form10
    Private Sub BtnInversa_Click_1(sender As Object, e As EventArgs) Handles BtnInversa.Click
        TxtCadInversa.Text = InvertirCadena(TxtCadena.Text)
    End Sub

    '  Inversion De Una Cadena De Caracteres
    Public Function InvertirCadena(CadenaInvertir As String) As String
        Dim Mx As Long
        Dim Y As Long
        Dim var As String

        Mx = Len(CadenaInvertir)

        If Mx = 0 Then
            InvertirCadena = ""
            Exit Function
        End If

        var = ""

        For Y = Mx To 1 Step -1
            var = var + Mid$(CadenaInvertir, Y, 1)
        Next Y

        InvertirCadena = var
    End Function
End Class