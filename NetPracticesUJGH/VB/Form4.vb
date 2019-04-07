Public Class Form4
    Private Sub cmdCalcular_Click(sender As Object, e As EventArgs) Handles cmdCalcular.Click
        Dim b, h As Integer
        Dim s, p As Integer

        b = CType(txtB.Text, Integer)
        h = CType(txtH.Text, Integer)

        s = b * h
        p = 2 * (b + h)

        txtS.Text = s
        txtP.Text = p
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        End
    End Sub
End Class