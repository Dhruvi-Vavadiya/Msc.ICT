using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExampleExpenseAPI.Models;
using ExampleExpenseAPI.DTO;

namespace ExampleExpenseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EinformationsController : ControllerBase
    {
        private readonly ExpenseMangementContext _context;

        public EinformationsController(ExpenseMangementContext context)
        {
            _context = context;
        }

        // GET: api/Einformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Einformation>>> GetEinformations()
        {
            return await _context.Einformations.ToListAsync();
        }

        // GET: api/Einformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Einformation>> GetEinformation(int id)
        {
            var einformation = await _context.Einformations.FindAsync(id);

            if (einformation == null)
            {
                return NotFound();
            }

            return einformation;
        }

        // PUT: api/Einformations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEinformation(int id, Einformation einformation)
        {
            var tbld = new Einformation
            {
                Eid = einformation.Eid,
                Uid = einformation.Uid,
                Amount = einformation.Amount,
                Date = einformation.Date
            };

            if (id != einformation.Eid)
            {
                return BadRequest();
            }

            _context.Entry(tbld).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EinformationExists(id))
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

        // POST: api/Einformations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Einformation>> PostEinformation(EinformationDTO einformation)
        {
            var tbldata = new Einformation
            {
                Eid = einformation.Eid,
                Uid = einformation.Uid,
                Amount = einformation.Amount,
                Date = einformation.Date
                
            };

            _context.Einformations.Add(tbldata);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EinformationExists(einformation.Eid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEinformation", new { id = einformation.Eid }, einformation);
        }

        // DELETE: api/Einformations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEinformation(int id)
        {
            var einformation = await _context.Einformations.FindAsync(id);
            if (einformation == null)
            {
                return NotFound();
            }

            _context.Einformations.Remove(einformation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EinformationExists(int id)
        {
            return _context.Einformations.Any(e => e.Eid == id);
        }
    }
}
