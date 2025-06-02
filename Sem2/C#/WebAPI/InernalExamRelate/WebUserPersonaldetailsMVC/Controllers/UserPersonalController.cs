using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebUserPersonaldetailsMVC.Models;

namespace WebUserPersonaldetailsMVC.Controllers
{
    public class UserPersonalController : Controller
    {
        public IConfiguration _config;
        public SqlConnection _conn;
        public SqlCommand _command;

        public UserPersonalController(IConfiguration config)
        {
            _config = config;
            _conn = new SqlConnection(_config.GetConnectionString("dbcs"));
            _command = new SqlCommand();
            _command.Connection = _conn;
        }
        

        // GET: UserPersonalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserPersonalController/Edit/5
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

        // GET: UserPersonalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserPersonalController/Delete/5
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
