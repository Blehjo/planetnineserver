﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planetnineserver.Data;
using Planetnineserver.Models;

namespace Planetnineserver.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanetcommentController : ControllerBase
    {
        private readonly Planetnineservercontext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public PlanetcommentController(Planetnineservercontext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: api/Comment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlanetComment>>> GetComments()
        {
            if (_context.PlanetComment == null)
            {
                return NotFound();
            }

            return await _context.PlanetComment.Select(x => new PlanetComment()
            {
                PlanetCommentId = x.PlanetCommentId,
                CommentValue = x.CommentValue,
                DateCreated = x.DateCreated,
                UserId = x.UserId,
                MediaLink = x.MediaLink,
                PlanetId = x.PlanetId,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.MediaLink)
            }).ToListAsync();
        }

        // GET: api/Comment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlanetComment>> GetComment(int id)
        {
            if (_context.PlanetComment == null)
            {
                return NotFound();
            }

            var planetcomment = await _context.PlanetComment.FindAsync(id);

            if (planetcomment == null)
            {
                return NotFound();
            }

            planetcomment.ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, planetcomment.MediaLink);

            return planetcomment;
        }

        // GET: api/Comment/5
        [HttpGet("planet/{id}")]
        public async Task<ActionResult<IEnumerable<PlanetComment>>> GetPostComments(int id)
        {
            if (_context.PlanetComment == null)
            {
                return NotFound();
            }

            return await _context.PlanetComment.Select(x => new PlanetComment()
            {
                PlanetCommentId = x.PlanetCommentId,
                CommentValue = x.CommentValue,
                DateCreated = x.DateCreated,
                UserId = x.UserId,
                MediaLink = x.MediaLink,
                PlanetId = x.PlanetId,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.MediaLink)
            }).Where(c => c.PlanetId == id).ToListAsync();
        }

        // PUT: api/Comment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComment(int id, PlanetComment planetcomment)
        {
            if (id != planetcomment.PlanetCommentId)
            {
                return BadRequest();
            }

            _context.Entry(planetcomment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(id))
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

        // POST: api/Comment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{id}")]
        public async Task<ActionResult<IEnumerable<PlanetComment>>> PostComment(int id, [FromForm] PlanetComment planetcomment)
        {
            if (_context.PlanetComment == null)
            {
                return Problem("Entity set 'PlanetNineDatabaseContext.Comments'  is null.");
            }

            if (planetcomment.ImageFile != null)
            {
                planetcomment.MediaLink = await SaveImage(planetcomment.ImageFile);
            }

            planetcomment.UserId = Int32.Parse(HttpContext.Request.Cookies["user"]);

            planetcomment.PlanetId = id;

            _context.PlanetComment.Add(planetcomment);

            await _context.SaveChangesAsync();

            return await _context.PlanetComment.Select(x => new PlanetComment()
            {
                PlanetCommentId = x.PlanetCommentId,
                CommentValue = x.CommentValue,
                DateCreated = x.DateCreated,
                UserId = x.UserId,
                MediaLink = x.MediaLink,
                PlanetId = x.PlanetId,
                ImageSource = String.Format("{0}://{1}{2}/images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.MediaLink)
            }).Where(c => c.PlanetId == id).ToListAsync();
        }

        // DELETE: api/Comment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            if (_context.MoonComment == null)
            {
                return NotFound();
            }
            var planetcomment = await _context.PlanetComment.FindAsync(id);
            if (planetcomment == null)
            {
                return NotFound();
            }

            _context.PlanetComment.Remove(planetcomment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommentExists(int id)
        {
            return (_context.PlanetComment?.Any(e => e.PlanetCommentId == id)).GetValueOrDefault();
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
