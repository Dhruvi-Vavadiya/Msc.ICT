using Oracle.ManagedDataAccess.Client;

namespace TestMVCCoreWebAPPCS.Models
{
    public class OracleDataLogger : IDataLogger
    {
        private IConfiguration _configuration;
        private OracleConnection _connection;
        private OracleCommand _command;
        private static int currentID = 1;
        public OracleDataLogger(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new OracleConnection(_configuration.GetConnectionString("OracleDBLoggerConnectionString"));
            _command = new OracleCommand();
            _command.Connection = _connection;
        }
        public void Log(string message)
        {
            message += " on " + DateTime.Now.ToString();
            //throw new NotImplementedException();
            _connection.Open();
            _command.CommandType = System.Data.CommandType.Text;
            _command.CommandText = "Insert into AppLogger values(" + currentID + ", '" + message + "')";
            _command.ExecuteNonQuery();
            _connection.Close();
            currentID++;
        }
    }
}
