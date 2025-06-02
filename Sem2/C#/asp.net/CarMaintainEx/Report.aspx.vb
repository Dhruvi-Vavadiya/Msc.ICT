Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Configuration
Partial Class Report
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection(WebConfigurationManager.ConnectionStrings("con").ConnectionString)

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("select * from car where com=@c", con)
        cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = txtcomnm.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "c1")
        GridView1.DataSource = ds.Tables("c1")
        GridView1.DataBind()
    End Sub
End Class
