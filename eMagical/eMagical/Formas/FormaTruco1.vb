Public Class FormaTruco1
    '
    Dim Simbolos(19) As String
    Dim SimboloPrincipal As String
    Dim Random As New Random()
    '
    Private Sub FormaTruco1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FormaPrincipal.Enabled = True
    End Sub
    Public Sub asigna_simbolo_principal(ByVal p_simbolo As String)
        SimboloPrincipal = p_simbolo
        '
        Button0.Text = p_simbolo
        Button9.Text = p_simbolo
        Button18.Text = p_simbolo
        Button27.Text = p_simbolo
        Button36.Text = p_simbolo
        Button45.Text = p_simbolo
        Button54.Text = p_simbolo
        Button63.Text = p_simbolo
        Button72.Text = p_simbolo
        Button81.Text = p_simbolo
        Button90.Text = p_simbolo
        Button99.Text = p_simbolo
    End Sub
    '
    Public Sub asigna_simbolo_restantes()
        '
        'Button0.Text = ""
        Button1.Text = Simbolos(Random.Next(0, 19)) '""
        Button2.Text = Simbolos(Random.Next(0, 19)) '""
        Button3.Text = Simbolos(Random.Next(0, 19)) '""
        Button4.Text = Simbolos(Random.Next(0, 19)) '""
        Button5.Text = Simbolos(Random.Next(0, 19)) '""
        Button6.Text = Simbolos(Random.Next(0, 19)) '""
        Button7.Text = Simbolos(Random.Next(0, 19)) '""
        Button8.Text = Simbolos(Random.Next(0, 19)) '""
        'Button9.Text = ""
        '
        Button10.Text = Simbolos(Random.Next(0, 19))
        Button11.Text = Simbolos(Random.Next(0, 19))
        Button12.Text = Simbolos(Random.Next(0, 19))
        Button13.Text = Simbolos(Random.Next(0, 19))
        Button14.Text = Simbolos(Random.Next(0, 19))
        Button15.Text = Simbolos(Random.Next(0, 19))
        Button16.Text = Simbolos(Random.Next(0, 19))
        Button17.Text = Simbolos(Random.Next(0, 19))
        'Button18.Text = ""
        Button19.Text = Simbolos(Random.Next(0, 19))
        '
        Button20.Text = Simbolos(Random.Next(0, 19))
        Button21.Text = Simbolos(Random.Next(0, 19))
        Button22.Text = Simbolos(Random.Next(0, 19))
        Button23.Text = Simbolos(Random.Next(0, 19))
        Button24.Text = Simbolos(Random.Next(0, 19))
        Button25.Text = Simbolos(Random.Next(0, 19))
        Button26.Text = Simbolos(Random.Next(0, 19))
        'Button27.Text = ""
        Button28.Text = Simbolos(Random.Next(0, 19))
        Button29.Text = Simbolos(Random.Next(0, 19))
        Button30.Text = Simbolos(Random.Next(0, 19))
        '
        Button31.Text = Simbolos(Random.Next(0, 19))
        Button32.Text = Simbolos(Random.Next(0, 19))
        Button33.Text = Simbolos(Random.Next(0, 19))
        Button34.Text = Simbolos(Random.Next(0, 19))
        Button35.Text = Simbolos(Random.Next(0, 19))
        'Button36.Text = ""
        Button37.Text = Simbolos(Random.Next(0, 19))
        Button38.Text = Simbolos(Random.Next(0, 19))
        Button39.Text = Simbolos(Random.Next(0, 19))
        Button40.Text = Simbolos(Random.Next(0, 19))
        '
        Button41.Text = Simbolos(Random.Next(0, 19))
        Button42.Text = Simbolos(Random.Next(0, 19))
        Button43.Text = Simbolos(Random.Next(0, 19))
        Button44.Text = Simbolos(Random.Next(0, 19))
        'Button45.Text = ""
        Button46.Text = Simbolos(Random.Next(0, 19))
        Button47.Text = Simbolos(Random.Next(0, 19))
        Button48.Text = Simbolos(Random.Next(0, 19))
        Button49.Text = Simbolos(Random.Next(0, 19))
        Button50.Text = Simbolos(Random.Next(0, 19))
        '
        Button51.Text = Simbolos(Random.Next(0, 19))
        Button52.Text = Simbolos(Random.Next(0, 19))
        Button53.Text = Simbolos(Random.Next(0, 19))
        'Button54.Text = ""
        Button55.Text = Simbolos(Random.Next(0, 19))
        Button56.Text = Simbolos(Random.Next(0, 19))
        Button57.Text = Simbolos(Random.Next(0, 19))
        Button58.Text = Simbolos(Random.Next(0, 19))
        Button59.Text = Simbolos(Random.Next(0, 19))
        Button60.Text = Simbolos(Random.Next(0, 19))
        '
        Button61.Text = Simbolos(Random.Next(0, 19))
        Button62.Text = Simbolos(Random.Next(0, 19))
        'Button63.Text = ""
        Button64.Text = Simbolos(Random.Next(0, 19))
        Button65.Text = Simbolos(Random.Next(0, 19))
        Button66.Text = Simbolos(Random.Next(0, 19))
        Button67.Text = Simbolos(Random.Next(0, 19))
        Button68.Text = Simbolos(Random.Next(0, 19))
        Button69.Text = Simbolos(Random.Next(0, 19))
        Button70.Text = Simbolos(Random.Next(0, 19))
        '
        Button71.Text = Simbolos(Random.Next(0, 19))
        'Button72.Text = ""
        Button73.Text = Simbolos(Random.Next(0, 19))
        Button74.Text = Simbolos(Random.Next(0, 19))
        Button75.Text = Simbolos(Random.Next(0, 19))
        Button76.Text = Simbolos(Random.Next(0, 19))
        Button77.Text = Simbolos(Random.Next(0, 19))
        Button78.Text = Simbolos(Random.Next(0, 19))
        Button79.Text = Simbolos(Random.Next(0, 19))
        Button80.Text = Simbolos(Random.Next(0, 19))
        '
        'Button81.Text = ""
        Button82.Text = Simbolos(Random.Next(0, 19))
        Button83.Text = Simbolos(Random.Next(0, 19))
        Button84.Text = Simbolos(Random.Next(0, 19))
        Button85.Text = Simbolos(Random.Next(0, 19))
        Button86.Text = Simbolos(Random.Next(0, 19))
        Button87.Text = Simbolos(Random.Next(0, 19))
        Button88.Text = Simbolos(Random.Next(0, 19))
        Button89.Text = Simbolos(Random.Next(0, 19))
        'Button90.Text = ""
        '
        Button91.Text = Simbolos(Random.Next(0, 19))
        Button92.Text = Simbolos(Random.Next(0, 19))
        Button93.Text = Simbolos(Random.Next(0, 19))
        Button94.Text = Simbolos(Random.Next(0, 19))
        Button95.Text = Simbolos(Random.Next(0, 19))
        Button96.Text = Simbolos(Random.Next(0, 19))
        Button97.Text = Simbolos(Random.Next(0, 19))
        Button98.Text = Simbolos(Random.Next(0, 19))
        'Button99.Text = ""
        Label105.Text = "¿?"
    End Sub
    Private Sub FormaTruco1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        'Simbolos(0) = "Ω"
        'Simbolos(1) = "-"
        'Simbolos(2) = "/"
        'Simbolos(3) = "="
        'Simbolos(4) = "µ"
        'Simbolos(5) = "ß"
        'Simbolos(6) = "§"
        'Simbolos(7) = "«"
        'Simbolos(8) = "¥"
        'Simbolos(9) = "+"
        'Simbolos(10) = "£"
        'Simbolos(11) = "¢"
        'Simbolos(12) = "×"
        'Simbolos(13) = "%"
        'Simbolos(14) = "¾"
        'Simbolos(15) = "½"
        'Simbolos(16) = "¼"
        'Simbolos(17) = "»"
        'Simbolos(18) = "*"
        'Simbolos(19) = "#"

        Simbolos(0) = "A"
        Simbolos(1) = "B"
        Simbolos(2) = "C"
        Simbolos(3) = "D"
        Simbolos(4) = "E"
        Simbolos(5) = "F"
        Simbolos(6) = "G"
        Simbolos(7) = "H"
        Simbolos(8) = "I"
        Simbolos(9) = "J"
        Simbolos(10) = "K"
        Simbolos(11) = "L"
        Simbolos(12) = "M"
        Simbolos(13) = "N"
        Simbolos(14) = "O"
        Simbolos(15) = "P"
        Simbolos(16) = "Q"
        Simbolos(17) = "R"
        Simbolos(18) = "S"
        Simbolos(19) = "T"

        Dim Numero As Integer = Random.Next(0, 20)
        asigna_simbolo_principal(Simbolos(Numero))
        asigna_simbolo_restantes()
    End Sub

    Private Sub Button100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button100.Click
        Label105.Text = SimboloPrincipal
        MsgBox("El Simbolo es: " & SimboloPrincipal)

        Dim Numero As Integer = Random.Next(0, 20)
        asigna_simbolo_principal(Simbolos(Numero))
        asigna_simbolo_restantes()
    End Sub

    Private Sub Button101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button101.Click
        If GroupBox1.Visible = True Then
            GroupBox1.Visible = False
        Else
            GroupBox1.Visible = True
        End If
    End Sub
End Class