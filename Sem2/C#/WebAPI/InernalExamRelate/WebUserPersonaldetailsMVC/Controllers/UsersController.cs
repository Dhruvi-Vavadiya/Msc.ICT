


using System.Data;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebUserPersonaldetailsMVC.Models;

namespace WebUserPersonaldetailsMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserPersonalDetailsContext _context;
        public IConfiguration _config;
        public SqlConnection _conn;
        public SqlCommand _command;

        public UsersController(UserPersonalDetailsContext context,IConfiguration config)
        {
            _context = context;
            _config = config;
            //_conn = new SqlConnection(_config.GetConnectionString("dbcs"));
            _command = new SqlCommand();
            //_command.Connection = _conn;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            var username = HttpContext.Session.GetString("unm");
            if (!string.IsNullOrEmpty(username))
            {
                // Retrieve the user from the database using LINQ
                var user = await _context.Users
                    .Where(u => u.UserName == username || u.Email == username)
                    .FirstOrDefaultAsync();

                if (user != null)
                {
                    // If the user is found, pass the user data to the view
                    ViewBag.OnewRecord = user; // You can pass the user object directly
                    return View();
                }
            }
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(string UserName, string Password)
        {
            if (ModelState.IsValid)
            {
                //using (SqlConnection _conn = new SqlConnection(_config.GetConnectionString("dbcs")))
                //{
                //    _conn.Open();
                //    _command.Connection = _conn;

                //    using (var _command = new SqlCommand("SELECT * FROM Users WHERE (UserName = @txtunm OR Email = @txtunm) AND Password = @txtpwd", _conn))
                //    {
                //        _command.Parameters.AddWithValue("@txtunm", UserName);
                //        _command.Parameters.AddWithValue("@txtpwd", Password);

                //        using (var dr = _command.ExecuteReader())
                //        {
                //            if (dr.HasRows)
                //            {
                //                DataTable dt = new DataTable();
                //                dt.Load(dr);
                //                TempData["onerecord"] = JsonConvert.SerializeObject(dt);
                                //                string username = dt.Rows[0]["UserId"].ToString();
                                //                TempData["onere"] = username;

                                //                //return RedirectToAction(nameof(Index);
                                //                TempData.Keep("onere");
                                //                HttpContext.Session.SetString("unm", dt.Rows[0]["UserName"].ToString());

                                //                string unm = HttpContext.Session.GetString("unm");
                                //                return RedirectToAction("Index", "PersonalDetails");
                            //}
                            //            else
                            //            {
                            //                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                            //                ModelState.AddModelError(string.Empty, "On login failure, give failure\r\nmessage to the user");
                            //            }
                    //    }
                    //    }
                    //}
                            // Use LINQ to query the Users table
                            var user = _context.Users
                    .Where(u => (u.UserName == UserName || u.Email == UserName) && u.Password == Password)
                    .FirstOrDefault();

                if (user != null)
                {
                    // User found, proceed with login
                    TempData["onerecord"] = JsonConvert.SerializeObject(user);
                    TempData["uid"] = user.UserId;

                    // Store username in session
                    HttpContext.Session.SetString("unm", user.UserName);

                    // Redirect to PersonalDetails Index
                    return RedirectToAction(nameof(Index));
                    //return RedirectToAction("Index", "PersonalDetails");
                }
                else
                {
                    // Invalid login attempt
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    ModelState.AddModelError(string.Empty, "On login failure, give failure\r\nmessage to the user");
                }
            }

            return View();
        }


        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,UserName,Password,Email")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
