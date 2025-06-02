using Microsoft.Data.SqlClient;

namespace TestMVCCoreWebAPPCS.Models
{
    public class SQLDataLogger : IDataLogger
    {
        private IConfiguration _configuration;
        private SqlConnection _connection;
        private SqlCommand _command;
        private static int currentID = 1;
        public SQLDataLogger(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetConnectionString("SQLDBLoggerConnectionString"));
            _command = new SqlCommand();
            _command.Connection = _connection;
        }

        public void Log(string message)
        {
            //throw new NotImplementedException();
            message += " on " + DateTime.Now.ToString();
            _connection.Open();
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = "Insert into AppLogger values(" + currentID + ", '" + message + "')";
            _command.ExecuteNonQuery();
            _connection.Close();
            currentID++;
        }
    }
}
