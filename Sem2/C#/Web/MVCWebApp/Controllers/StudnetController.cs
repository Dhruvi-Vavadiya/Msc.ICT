using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCWebApp.Models;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace MVCWebApp.Controllers
{
    public class StudnetController : Controller
    {
        //private readonly string connectionString = "server=(LocalDB)\\MSSQLLocalDB;database=C:\\Users\\Planet\\OneDrive\\Documents\\dhruvi.mdf;trusted_connection=true;";
        private readonly CUsersPlanetOneDriveDocumentsDhruviMdfContext context;

        public StudnetController(CUsersPlanetOneDriveDocumentsDhruviMdfContext context)
        {
            this.context = context;
        }


        //not work
        public IActionResult Index()
        {
            var data =context.Studnets.ToList();
            return View(data);
            
        }
        public async Task<IActionResult> Details(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var studnet = await context.Studnets
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (studnet == null)
            //{
            //    return NotFound();
            //}

            return View();
        }
    }
}
