using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class EmpController : Controller
    {
        Employee emp = new Employee();
        public IActionResult Index()
        {
            emp.Id = 1;
            emp.Name = "Test";
            emp.Designtion = "abc";

            ViewBag.empid = emp.Id;
            ViewBag.empname = emp.Name;
            ViewBag.empdes = emp.Designtion;
            return View();
        }
        public IActionResult Emp()
        {
            return View();
        }
        public IActionResult ListObj()
        {
            List<Employee> lst = new List<Employee>
            {
                new Employee {Id=1,Name="nency",Designtion="jaipur",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
                new Employee {Id=2,Name="janvi",Designtion="rajashthan",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
                new Employee {Id=3,Name="janvi",Designtion="bangladesh",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
                new Employee {Id=4,Name="janvi",Designtion="afrika",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
                new Employee {Id=1,Name="nency",Designtion="haridwar",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
                new Employee {Id=2,Name="janvi",Designtion="adajan",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
                new Employee {Id=3,Name="janvi",Designtion="hajira",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
                new Employee {Id=4,Name="janvi",Designtion="katargam",age=25,Email="sads@gmail.com",LastName="vavadiya",Password="Dfdc",PasswordConfirmation="sdcsdc",Passwordd="wsds"},
            };
            return View(lst);
        }
    }
}
