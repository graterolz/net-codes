Public Class Form6
    Private Sub calcularButton_Click(sender As Object, e As EventArgs) Handles calcularButton.Click
        Dim Numeros(4) As Integer
        Dim Aleatorio As New Random()
        Numeros(0) = 30
        Numeros(1) = 30
        Numeros(2) = 30
        Numeros(3) = 30
        Numeros(4) = 30

        While Numeros(0) > 20
            Numeros(0) = Aleatorio.Next(1, 100)
            If Numeros(0) <= 20 Then
                numero1TextBox.Text = Numeros(0)
            End If
        End While

        While Numeros(1) > 20
            Numeros(1) = Aleatorio.Next(1, 100)
            If Numeros(1) <= 20 Then
                numero2TextBox.Text = Numeros(1)
            End If
        End While

        While Numeros(2) > 20
            Numeros(2) = Aleatorio.Next(1, 100)
            If Numeros(2) <= 20 Then
                numero3TextBox.Text = Numeros(2)
            End If
        End While

        While Numeros(3) > 20
            Numeros(3) = Aleatorio.Next(1, 100)
            If Numeros(3) <= 20 Then
                numero4TextBox.Text = Numeros(3)
            End If
        End While

        While Numeros(4) > 20
            Numeros(4) = Aleatorio.Next(1, 100)
            If Numeros(4) <= 20 Then
                numero5TextBox.Text = Numeros(4)
            End If
        End While
    End Sub

    Private Sub salirButton_Click(sender As Object, e As EventArgs) Handles salirButton.Click
        End
    End Sub
End Class