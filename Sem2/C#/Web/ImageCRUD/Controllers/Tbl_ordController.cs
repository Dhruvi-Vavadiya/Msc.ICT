using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using ImageCRUD.Models;
using System.Security.Cryptography;

namespace ImageCRUD.Controllers
{
    public class Tbl_ordController : Controller
    {
        string connectionString = "server=(LocalDB)\\MSSQLLocalDB;database=C:\\Users\\Planet\\OneDrive\\Documents\\dhruvi.mdf;trusted_connection=true;";
        private IWebHostEnvironment _webHostEnvironment;

        public Tbl_ordController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Tbl_ordController
        public ActionResult Index()
        {
            List<Tbl_ord> employees = new List<Tbl_ord>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, onm, img FROM tbl_ord";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employees.Add(new Tbl_ord
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        onm = reader["onm"].ToString(),
                        img = reader["img"].ToString()
                    });
                }

                conn.Close();
            }

            return View(employees);
        }

        // GET: Tbl_ordController/Details/5
        public ActionResult Details(string onm)
        {
            Tbl_ord order = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, onm, img FROM tbl_ord WHERE onm = @onm";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@onm", onm);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    order = new Tbl_ord
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        onm = reader["onm"].ToString(),
                        img = reader["img"].ToString()
                    };
                }
                conn.Close();
            }

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Tbl_ordController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tbl_ordController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tbl_ord model)
        {
            if (model.ImageFile != null)
            {
                // Save the image in the wwwroot/Images folder
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(fileStream);
                }

                model.img = "/Images/" + uniqueFileName; // Store relative file path

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                   
                    string query = "INSERT INTO tbl_ord (onm, img) VALUES (@Enm, @Img)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //cmd.Parameters.AddWithValue("@id", model.Id);
                    cmd.Parameters.AddWithValue("@Enm", model.onm);
                    cmd.Parameters.AddWithValue("@Img", model.img);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                return RedirectToAction("Index");
            }
            return View(model);
        }
        

        // GET: Tbl_ordController/Edit/5
        public ActionResult Edit(string onm)
        {
            Tbl_ord order = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, onm, img FROM tbl_ord WHERE onm = @onm";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@onm", onm);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    order = new Tbl_ord
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        onm = reader["onm"].ToString(),
                        img = reader["img"].ToString()
                    };
                }
                conn.Close();
            }

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Tbl_ordController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string onm, Tbl_ord model)
        {
            if (model.ImageFile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(fileStream);
                }

                model.img = "/Images/" + uniqueFileName;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE tbl_ord SET onm = @onm, img = @img WHERE onm = @onmm";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", model.Id);
                cmd.Parameters.AddWithValue("@onm", model.onm);
                cmd.Parameters.AddWithValue("@img", model.img ?? model.img); // Keep old image if not updated
                cmd.Parameters.AddWithValue("@onmm", model.onm);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return RedirectToAction("Index");
        }

        // GET: Tbl_ordController/Delete/5
        public ActionResult Delete(int id)
        {
            Tbl_ord order = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, onm, img FROM tbl_ord WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    order = new Tbl_ord
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        onm = reader["onm"].ToString(),
                        img = reader["img"].ToString()
                    };
                }
                conn.Close();
            }

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Tbl_ordController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM tbl_ord WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return RedirectToAction("Index");
        }
    }
}
