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
    public class planet : ControllerBase
    {
        private readonly planetnineservercontext _context;

        public planet(planetnineservercontext context)
        {
            _context = context;
        }

        // GET: api/planet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Planet>>> GetPlanet()
        {
          if (_context.Planet == null)
          {
              return NotFound();
          }
            return await _context.Planet.ToListAsync();
        }

        // GET: api/planet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Planet>> GetPlanet(int id)
        {
          if (_context.Planet == null)
          {
              return NotFound();
          }
            var planet = await _context.Planet.FindAsync(id);

            if (planet == null)
            {
                return NotFound();
            }

            return planet;
        }

        // PUT: api/planet/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlanet(int id, Planet planet)
        {
            if (id != planet.PlanetId)
            {
                return BadRequest();
            }

            _context.Entry(planet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanetExists(id))
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

        // POST: api/planet
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Planet>> PostPlanet(Planet planet)
        {
          if (_context.Planet == null)
          {
              return Problem("Entity set 'planetnineservercontext.Planet'  is null.");
          }
            _context.Planet.Add(planet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlanet", new { id = planet.PlanetId }, planet);
        }

        // DELETE: api/planet/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlanet(int id)
        {
            if (_context.Planet == null)
            {
                return NotFound();
            }
            var planet = await _context.Planet.FindAsync(id);
            if (planet == null)
            {
                return NotFound();
            }

            _context.Planet.Remove(planet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlanetExists(int id)
        {
            return (_context.Planet?.Any(e => e.PlanetId == id)).GetValueOrDefault();
        }
    }
}
