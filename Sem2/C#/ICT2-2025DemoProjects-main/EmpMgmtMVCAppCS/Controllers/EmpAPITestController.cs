using EmpMgmtMVCAppCS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace EmpMgmtMVCAppCS.Controllers
{
    public class EmpAPITestController : Controller
    {
        private string baseURL = @"https://localhost:7259/api/TestList";
        // GET: EmpAPITestController
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));
            List<Employee> employees = new List<Employee>();

            HttpResponseMessage httpResponse = client.GetAsync(baseURL).Result;

            if(httpResponse.IsSuccessStatusCode)
            {
                employees = await httpResponse.Content.ReadFromJsonAsync<List<Employee>>();
            }

            return View(employees.ToList());
        }

        // GET: EmpAPITestController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            
            HttpResponseMessage httpResponse = client.GetAsync(baseURL+"/"+id).Result;
            Employee employee = new Employee();
            if (httpResponse.IsSuccessStatusCode)
            {
                employee = await httpResponse.Content.ReadFromJsonAsync<Employee>();
            }
            return View(employee);
        }

        // GET: EmpAPITestController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpAPITestController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Employee newEmployee)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseURL);
                
                var newStudentConent = JsonConvert.SerializeObject(newEmployee);
                StringContent stringContent =
                    new StringContent(newStudentConent,System.Text.Encoding.UTF8, 
                    new MediaTypeWithQualityHeaderValue("application/json"));
               
                HttpResponseMessage httpResponse = await client.PostAsync(baseURL,stringContent);

                if (httpResponse.IsSuccessStatusCode)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpAPITestController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);

            HttpResponseMessage httpResponse = client.GetAsync(baseURL + "/" + id).Result;
            Employee employee = new Employee();
            if (httpResponse.IsSuccessStatusCode)
            {
                employee = await httpResponse.Content.ReadFromJsonAsync<Employee>();
            }
            return View(employee);
        }

        // POST: EmpAPITestController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee updatedEmployee)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseURL);

                var newStudentConent = JsonConvert.SerializeObject(updatedEmployee);
                StringContent stringContent =
                    new StringContent(newStudentConent, System.Text.Encoding.UTF8,
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage httpResponse = client.PutAsJsonAsync(baseURL + "/" + id, stringContent).Result;
                
                if (httpResponse.IsSuccessStatusCode)
                {
                    
                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpAPITestController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);

            HttpResponseMessage httpResponse = client.GetAsync(baseURL + "/" + id).Result;
            Employee employee = new Employee();
            if (httpResponse.IsSuccessStatusCode)
            {
                employee = await httpResponse.Content.ReadFromJsonAsync<Employee>();
            }
            return View(employee);
        }

        // POST: EmpAPITestController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseURL);

                HttpResponseMessage httpResponse = client.DeleteAsync(baseURL + "/" + id).Result;
                
                if (httpResponse.IsSuccessStatusCode)
                {
                    
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpAPITestController/AddEmployee
        public ActionResult AddEmployee()
        {
            return View();
        }

        // POST: EmpAPITestController/AddEmployee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddEmployee(Employee newEmployee)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseURL);

                //var newStudentConent = JsonConvert.SerializeObject(newEmployee);
                //StringContent stringContent =
                //    new StringContent(newStudentConent, System.Text.Encoding.UTF8,
                //    new MediaTypeWithQualityHeaderValue("application/json"));
                string param = newEmployee.EmpId + "/" + newEmployee.Name + "/" + newEmployee.Age;
                HttpResponseMessage httpResponse = await client.PostAsync(baseURL + "/" + param, null);

                if (httpResponse.IsSuccessStatusCode)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpAPITestController/AddEmployee
        public ActionResult CalculateSalary()
        {
            return View();
        }

        // POST: EmpAPITestController/AddEmployee
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CalculateSalary(int basic, float da, int ta)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseURL);

                string param = "salary/" + basic + "/" + da + "/" + ta;
                HttpResponseMessage httpResponse = await client.GetAsync(baseURL + "/" + param);
                double _finalSalary = 0;
                if (httpResponse.IsSuccessStatusCode)
                {
                    var result = await httpResponse.Content.ReadAsStringAsync();
                    _finalSalary = JsonConvert.DeserializeObject<double>(result);
                }
                
                return RedirectToAction(nameof(FinalSalary), new { _finalSalary_ = _finalSalary });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FinalSalary(double _finalSalary_)
        {
            return View(_finalSalary_);
        }
    }
}
