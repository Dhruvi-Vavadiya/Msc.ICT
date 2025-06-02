using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class StudsController : Controller
    {
        private readonly CUsersPlanetOneDriveDocumentsDhruviMdfContext _context;

        public StudsController(CUsersPlanetOneDriveDocumentsDhruviMdfContext context)
        {
            _context = context;
        }

        // GET: Studs
        public async Task<IActionResult> Index()
        {
            string ename = (string?)TempData["enm"];
            var students = from s in _context.Studnets select s;//linq

            if (!string.IsNullOrEmpty(ename))
            {
                students = students.Where(s => s.Nm.Contains(ename));//lambda
                return View(await students.ToListAsync());
            }

           // var searchResu = await _context.Studnets.Where(s => s.Nm.Contains(ename)).ToListAsync();
            return View(await _context.Studnets.ToListAsync());

           //public async Task<IActionResult> Index(string searchQuery)
            //var students = from s in _context.Studnets select s; // Fetch all students

            //if (!string.IsNullOrEmpty(searchQuery))
            //{
            //    students = students.Where(s => s.Nm.Contains(searchQuery));
            //}

            //return View(await students.ToListAsync());
        }
        // GET: Studs/Create
        public IActionResult Search()
        {
            return View();
        }

       [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Search(string empName)
        {
            TempData["enm"] = empName;
            
            return RedirectToAction(nameof(Index));

            //return RedirectToAction(nameof(Index), new { searchQuery = empName });
        }

        // GET: Studs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studnet = await _context.Studnets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studnet == null)
            {
                return NotFound();
            }

            return View(studnet);
        }

        // GET: Studs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Studs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nm,Des")] Studnet studnet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studnet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studnet);
        }

        // GET: Studs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studnet = await _context.Studnets.FindAsync(id);
            if (studnet == null)
            {
                return NotFound();
            }
            return View(studnet);
        }

        // POST: Studs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nm,Des")] Studnet studnet)
        {
            if (id != studnet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studnet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudnetExists(studnet.Id))
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
            return View(studnet);
        }

        // GET: Studs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studnet = await _context.Studnets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studnet == null)
            {
                return NotFound();
            }

            return View(studnet);
        }

        // POST: Studs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studnet = await _context.Studnets.FindAsync(id);
            if (studnet != null)
            {
                _context.Studnets.Remove(studnet);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudnetExists(int id)
        {
            return _context.Studnets.Any(e => e.Id == id);
        }
    }
}
