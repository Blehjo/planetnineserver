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
    public class messagecomment : ControllerBase
    {
        private readonly planetnineservercontext _context;

        public messagecomment(planetnineservercontext context)
        {
            _context = context;
        }

        // GET: api/messagecomment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessageComment>>> GetMessageComment()
        {
          if (_context.MessageComment == null)
          {
              return NotFound();
          }
            return await _context.MessageComment.ToListAsync();
        }

        // GET: api/messagecomment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MessageComment>> GetMessageComment(int id)
        {
          if (_context.MessageComment == null)
          {
              return NotFound();
          }
            var messageComment = await _context.MessageComment.FindAsync(id);

            if (messageComment == null)
            {
                return NotFound();
            }

            return messageComment;
        }

        // PUT: api/messagecomment/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessageComment(int id, MessageComment messageComment)
        {
            if (id != messageComment.MessageCommentId)
            {
                return BadRequest();
            }

            _context.Entry(messageComment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessageCommentExists(id))
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

        // POST: api/messagecomment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MessageComment>> PostMessageComment(MessageComment messageComment)
        {
          if (_context.MessageComment == null)
          {
              return Problem("Entity set 'planetnineservercontext.MessageComment'  is null.");
          }
            _context.MessageComment.Add(messageComment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessageComment", new { id = messageComment.MessageCommentId }, messageComment);
        }

        // DELETE: api/messagecomment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessageComment(int id)
        {
            if (_context.MessageComment == null)
            {
                return NotFound();
            }
            var messageComment = await _context.MessageComment.FindAsync(id);
            if (messageComment == null)
            {
                return NotFound();
            }

            _context.MessageComment.Remove(messageComment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessageCommentExists(int id)
        {
            return (_context.MessageComment?.Any(e => e.MessageCommentId == id)).GetValueOrDefault();
        }
    }
}
