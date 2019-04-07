Imports System.Data.OleDb
Public Class FormaLogin
    Public str As String = "Provider=Microsoft.Jet.oledb.4.0;Data Source = " & Application.StartupPath & "\BD\BD.mdb"
    Public dirbd As String = Application.StartupPath & "\BD\BD.mdb"
    Public con, con2 As OleDbConnection
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public sql As String
    '
    Public NombreApp As String = "Condo Management"
    '
    Private Sub LoginUsuario(ByVal pUsuario As String, ByVal pContrasena As String)
        con = New OleDbConnection(str)
        Dim Num As Integer = 0

        sql = "select count(*) as total from usuario where usuario = '" & pUsuario & _
        "' and contrasena = '" & pContrasena & "'"

        Try
            con.Open()
            cmd = New OleDbCommand(sql, con)
            rd = cmd.ExecuteReader()

            If rd.Read Then
                Num = rd("total")
                If Num = 1 Then
                    Me.Visible = False
                    FormaPrincipal.Show()
                Else
                    MsgBox("Usuario o Contraseña invalida", MsgBoxStyle.Critical, NombreApp)
                    TxtUsuario.Clear()
                    TxtContrasena.Clear()
                    TxtUsuario.Focus()
                End If
            End If
            con.Close()
        Catch ex As OleDbException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
        End Try
    End Sub
    '
    Private Sub BotonSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub
    '
    Sub Ingresar()
        Dim pUsuario As String = Trim(TxtUsuario.Text)
        Dim PContrasena As String = Trim(TxtContrasena.Text)

        If pUsuario = "" Or PContrasena = "" Then
            MsgBox("Ingrese informacion completa", MsgBoxStyle.Critical, NombreApp)
            TxtUsuario.Focus()
        Else
            LoginUsuario(TxtUsuario.Text, TxtContrasena.Text)
        End If
    End Sub
    '
    Private Sub BotonEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonEntrar.Click
        Ingresar()
    End Sub
    '
    Private Sub FormaLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtUsuario.Focus()
        Me.Text = NombreApp
    End Sub
    '
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click        
        FormaRegistro.Show()
        Me.Visible = False
    End Sub

    Private Sub TxtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ingresar()
        End If
    End Sub

    Private Sub TxtContrasena_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ingresar()
        End If
    End Sub
End Class