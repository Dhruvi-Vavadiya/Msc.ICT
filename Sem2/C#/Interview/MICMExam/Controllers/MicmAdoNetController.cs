using System.Diagnostics.Metrics;
using MICMExam.App_Data;
using MICMExam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace MICMExam.Controllers
{
    public class MicmAdoNetController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ExamMicmContext _context;
        SqlConnection _conn;
        SqlCommand _cmd;
        Inculde _inc;
        public MicmAdoNetController(ExamMicmContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
            _cmd = new SqlCommand();
            _inc = new Inculde(_config);
        }
        //ExecuteReader 
        public ActionResult Index()
        {
            List<HelpDeskCall> list = new List<HelpDeskCall>();
            _conn = _inc.db_micm(_config);
            _cmd.Connection = _conn;
            _conn.Open();
            _cmd.CommandText = "SELECT * FROM HelpDeskCall";

            SqlDataReader dr = _cmd.ExecuteReader();

            while (dr.Read())
            {
                HelpDeskCall call = new HelpDeskCall
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    CustomerName = dr["CustomerName"].ToString() ,
                    CustomerQuery = dr["CustomerQuery"].ToString(),
                    TokenNumber = dr["TokenNumber"].ToString(),
                   // CreatedOn = dr["CreatedOn"] != DBNull.Value ? Convert.ToDateTime(dr["CreatedOn"]) : (DateTime?)null,
                    ExecutiveName = dr["ExecutiveName"] != DBNull.Value ? dr["ExecutiveName"].ToString() : null,
                    ResolutionRemarks = dr["ResolutionRemarks"] != DBNull.Value ? dr["ResolutionRemarks"].ToString() : null,
                    ResolutionStatus = dr["ResolutionStatus"] != DBNull.Value ? dr["ResolutionStatus"].ToString() : null,
                    ResolvedOn = dr["ResolvedOn"] != DBNull.Value ? Convert.ToDateTime(dr["ResolvedOn"]) : (DateTime?)null
                };
                list.Add(call);
            }
              
                return View(list);
        }

        // GET: MicmAdoNetController/Details/5
        public ActionResult Details()
        {
            _conn = _inc.db_micm(_config);
            _cmd.Connection = _conn;
            _cmd.CommandText = "select count(*) from HelpDeskCall where ResolutionStatus IS NULL";
            _conn.Open();
            int pendingCount = (int)_cmd.ExecuteScalar();
            _conn.Close();
            ViewBag.PendingCount = pendingCount;

           // var counters = _context.HelpDeskCalls
           //.Where(t => t.ResolutionStatus == "In Service")
           //.GroupBy(t => t.AssignedCounterNo)
           //.Select(g => new CounterStatus
           //{
           //    AssignedCounterNo = g.FirstOrDefault().AssignedCounterNo,
           //    TokenNumber = g.OrderByDescending(t => t.CreatedOn).FirstOrDefault().TokenNumber,
           //    IsInService = true
           //}).ToList();

           // var model = new TokenStatusViewModel
           // {
           //              CounterStatuses = counters
           // };

           // return View("TokenStatus", model);
            return View();
        }

       
        public ActionResult Create()
        {
            return View();
        }

        // ExecuteNonQuery 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HelpDeskCall model)
        {
            try
            {
                _conn = _inc.db_micm(_config);
                _cmd.Connection = _conn;
                _conn.Open();
                _cmd.CommandText = "INSERT INTO HelpDeskCall (CustomerName, CustomerQuery, TokenNumber, CreatedOn) VALUES (@CustomerName, @CustomerQuery, @TokenNumber, GETDATE())";
                _cmd.Parameters.AddWithValue("@CustomerName", model.CustomerName);
                _cmd.Parameters.AddWithValue("@CustomerQuery", model.CustomerQuery);
                int token_no = _context.HelpDeskCalls.Select(s => s.Id).Count() + 1;
                string token_string = "T0" + token_no;
                _cmd.Parameters.AddWithValue("@TokenNumber", token_string);
                _cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                _cmd.ExecuteNonQuery();
                return RedirectToAction(nameof(GetTokenNo));
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult GetTokenNo()
        {
            try
            {
                _conn = _inc.db_micm(_config);
                _cmd.Connection = _conn;
                _conn.Open();
                _cmd.CommandText = "SELECT TOP 1 TokenNumber FROM HelpDeskCall ORDER BY CreatedOn DESC";
                string tokenNumber = (string)_cmd.ExecuteScalar();
                TempData["TokenNumber"] = tokenNumber;

                //alternate solution
                string gettokenusing_linq = _context.HelpDeskCalls.OrderByDescending(u => u.CreatedOn).Select(u => u.TokenNumber).FirstOrDefault();

                return View(); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return View();
        }
        // GET: MicmAdoNetController/Edit/5
        [HttpGet]
        public ActionResult Edit()
        {
            var ex_name = _context.HelpDeskCalls.Where(e => e.ExecutiveName != null).Select(s => s.ExecutiveName).ToList();
            ViewBag.ExecutiveNames = ex_name;

            List<string> exx_name = new List<string>();
            _conn = _inc.db_micm(_config);
            _cmd.Connection = _conn;
            _conn.Open();
            _cmd.CommandText = "select ExecutiveName from HelpDeskCall where ExecutiveName IS NOT NULL";
            SqlDataReader dr = _cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr["ExecutiveName"].ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    exx_name.Add(name);
                }
            }
            _conn.Close();
            ViewBag.Executive_Names = exx_name;

            return View();
        }

        // POST: MicmAdoNetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int counterNo,string ExecutiveName)
        {
            try
            {
                _conn = _inc.db_micm(_config);
                _cmd.Connection = _conn;
                _conn.Open();

                _cmd.CommandText = "select Id from HelpDeskCall where ExecutiveName=@ExecutiveName and ResolutionStatus IS NULL";
                _cmd.Parameters.AddWithValue("@ExecutiveName", ExecutiveName);

                SqlDataReader dr = _cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        string id = dr["Id"].ToString();

                        if (!string.IsNullOrEmpty(id))
                        {
                            _cmd.Parameters.Clear();
                            dr.Close();
                            _cmd.CommandText = "UPDATE HelpDeskCall SET AssignedCounterNo = @CounterNo, ExecutiveName = @ExecutiveName WHERE Id=@id";
                            _cmd.Parameters.AddWithValue("@CounterNo", counterNo);
                            _cmd.Parameters.AddWithValue("@ExecutiveName", ExecutiveName);
                            _cmd.Parameters.AddWithValue("@id", id);
                            int data = _cmd.ExecuteNonQuery();
                           
                            if (data > 0)
                            {
                                TempData["SuccessMessage"] = "Counter assigned successfully.";
                                
                                TempData["helpid"] = id;
                                
                                return RedirectToAction(nameof(Resolve));
                            }
                            else
                            {
                                TempData["ErrorMessage"] = "No pending calls found to assign.";
                                return RedirectToAction(nameof(Edit));
                            }
                        }


                    }
                }
                else
                {
                    TempData["ErrorMessage"] = "No pending calls found to assign.";
                    return RedirectToAction(nameof(Edit));
                }
                dr.Close();

                
            }
            catch
            {
                return View();
            }
            finally
            {
                _conn.Close();
            }
            return View();
        }

        public ActionResult Resolve()
        {
            try
            {
                
                int id = Convert.ToInt32(TempData["helpid"]);
                
                _conn = _inc.db_micm(_config);
                _cmd.Connection = _conn;
                _conn.Open();
                _cmd.CommandText = "select * from HelpDeskCall where Id=@id";
                _cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = _cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ViewBag.helpname = dr["ExecutiveName"].ToString();
                        ViewBag.counterno = dr["AssignedCounterNo"].ToString();
                        ViewData["helpname"] = dr["ExecutiveName"].ToString();
                        ViewData["counterno"] = dr["AssignedCounterNo"].ToString();
                    }
                    var result = _context.HelpDeskCalls.FirstOrDefault(m => m.Id == id);
                    return View(result);
                }
                else
                {
                    return View();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                TempData.Keep();
                _conn.Close();
            }
            return View();
        }

        // GET: MicmAdoNetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MicmAdoNetController/Delete/5
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
