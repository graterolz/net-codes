Public Class FormaApartamento
    Dim connex As New ConectarBD
    Dim tablas As DataTable
    '
    Public Sub carga_listview_apartamento()
        Try
            Dim tab As String = "SELECT * FROM Apartamento"
            connex.Conectar(FormaLogin.dirbd, tab)
            For Each dr As DataRow In connex.dt.Rows
                Dim item As ListViewItem

                item = New ListViewItem(dr("idapartamento").ToString)
                item.SubItems.Add(dr("telefono").ToString)
                item.SubItems.Add(dr("status").ToString)

                ListView1.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Error al llenar Listview", MsgBoxStyle.Critical, FormaLogin.NombreApp)
        End Try
    End Sub
    '
    Private Sub FormaApartamento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_listview_apartamento()
        BotonModificar.Enabled = False
        BotonEliminar.Enabled = False
    End Sub
    '
    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
    '
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        BotonModificar.Enabled = True
        BotonEliminar.Enabled = True

        If Not ListView1.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In ListView1.SelectedItems
                'Cedula = item.Text
            Next
        End If
    End Sub
End Class