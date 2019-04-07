Public Class FormaPago
    Dim connex As New ConectarBD
    Dim tablas As DataTable
    '
    Public Sub carga_listview_pago()
        Try
            Dim tab As String = "SELECT * FROM Pagos"
            connex.Conectar(FormaLogin.dirbd, tab)
            For Each dr As DataRow In connex.dt.Rows
                Dim item As ListViewItem

                item = New ListViewItem(dr("Id").ToString)
                item.SubItems.Add(dr("Fecha").ToString)
                item.SubItems.Add(dr("idInquilino").ToString)
                item.SubItems.Add(dr("Monto").ToString)
                item.SubItems.Add(dr("FormaPago").ToString)
                item.SubItems.Add(dr("EstadoPago").ToString)
                ListView1.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Error al llenar Listview", MsgBoxStyle.Critical, FormaLogin.NombreApp)
        End Try
    End Sub
    '
    Private Sub FormaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_listview_pago()
    End Sub
    '
    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
    '
End Class