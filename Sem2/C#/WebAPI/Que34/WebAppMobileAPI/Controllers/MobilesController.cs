using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using WebAppMobileAPI.Models;

namespace WebAppMobileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilesController : ControllerBase
    {
        private readonly MobileManagedContext _context;

        public MobilesController(MobileManagedContext context)
        {
            _context = context;
        }

        // GET: api/Mobiles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mobile>>> GetMobiles()
        {
            return await _context.Mobiles.ToListAsync();
        }

        // GET: api/Mobiles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mobile>> GetMobile(int id)
        {
            var mobile = await _context.Mobiles.FindAsync(id);

            if (mobile == null)
            {
                return NotFound();
            }

            return mobile;
        }
        // GET: api/Mobiles/by-model/Samsung
        [HttpGet("by/{model}")]
        public async Task<ActionResult<Mobile>> SearchMobile(string model)
        {
            var mobile = await _context.Mobiles.FirstOrDefaultAsync(m => m.Model == model);
            var mo = await _context.Mobiles.Where(m =>
            m.Model.ToLower().Contains(model.ToLower()) || m.Model.ToLower().Contains(model.ToLower())).ToListAsync();



            if (mobile == null)
            {
                return NotFound();
            }
            return mobile;
        }


        // PUT: api/Mobiles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMobile(int id, Mobile mobile)
        {
            if (id != mobile.Id)
            {
                return BadRequest();
            }

            _context.Entry(mobile).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MobileExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Mobiles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mobile>> PostMobile(Mobile mobile)
        {
            _context.Mobiles.Add(mobile);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MobileExists(mobile.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMobile", new { id = mobile.Id }, mobile);
        }

        // DELETE: api/Mobiles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMobile(int id)
        {
            var mobile = await _context.Mobiles.FindAsync(id);
            if (mobile == null)
            {
                return NotFound();
            }

            _context.Mobiles.Remove(mobile);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        
        //[HttpPost]
        //public async Task<ActionResult> PostSearch(string name)
        //{
        //    HttpContext.Session.SetString("mobile_nm", name);
        //    return RedirectToAction(nameof(GetMobiles));
        //}

        private bool MobileExists(int id)
        {
            return _context.Mobiles.Any(e => e.Id == id);
        }
    }
}
