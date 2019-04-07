Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Numero 1:"
        Label2.Text = "Numero 2:"
        Label3.Text = "Numero 3:"
        Label4.Text = "Numero 4:"
        '
        Button1.Text = "Calcular"
    End Sub
    '
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Integer = CType(TextBox1.Text, Integer)
        Dim B As Integer = CType(TextBox2.Text, Integer)
        Dim C As Integer = CType(TextBox3.Text, Integer)
        Dim D As Integer = CType(TextBox4.Text, Integer)
        '
        MsgBox("Se van a intercambiar los datos")
        '
        TextBox1.Text = D
        TextBox2.Text = C
        TextBox3.Text = B
        TextBox4.Text = A
    End Sub
End Class
