Imports System.Data.OleDb
Public Class Periodo
    Dim CNX As New BD
    Public RegistroListView As Integer
    '
    Public Sub CargaListViewPeriodo()
        LVPeriodos.Items.Clear()

        CNX.SQL = "SELECT * FROM PERIODO ORDER BY 1"
        CNX.CursorBD_Access(CNX.SQL)
        For Each DR As DataRow In CNX.DT.Rows
            Dim Item As ListViewItem
            Item = New ListViewItem(DR("id_periodo").ToString)
            Item.SubItems.Add(DR("descripcion_periodo").ToString)
            LVPeriodos.Items.Add(Item)
        Next
    End Sub
    '
    Public Sub HabilitaBotones(ByVal pRespuesta As Boolean)
        If pRespuesta = True Then
            BModificar.Enabled = True
            BEliminar.Enabled = True
        Else
            BModificar.Enabled = False
            BEliminar.Enabled = False
        End If
    End Sub
    '
    Private Sub ModificaPeriodo()
        PeriodoModificaIncluye.TipoAccionPeriodo = "Modificar"
        PeriodoModificaIncluye.MdiParent = Principal
        PeriodoModificaIncluye.Show()
    End Sub
    '
    Private Sub EliminaPeriodo(ByVal pPeriodo As Integer)
        Dim result = MessageBox.Show("¿Estas Seguro de Eliminar el Registro?", Principal.NombreApp, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then

            CNX.SQL = "DELETE FROM PERIODO WHERE ID_PERIODO = " & pPeriodo

            CNX.ODbCn = New OleDbConnection(CNX.CadenaConexion)
            CNX.ODbCn.Open()
            CNX.ODbC = New OleDbCommand(CNX.SQL, CNX.ODbCn)
            CNX.ODbC.ExecuteNonQuery()
            CNX.ODbCn.Close()
            MessageBox.Show("Registro Eliminado.", Principal.NombreApp, MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargaListViewPeriodo()
        End If
    End Sub
    '
    Private Sub Periodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Principal.NombreApp
        CargaListViewPeriodo()
        HabilitaBotones(False)
    End Sub
    '
    Private Sub LVPeriodos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LVPeriodos.SelectedIndexChanged
        HabilitaBotones(True)

        If Not LVPeriodos.SelectedItems.Count = 0 Then
            For Each item As ListViewItem In LVPeriodos.SelectedItems
                RegistroListView = item.Text
            Next
        End If
    End Sub
    '
    Private Sub BIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIncluir.Click
        PeriodoModificaIncluye.TipoAccionPeriodo = "Inserta"
        PeriodoModificaIncluye.MdiParent = Principal
        PeriodoModificaIncluye.Show()
    End Sub
    '
    Private Sub BModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModificar.Click
        ModificaPeriodo()
    End Sub
    '
    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click
        EliminaPeriodo(RegistroListView)
        HabilitaBotones(False)
    End Sub
    '
    Private Sub BCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub
End Class