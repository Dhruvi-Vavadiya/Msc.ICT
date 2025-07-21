using Microsoft.Data.SqlClient;

namespace MICMExam.App_Data
{
    public class Inculde
    {
        public readonly IConfiguration
            _config;
        public Inculde(IConfiguration config) 
        {
            _config = config;
        }

        public SqlConnection db_micm(IConfiguration config)
        {
            SqlConnection conn = new SqlConnection(config.GetConnectionString("dbcs"));
            return conn;
        }
    }
}
