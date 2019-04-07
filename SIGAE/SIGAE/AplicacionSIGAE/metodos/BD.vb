Imports System.Data.OleDb
Public Class BD
    Public DT As DataTable = Nothing
    Public ODbDA As OleDbDataAdapter = Nothing
    Public ODbDR As OleDbDataReader = Nothing
    Public ODbC As OleDbCommand = Nothing
    Public ODbCn As OleDbConnection = Nothing
    Public CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Application.StartupPath & "\AplicacionSIGAE\BD\BD_SIGAE.mdb"
    '
    Public SQL As String = ""    
    Public Sub CursorBD_Access(ByVal pSQL As String)
        Try
            ODbDA = New OleDbDataAdapter(pSQL, CadenaConexion)
            Dim CB As New OleDbCommandBuilder(ODbDA)
            CB.QuotePrefix = "["
            CB.QuoteSuffix = "]"
            ODbDA.InsertCommand = CB.GetInsertCommand
            DT = New DataTable
            ODbDA.Fill(DT)
        Catch EX As Exception
            MessageBox.Show("Error General:" & vbCrLf & _
                            EX.Message, "ConectarBD_Access", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Return Conectar
    End Sub
End Class
