Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Configuration
Partial Class changepwd
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection(WebConfigurationManager.ConnectionStrings("con").ConnectionString)

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("Login.aspx")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("update tbluser set pwd=@np,cpwd=@cn where usernm=@u and pwd=@op", con)
        cmd.Parameters.Add("@np", SqlDbType.VarChar).Value = txtnewpwd.Text
        cmd.Parameters.Add("@cn", SqlDbType.VarChar).Value = txtconpwd.Text
        cmd.Parameters.Add("@u", SqlDbType.VarChar).Value = Session("unm")
        cmd.Parameters.Add("@op", SqlDbType.VarChar).Value = txtoldpwd.Text
        con.Open()
        Dim cnt As Integer
        cnt = cmd.ExecuteNonQuery
        con.Close()
        If cnt = 1 Then
            MultiView1.ActiveViewIndex = 1
        Else
            MsgBox("Invalid Password")
        End If
    End Sub
End Class
