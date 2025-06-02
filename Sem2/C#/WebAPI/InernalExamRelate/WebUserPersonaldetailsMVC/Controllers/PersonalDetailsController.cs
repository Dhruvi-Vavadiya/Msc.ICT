using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUserPersonaldetailsMVC.Models;

namespace WebUserPersonaldetailsMVC.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private readonly UserPersonalDetailsContext _context;

        public PersonalDetailsController(UserPersonalDetailsContext context)
        {
            _context = context;
        }

        // GET: PersonalDetails
        public async Task<IActionResult> Index()
        {
            if (TempData["uid"] != null)
            {
                TempData.Keep("uid");
                string userId = TempData["uid"].ToString();

                // Filter by UserId
                var filteredDetails = await _context.PersonalDetails
                    .Include(u => u.User)
                    .Where(p => p.UserId.ToString() == userId)
                    .ToListAsync();

                return View(filteredDetails.ToList());
            }

            var userPersonalDetailsContext = _context.PersonalDetails.Include(p => p.User);
            return View(await userPersonalDetailsContext.ToListAsync());
        }

        // GET: PersonalDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _context.PersonalDetails
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PersonalId == id);
            if (personalDetail == null)
            {
                return NotFound();
            }

            return View(personalDetail);
        }

        // GET: PersonalDetails/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: PersonalDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonalId,Dob,Gender,Education,City,UserId")] PersonalDetail personalDetail)
        {
            
/// Get the selected hobbies from the form
    var selectedHobbies = Request.Form["Hobby"];

            // Join the selected hobbies into a comma-separated string
            personalDetail.Hobby = string.Join(",", selectedHobbies);

            if (ModelState.IsValid)
            {
                _context.Add(personalDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", personalDetail.UserId);
            return View(personalDetail);
        }

        // GET: PersonalDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _context.PersonalDetails.FindAsync(id);
            if (personalDetail == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", personalDetail.UserId);
            return View(personalDetail);
        }

        // POST: PersonalDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonalId,Dob,Gender,Hobby,Education,City,UserId")] PersonalDetail personalDetail)
        {
            if (id != personalDetail.PersonalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personalDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalDetailExists(personalDetail.PersonalId))
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
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", personalDetail.UserId);
            return View(personalDetail);
        }

        // GET: PersonalDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personalDetail = await _context.PersonalDetails
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.PersonalId == id);
            if (personalDetail == null)
            {
                return NotFound();
            }

            return View(personalDetail);
        }

        // POST: PersonalDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personalDetail = await _context.PersonalDetails.FindAsync(id);
            if (personalDetail != null)
            {
                _context.PersonalDetails.Remove(personalDetail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalDetailExists(int id)
        {
            return _context.PersonalDetails.Any(e => e.PersonalId == id);
        }
    }
}
