using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class VehicleController : Controller
    {
        private readonly ILogger<VehicleController> _logger;

        private string baseURL = @"http://localhost:5020/api/Vehicle";
        private HttpClient client;

        public VehicleController(ILogger<VehicleController> logger)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            _logger = logger;
        }

        // GET: VehicleController
        public async Task<ActionResult> Index()
        {
            try
            {
                List<Vehicle> list = new List<Vehicle>();

                if (TempData["searchingresult"] != null)
                {
                    var vehicaljson = TempData["searchingresult"].ToString();
                     list = JsonSerializer.Deserialize<List<Vehicle>>(vehicaljson);
                    return View(list.ToList());

                }

                    var result = await client.GetAsync(baseURL);
                if (result.IsSuccessStatusCode)
                {
                    list = await result.Content.ReadFromJsonAsync<List<Vehicle>>();
                    return View(list);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }

        // GET: VehicleController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var result = await client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var veh = await result.Content.ReadFromJsonAsync<Vehicle>();
                    return View(veh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }

        // GET: VehicleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehicleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Vehicle modlell)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await client.PostAsJsonAsync(baseURL, modlell);
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

        // GET: VehicleController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var result = await client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var veh = await result.Content.ReadFromJsonAsync<Vehicle>();
                    return View(veh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }

        // POST: VehicleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Vehicle modelll)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await client.PutAsJsonAsync($"{baseURL}/{id}", modelll);
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

        // GET: VehicleController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var result = await client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var veh = await result.Content.ReadFromJsonAsync<Vehicle>();
                    return View(veh);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return NotFound();
        }

        // POST: VehicleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,IFormCollection coll)
        {
            try
            {
                HttpResponseMessage result =  client.DeleteAsync($"{baseURL}/{id}").Result;
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
        [HttpGet]
        public ActionResult GetSalary()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> GetSalary(int basic,float da,int ta)
        {
            //http://localhost:5020/api/Vehicle/salary/2/5.58/2
            var result = await client.GetAsync($"{baseURL}/salary/{basic}/{da}/{ta}");
            if (result.IsSuccessStatusCode)
            {
                var finalsaley = await result.Content.ReadAsStringAsync();
                HttpContext.Session.SetString("fin",finalsaley);
                _logger.Log(LogLevel.Warning, "logger test warnig");
                return View();
            }
            TempData["fin"] = "Failed calculateing the salary";
            return View();
        }

        [HttpGet]
        public ActionResult SearchByAny()
        {

            return View();
        }

        [HttpPost]
        
        public async Task<ActionResult> SearchByAny(string anyname)
        {
            //http://localhost:5020/api/Vehicle/salary/2/5.58/2
            var result = await client.GetAsync($"{baseURL}/by/{anyname}");
            if (result.IsSuccessStatusCode)
            {
                var mb = await result.Content.ReadFromJsonAsync<List<Vehicle>>();
                TempData["searchingresult"] = JsonSerializer.Serialize(mb);

                return RedirectToAction("Index");
            }
            TempData["fin"] = "Failed calculateing the salary";
            return View();
        }



    }
}
