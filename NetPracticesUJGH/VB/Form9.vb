Public Class Form9
    '
    Dim Lenguajes As String() = New String(1) {}
    Dim CantidadCodigos As Integer = 9
    '
    Dim CodigosC As String() = New String(CantidadCodigos) {}
    Dim CodigosJava As String() = New String(CantidadCodigos) {}
    '
    Dim DescripcionC As String() = New String(CantidadCodigos) {}
    Dim DescripcionJava As String() = New String(CantidadCodigos) {}
    '
    Dim ArchivoC As String() = New String(CantidadCodigos) {}
    Dim ArchivoJava As String() = New String(CantidadCodigos) {}
    '
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        asignaLenguajes()
        asignaDescripcionC()
        asignaDescripcionJava()
    End Sub
    '
    Sub asignaLenguajes()
        Lenguajes(0) = "C++"
        Lenguajes(1) = "Java"
        ListBox1.Items.AddRange(Lenguajes)
    End Sub
    '
    Sub asignaCodigoC()
        CodigosC(0) = "HolaMundo"
        CodigosC(1) = "Imprime cadena"
        CodigosC(2) = "Cantidad de letras en cadena"
        CodigosC(3) = "Suma de 2 Numeros"
        CodigosC(4) = "Resta de 2 Numeros"
        CodigosC(5) = "Multiplicacion de 2 Numeros"
        CodigosC(6) = "Division de 2 Numeros"
        CodigosC(7) = "Potencia de un Numero"
        CodigosC(8) = "Raiz cuadrada de un Numero"
        CodigosC(9) = "Determina numero Mayor"

        ArchivoC(0) = "C001_HolaMundo.cpp"
        ArchivoC(1) = "C002_ImprimeCadena.cpp"
        ArchivoC(2) = "C003_CantidadLetrasCadena.cpp"
        ArchivoC(3) = "C004_Suma2Numeros.cpp"
        ArchivoC(4) = "C005_Resta2Numeros.cpp"
        ArchivoC(5) = "C006_Multiplicacion2Numeros.cpp"
        ArchivoC(6) = "C007_Division2Numeros.cpp"
        ArchivoC(7) = "C008_PotenciaNumero.cpp"
        ArchivoC(8) = "C009_RaizCuadrada.cpp"
        ArchivoC(9) = "C010_NumeroMayor.cpp"

        ListBox2.Items.AddRange(CodigosC)
    End Sub
    '
    Sub asignaDescripcionC()
        DescripcionC(0) = "Programa que muestra el famoso Hola Mundo.. en C++"
        DescripcionC(1) = "Descripcion del Codigo 2"
        DescripcionC(2) = "Descripcion del Codigo 3"
    End Sub
    '
    Sub asignaCodigoJava()
        CodigosJava(0) = "HolaMundo en Java"
        CodigosJava(1) = "Imprime cadena"
        CodigosJava(2) = "Cantidad de letras en cadena"
        CodigosJava(3) = "Suma de 2 Numeros"
        CodigosJava(4) = "Resta de 2 Numeros"
        CodigosJava(5) = "Multiplicacion de 2 Numeros"
        CodigosJava(6) = "Division de 2 Numeros"
        CodigosJava(7) = "Potencia de un Numero"
        CodigosJava(8) = "Raiz cuadrada de un Numero"
        CodigosJava(9) = "Determina numero Mayor"

        ArchivoJava(0) = "J001_HolaMundo.java"
        ArchivoJava(1) = "J002_ImprimeCadena.java"
        ArchivoJava(2) = "J003_CantidadLetrasCadena.java"
        ArchivoJava(3) = "J004_Suma2Numeros.java"
        ArchivoJava(4) = "J005_Resta2Numeros.java"
        ArchivoJava(5) = "J006_Multiplicacion2Numeros.java"
        ArchivoJava(6) = "J007_Division2Numeros.java"
        ArchivoJava(7) = "J008_PotenciaNumero.java"
        ArchivoJava(8) = "J009_RaizCuadrada.java"
        ArchivoJava(9) = "J010_NumeroMayor.java"

        ListBox2.Items.AddRange(CodigosJava)
    End Sub
    '
    Sub asignaDescripcionJava()
        DescripcionJava(0) = "Programa que muestra el famoso Hola Mundo.. en Java"
        DescripcionJava(1) = "Descripcion del Codigo 2 Java"
        DescripcionJava(2) = "Descripcion del Codigo 3 Java"
    End Sub
    '

    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fic As String = ""
            If ListBox1.SelectedItem.ToString() = Lenguajes(0) Then
                fic = Application.StartupPath & "\Codigos\C++\" & ArchivoC(ListBox2.SelectedIndex)
            ElseIf ListBox1.SelectedItem.ToString() = Lenguajes(1) Then
                fic = Application.StartupPath & "\Codigos\Java\" & ArchivoJava(ListBox2.SelectedIndex)
            End If


            Dim texto As String
            '
            Dim sr As New System.IO.StreamReader(fic)
            texto = sr.ReadToEnd()
            sr.Close()
            '
            TextBox2.Text = texto
            MsgBox("Codigo Generado.")
        Catch ex As Exception
            MsgBox("Error al generar codigo: " & ex.ToString)
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        'TextBox1.Clear()
        '
        If ListBox1.SelectedItem.ToString() = Lenguajes(0) Then
            asignaCodigoC()
        ElseIf ListBox1.SelectedItem.ToString() = Lenguajes(1) Then
            asignaCodigoJava()
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        '
        If ListBox1.SelectedItem.ToString() = Lenguajes(0) Then
            'TextBox1.Text = DescripcionC(ListBox2.SelectedIndex)
        ElseIf ListBox1.SelectedItem.ToString() = Lenguajes(1) Then
            'TextBox1.Text = DescripcionJava(ListBox2.SelectedIndex)
        End If
        '
    End Sub
End Class