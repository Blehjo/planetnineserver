using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using planetnineserver.Data;
using planetnineserver.Models;

namespace planetnineserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moon : ControllerBase
    {
        private readonly planetnineservercontext _context;

        public moon(planetnineservercontext context)
        {
            _context = context;
        }

        // GET: api/moon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Moon>>> GetMoon()
        {
          if (_context.Moon == null)
          {
              return NotFound();
          }
            return await _context.Moon.ToListAsync();
        }

        // GET: api/moon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Moon>> GetMoon(int id)
        {
          if (_context.Moon == null)
          {
              return NotFound();
          }
            var moon = await _context.Moon.FindAsync(id);

            if (moon == null)
            {
                return NotFound();
            }

            return moon;
        }

        // PUT: api/moon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMoon([FromForm] int id, Moon moon)
        {
            if (id != moon.MoonId)
            {
                return BadRequest();
            }

            _context.Entry(moon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MoonExists(id))
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

        // POST: api/moon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Moon>> PostMoon([FromForm] Moon moon)
        {
          if (_context.Moon == null)
          {
              return Problem("Entity set 'planetnineservercontext.Moon'  is null.");
          }
            _context.Moon.Add(moon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMoon", new { id = moon.MoonId }, moon);
        }

        // DELETE: api/moon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMoon(int id)
        {
            if (_context.Moon == null)
            {
                return NotFound();
            }
            var moon = await _context.Moon.FindAsync(id);
            if (moon == null)
            {
                return NotFound();
            }

            _context.Moon.Remove(moon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MoonExists(int id)
        {
            return (_context.Moon?.Any(e => e.MoonId == id)).GetValueOrDefault();
        }
    }
}
