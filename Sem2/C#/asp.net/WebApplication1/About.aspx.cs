using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using WebApplication1.App_Start;

namespace WebApplication1
{
    public partial class About : Page
    {
        Inculde include = new Inculde();
        MySqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string suffix = Page.RouteData.Values["suffix"] as string;
            Response.Write("Dynamic Suffix: " + suffix + "<br>" + "<br>");
            Session["unm"] = suffix;
            Response.Write("SEssion :-" + Session["unm"] + "<br>" + "<br>");


            //string connectionString = "Server=localhost;Database=dhruvi;User ID=root;Password=dhruvi;";


            try
            {
                using (conn = include.GetConnection())
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    string query = $"SELECT * FROM cust where nm = '{Session["unm"]}';";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Check if any records were returned
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Process the records here

                            Response.Write("Databse cust name record " + reader["nm"].ToString() + "<br>"); // Corrected line
                            Response.Write("Databse cust email  " + reader["email"].ToString() + "<br>"); // Corrected line
                            Response.Write("Databse cust address  " + reader["addre"].ToString() + "<br>"); // Corrected line
                            Console.WriteLine(reader["nm"].ToString());
                        }
                        if (ChechDatabaseExists(suffix))
                        {
                            Console.WriteLine("done");
                            Response.Write($"<br>Databse exsists <b>db_{suffix}</b>" + "<br>");
                        }
                        else
                        {
                            Response.Write($"<br><<< --------- Databse NOT exsists <b>db_{suffix}</b>-------XXXXX>>>>>>>");
                            //Response.Redirect("/ErrorPage.aspx");
                        }
                    }
                    else
                    {
                        // No records found, redirect to error page
                        Console.WriteLine("No records found.");
                        Response.Redirect("/ErrorPage.aspx");  // Replace "ErrorPage.aspx" with your actual error page
                    }
                }



            }
            catch (Exception ex)
            {
                // Log the exception (you can add more detailed logging here)
                Console.WriteLine("Error: " + ex.Message);
                Response.Redirect("/ErrorPage.aspx");  // Redirect to error page in case of exception
            }
        }



        private bool ChechDatabaseExists(string dbName)
        {
            try
            {
                // string connectionString = $"Server=localhost;Database=db_{dbName};User ID=root;Password=dhruvi;";
                //string connectionString = include.GetConnection();
                using (conn = include.DB_Connection(dbName))
                {
                    conn.Open();
                    Console.WriteLine("Connection successful!");

                    string query = $"SELECT * FROM rest where nm='abc' AND pwd='123'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Check if any records were returned
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Response.Write("</br>Databse rest name record :-<b> " + reader["nm"].ToString() + "</b><br>"); // Corrected line
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            return false;
        }
        //end func
    }
}