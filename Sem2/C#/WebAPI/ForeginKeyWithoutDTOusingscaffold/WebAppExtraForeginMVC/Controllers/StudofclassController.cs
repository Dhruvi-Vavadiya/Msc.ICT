using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppExtraForeginMVC.Models;

namespace WebAppExtraForeginMVC.Controllers
{
    public class StudofclassController : Controller
    {
        private string baseURL = @"http://localhost:5016/api/Studofclasses";
        //private  string baseURL = @"http://localhost:7028/api/Studofclasses";
        private  HttpClient _Client;
        public StudofclassController() { 
            _Client = new HttpClient();
            _Client.BaseAddress = new Uri(baseURL);
        }
        // GET: StudofclassController
        public async Task<ActionResult> Index()
        {
            List<Studofclass> list = new List<Studofclass>();
            var result = await _Client.GetAsync(baseURL);
            if (result.IsSuccessStatusCode)
            {
                list = await result.Content.ReadFromJsonAsync<List<Studofclass>>();
                return View(list);
            }
            return View();
        }

        // GET: StudofclassController/Details/5
        public async Task<ActionResult> Details(int id)
        {

            try
            {
                var result = await _Client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var mb = await result.Content.ReadFromJsonAsync<Studofclass>();
                    return View(mb);
                }
            }
            catch (Exception ex)
            {
                
            }
            return NotFound();
        }

        // GET: StudofclassController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudofclassController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Studofclass modlell)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _Client.PostAsJsonAsync(baseURL, modlell);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }


        // GET: StudofclassController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var result = await _Client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var veh = await result.Content.ReadFromJsonAsync<Studofclass>();
                    return View(veh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }

        // POST: StudofclassController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Studofclass modelll)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _Client.PutAsJsonAsync($"{baseURL}/{id}", modelll);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }

        // GET: StudofclassController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var result = await _Client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var veh = await result.Content.ReadFromJsonAsync<Studofclass>();
                    return View(veh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }

        // POST: StudofclassController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection coll)
        {
            try
            {
                HttpResponseMessage result = _Client.DeleteAsync($"{baseURL}/{id}").Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                return NotFound();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
