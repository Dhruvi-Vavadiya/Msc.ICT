Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class _Default
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection(WebConfigurationManager.ConnectionStrings("con").ConnectionString)


    Protected Sub btncreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncreate.Click
        Dim cmd As New SqlCommand("insert into tbluser values(@u,@p,@cp,@e,@s,@a)", con)
        cmd.Parameters.Add("@u", SqlDbType.VarChar).Value = txtunm.Text
        cmd.Parameters.Add("@p", SqlDbType.VarChar).Value = txtpwd.Text
        cmd.Parameters.Add("@cp", SqlDbType.VarChar).Value = txtcpwd.Text
        cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = txtemail.Text
        cmd.Parameters.Add("@s", SqlDbType.VarChar).Value = txtque.Text
        cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = txtans.Text
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Registration")
        MultiView1.ActiveViewIndex = 1
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class
