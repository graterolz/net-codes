Imports System.Data.OleDb
Public Class Principal
    Public NombreApp As String = "SIGAE"
    '
    Private Sub Forma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = NombreApp
        'Me.WindowState = 2 'Maximiza Ventana Acorde a Monitor.
    End Sub
    '
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
    '
    Private Sub GrupoFamiliarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrupoFamiliarToolStripMenuItem.Click
        Representante.MdiParent = Me
        Representante.Show()
    End Sub
    '
    Private Sub EstudiantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstudiantesToolStripMenuItem.Click
        Estudiante.MdiParent = Me
        Estudiante.Show()
    End Sub
    '
    'Public str As String = "Provider=Microsoft.Jet.oledb.4.0;Data Source = " & Application.StartupPath & "\AplicacionSIGAE\BD\BD_SIGAE.mdb"
    'Public dirbd As String = Application.StartupPath & "\AplicacionSIGAE\BD\BD_SIGAE.mdb"
    'Public con, con2 As OleDbConnection
    'Public cmd As OleDbCommand
    'Public rd As OleDbDataReader
    'Public sql As String
    '
    'Public NombreApp As String = "Condo Management"
    '
    'Private Sub LoginUsuario(ByVal pUsuario As String, ByVal pContrasena As String)
    '    con = New OleDbConnection(str)
    'Dim Num As Integer = 0

    'sql = "select count(*) as total from usuario where usuario = '" & pUsuario & _
    '"' and contrasena = '" & pContrasena & "'"

    ' Try
    '    con.Open()
    '    cmd = New OleDbCommand(sql, con)
    '    rd = cmd.ExecuteReader()

    'If rd.Read Then
    '    Num = rd("total")
    '    If Num = 1 Then
    '        Me.Visible = False
    '        Me.Show()
    '    Else
    '        MsgBox("Usuario o Contraseña invalida", MsgBoxStyle.Critical, NombreApp)
    'TxtUsuario.Clear()
    'TxtContrasena.Clear()
    'TxtUsuario.Focus()
    '    End If
    'End If
    'con.Close()
    'Catch ex As OleDbException
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
    'Catch ex As Exception
    '    MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
    'End Try
    'End Sub
    '
    Private Sub PeriodosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodosToolStripMenuItem.Click
        Periodo.MdiParent = Me
        Periodo.Show()
    End Sub
    '
    Private Sub AsignaturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignaturasToolStripMenuItem.Click
        Asignatura.MdiParent = Me
        Asignatura.Show()
    End Sub
End Class