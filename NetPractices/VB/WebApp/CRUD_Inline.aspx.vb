Imports System.Data.SqlClient
Public Class CRUD_Inline
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
                gvSubDetails.DataSource = dt
                gvSubDetails.DataBind()
                sqlCon.Close()
            End Using
        End Using
    End Sub

    'called on row edit command
    Protected Sub gvSubDetails_RowEditing(ByVal sender As Object, ByVal e As GridViewEditEventArgs)
        gvSubDetails.EditIndex = e.NewEditIndex
        BindPersonData()
    End Sub

    'called when cancel edit mode
    Protected Sub gvSubDetails_RowCancelingEdit(ByVal sender As Object, ByVal e As GridViewCancelEditEventArgs)
        gvSubDetails.EditIndex = -1
        BindPersonData()
    End Sub

    'called on row add new command
    Protected Sub gvSubDetails_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs)
        If e.CommandName = "Add" Then
            Dim IsAdded As Boolean = False
            Dim FirstName As TextBox = CType(gvSubDetails.FooterRow.FindControl("newFirstName"), TextBox)
            Dim LastName As TextBox = CType(gvSubDetails.FooterRow.FindControl("newLastName"), TextBox)
            Dim Age As TextBox = CType(gvSubDetails.FooterRow.FindControl("newAge"), TextBox)
            Using sqlCon As New SqlConnection(DBString)
                Using cmd As New SqlCommand()
                    cmd.CommandText = "INSERT INTO Persons (FirstName,LastName,Age) VALUES (@FirstName,@LastName,@Age)"
                    cmd.Parameters.AddWithValue("@FirstName", FirstName.Text)
                    cmd.Parameters.AddWithValue("@LastName", LastName.Text)
                    cmd.Parameters.AddWithValue("@Age", Age.Text)
                    cmd.Connection = sqlCon
                    sqlCon.Open()
                    IsAdded = cmd.ExecuteNonQuery() > 0
                    sqlCon.Close()
                End Using
            End Using
            If IsAdded Then
                lblMsg.Text = "'" & FirstName.Text & "' person details has been added successfully!"
                lblMsg.ForeColor = System.Drawing.Color.Green
                BindPersonData()
            Else
                lblMsg.Text = "Error while adding '" & FirstName.Text & "' person details"
                lblMsg.ForeColor = System.Drawing.Color.Red
            End If
        End If
    End Sub

    'called on row update command
    Protected Sub gvSubDetails_RowUpdating(ByVal sender As Object, ByVal e As GridViewUpdateEventArgs)
        Dim IsUpdated As Boolean = False
        'getting key value, row id
        Dim ID As Integer = Convert.ToInt32(gvSubDetails.DataKeys(e.RowIndex).Value.ToString())
        'getting row field details
        Dim FirstName As TextBox = CType(gvSubDetails.Rows(e.RowIndex).FindControl("txtFirstName"), TextBox)
        Dim LastName As TextBox = CType(gvSubDetails.Rows(e.RowIndex).FindControl("txtLastName"), TextBox)
        Dim Age As TextBox = CType(gvSubDetails.Rows(e.RowIndex).FindControl("txtAge"), TextBox)
        Using sqlCon As New SqlConnection(DBString)
            Using cmd As New SqlCommand()
                cmd.CommandText = "UPDATE Persons SET FirstName=@FirstName,LastName=@LastName,Age=@Age WHERE ID=@ID"
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.Parameters.AddWithValue("@FirstName", FirstName.Text)
                cmd.Parameters.AddWithValue("@LastName", LastName.Text)
                cmd.Parameters.AddWithValue("@Age", Age.Text)
                cmd.Connection = sqlCon
                sqlCon.Open()
                IsUpdated = cmd.ExecuteNonQuery() > 0
                sqlCon.Close()
            End Using
        End Using
        If IsUpdated Then
            lblMsg.Text = "'" & FirstName.Text & "' person details has been updated successfully!"
            lblMsg.ForeColor = System.Drawing.Color.Green
        Else
            lblMsg.Text = "Error while updating '" & FirstName.Text & "' person details"
            lblMsg.ForeColor = System.Drawing.Color.Red
        End If
        gvSubDetails.EditIndex = -1
        BindPersonData()
    End Sub

    'called on row delete command
    Protected Sub gvSubDetails_RowDeleting(ByVal sender As Object, ByVal e As GridViewDeleteEventArgs)
        Dim IsDeleted As Boolean = False
        'getting key value, row id
        Dim ID As Integer = Convert.ToInt32(gvSubDetails.DataKeys(e.RowIndex).Value.ToString())
        'getting row field FirstName
        Dim FirstName As Label = CType(gvSubDetails.Rows(e.RowIndex).FindControl("lblFirstName"), Label)
        Using sqlCon As New SqlConnection(DBString)
            Using cmd As New SqlCommand()
                cmd.CommandText = "DELETE FROM Persons WHERE ID=@ID"
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.Connection = sqlCon
                sqlCon.Open()
                IsDeleted = cmd.ExecuteNonQuery() > 0
                sqlCon.Close()
            End Using
        End Using
        If IsDeleted Then
            lblMsg.Text = "'" & FirstName.Text & "' person details has been deleted successfully!"
            lblMsg.ForeColor = System.Drawing.Color.Green
            BindPersonData()
        Else
            lblMsg.Text = "Error while deleting '" & FirstName.Text & "' person details"
            lblMsg.ForeColor = System.Drawing.Color.Red
        End If
    End Sub
End Class