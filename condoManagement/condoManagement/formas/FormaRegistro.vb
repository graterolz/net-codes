Imports System.Data.OleDb
Public Class FormaRegistro
    'Public str As String = "Provider=Microsoft.Jet.oledb.4.0;Data Source = " & Application.StartupPath & "\BD\BD.mdb"
    'Public dirbd As String = Application.StartupPath & "\BD\BD.mdb"
    'Public con, conn As OleDbConnection
    'Public cmd As OleDbCommand
    'Public rd As OleDbDataReader
    'Public sql As String
    '

    '
    Private Sub NuevoUsuario(ByVal pUsuario As String, ByVal pContrasena As String)

        If Trim(pUsuario) <> "" And Trim(pContrasena) <> "" Then        
            FormaLogin.con = New OleDbConnection(FormaLogin.str)
            FormaLogin.con2 = New OleDbConnection(FormaLogin.str)
            Dim Num As Integer = 0
            FormaLogin.sql = "select count(*) as total from Usuario where usuario = '" & pUsuario & "'"
            Try
                FormaLogin.con.Open()
                FormaLogin.cmd = New OleDbCommand(FormaLogin.sql, FormaLogin.con)
                FormaLogin.rd = FormaLogin.cmd.ExecuteReader()

                If FormaLogin.rd.Read Then
                    Num = FormaLogin.rd("total")
                End If

                If Num = 0 Then
                    'MsgBox("Nombre de usuario Disponible", MsgBoxStyle.Critical)
                    Dim sql = "insert into Usuario (usuario,contrasena,perfil) values('" & _
                                pUsuario & "','" & pContrasena & "'," & "'2')"
                    Try
                        FormaLogin.con2.Open()
                        FormaLogin.cmd = New OleDb.OleDbCommand(sql, FormaLogin.con2)
                        FormaLogin.cmd.ExecuteNonQuery()
                        FormaLogin.con2.Close()

                        TxtUsuario.Clear()
                        TxtContrasena.Clear()
                        TxtContrasenaC.Clear()
                        MsgBox("Su registro ha sido completado con existo", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
                    End Try
                Else
                    TxtUsuario.Clear()
                    TxtContrasena.Clear()
                    TxtContrasenaC.Clear()
                    MsgBox("Nombre de usuario no Disponible", MsgBoxStyle.Critical)
                End If
                FormaLogin.con.Close()
            Catch ex As OleDbException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Oledb Error")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "General Error")
            End Try
        Else
            MsgBox("Ingrese los datos completos", MsgBoxStyle.Critical)
        End If
    End Sub
    '
    Public Sub Ingresar()
        Dim pUsuario As String = Trim(TxtUsuario.Text)
        Dim pContrasena As String = Trim(TxtContrasena.Text)
        Dim pContrasenaC As String = Trim(TxtContrasenaC.Text)

        If (pContrasena = pContrasenaC) Then
            Me.NuevoUsuario(pUsuario, pContrasena)
        Else
            TxtContrasena.Clear()
            TxtContrasenaC.Clear()
            TxtContrasena.Focus()
            MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical)
        End If
    End Sub
    '
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        FormaLogin.Show()
    End Sub
    '
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Ingresar()
    End Sub

    Private Sub TxtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ingresar()
        End If
    End Sub
    '
    Private Sub TxtContrasena_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ingresar()
        End If
    End Sub
    '
    Private Sub TxtContrasenaC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtContrasenaC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Ingresar()
        End If
    End Sub
End Class