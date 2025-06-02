using ExampleWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApp.Controllers
{
    public class ProductController : Controller
    {
        static List<Product>  products = new List<Product>();

        public ProductController()
        {
            if (products.Count == 0)
            {

                products.Add(new Product
                {
                    Id = 1,
                    Name = "T-shirt",
                    Description = "crop t-shirt"

                });
                products.Add(new Product
                {
                    Id = 2,
                    Name = "Jeans",
                    Description = "mom feat Jeans"

                });
                products.Add(new Product
                {
                    Id = 3,
                    Name = "Dress",
                    Description = "Patyala dress"

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
            var prods = (from p in products where p.Id == id select p).FirstOrDefault();
            return View(prods);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                products.Add (product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var prods = (from p in products where p.Id == id select p).FirstOrDefault();
            return View(prods);
           
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                var prods = (from p in products where p.Id == id select p).FirstOrDefault();
                prods.Name= product.Name;
                prods.Description= product.Description;
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
            var prods = (from p in products where p.Id == id select p).FirstOrDefault();
            return View(prods);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                products.Remove((from p in products where p.Id == id select p).FirstOrDefault());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
