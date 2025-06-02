using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalExpenseMVC.Controllers
{
    public class TblUserController : Controller
    {

        // GET: TblUserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TblUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TblUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TblUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TblUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TblUserController/Edit/5
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

        // GET: TblUserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TblUserController/Delete/5
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
