using System.Data;
using Microsoft.Data.SqlClient;

namespace WebAppMobileMVC.Models
{
    public class ErrorLog : IDataLog
    {
        private readonly IConfiguration _configuration;
        private SqlConnection _connection;
        private SqlCommand _command;

        public ErrorLog(IConfiguration config)
        {
            _configuration = config;
            _connection = new SqlConnection(_configuration.GetConnectionString("dbcs"));
            _command = new SqlCommand();
            _command.Connection = _connection;
        }
        public void Log(string message)
        {
            message = message + " " + DateTime.Now.ToString();
            _connection.Open();
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = "insert into TblError values ('" + message + "')";
            //_command.CommandText = "insert into TblError values ('"+message +"',"+ DateTime.Now.ToString() +")";
            _command.ExecuteNonQuery();
            _connection.Close();

        }
    }

    
}
