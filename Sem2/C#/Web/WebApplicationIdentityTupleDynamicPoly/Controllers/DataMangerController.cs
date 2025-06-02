using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationIdentityTupleDynamicPoly.Models;

namespace WebApplicationIdentityTupleDynamicPoly.Controllers
{
    public class DataMangerController : Controller
    {
        public static List<IClassDesign> _datacoll = new List<IClassDesign>();

        public DataMangerController()
        {
            //IEnumerable<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            //// Get the enumerator
            //IEnumerator<string> enumerator = names.GetEnumerator();

            //// Manually iterate using MoveNext() and Current
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            if (_datacoll.Count == 0)
            {
                _datacoll.Add(new Studnet { sid = 1,age = 20,name = "dhuvi" , semester = "first"});
                _datacoll.Add(new Employee { eid = 101 , name = "parshant", salary = 50.5,designation = "Android dev"});
                _datacoll.Add(new Studnet { sid = 2, age = 16, name = "nency", semester = "secoend" });
                _datacoll.Add(new Employee { eid = 102, name = "khushi", salary = 20.5, designation = "Fultter dev" });
            }
        }

        // GET: DataMangerController
        public ActionResult Index()
        {
            return View(_datacoll.ToList());
        }

        public ActionResult stud()
        {
            List<Studnet> listOfStud = new List<Studnet>();
            foreach (var item in _datacoll)
            {
                if (item is Studnet)
                {
                    listOfStud.Add((Studnet)item);
                }
            }

            //var studs = _datacoll.Where(d => d is Studnet).Select(d => (Studnet)d);
            //studs.ToList();
            //return View(studs.ToList());
            return View(listOfStud.ToList());
        }

        public ActionResult StudentEmpIndex()
        {
            List<Studnet> listofstud = new List<Studnet>();
            List<Employee> emps = new List<Employee>();
            foreach(var item in _datacoll)
            {
                if(item is Studnet)
                {
                    listofstud.Add((Studnet)item);
                }
            }
            emps = _datacoll.Where(d => d is Employee).Select(d => (Employee)d).ToList();


            (List<Studnet>, List<Employee>) myList = (listofstud, emps);


            return View((listofstud, emps));
        }

        // GET: DataMangerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DataMangerController/Create
        public ActionResult Create()
        {   
            return View();
        }

        // POST: DataMangerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: DataMangerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DataMangerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DataMangerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DataMangerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
