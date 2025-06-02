using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class StudentsController : Controller
    {
        private string baseURL = @"http://localhost:5157/api/Students";
        private HttpClient Client;

        public StudentsController()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(baseURL);
        }
        // GET: StudentsController
        public async Task<ActionResult> Index()
        {
            List<Student> stud = new List<Student>();
            var result = await Client.GetAsync(baseURL);
            if (result.IsSuccessStatusCode)
            {
                stud = await result.Content.ReadFromJsonAsync<List<Student>>();
            }
            return View(stud.ToList());
        }

        // GET: StudentsController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var resu = await Client.GetAsync($"{baseURL}/{id}");
            if (resu.IsSuccessStatusCode)
            {
                var stud = await resu.Content.ReadFromJsonAsync<Student>();
                return View(stud);
            }
            return View();
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await Client.PostAsJsonAsync(baseURL, student);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var result = await Client.GetAsync($"{baseURL}/{id}");
            if (result.IsSuccessStatusCode)
            {
                var student = await result.Content.ReadFromJsonAsync<Student>();
                return View(student);
            }
            return NotFound();
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Student student)
        {
            if (ModelState.IsValid)
            {
                var result = await Client.PutAsJsonAsync($"{baseURL}/{id}", student);
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(student);
        }

        // GET: StudentsController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var result = await Client.GetAsync($"{baseURL}/{id}");
            if (result.IsSuccessStatusCode)
            {
               var stud = await result.Content.ReadFromJsonAsync<Student>();
                return View(stud);
            }
          
            return NotFound();
        }

        // POST: StudentsController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var result = await Client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
          
        }
    }
}
