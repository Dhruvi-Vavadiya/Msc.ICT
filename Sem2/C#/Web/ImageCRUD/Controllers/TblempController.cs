using System;
using ImageCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace ImageCRUD.Controllers
{
    public class TblempController : Controller
    {
        private readonly string connectionString = "server=(LocalDB)\\MSSQLLocalDB;database=C:\\Users\\Planet\\OneDrive\\Documents\\dhruvi.mdf;trusted_connection=true;";



        // GET: TblempController
        public ActionResult Index()
        {
            List<Tblemp> employees = new List<Tblemp>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Enm, Img FROM tblemp";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employees.Add(new Tblemp
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Enm = reader["Enm"].ToString(),
                        Img = reader["Img"] != DBNull.Value ? (byte[])reader["Img"] : null
                    });
                }

                conn.Close();
            }

            return View(employees);
        }
       

        // GET: TblempController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TblempController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TblempController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tblemp model, IFormFile file)
        {

            if (file != null && file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    model.Img = memoryStream.ToArray(); // Convert image to byte array
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO tblemp (Id,Enm, Img) VALUES (@id,@Enm, @Img)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", model.Id);
                    cmd.Parameters.AddWithValue("@Enm", model.Enm);
                    cmd.Parameters.AddWithValue("@Img", model.Img);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: TblempController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TblempController/Edit/5
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

        // GET: TblempController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TblempController/Delete/5
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
