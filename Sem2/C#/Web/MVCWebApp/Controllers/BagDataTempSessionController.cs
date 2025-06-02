using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class BagDataTempSessionController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.var1 = "i am view bag";
            ViewData["var2"] = "i am view data";
            TempData["var3"] = " i am temp data";
            return RedirectToAction("About");
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
