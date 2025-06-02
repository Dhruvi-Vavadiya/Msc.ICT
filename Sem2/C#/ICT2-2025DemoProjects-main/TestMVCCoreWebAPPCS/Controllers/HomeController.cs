using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using TestMVCCoreWebAPPCS.Models;

namespace TestMVCCoreWebAPPCS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataLogger _dataLogger;

        private readonly IConfiguration _config;

        public HomeController(ILogger<HomeController> logger, IDataLogger dataLogger, IConfiguration config)
        {
            _logger = logger;
            _dataLogger = dataLogger;
            _config = config;

        }

        public IActionResult Index()
        {
            _logger.Log(LogLevel.Warning, "logger test warnig");
            try
            {
                string connectionstring = _config.GetConnectionString("dbcs");
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                }
                return View();
            }
            catch (Exception ex)
            {
                _dataLogger.Log(ex.Message);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            _dataLogger.Log("This is Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
