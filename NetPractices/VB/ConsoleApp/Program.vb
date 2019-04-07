Imports System.Data.SqlClient
Module Program
    '
    Public Const DBString As String = "Data Source=SQLSERVER02;Integrated Security=true;Initial Catalog=TEST"
    Public SQL As String
    Dim CMD As New SqlCommand
    Dim CON As New SqlConnection
    '
    Sub SelectSQL()
        SQL = "SELECT * FROM Persons ORDER BY 1"
        Try
            CON.ConnectionString = DBString
            CON.Open()
            CMD.Connection = CON
            CMD.CommandText = SQL
            '
            Dim lrd As SqlDataReader = CMD.ExecuteReader()
            Dim var As String
            While lrd.Read()
                var = lrd(0) & " - " & lrd(1) & " - " & lrd(2)
                Console.WriteLine(var)
            End While
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub
    '
    Sub InsertSQL()
        SQL = "INSERT INTO Persons (FirstName,LastName,Age) VALUES (@FirstName,@LastName,@Age)"
        Try
            CON.ConnectionString = DBString
            CON.Open()
            CMD.Connection = CON
            CMD.CommandText = SQL
            CMD.Parameters.AddWithValue("@FirstName", "Console")
            CMD.Parameters.AddWithValue("@LastName", "Test")
            CMD.Parameters.AddWithValue("@Age", "0")
            CMD.ExecuteScalar()
            CMD.Parameters.Clear()
            '
            Console.WriteLine("Registro Insertado.")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub
    '
    Sub UpdateSQL()
        SQL = "UPDATE Persons SET FirstName=@FirstName,LastName=@LastName,Age=@Age WHERE ID=@ID"
        Try
            CON.ConnectionString = DBString
            CON.Open()
            CMD.Connection = CON
            CMD.CommandText = SQL
            CMD.Parameters.AddWithValue("@ID", 10)
            CMD.Parameters.AddWithValue("@FirstName", "Registro")
            CMD.Parameters.AddWithValue("@LastName", "Actualizado")
            CMD.Parameters.AddWithValue("@Age", 0)
            CMD.ExecuteScalar()
            CMD.Parameters.Clear()
            '
            Console.WriteLine("Registro Actualizado.")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub
    '
    Sub DeleteSQL()
        SQL = "DELETE FROM Persons WHERE ID=@ID"
        Try
            CON.ConnectionString = DBString
            CON.Open()

            CMD.Connection = CON
            CMD.CommandText = SQL
            CMD.Parameters.AddWithValue("@ID", 3)
            CMD.ExecuteScalar()
            CMD.Parameters.Clear()

            Console.WriteLine("Registro Eliminado.")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            CON.Close()
        End Try
    End Sub
    '
    Sub Main()
        'InsertSQL()
        'UpdateSQL()
        'DeleteSQL()
        SelectSQL()
        Console.ReadKey()
    End Sub
    '
End Module
