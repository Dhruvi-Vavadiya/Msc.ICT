using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppForeginKey.Models;

namespace WebAppForeginKey.Controllers
{
    public class StudentController : Controller
    {

        mycontext my_context;

        public StudentController(mycontext my)
        {
            my_context = my;
        }
        public IActionResult Index()
        {
            var fetch = my_context.Students.Include(x => x.skillid).ToList();
            return View(fetch);
        }

        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(skill model)
        {
            my_context.Skills.Add(model);
            my_context.SaveChanges();
            ModelState.Clear();
            ViewBag.success = "Skill inserted";
            return View(model);
        }

        public IActionResult AddStudent()
        {
            ViewBag.getSkill = my_context.Skills.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(student model)
        {
            my_context.Students.Add(model);
            my_context.SaveChanges();
            ModelState.Clear();
            ViewBag.success = "students  data  inserted";
            return RedirectToAction("AddStudent");
        }
    }
}
