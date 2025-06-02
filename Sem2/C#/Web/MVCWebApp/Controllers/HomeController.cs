using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace MVCWebApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly CUsersPlanetOneDriveDocumentsDhruviMdfContext context;

        public HomeController(ILogger<HomeController> logger,CUsersPlanetOneDriveDocumentsDhruviMdfContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public ActionResult Index()
        {
            IEnumerable<Studnet> todo = context.Studnets;
            ICollection<Studnet> todo2 = context.Studnets.ToList();
            IList<Studnet> todo3 = context.Studnets.ToList();

            foreach (Studnet item in todo)
            {
                _logger.Log(LogLevel.Information, "enum" + item.Nm);   
            }
            foreach (Studnet item in todo2)
            {
                _logger.Log(LogLevel.Information, "coll" + item.Nm);
            }
            foreach (Studnet item in todo3)
            {
                _logger.Log(LogLevel.Information, "ilist" + item.Nm);
            }

            ViewBag.Meassage = "message from view bag!!";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();

            string[] fruits = { "apple", "banana", "lamon" };

            ViewBag.Fruits = fruits;

            ViewBag.sportlist = new List<String>(){"crichet","Hochy","football"};

            Employee ans = new Employee();
            {
                ans.Id = 22;
                ans.Name = "dhruvi";
                ans.Designtion = "surat";
            }
            ViewBag.emp = ans;

            var student = new List<String> { "dhrhvu vfcf", "sdsf sefe", "edfe efd" };
            ViewData["student"] = student;


            HttpContext.Session.SetString("mykey", "HAR HAR MAHADEV");
            return View();

            //return Content("<script>alert('Welcome To All');</script>");

            //return File("Web.Config", "text");
        }
        public IActionResult Employee()
        {
            if (HttpContext.Session.GetString("mykey") != null)
            {
                ViewBag.data = HttpContext.Session.GetString("mykey");
            }
            return View();
        }
        public String show()
        {
            return "i am show method";
        }

        public IActionResult showStudent()
        {
            var data = context.Studnets.ToList();
            return View(data);
        }

        public IActionResult Privacy()
        {
         var va=   HttpContext.Session.GetString("mykey");
            va += "i am  method";
            return View("Privacy", va);
        }
        public String Deatils(int? id,string name)
        {
            return "id= " + id.Value.ToString() + " name :" + name;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
