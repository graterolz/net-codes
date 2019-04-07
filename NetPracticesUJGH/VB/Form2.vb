Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Hola, esta es la Form2!")
    End Sub
    '
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Solo se puede invocar una 2 Forms!")
    End Sub
    '
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub
    '
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()
        Me.Close()
    End Sub
    '
End Class