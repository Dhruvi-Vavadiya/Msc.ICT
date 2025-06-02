using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationObject.Models;

namespace WebApplicationObject.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>();

        public ProductController()
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
        // GET: ProductController
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = (from p in products where p.Id == id select p).FirstOrDefault();
            return View(product);
        }

        // GET: ProductController/Create
        [HttpPost]
        public ActionResult Insert()
        {
            
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(Product productmodel)
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

        // GET: ProductController/Edit/5
        public ActionResult update(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
           
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult update(int id, IFormCollection collection)
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
