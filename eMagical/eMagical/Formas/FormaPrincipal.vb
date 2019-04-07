Public Class FormaPrincipal
    '
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Enabled = False
        FormaTruco1.Show()
    End Sub
    '
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Enabled = False
        FormaTruco2.Show()
    End Sub
    '
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Enabled = False
        FormaTruco3.Show()
    End Sub
    '
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Enabled = False
        FormaTruco4.Show()
    End Sub
    '
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("¡Gracias por usar la Aplicacion!")
        Me.Close()
    End Sub

    Private Sub FormaPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
