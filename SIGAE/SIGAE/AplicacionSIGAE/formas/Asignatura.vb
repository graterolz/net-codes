Imports System.Data.OleDb
Public Class Asignatura
    Dim CNX As New BD
    '
    Public Sub CargaComboBoxPeriodo()
        CBPeriodos.Items.Clear()

        CNX.SQL = "SELECT * FROM PERIODO ORDER BY 1"
        CNX.ODbCn = New OleDbConnection(CNX.CadenaConexion)
        CNX.ODbCn.Open()
        CNX.ODbC = New OleDb.OleDbCommand(CNX.SQL, CNX.ODbCn)
        CNX.ODbDR = CNX.ODbC.ExecuteReader()
        While CNX.ODbDR.Read()
            Me.CBPeriodos.Items.Add(CNX.ODbDR(1))
        End While
        CNX.ODbDR.Close()
        CNX.ODbCn.Close()

        CBPeriodos.Text = CBPeriodos.Items(0).ToString
    End Sub
    '
    Public Sub CargaListViewAsignatura()
        LVAsignaturas.Items.Clear()

        CNX.SQL = "SELECT * FROM ASIGNATURA WHERE ID_PERIODO = (SELECT ID_PERIODO FROM PERIODO WHERE DESCRIPCION_PERIODO = '" & CBPeriodos.Text & "')"
        CNX.CursorBD_Access(CNX.SQL)
        For Each DR As DataRow In CNX.DT.Rows
            Dim Item As ListViewItem
            Item = New ListViewItem(DR("ID_ASIGNATURA").ToString)
            Item.SubItems.Add(DR("DESCRIPCION_ASIGNATURA").ToString)
            LVAsignaturas.Items.Add(Item)
        Next
    End Sub
    '
    Private Sub Asignatura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Principal.NombreApp
        CargaComboBoxPeriodo()
        CargaListViewAsignatura()
    End Sub
    '
    Private Sub CBPeriodos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPeriodos.SelectedIndexChanged
        CargaListViewAsignatura()
    End Sub
    '
    Private Sub BIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BIncluir.Click

    End Sub
    '
    Private Sub BModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BModificar.Click

    End Sub
    '
    Private Sub BEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEliminar.Click

    End Sub
    '
    Private Sub BCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub
End Class