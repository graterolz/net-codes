Public Class FormaPrincipal
    Private Sub FormaPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = FormaLogin.NombreApp
        Me.WindowState = 2
        'ApartamentosToolStripMenuItem.Visible = False
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        FormaLogin.TxtUsuario.Clear()
        FormaLogin.TxtContrasena.Clear()        
        FormaLogin.Visible = True
        FormaLogin.TxtUsuario.Focus()
    End Sub

    Private Sub ApartamentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApartamentosToolStripMenuItem.Click
        FormaApartamento.MdiParent = Me
        FormaApartamento.Show()
    End Sub
    '
    Private Sub InquilinosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InquilinosToolStripMenuItem.Click
        FormaInquilino.MdiParent = Me
        FormaInquilino.Show()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagosToolStripMenuItem.Click
        FormaPago.MdiParent = Me
        FormaPago.Show()
    End Sub
End Class