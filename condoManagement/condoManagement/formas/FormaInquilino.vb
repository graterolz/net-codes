﻿Public Class FormaInquilino
    Dim connex As New ConectarBD
    Dim tablas As DataTable
    '
    Public Sub carga_listview_inquilino()
        Try
            Dim tab As String = "SELECT * FROM Inquilino"
            connex.Conectar(FormaLogin.dirbd, tab)
            For Each dr As DataRow In connex.dt.Rows
                Dim item As ListViewItem

                item = New ListViewItem(dr("idinquilino").ToString)
                item.SubItems.Add(dr("cedula").ToString)
                item.SubItems.Add(dr("nombre").ToString)
                item.SubItems.Add(dr("apellido").ToString)
                item.SubItems.Add(dr("idapartamento").ToString)
                item.SubItems.Add(dr("tipocontrato").ToString)
                ListView1.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox("Error al llenar Listview", MsgBoxStyle.Critical, FormaLogin.NombreApp)
        End Try
    End Sub
    '
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carga_listview_inquilino()
        BotonModificar.Enabled = False
        BotonEliminar.Enabled = False
    End Sub
    '
    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.Close()
    End Sub
End Class