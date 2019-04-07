Imports System.Data
Imports System.Data.OleDb
Public Class ConectarBD
    Public dt As DataTable
    Public da As OleDbDataAdapter
    Public fila As Integer
    Public ds As New DataSet
    Public Function Conectar(ByVal dirPath As String, ByVal tabla As String) As String
        Dim sCnn As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & dirPath
        Dim sSel As String = tabla

        Try
            da = New OleDbDataAdapter(sSel, sCnn)
            Dim cb As New OleDbCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            da.InsertCommand = cb.GetInsertCommand
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("ERROR al conectar o recuperar los datos:" & vbCrLf & _
                            ex.Message, "Conectar con la base", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Conectar
    End Function
End Class
