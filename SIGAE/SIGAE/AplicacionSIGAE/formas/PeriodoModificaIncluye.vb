Imports System.Data.OleDb
Public Class PeriodoModificaIncluye
    Dim CNX As New BD
    Public TipoAccionPeriodo As String = Nothing
    Private Sub ObtieneSecuenciaPeriodo()
        CNX.SQL = "SELECT IIF(ISNULL(MAX(ID_PERIODO)),0,MAX(ID_PERIODO))+1 AS SECUENCIA FROM PERIODO"
        CNX.ODbCn = New OleDbConnection(CNX.CadenaConexion)
        CNX.ODbCn.Open()
        CNX.ODbC = New OleDbCommand(CNX.SQL, CNX.ODbCn)
        CNX.ODbDR = CNX.ODbC.ExecuteReader()
        While CNX.ODbDR.Read()
            TIDPeriodo.Text = CNX.ODbDR(0)
        End While
        CNX.ODbCn.Close()
    End Sub
    Private Sub InsertaPeriodo()
        CNX.SQL = "INSERT INTO PERIODO (ID_PERIODO,DESCRIPCION_PERIODO) VALUES('" & _
                    TIDPeriodo.Text & "','" & TDescripcionPeriodo.Text.Trim & "')"
        CNX.ODbCn = New OleDbConnection(CNX.CadenaConexion)
        CNX.ODbCn.Open()
        CNX.ODbC = New OleDbCommand(CNX.SQL, CNX.ODbCn)
        CNX.ODbC.ExecuteNonQuery()
        CNX.ODbCn.Close()
        MsgBox("Periodo Incluido")
    End Sub
    '
    Private Sub ObtieneRegistroParaActualizar()
        Periodo.RegistroListView = Periodo.RegistroListView
        CNX.SQL = "SELECT * FROM PERIODO WHERE ID_PERIODO = " & Periodo.RegistroListView
        CNX.ODbCn = New OleDbConnection(CNX.CadenaConexion)
        CNX.ODbCn.Open()
        CNX.ODbC = New OleDbCommand(CNX.SQL, CNX.ODbCn)
        CNX.ODbDR = CNX.ODbC.ExecuteReader()
        While CNX.ODbDR.Read()
            TIDPeriodo.Text = CNX.ODbDR(0)
            TDescripcionPeriodo.Text = CNX.ODbDR(1)
        End While
        CNX.ODbCn.Close()
    End Sub
    '
    Private Sub ActualizaPeriodo()
        CNX.SQL = "UPDATE PERIODO SET DESCRIPCION_PERIODO = '" & TDescripcionPeriodo.Text.Trim & "' WHERE ID_PERIODO = " & TIDPeriodo.Text
        CNX.ODbCn = New OleDbConnection(CNX.CadenaConexion)
        CNX.ODbCn.Open()
        CNX.ODbC = New OleDbCommand(CNX.SQL, CNX.ODbCn)
        CNX.ODbC.ExecuteNonQuery()
        CNX.ODbCn.Close()
        MsgBox("Periodo Actualizado")
    End Sub
    '
    Private Sub Periodo_Incluir_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Periodo.HabilitaBotones(False)
    End Sub
    '
    Private Sub Periodo_Incluir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Principal.NombreApp
        If TipoAccionPeriodo = "Inserta" Then
            ObtieneSecuenciaPeriodo()
            BMultiAccion.Text = "Incluir"
        ElseIf TipoAccionPeriodo = "Modificar" Then
            ObtieneRegistroParaActualizar()
            BMultiAccion.Text = "Modificar"
        End If
    End Sub
    '
    Private Sub BCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub
    '
    Private Sub BMultiAccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMultiAccion.Click
        If TDescripcionPeriodo.Text.Trim <> "" Then
            If TipoAccionPeriodo = "Inserta" Then
                InsertaPeriodo()
            ElseIf TipoAccionPeriodo = "Modificar" Then
                ActualizaPeriodo()
            End If
            Periodo.CargaListViewPeriodo()
            Me.Close()
        Else
            MsgBox("Registro NO Incluido")
        End If
    End Sub
End Class