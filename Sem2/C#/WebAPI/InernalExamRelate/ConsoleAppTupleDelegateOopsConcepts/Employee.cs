using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppTupleDelegateOopsConcepts;

namespace ConsoleAppTupleDelegateOopsConcepts
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }


        static void Main()
        {
            //1st List
            var emps = new List<Employee>()
            {
                new Employee() { Id = 1,Name = "dhruvi" },
                new Employee() { Id = 2,Name = "encu" }

            };

            //2nd list
            List<Employee> emps1= new List<Employee>();

            emps1.Add(new Employee { Name = "dhruvi", Id = 5 });
            emps1.Add(new Employee { Name = "nencu", Id = 9 });


            foreach (var item in emps)
            {
                Console.WriteLine(item.Id + " , " + item.Name);
            }
            IEnumerable<Employee> ie = emps1;

            foreach (var item in ie)
            {
                Console.WriteLine(item.Id + item.Name);
            }

            //3rd list

            List<string> em = new List<string>();
            em.Add("rrrr");
            em.Add("Jeo");
            em.Add("hhhh");

            IEnumerable<string> iee = em;

            foreach (var item in iee)
            {
                Console.WriteLine(item);
            }

            //example
            IEnumerator<string> ienumerator = iee.GetEnumerator();
            while (ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current);
            }
            ////
            ///
            IEnumerable<string> names = new List<string> { "Alice", "Bob", "Charlie" };

            // Get the enumerator
            IEnumerator<string> enumerator = names.GetEnumerator();

            // Manually iterate using MoveNext() and Current
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}

//private readonly ILogger<HomeController> _logger;
//private readonly CUsersPlanetOneDriveDocumentsDhruviMdfContext context;

//public HomeController(ILogger<HomeController> logger, CUsersPlanetOneDriveDocumentsDhruviMdfContext context)
//{
//    _logger = logger;
//    this.context = context;
//}

//public ActionResult Index()
//{
//    IEnumerable<Studnet> todo = context.Studnets;
//    ICollection<Studnet> todo2 = context.Studnets.ToList();
//    IList<Studnet> todo3 = context.Studnets.ToList();

//    foreach (Studnet item in todo)
//    {
//        _logger.Log(LogLevel.Information, "enum" + item.Nm);
//    }
//    foreach (Studnet item in todo2)
//    {
//        _logger.Log(LogLevel.Information, "coll" + item.Nm);
//    }
//    foreach (Studnet item in todo3)
//    {
//        _logger.Log(LogLevel.Information, "ilist" + item.Nm);
//    }
