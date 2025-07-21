using System.Diagnostics;
using MICMExam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace MICMExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IConfiguration _config;
        //private readonly ExamMicmContext _context;

        public HomeController(ILogger<HomeController> logger
            //,IConfiguration config, ExamMicmContext context
            )
        {
            _logger = logger;
            //_config = config;
            //_context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(HelpDeskCall model)
        //{
        //    SqlConnection conn = new SqlConnection(_config.GetConnectionString("dbcs"));
        //    SqlCommand cmd = new SqlCommand("INSERT INTO HelpDeskCall (CustomerName, CustomerQuery, TokenNumber, CreatedOn) VALUES (@CustomerName, @CustomerQuery, @TokenNumber, GETDATE())", conn);
        //    cmd.Parameters.AddWithValue("@CustomerName", model.CustomerName);
        //    cmd.Parameters.AddWithValue("@CustomerQuery", model.CustomerQuery);
        //    int token_no = _context.HelpDeskCalls.Select(s => s.Id).Count() + 1;
        //    string token_string = "T0" + token_no;
        //    cmd.Parameters.AddWithValue("@TokenNumber", token_string);
        //    cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
        //    try
        //    {
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //        ViewBag.Message = "Call created successfully!";
        //        return RedirectToAction("Index","HelpDeskCalls");
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewBag.Message = "Error: " + ex.Message;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return View();
        //}

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
