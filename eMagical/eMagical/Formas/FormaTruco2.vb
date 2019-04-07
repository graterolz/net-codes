Imports System.Threading
Public Class FormaTruco2
    Public Bandera As Integer = 1
    Dim Numero As Integer = 0
    Dim Columna(2) As Integer
    '
    Public Sub habilita_group(ByVal p_opcion As Integer)
        If p_opcion = 0 Then
            GroupBox2.Visible = False
            GroupBox4.Visible = False
        ElseIf p_opcion = 1 Then
            GroupBox2.Visible = True
            GroupBox4.Visible = True
        End If
    End Sub
    '
    Public Sub limpia_text(ByVal p_tiempo As Integer)
        For value As Integer = 1 To 18
            If value = 1 Then
                TextBox1.Clear()
                Me.Refresh()
            ElseIf value = 2 Then
                TextBox2.Clear()
                Me.Refresh()
            ElseIf value = 3 Then
                TextBox3.Clear()
                Me.Refresh()
            ElseIf value = 4 Then
                TextBox4.Clear()
                Me.Refresh()
            ElseIf value = 5 Then
                TextBox5.Clear()
                Me.Refresh()
            ElseIf value = 6 Then
                TextBox6.Clear()
                Me.Refresh()
            ElseIf value = 7 Then
                TextBox7.Clear()
                Me.Refresh()
            ElseIf value = 8 Then
                TextBox8.Clear()
                Me.Refresh()
            ElseIf value = 9 Then
                TextBox9.Clear()
                Me.Refresh()
            ElseIf value = 10 Then
                TextBox10.Clear()
                Me.Refresh()
            ElseIf value = 11 Then
                TextBox11.Clear()
                Me.Refresh()
            ElseIf value = 12 Then
                TextBox12.Clear()
                Me.Refresh()
            ElseIf value = 13 Then
                TextBox13.Clear()
                Me.Refresh()
            ElseIf value = 14 Then
                TextBox14.Clear()
                Me.Refresh()
            ElseIf value = 15 Then
                TextBox15.Clear()
                Me.Refresh()
            ElseIf value = 16 Then
                TextBox16.Clear()
                Me.Refresh()
            ElseIf value = 17 Then
                TextBox17.Clear()
                Me.Refresh()
            ElseIf value = 18 Then
                TextBox18.Clear()
                Me.Refresh()
            End If
            If p_tiempo = 1 Then
                Thread.Sleep(125)
            End If
        Next
    End Sub
    '
    Public Sub cambia_numero(ByVal p_cambio As Integer)
        If p_cambio = 1 Then
            For value As Integer = 1 To 18
                If value = 1 Then
                    TextBox1.Text = value
                    Me.Refresh()
                ElseIf value = 2 Then
                    TextBox2.Text = value
                    Me.Refresh()
                ElseIf value = 3 Then
                    TextBox3.Text = value
                    Me.Refresh()
                ElseIf value = 4 Then
                    TextBox4.Text = value
                    Me.Refresh()
                ElseIf value = 5 Then
                    TextBox5.Text = value
                    Me.Refresh()
                ElseIf value = 6 Then
                    TextBox6.Text = value
                    Me.Refresh()
                ElseIf value = 7 Then
                    TextBox7.Text = value
                    Me.Refresh()
                ElseIf value = 8 Then
                    TextBox8.Text = value
                    Me.Refresh()
                ElseIf value = 9 Then
                    TextBox9.Text = value
                    Me.Refresh()
                ElseIf value = 10 Then
                    TextBox10.Text = value
                    Me.Refresh()
                ElseIf value = 11 Then
                    TextBox11.Text = value
                    Me.Refresh()
                ElseIf value = 12 Then
                    TextBox12.Text = value
                    Me.Refresh()
                ElseIf value = 13 Then
                    TextBox13.Text = value
                    Me.Refresh()
                ElseIf value = 14 Then
                    TextBox14.Text = value
                    Me.Refresh()
                ElseIf value = 15 Then
                    TextBox15.Text = value
                    Me.Refresh()
                ElseIf value = 16 Then
                    TextBox16.Text = value
                    Me.Refresh()
                ElseIf value = 17 Then
                    TextBox17.Text = value
                    Me.Refresh()
                ElseIf value = 18 Then
                    TextBox18.Text = value
                    Me.Refresh()
                End If
                Thread.Sleep(125)
            Next
        ElseIf p_cambio = 2 Then
            For value As Integer = 1 To 18
                If value = 1 Then
                    TextBox13.Text = value
                    Me.Refresh()
                ElseIf value = 2 Then
                    TextBox7.Text = value
                    Me.Refresh()
                ElseIf value = 3 Then
                    TextBox1.Text = value
                    Me.Refresh()
                ElseIf value = 4 Then
                    TextBox14.Text = value
                    Me.Refresh()
                ElseIf value = 5 Then
                    TextBox8.Text = value
                    Me.Refresh()
                ElseIf value = 6 Then
                    TextBox2.Text = value
                    Me.Refresh()
                ElseIf value = 7 Then
                    TextBox15.Text = value
                    Me.Refresh()
                ElseIf value = 8 Then
                    TextBox9.Text = value
                    Me.Refresh()
                ElseIf value = 9 Then
                    TextBox3.Text = value
                    Me.Refresh()
                ElseIf value = 10 Then
                    TextBox16.Text = value
                    Me.Refresh()
                ElseIf value = 11 Then
                    TextBox10.Text = value
                    Me.Refresh()
                ElseIf value = 12 Then
                    TextBox4.Text = value
                    Me.Refresh()
                ElseIf value = 13 Then
                    TextBox17.Text = value
                    Me.Refresh()
                ElseIf value = 14 Then
                    TextBox11.Text = value
                    Me.Refresh()
                ElseIf value = 15 Then
                    TextBox5.Text = value
                    Me.Refresh()
                ElseIf value = 16 Then
                    TextBox18.Text = value
                    Me.Refresh()
                ElseIf value = 17 Then
                    TextBox12.Text = value
                    Me.Refresh()
                ElseIf value = 18 Then
                    TextBox6.Text = value
                    Me.Refresh()
                End If
                Thread.Sleep(125)
            Next
        ElseIf p_cambio = 3 Then
            For value As Integer = 1 To 18
                If value = 1 Then
                    TextBox17.Text = value
                    Me.Refresh()
                ElseIf value = 2 Then
                    TextBox15.Text = value
                    Me.Refresh()
                ElseIf value = 3 Then
                    TextBox13.Text = value
                    Me.Refresh()
                ElseIf value = 4 Then
                    TextBox11.Text = value
                    Me.Refresh()
                ElseIf value = 5 Then
                    TextBox9.Text = value
                    Me.Refresh()
                ElseIf value = 6 Then
                    TextBox7.Text = value
                    Me.Refresh()
                ElseIf value = 7 Then
                    TextBox5.Text = value
                    Me.Refresh()
                ElseIf value = 8 Then
                    TextBox3.Text = value
                    Me.Refresh()
                ElseIf value = 9 Then
                    TextBox1.Text = value
                    Me.Refresh()
                ElseIf value = 10 Then
                    TextBox18.Text = value
                    Me.Refresh()
                ElseIf value = 11 Then
                    TextBox16.Text = value
                    Me.Refresh()
                ElseIf value = 12 Then
                    TextBox14.Text = value
                    Me.Refresh()
                ElseIf value = 13 Then
                    TextBox12.Text = value
                    Me.Refresh()
                ElseIf value = 14 Then
                    TextBox10.Text = value
                    Me.Refresh()
                ElseIf value = 15 Then
                    TextBox8.Text = value
                    Me.Refresh()
                ElseIf value = 16 Then
                    TextBox6.Text = value
                    Me.Refresh()
                ElseIf value = 17 Then
                    TextBox4.Text = value
                    Me.Refresh()
                ElseIf value = 18 Then
                    TextBox2.Text = value
                    Me.Refresh()
                End If
                Thread.Sleep(125)
            Next
        End If
    End Sub
    '
    Public Sub busca_numero(ByVal p_valor1 As Integer, ByVal p_valor2 As Integer, ByVal p_valor3 As Integer)
        Dim numero As Integer = 0
        If p_valor1 = 1 And p_valor2 = 1 And p_valor3 = 2 Then
            numero = 1
        ElseIf p_valor1 = 2 And p_valor2 = 1 And p_valor3 = 3 Then
            numero = 2
        ElseIf p_valor1 = 3 And p_valor2 = 1 And p_valor3 = 1 Then
            numero = 3
        ElseIf p_valor1 = 1 And p_valor2 = 2 And p_valor3 = 2 Then
            numero = 4
        ElseIf p_valor1 = 2 And p_valor2 = 2 And p_valor3 = 3 Then
            numero = 5
        ElseIf p_valor1 = 3 And p_valor2 = 2 And p_valor3 = 1 Then
            numero = 6
        ElseIf p_valor1 = 1 And p_valor2 = 3 And p_valor3 = 2 Then
            numero = 7
        ElseIf p_valor1 = 2 And p_valor2 = 3 And p_valor3 = 3 Then
            numero = 8
        ElseIf p_valor1 = 3 And p_valor2 = 3 And p_valor3 = 1 Then
            numero = 9
        ElseIf p_valor1 = 1 And p_valor2 = 1 And p_valor3 = 3 Then
            numero = 10
        ElseIf p_valor1 = 2 And p_valor2 = 1 And p_valor3 = 1 Then
            numero = 11
        ElseIf p_valor1 = 3 And p_valor2 = 1 And p_valor3 = 2 Then
            numero = 12
        ElseIf p_valor1 = 1 And p_valor2 = 2 And p_valor3 = 3 Then
            numero = 13
        ElseIf p_valor1 = 2 And p_valor2 = 2 And p_valor3 = 1 Then
            numero = 14
        ElseIf p_valor1 = 3 And p_valor2 = 2 And p_valor3 = 2 Then
            numero = 15
        ElseIf p_valor1 = 1 And p_valor2 = 3 And p_valor3 = 3 Then
            numero = 16
        ElseIf p_valor1 = 2 And p_valor2 = 3 And p_valor3 = 1 Then
            numero = 17
        ElseIf p_valor1 = 3 And p_valor2 = 3 And p_valor3 = 2 Then
            numero = 18
        End If

        MsgBox("El numero es: " & numero)
    End Sub
    '
    Private Sub FormaTruco2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormaPrincipal.Enabled = True
    End Sub
    '
    Private Sub FormaTruco2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        habilita_group(0)
    End Sub
    '
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cambia_numero(1)
        habilita_group(1)
        TextBox28.Focus()
        Button1.Enabled = False
    End Sub

    Private Sub TextBox28_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox28.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Columna(numero) = Integer.Parse(TextBox28.Text)
                If Columna(numero) > 0 And Columna(numero) <= 3 Then
                    If Bandera = 1 Then
                        limpia_text(1)
                        TextBox28.Clear()
                        habilita_group(0)
                        cambia_numero(2)
                        habilita_group(1)
                        Bandera = 2
                        numero = numero + 1
                    ElseIf Bandera = 2 Then
                        limpia_text(1)
                        TextBox28.Clear()
                        habilita_group(0)
                        cambia_numero(3)
                        habilita_group(1)
                        Bandera = 3
                        numero = numero + 1
                    ElseIf Bandera = 3 Then
                        busca_numero(Columna(0), Columna(1), Columna(2))
                        limpia_text(0)
                        Button1.Enabled = True
                        TextBox28.Clear()
                        habilita_group(0)
                        Bandera = 1
                        numero = 0
                    End If
                Else
                    MsgBox("Existen solo 3 columnas.")                    
                    TextBox28.Clear()
                End If

            Catch ex As Exception
                If TextBox28.Text = "" Then
                    MsgBox("Ingrese un valor numerico.")
                    TextBox28.Clear()
                Else
                    MsgBox("El campo no admite valores alfanumericos.")
                    TextBox28.Clear()
                End If
            End Try
        End If
    End Sub
    '
End Class