Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim var1 As Integer = 21
        Dim var2 As Integer = 21
        Dim var3 As Integer = 21
        Dim var4 As Integer = 21
        Dim var5 As Integer = 21

        Dim Random As New Random()

        While var1 > 20
            var1 = Random.Next(1, 100)
            If var1 <= 20 Then
                TextBox1.Text = var1
            End If
        End While

        While var2 > 20
            var2 = Random.Next(1, 100)
            If var2 <= 20 Then
                TextBox2.Text = var2
            End If
        End While

        While var3 > 20
            var3 = Random.Next(1, 100)
            If var3 <= 20 Then
                TextBox3.Text = var3
            End If
        End While

        While var4 > 20
            var4 = Random.Next(1, 100)
            If var4 <= 20 Then
                TextBox4.Text = var4
            End If
        End While

        While var5 > 20
            var5 = Random.Next(1, 100)
            If var5 <= 20 Then
                TextBox5.Text = var5
            End If
        End While
    End Sub
End Class