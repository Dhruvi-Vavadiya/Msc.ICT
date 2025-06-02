using ExternalExpenseMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalExpenseMVC.Controllers
{
    public class EInformationController : Controller
    {
        private string baseURL = @"";
        private HttpClient _client;

        public EInformationController(HttpClient client)
        {
            _client = client;
        }
        // GET: EInformationController
        public async Task<ActionResult> Index()
        {
            List<Einformation> list = new List<Einformation>();

            var result = await _client.GetAsync(baseURL);
            if (result.IsSuccessStatusCode)
            {
                list = await result.Content.ReadFromJsonAsync<List<Einformation>>();
                return View(list.ToList());
            }
            return View();
        }

        // GET: EInformationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EInformationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EInformationController/Create
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

        // GET: EInformationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EInformationController/Edit/5
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

        // GET: EInformationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EInformationController/Delete/5
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
