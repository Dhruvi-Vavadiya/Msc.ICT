using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppliForeginKey.Models;

namespace WebAppliForeginKey.Controllers
{
    public class StudofclassesController : Controller
    {
        private readonly DbClassStudForeginkeyContext _context;

        public StudofclassesController(DbClassStudForeginkeyContext context)
        {
            _context = context;
        }

        // GET: Studofclasses
        public async Task<IActionResult> Index()
        {
            var dbClassStudForeginkeyContext = _context.Studofclasses.Include(s => s.Class);
            return View(await dbClassStudForeginkeyContext.ToListAsync());
        }

        // GET: Studofclasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studofclass = await _context.Studofclasses
                .Include(s => s.Class)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studofclass == null)
            {
                return NotFound();
            }

            return View(studofclass);
        }

        // GET: Studofclasses/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.Classes, "ClassId", "Classname");
            return View();
        }

        // POST: Studofclasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Age,ClassId")] Studofclass studofclass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studofclass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "ClassId", "Classname", studofclass.ClassId);
            return View(studofclass);
        }

        // GET: Studofclasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studofclass = await _context.Studofclasses.FindAsync(id);
            if (studofclass == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.Classes, "ClassId", "Classname", studofclass.ClassId);
            return View(studofclass);
        }

        // POST: Studofclasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Age,ClassId")] Studofclass studofclass)
        {
            if (id != studofclass.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studofclass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudofclassExists(studofclass.Id))
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
            ViewData["ClassId"] = new SelectList(_context.Classes, "ClassId", "Classname", studofclass.ClassId);
            return View(studofclass);
        }

        // GET: Studofclasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studofclass = await _context.Studofclasses
                .Include(s => s.Class)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studofclass == null)
            {
                return NotFound();
            }

            return View(studofclass);
        }

        // POST: Studofclasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studofclass = await _context.Studofclasses.FindAsync(id);
            if (studofclass != null)
            {
                _context.Studofclasses.Remove(studofclass);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudofclassExists(int id)
        {
            return _context.Studofclasses.Any(e => e.Id == id);
        }
    }
}
