using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1ExtraForegin.Models;

namespace WebApplication1ExtraForegin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudofclassesController : ControllerBase
    {
        private readonly DbClassStudForeginkeyContext _context;

        public StudofclassesController(DbClassStudForeginkeyContext context)
        {
            _context = context;
        }

        // GET: api/Studofclasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Studofclass>>> GetStudofclasses()
        {
            return await _context.Studofclasses.ToListAsync();
        }

        // GET: api/Studofclasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Studofclass>> GetStudofclass(int id)
        {
            var studofclass = await _context.Studofclasses.FindAsync(id);

            if (studofclass == null)
            {
                return NotFound();
            }

            return studofclass;
        }

        // PUT: api/Studofclasses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudofclass(int id, Studofclass studofclass)
        {
            if (id != studofclass.Id)
            {
                return BadRequest();
            }

            _context.Entry(studofclass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudofclassExists(id))
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

        // POST: api/Studofclasses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Studofclass>> PostStudofclass(Studofclass studofclass)
        {
            _context.Studofclasses.Add(studofclass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudofclass", new { id = studofclass.Id }, studofclass);
        }

        // DELETE: api/Studofclasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudofclass(int id)
        {
            var studofclass = await _context.Studofclasses.FindAsync(id);
            if (studofclass == null)
            {
                return NotFound();
            }

            _context.Studofclasses.Remove(studofclass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudofclassExists(int id)
        {
            return _context.Studofclasses.Any(e => e.Id == id);
        }
    }
}
