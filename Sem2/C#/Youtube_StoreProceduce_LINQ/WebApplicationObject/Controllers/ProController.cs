using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationObject.Models;

namespace WebApplicationObject.Controllers
{
    public class ProController : Controller
    {
        private static List<Product> products = new List<Product>();

        public ProController()
        {
            if (products.Count == 0)
            {


                products.Add(new Product
                {

                    Id = 1,
                    Name = "sir",
                    Description = "Description",
                    Author = "abc",
                    Category = "abc"

                });

                products.Add(new Product
                {
                    Id = 2,
                    Name = "anc",
                    Description = "laji",
                    Author = "abc",
                    Category = "abc"
                });
            }

        }
        // GET: Pro
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: Pro/Details/5
        public ActionResult Details(int id)
        {
            var product = (from p in products where p.Id == id select p).FirstOrDefault();
            return View(product);
        }

        // GET: Pro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product productmodel)
        {
            try
            {
                products.Add(productmodel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pro/Edit/5
        public ActionResult Edit(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            return View(product);
        }

        // POST: Pro/Edit/5
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

        // GET: Pro/Delete/5
        public ActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        // POST: Pro/Delete/5
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
