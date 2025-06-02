using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebAppliForeginKey.Models;

namespace WebAppliForeginKey.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ILogger<HomeController> _logger;
        SqlConnection conn;
        SqlCommand cmd;
       

        public HomeController(ILogger<HomeController> logger,IConfiguration configuration)
        {
            _logger = logger;
            _config = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public IActionResult Index()
        {
            try
            {
                string connectionstring = _config.GetConnectionString("dbcs");
                using (conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                }
                    return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred in the Index action.");
                SaveErrorToDatabase(ex); // Save error in SQL Server
                return View("Error");  // Redirect to an error page
            }
        }

        // Function to save error details in SQL Server
        private void SaveErrorToDatabase(Exception ex)
        {
            try
            {
                if (_config == null)
                {
                    throw new Exception("Configuration is null. Cannot fetch connection string.");
                }

                string connectionstring = _config.GetConnectionString("dbcs");

                if (string.IsNullOrEmpty(connectionstring))
                {
                    throw new Exception("Connection string is missing or empty.");
                }

                using ( conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                    string query = "INSERT INTO ErrorLogs (ErrorMessage, StackTrace, LogTime) VALUES (@ErrorMessage, @StackTrace, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ErrorMessage", ex.Message);
                        cmd.Parameters.AddWithValue("@StackTrace", ex.StackTrace);
                        //   at WebAppliForeginKey.Controllers.HomeController.Index() in D:\Msc_ICT\Sem2\C#\Web\WebAppliForeginKey\Controllers\HomeController.cs:line 27
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed to log error in database.");
            }
            finally
            {
                conn.Close();
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
