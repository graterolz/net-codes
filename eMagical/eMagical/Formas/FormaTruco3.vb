Public Class FormaTruco3
    '
    Public Structure ListaARR
        Public CombinacionRespuesta As String
        Public ListaRespuesta As Integer
    End Structure
    '
    Dim Comb(30) As ListaARR
    '
    Dim Respuestas(9) As String
    Dim CadenaRespuesta As String = ""
    Dim Random As New Random()
    '
    Private Sub FormaTruco3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormaPrincipal.Enabled = True
    End Sub
    '
    Public Sub limpia_forma()
        '
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label17.Text = ""
        Label18.Text = ""
        Label19.Text = ""
        Label20.Text = ""
        Label21.Text = ""
        Label22.Text = ""
        Label23.Text = ""
        '
        GroupBox1.Visible = False
        '        
        Label1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button1.Enabled = True
        Button2.Enabled = True
        '
        Label2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button3.Enabled = True
        Button4.Enabled = True
        '
        Label3.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button5.Enabled = True
        Button6.Enabled = True
        '
        Label4.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button7.Enabled = True
        Button8.Enabled = True
        '
        Label5.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button9.Enabled = True
        Button10.Enabled = True
        '
        Label6.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button11.Enabled = True
        Button12.Enabled = True
        '
        Label7.Visible = False
        Button13.Visible = False
        Button14.Visible = False
        Button13.Enabled = True
        Button14.Enabled = True
        '
        Label8.Visible = False
        Button15.Visible = False
        Button16.Visible = False
        Button15.Enabled = True
        Button16.Enabled = True
        '
        Label9.Visible = False
        Button17.Visible = False
        Button18.Visible = False
        Button17.Enabled = True
        Button18.Enabled = True
        '
        Label10.Visible = False
        Button19.Visible = False
        Button20.Visible = False
        Button19.Enabled = True
        Button20.Enabled = True
    End Sub
    '
    Public Sub retorna_respuesta(ByVal p_numero As String)
        Dim Bandera As Integer = 0
        For i As Integer = 0 To 30
            If Comb(i).CombinacionRespuesta = p_numero Then
                For x As Integer = 0 To 9
                    If Comb(i).ListaRespuesta = x Then
                        MsgBox("Creo sospechar que el animal es: " & Respuestas(x) & ".")
                    End If
                Next
            Else
                Bandera = Bandera + 1
            End If
        Next

        If Bandera = 31 Then
            MsgBox("No logro adivinar, TU GANAS! D:")
        End If
    End Sub
    '
    Private Sub FormaTruco3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        limpia_forma()
        '
        Dim Numero As Integer = Random.Next(0, 10)

        'Perro
        Comb(0).CombinacionRespuesta = "0101101110"
        Comb(0).ListaRespuesta = 0
        Comb(1).CombinacionRespuesta = "0101100111"
        Comb(1).ListaRespuesta = 0
        Comb(2).CombinacionRespuesta = "0101101111"
        Comb(2).ListaRespuesta = 0

        'Gato
        Comb(3).CombinacionRespuesta = "0101001110"
        Comb(3).ListaRespuesta = 1
        Comb(4).CombinacionRespuesta = "0101001111"
        Comb(4).ListaRespuesta = 1
        Comb(5).CombinacionRespuesta = "2"
        Comb(5).ListaRespuesta = 1

        'Aguila
        Comb(6).CombinacionRespuesta = "1010001111"
        Comb(6).ListaRespuesta = 2
        Comb(7).CombinacionRespuesta = "1000001110"
        Comb(7).ListaRespuesta = 2
        Comb(8).CombinacionRespuesta = "2"
        Comb(8).ListaRespuesta = 2

        'Tigre        
        Comb(9).CombinacionRespuesta = "0000001111"
        Comb(9).ListaRespuesta = 3
        Comb(10).CombinacionRespuesta = "2"
        Comb(10).ListaRespuesta = 3
        Comb(11).CombinacionRespuesta = "2"
        Comb(11).ListaRespuesta = 3

        'Loro
        Comb(12).CombinacionRespuesta = "1111000111"
        Comb(12).ListaRespuesta = 4
        Comb(13).CombinacionRespuesta = "2"
        Comb(13).ListaRespuesta = 4
        Comb(14).CombinacionRespuesta = "2"
        Comb(14).ListaRespuesta = 4

        'Tiburon
        Comb(15).CombinacionRespuesta = "0000001010"
        Comb(15).ListaRespuesta = 5
        Comb(16).CombinacionRespuesta = "0000001011"
        Comb(17).ListaRespuesta = 5
        Comb(18).CombinacionRespuesta = "0000001001"
        Comb(18).ListaRespuesta = 5

        'Mono
        Comb(19).CombinacionRespuesta = "0110000011"
        Comb(19).ListaRespuesta = 6
        Comb(20).CombinacionRespuesta = "2"
        Comb(20).ListaRespuesta = 6
        Comb(21).CombinacionRespuesta = "2"
        Comb(21).ListaRespuesta = 6

        'Delfin
        Comb(22).CombinacionRespuesta = "0101001011"
        Comb(22).ListaRespuesta = 7
        Comb(23).CombinacionRespuesta = "2"
        Comb(23).ListaRespuesta = 7
        Comb(24).CombinacionRespuesta = "2"
        Comb(24).ListaRespuesta = 7

        'Serpiente
        Comb(25).CombinacionRespuesta = "0000011011"
        Comb(25).ListaRespuesta = 8
        Comb(26).CombinacionRespuesta = "0000011010"
        Comb(26).ListaRespuesta = 8
        Comb(27).CombinacionRespuesta = "2"
        Comb(27).ListaRespuesta = 8

        'Raton
        Comb(28).CombinacionRespuesta = "0000001101"
        Comb(28).ListaRespuesta = 9
        Comb(29).CombinacionRespuesta = "0000001111"
        Comb(29).ListaRespuesta = 9
        Comb(30).CombinacionRespuesta = "0000001110"
        Comb(30).ListaRespuesta = 9
        '
        Respuestas(0) = "Un Perro"
        Respuestas(1) = "Un Gato"
        Respuestas(2) = "Una Aguila"
        Respuestas(3) = "Un Tigre"
        Respuestas(4) = "Un Loro"
        Respuestas(5) = "Un Tiburon"
        Respuestas(6) = "Un Mono"
        Respuestas(7) = "Un Delfin"
        Respuestas(8) = "Una Serpiente"
        Respuestas(9) = "Un Raton"
        '
    End Sub
    '
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        GroupBox1.Visible = True
        Label1.Visible = True
        Button1.Visible = True
        Button2.Visible = True
    End Sub
    '
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label14.Text = "NO"
        '
        Button1.Enabled = False
        Button2.Enabled = False
        '
        Label2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label14.Text = "SI"
        '
        Button1.Enabled = False
        Button2.Enabled = False
        '
        Label2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label15.Text = "NO"
        '
        Button3.Enabled = False
        Button4.Enabled = False
        '
        Label3.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label15.Text = "SI"
        '
        Button3.Enabled = False
        Button4.Enabled = False
        '
        Label3.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label16.Text = "NO"
        '
        Button5.Enabled = False
        Button6.Enabled = False
        '
        Label4.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label16.Text = "SI"
        '
        Button5.Enabled = False
        Button6.Enabled = False
        '
        Label4.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Label17.Text = "NO"

        Button7.Enabled = False
        Button8.Enabled = False
        '
        Label5.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Label17.Text = "SI"
        '
        Button7.Enabled = False
        Button8.Enabled = False
        '
        Label5.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Label18.Text = "NO"
        '
        Button9.Enabled = False
        Button10.Enabled = False
        '
        Label6.Visible = True
        Button11.Visible = True
        Button12.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Label18.Text = "SI"
        '
        Button9.Enabled = False
        Button10.Enabled = False
        '
        Label6.Visible = True
        Button11.Visible = True
        Button12.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Label19.Text = "NO"
        '
        Button11.Enabled = False
        Button12.Enabled = False
        '
        Label7.Visible = True
        Button13.Visible = True
        Button14.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Label19.Text = "SI"
        '
        Button11.Enabled = False
        Button12.Enabled = False
        '
        Label7.Visible = True
        Button13.Visible = True
        Button14.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Label20.Text = "NO"
        '
        Button13.Enabled = False
        Button14.Enabled = False
        '
        Label8.Visible = True
        Button15.Visible = True
        Button16.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Label20.Text = "SI"
        '
        Button13.Enabled = False
        Button14.Enabled = False
        '
        Label8.Visible = True
        Button15.Visible = True
        Button16.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Label21.Text = "NO"
        '
        Button15.Enabled = False
        Button16.Enabled = False
        '
        Label9.Visible = True
        Button17.Visible = True
        Button18.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Label21.Text = "SI"
        '
        Button15.Enabled = False
        Button16.Enabled = False
        '
        Label9.Visible = True
        Button17.Visible = True
        Button18.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Label22.Text = "NO"
        '
        Button17.Enabled = False
        Button18.Enabled = False
        '
        Label10.Visible = True
        Button19.Visible = True
        Button20.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 0
    End Sub
    '
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Label22.Text = "SI"
        '
        Button17.Enabled = False
        Button18.Enabled = False
        '
        Label10.Visible = True
        Button19.Visible = True
        Button20.Visible = True
        '
        CadenaRespuesta = CadenaRespuesta & 1
    End Sub
    '
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Label23.Text = "NO"
        '
        Button19.Enabled = False
        Button20.Enabled = False
        '
        CadenaRespuesta = CadenaRespuesta & 0
        '
        retorna_respuesta(CadenaRespuesta)
        limpia_forma()
    End Sub
    '
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Label23.Text = "SI"
        '
        Button19.Enabled = False
        Button20.Enabled = False
        '
        CadenaRespuesta = CadenaRespuesta & 1
        '
        retorna_respuesta(CadenaRespuesta)
        limpia_forma()
    End Sub
End Class