using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MySql.Data.MySqlClient;

namespace WebApplication1.App_Start
{
    public class Inculde
    {
        //public string GetConnection()
        //{
        //    string cn = WebConfigurationManager.ConnectionStrings["con"].ConnectionString;
        //    return cn;
        //}
        public MySqlConnection GetConnection()
        {
            
            string connectionString = "Server=localhost;Database=dhruvi;User ID=root;Password=dhruvi;";

            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }

        public MySqlConnection DB_Connection(string dbName)
        {
           
            string connectionString = $"Server=localhost;Database=db_{dbName};User ID=root;Password=dhruvi;";

           MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}