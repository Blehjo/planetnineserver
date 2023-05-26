using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Planetnineserver.Data;
using Planetnineserver.Models;

namespace Planetnineserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private readonly Planetnineservercontext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PlanetController(Planetnineservercontext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: api/planet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Planet>>> GetPlanet()
        {
          if (_context.Planet == null)
          {
              return NotFound();
          }

            return await _context.Planet.Select(x => new Planet()
            {
                PlanetId = x.PlanetId,
                PlanetName = x.PlanetName,
                PlanetMass = x.PlanetMass,
                Perihelion = x.Perihelion,
                Aphelion = x.Aphelion,
                Gravity = x.Gravity,
                UserId = x.UserId,
                Favorites = x.Favorites,
                ImageLink = x.ImageLink,
                Temperature = x.Temperature,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageLink)
            }).ToListAsync();
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

            planet.ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, planet.ImageLink);

            return planet;
        }

        // GET: api/ArtificialIntelligence/user
        [HttpGet("user")]
        public async Task<ActionResult<IEnumerable<Planet>>> GetUserArtificialIntelligences()
        {
            if (_context.Planet == null)
            {
                return NotFound();
            }

            var userId = Int32.Parse(HttpContext.Request.Cookies["user"]);

            return await _context.Planet.Where(p => p.UserId == userId).Select(x => new Planet()
            {
                PlanetId = x.PlanetId,
                PlanetName = x.PlanetName,
                PlanetMass = x.PlanetMass,
                Perihelion = x.Perihelion,
                Aphelion = x.Aphelion,
                Gravity = x.Gravity,
                UserId = x.UserId,
                Favorites = x.Favorites,
                ImageLink = x.ImageLink,
                Temperature = x.Temperature,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageLink)
            }).ToListAsync();
        }

        [HttpGet("user/{id}")]
        public async Task<ActionResult<IEnumerable<Planet>>> GetOtherUserPlanets(int id)
        {
            if (_context.Planet == null)
            {
                return NotFound();
            }

            return await _context.Planet.Where(p => p.UserId == id).Select(x => new Planet()
            {
                PlanetId = x.PlanetId,
                PlanetName = x.PlanetName,
                PlanetMass = x.PlanetMass,
                Perihelion = x.Perihelion,
                Aphelion = x.Aphelion,
                Gravity = x.Gravity,
                UserId = x.UserId,
                Favorites = x.Favorites,
                ImageLink = x.ImageLink,
                Temperature = x.Temperature,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageLink)
            }).ToListAsync();
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
        public async Task<ActionResult<IEnumerable<Planet>>> PostPlanet(int planetId, [FromForm] Planet planet)
        {
          if (_context.Planet == null)
          {
              return Problem("Entity set 'Planetnineservercontext.Planet'  is null.");
          }

            if (planet.ImageFile != null)
            {
                planet.ImageLink = await SaveImage(planet.ImageFile);
            }

            planet.UserId = Int32.Parse(HttpContext.Request.Cookies["user"]);

            _context.Planet.Add(planet);

            await _context.SaveChangesAsync();

            return await _context.Planet.Where(p => p.UserId == planet.UserId).Select(x => new Planet()
            {
                PlanetId = x.PlanetId,
                PlanetName = x.PlanetName,
                PlanetMass = x.PlanetMass,
                Perihelion = x.Perihelion,
                Aphelion = x.Aphelion,
                Gravity = x.Gravity,
                UserId = x.UserId,
                Favorites = x.Favorites,
                ImageLink = x.ImageLink,
                Temperature = x.Temperature,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageLink)
            }).ToListAsync();
        }

        // DELETE: api/planet/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Planet>>> DeletePlanet(int id)
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

            var userId = Int32.Parse(HttpContext.Request.Cookies["user"]);

            return await _context.Planet.Where(p => p.UserId == userId).Select(x => new Planet()
            {
                PlanetId = x.PlanetId,
                PlanetName = x.PlanetName,
                PlanetMass = x.PlanetMass,
                Perihelion = x.Perihelion,
                Aphelion = x.Aphelion,
                Gravity = x.Gravity,
                UserId = x.UserId,
                Favorites = x.Favorites,
                ImageLink = x.ImageLink,
                Temperature = x.Temperature,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageLink)
            }).ToListAsync();
        }

        private bool PlanetExists(int id)
        {
            return (_context.Planet?.Any(e => e.PlanetId == id)).GetValueOrDefault();
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }

        [NonAction]
        public void DeleteImage(string imageName)
        {
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "images", imageName);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);
        }
    }
}
