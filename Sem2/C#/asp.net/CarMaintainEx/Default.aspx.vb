Imports System.Data.SqlClient
Imports System.Data
Imports System.Web.Configuration
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection(WebConfigurationManager.ConnectionStrings("con").ConnectionString)
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("insert into car values(@cid,@cnm,@com,@col,@pri)", con)
        cmd.Parameters.Add("@cid", SqlDbType.Int).Value = txtcid.Text
        cmd.Parameters.Add("@cnm", SqlDbType.VarChar).Value = txtcnm.Text
        cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = txtcom.Text
        cmd.Parameters.Add("@col", SqlDbType.VarChar).Value = txtcolor.Text
        cmd.Parameters.Add("@pri", SqlDbType.Int).Value = txtprice.Text
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Inserted Successfully")
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cmd As New SqlCommand("select * from car", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "c1")
        GridView1.DataSource = ds.Tables("c1")
        GridView1.DataBind()
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand("update car set cnm=@cnm,com=@com,color=@col,price=@pri where cid=@cid", con)
        cmd.Parameters.Add("@cnm", SqlDbType.VarChar).Value = txtcnm.Text
        cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = txtcom.Text
        cmd.Parameters.Add("@col", SqlDbType.VarChar).Value = txtcolor.Text
        cmd.Parameters.Add("@pri", SqlDbType.Int).Value = txtprice.Text
        cmd.Parameters.Add("@cid", SqlDbType.Int).Value = txtcid.Text
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Updated Successfully")
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As New SqlCommand("delete from car where cid=" & txtcid.Text, con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("Delete Successfully")
    End Sub
End Class
