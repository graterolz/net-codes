Imports System.Data.SqlClient
Public Class CRUD_Simple
    Inherits System.Web.UI.Page

    Private DBString As String = ConfigurationManager.ConnectionStrings("DBString").ConnectionString
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblMsg.Text = ""
        If Not IsPostBack Then
            BindPersonData()
        End If
    End Sub

    'call this method to bind gridview
    Private Sub BindPersonData()
        Using sqlCon As New SqlConnection(DBString)
            Using cmd As New SqlCommand()
                cmd.CommandText = "SELECT * FROM Persons ORDER BY 1"
                cmd.Connection = sqlCon
                sqlCon.Open()
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)
                gvPersonDetails.DataSource = dt
                gvPersonDetails.DataBind()
                sqlCon.Close()
            End Using
        End Using
    End Sub

    'Insert click event to insert new record to database
    Protected Sub btnInsert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInsert.Click
        Dim IsAdded As Boolean = False
        Dim FirstName As String = txtFirstName.Text.Trim()
        Dim LastName As String = txtLastName.Text
        Dim Age As String = txtAge.Text
        Using sqlCon As New SqlConnection(DBString)
            Using cmd As New SqlCommand()
                cmd.CommandText = "INSERT INTO Persons (FirstName,LastName,Age) VALUES (@FirstName,@LastName,@Age)"
                cmd.Parameters.AddWithValue("@FirstName", FirstName)
                cmd.Parameters.AddWithValue("@LastName", LastName)
                cmd.Parameters.AddWithValue("@Age", Age)
                cmd.Connection = sqlCon
                sqlCon.Open()
                IsAdded = cmd.ExecuteNonQuery() > 0
                sqlCon.Close()
            End Using
        End Using
        If IsAdded Then
            lblMsg.Text = "'" & FirstName & "' person details added successfully!"
            lblMsg.ForeColor = System.Drawing.Color.Green

            BindPersonData()
        Else
            lblMsg.Text = "Error while adding '" & FirstName & "' person details"
            lblMsg.ForeColor = System.Drawing.Color.Red
        End If
        ResetAll() 'to reset all form controls
    End Sub

    'Update click event to update existing record from the gridview
    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)
        If String.IsNullOrEmpty(txtID.Text) Then
            lblMsg.Text = "Please select record to update"
            lblMsg.ForeColor = System.Drawing.Color.Red
            Return
        End If
        Dim IsUpdated As Boolean = False
        Dim SubjectID As Integer = Convert.ToInt32(txtID.Text)
        Dim FirstName As String = txtFirstName.Text.Trim()
        Dim LastName As String = txtLastName.Text
        Dim Age As String = txtAge.Text
        Using sqlCon As New SqlConnection(DBString)
            Using cmd As New SqlCommand()
                cmd.CommandText = "UPDATE Persons SET FirstName=@FirstName,LastName=@LastName,Age=@Age WHERE ID=@ID"
                cmd.Parameters.AddWithValue("@ID", SubjectID)
                cmd.Parameters.AddWithValue("@FirstName", FirstName)
                cmd.Parameters.AddWithValue("@LastName", LastName)
                cmd.Parameters.AddWithValue("@Age", Age)
                cmd.Connection = sqlCon
                sqlCon.Open()
                IsUpdated = cmd.ExecuteNonQuery() > 0
                sqlCon.Close()
            End Using
        End Using
        If IsUpdated Then
            lblMsg.Text = "'" & FirstName & "' person details updated successfully!"
            lblMsg.ForeColor = System.Drawing.Color.Green
        Else
            lblMsg.Text = "Error while updating '" & FirstName & "' person details"
            lblMsg.ForeColor = System.Drawing.Color.Red
        End If
        gvPersonDetails.EditIndex = -1
        BindPersonData()
        ResetAll() 'to reset all form controls
    End Sub

    'Delete click event to delete selected record from the database
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        If String.IsNullOrEmpty(txtID.Text) Then
            lblMsg.Text = "Please select record to delete"
            lblMsg.ForeColor = System.Drawing.Color.Red
            Return
        End If
        Dim IsDeleted As Boolean = False
        Dim SubjectID As Integer = Convert.ToInt32(txtID.Text)
        Dim FirstName As String = txtFirstName.Text.Trim()
        Using sqlCon As New SqlConnection(DBString)
            Using cmd As New SqlCommand()
                cmd.CommandText = "DELETE FROM Persons WHERE ID=@ID"
                cmd.Parameters.AddWithValue("@ID", SubjectID)
                cmd.Connection = sqlCon
                sqlCon.Open()
                IsDeleted = cmd.ExecuteNonQuery() > 0
                sqlCon.Close()
            End Using
        End Using
        If IsDeleted Then
            lblMsg.Text = "'" & FirstName & "' person details deleted successfully!"
            lblMsg.ForeColor = System.Drawing.Color.Green
            BindPersonData()
        Else
            lblMsg.Text = "Error while deleting '" & FirstName & "' person details"
            lblMsg.ForeColor = System.Drawing.Color.Red
        End If
        ResetAll() 'to reset all form controls
    End Sub

    'Cancel click event to clear and reset all the textboxes
    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        ResetAll() 'to reset all form controls
    End Sub

    Protected Sub gvPersonDetails_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        txtID.Text = gvPersonDetails.DataKeys(gvPersonDetails.SelectedRow.RowIndex).Value.ToString().Trim
        txtFirstName.Text = (TryCast(gvPersonDetails.SelectedRow.FindControl("lblFirstName"), Label)).Text.Trim
        txtLastName.Text = (TryCast(gvPersonDetails.SelectedRow.FindControl("lblLastName"), Label)).Text.Trim
        txtAge.Text = (TryCast(gvPersonDetails.SelectedRow.FindControl("lblAge"), Label)).Text.Trim
        'make invisible Insert button during update/delete
        btnInsert.Visible = False
    End Sub

    'call to reset all form controls
    Private Sub ResetAll()
        btnInsert.Visible = True
        txtID.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAge.Text = ""
    End Sub
End Class