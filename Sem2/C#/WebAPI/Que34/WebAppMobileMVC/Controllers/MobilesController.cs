using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using WebAppMobileMVC.Models;

namespace WebAppMobileMVC.Controllers
{
    public class MobilesController : Controller
    {
        private string baseURL = @"http://localhost:5280/api/Mobiles";
        private HttpClient Client;

        private readonly ILogger<MobilesController> _logger;
        private readonly IDataLog _dataLog;
        private readonly IConfiguration _config;

        public MobilesController(ILogger<MobilesController> logger, IDataLog dataLog, IConfiguration config)
        {
            Client = new HttpClient(); 
            Client.BaseAddress = new Uri(baseURL);
            _logger = logger;
            _dataLog = dataLog;
            _config = config;
        }
        public ActionResult IndexErrortbl()
        {
            SqlConnection _conn = new SqlConnection(_config.GetConnectionString("dbcs"));
            SqlCommand _cmd = new SqlCommand();
            SqlDataReader _read;

            try
            {
                List<TblError> tblErro_list = new List<TblError>();

                _cmd.Connection = _conn;
                _conn.Open();
                _cmd.CommandText = "SELECT * FROM TblError";
                _cmd.CommandType = System.Data.CommandType.Text;

                _read = _cmd.ExecuteReader();
                while (_read.Read())
                {
                    TblError record = new TblError
                    {
                        Id = Convert.ToInt32(_read["Id"]),
                        Name = _read["Name"].ToString()
                    };

                    tblErro_list.Add(record);

                    // Index into Elasticsearch
                    var esResponse = ElasticSearchHelper.Client.IndexDocument(record);
                }

                return View(tblErro_list);
            }
            catch (Exception ex)
            {
                _dataLog.Log("Method :- IndexErrortbl = " + ex.Message);
            }
            finally
            {
                _conn.Close();
                _cmd.Parameters.Clear();
            }

            return NotFound();
        }

        // GET: MobilesController
        public async Task<ActionResult> Index()
        {
            
            try
            {
                List<Mobile> list = new List<Mobile>();

                if (TempData["SearchResult"] != null)
                {
                    var mobilejson = TempData["SearchResult"].ToString();
                    var mobile = JsonSerializer.Deserialize<List<Mobile>>(mobilejson);

                    //var red = new List<Mobile> { mobile };

                    return View(mobile.ToList());
                }
                
                var result = await Client.GetAsync(baseURL);
                if (result.IsSuccessStatusCode)
                {
                    list = await result.Content.ReadFromJsonAsync<List<Mobile>>();
                    _logger.Log(LogLevel.Warning, "logger test warnig");
                    //_dataLog.Log("done display");
                    return View(list.ToList());
                }
               

            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return NotFound();
        }

        // GET: MobilesController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var result = await Client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var mb = await result.Content.ReadFromJsonAsync<Mobile>();
                    return View(mb);
                }
            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return NotFound();
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Search(string name)
        {
            try
            {
                var result = await Client.GetAsync($"{baseURL}/by/{name}");
                if (result.IsSuccessStatusCode)
                {
                    var mb = await result.Content.ReadFromJsonAsync<Mobile>();
                    TempData["SearchResult"] = JsonSerializer.Serialize(mb);
                    return RedirectToAction("Index"); // Redirect to Index to display results
                }
                else
                {
                    ViewBag.NotFound = "No mobile found with this model.";
                }
            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return View();
        }
        // GET: MobilesController/Create
        public ActionResult Create()
        {
            //Dictionary<int, string> list = new Dictionary<int, string>();

            //list.Add(2,"Polo");
            //list.Add(7, "java");
            //list.Add(6, "abc");
            //list.Add(10, "sfcd");
            //list.Add(5,"jum");

           

            //List<string> brandList = list.Values.ToList();

            //ViewBag.brandss = brandList;


            List<string> list_br = new List<string>();
            list_br.Add("sf");
            list_br.Add("abc");
            list_br.Add("jvavavv");
            IEnumerable<string> brandList = list_br;
            ViewBag.brands = brandList;


            return View();
        }

        // POST: MobilesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Mobile modell)
        {
            try
            {
                //Mobile model = new Mobile
                //{
                //    Id = 6,
                //    Brand = "hh",
                //    Model = "hh",
                //    Price = 66
                //};
                if (ModelState.IsValid)
                {
                    var result = await Client.PostAsJsonAsync(baseURL, modell);
                    if (result.IsSuccessStatusCode)
                    {
                        _dataLog.Log("Insert data into mobile data");
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        _dataLog.Log("not fetch url or data");
                    }
                }
            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return NotFound();
        }

        // GET: MobilesController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            try
            {
                var result = await Client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var mbe = await result.Content.ReadFromJsonAsync<Mobile>();
                    return View(mbe);
                }
            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return NotFound();
        }

        // POST: MobilesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Mobile modell)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await Client.PutAsJsonAsync($"{baseURL}/{id}", modell);
                    if (result.IsSuccessStatusCode)
                    {
                        _dataLog.Log("Edit successfully for this id :-" + id);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        _dataLog.Log("Edit put method result not valid");
                    }
                }
            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return NotFound();
        }

        // GET: MobilesController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var result = await Client.GetAsync($"{baseURL}/{id}");
                if (result.IsSuccessStatusCode)
                {
                    var mbe = await result.Content.ReadFromJsonAsync<Mobile>();
                    return View(mbe);
                }
                else
                {
                    _dataLog.Log("delete get mthod invalid");
                }
            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return View();
        }

        // POST: MobilesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int del_id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await Client.DeleteAsync($"{baseURL}/{del_id}");
                    if (result.IsSuccessStatusCode)
                    {
                        if (result.IsSuccessStatusCode)
                        {
                            _dataLog.Log($"Delete {del_id} confirm");
                            TempData["del_data"] = $"{del_id} delete success";
                            return RedirectToAction(nameof(Index));
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                _dataLog.Log(ex.Message);
            }
            return NotFound();
        }


    }
}
