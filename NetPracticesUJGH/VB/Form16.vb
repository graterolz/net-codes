Public Class Form16

    Dim A(10) As Integer
    Dim i As Integer

    Private Sub txtValor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            A(i) = CInt(txtValor.Text)
            If CInt(txtValor.Text) > 0 Then
                lstPositivos.Items.Add(txtValor.Text)
            Else
                lstNegativos.Items.Add(txtValor.Text)
                i = i + 1
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
    End Sub

    Private Sub btnCalcular_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcular.Click
        lblTotalN.Text = lstNegativos.Items.Count
        lblTotalP.Text = lstPositivos.Items.Count
    End Sub
End Class