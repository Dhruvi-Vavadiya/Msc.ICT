using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MICMExam.Models;
using Microsoft.Data.SqlClient;
using MICMExam.App_Data;

namespace MICMExam.Controllers
{
    public class HelpDeskCallsController : Controller
    {
        private readonly ExamMicmContext _context;
        private readonly IConfiguration _config;
        Inculde _inc ;
        SqlConnection _conn ;
        SqlCommand _cmd;


        public HelpDeskCallsController(ExamMicmContext context,IConfiguration config)
        {
            _context = context;
            _config = config;
            _cmd = new SqlCommand();
            _inc = new Inculde(_config);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(HelpDeskCall model)
        {
            //conn = new SqlConnection(inc.db_micm(_config));
            //SqlConnection conn = new SqlConnection(_config.GetConnectionString("dbcs"));
            _conn = _inc.db_micm(_config);
            _cmd.Connection = _conn;
            _cmd.CommandText = "INSERT INTO HelpDeskCall (CustomerName, CustomerQuery, TokenNumber, CreatedOn) VALUES (@CustomerName, @CustomerQuery, @TokenNumber, GETDATE())";
            _cmd.Parameters.AddWithValue("@CustomerName", model.CustomerName);
            _cmd.Parameters.AddWithValue("@CustomerQuery", model.CustomerQuery);
            int token_no = _context.HelpDeskCalls.Select(s => s.Id).Count() + 1;
            string token_string = "T0" + token_no;
            _cmd.Parameters.AddWithValue("@TokenNumber", token_string);
            _cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            try
            {
                _conn.Open();
                _cmd.ExecuteNonQuery();
                ViewBag.Message = "Call created successfully!";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
            }
            finally
            {
                _conn.Close();
            }
            return View();
        }

        public IActionResult getallrecord()
        {
            return View();
        }


        //-------------------------automatically generatred code----------------------------------
        // GET: HelpDeskCalls
        public async Task<IActionResult> Index()
        {
            return View(await _context.HelpDeskCalls.ToListAsync());
        }

        // GET: HelpDeskCalls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpDeskCall = await _context.HelpDeskCalls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (helpDeskCall == null)
            {
                return NotFound();
            }

            return View(helpDeskCall);
        }

        // GET: HelpDeskCalls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HelpDeskCalls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerName,CustomerQuery,TokenNumber,AssignedCounterNo,ExecutiveName,ResolutionRemarks,ResolutionStatus,CreatedOn,ResolvedOn")] HelpDeskCall helpDeskCall)
        {
            if (ModelState.IsValid)
            {
                _context.Add(helpDeskCall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(helpDeskCall);
        }

        // GET: HelpDeskCalls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpDeskCall = await _context.HelpDeskCalls.FindAsync(id);
            if (helpDeskCall == null)
            {
                return NotFound();
            }
            return View(helpDeskCall);
        }

        // POST: HelpDeskCalls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CustomerName,CustomerQuery,TokenNumber,AssignedCounterNo,ExecutiveName,ResolutionRemarks,ResolutionStatus,CreatedOn,ResolvedOn")] HelpDeskCall helpDeskCall)
        {
            if (id != helpDeskCall.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(helpDeskCall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HelpDeskCallExists(helpDeskCall.Id))
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
            return View(helpDeskCall);
        }

       

        // GET: HelpDeskCalls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var helpDeskCall = await _context.HelpDeskCalls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (helpDeskCall == null)
            {
                return NotFound();
            }

            return View(helpDeskCall);
        }

        // POST: HelpDeskCalls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var helpDeskCall = await _context.HelpDeskCalls.FindAsync(id);
            if (helpDeskCall != null)
            {
                _context.HelpDeskCalls.Remove(helpDeskCall);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HelpDeskCallExists(int id)
        {
            return _context.HelpDeskCalls.Any(e => e.Id == id);
        }
    }
}
