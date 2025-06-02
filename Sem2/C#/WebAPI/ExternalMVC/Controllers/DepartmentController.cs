using ExternalMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExternalMVC.Controllers
{
    public class DepartmentController : Controller
    {
        public string baseURL = @"http://localhost:5145/api/Departments";
        public HttpClient _client;

        public DepartmentController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseURL);
        }

        // GET: DepartmentController
        public  async Task<ActionResult> Index()
        {
            List<Department> list = new List<Department>();

            var result = await _client.GetAsync(baseURL);
            if (result.IsSuccessStatusCode)
            {
                list = await result.Content.ReadFromJsonAsync<List<Department>>();
                return View(list.ToList());
            }
            return View();
        }

        // GET: DepartmentController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var result = await _client.GetAsync($"{baseURL}/{id}");
            if (result.IsSuccessStatusCode)
            {
                var mb = await result.Content.ReadFromJsonAsync<Department>();
                return View(mb);
            }
            return View();
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Department deptmodel)
        {
            try
            {
                var result = await _client.PostAsJsonAsync(baseURL, deptmodel);
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var result = await _client.GetAsync($"{baseURL}/{id}");
            if (result.IsSuccessStatusCode)
            {
                var mb = await result.Content.ReadFromJsonAsync<Department>();
                return View(mb);
            }
            return View();
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Edit(int id, Department deptmodel)
        {
            try
            {
                var result = await _client.PutAsJsonAsync($"{baseURL}/{id}", deptmodel);
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DepartmentController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _client.GetAsync($"{baseURL}/{id}");
            if (result.IsSuccessStatusCode)
            {
                var mb = await result.Content.ReadFromJsonAsync<Department>();
                return View(mb);
            }
            return View();
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int did)
        {
            try
            {
                var result = await _client.DeleteAsync($"{baseURL}/{did}");
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
