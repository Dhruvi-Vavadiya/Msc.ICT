Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class forgatpwd
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection(WebConfigurationManager.ConnectionStrings("con").ConnectionString)

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("select * from tbluser where usernm=@unm", con)
        cmd.Parameters.Add("@unm", SqlDbType.VarChar).Value = txtunm.Text
        con.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        If dr.Read Then
            lbluser.Text = txtunm.Text
            lblques.Text = dr.GetString(4)
            MultiView1.ActiveViewIndex += 1
        Else
            lblmsg1.Text = "Invalid User Name !"
        End If
        dr.Close()
        con.Close()
    End Sub

  

    Protected Sub btncontiune_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncontiune.Click
        Response.Redirect("Login.aspx")
    End Sub

    Protected Sub btnget_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnget.Click
        Dim cmd As New SqlCommand("select count(*), pwd from tbluser where usernm=@unm and answer=@ans group by usernm,pwd", con)
        cmd.Parameters.Add("@unm", SqlDbType.VarChar).Value = txtunm.Text
        cmd.Parameters.Add("@ans", SqlDbType.VarChar).Value = txtans.Text
        con.Open()
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If dr.Read Then
            If dr.GetSqlInt32(0) = 1 Then
                lblpwd.Text = dr.GetString(1)
                MultiView1.ActiveViewIndex += 1
            End If
        Else
            lblmsg2.Text = "Invalid Answer"
        End If
        dr.Close()
        con.Close()
    End Sub
End Class
