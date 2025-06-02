Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration

Partial Class Login
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection(WebConfigurationManager.ConnectionStrings("con").ConnectionString)

    Protected Sub LinkButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkButton1.Click
        MultiView1.ActiveViewIndex = 0
        Session.Abandon()
        txtunm.Text = ""
        txtpwd.Text = ""
    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim cmd As New SqlCommand("select count(*) from tbluser where usernm=@u and pwd=@p", con)
        cmd.Parameters.Add("@u", SqlDbType.VarChar).Value = txtunm.Text
        cmd.Parameters.Add("@p", SqlDbType.VarChar).Value = txtpwd.Text
        con.Open()
        Dim cnt As Integer
        cnt = CInt(cmd.ExecuteScalar)
        con.Close()
        If cnt = 0 Then
            lblmsg.Text = "User Doesn't Exist"
        Else
            MultiView1.ActiveViewIndex = 1
            Literal1.Text = txtunm.Text
            Session("unm") = txtunm.Text
        End If
    End Sub
End Class
