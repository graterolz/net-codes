Public Class Form8
    Private Sub botonVisible_Click(sender As Object, e As EventArgs) Handles botonVisible.Click
        If cajaImagen.Visible = True Then
            MessageBox.Show("Esta Visible la Imagen", "Mensaje")
        Else
            cajaImagen.Visible = True
        End If
    End Sub
    '
    Private Sub botonNoVisible_Click(sender As Object, e As EventArgs) Handles botonNoVisible.Click
        cajaImagen.Visible = False
    End Sub
End Class