using System;
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
    public class MessageController : ControllerBase
    {
        private readonly Planetnineservercontext _context;

        public MessageController(Planetnineservercontext context)
        {
            _context = context;
        }

        // GET: api/Message
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> GetMessages()
        {
          if (_context.Message == null)
          {
              return NotFound();
          }
            var userId = Int32.Parse(HttpContext.Request.Cookies["user"]);

            var user = await _context.User.FindAsync(userId);

            return await _context.Message.Where(m => m.UserId == userId || m.MessageValue == user.Username).Select(x => new Message()
            {
                MessageId = x.MessageId,
                MessageValue = x.MessageValue,
                DateCreated = x.DateCreated,
                User = x.User,
                UserId = x.UserId,
                MessageComments = x.MessageComments
            }).ToListAsync();
        }

        // GET: api/Message/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Message>> GetMessage(int id)
        {
          if (_context.Message == null)
          {
              return NotFound();
          }
            var message = await _context.Message.FindAsync(id);

            if (message == null)
            {
                return NotFound();
            }

            return message;
        }

        // PUT: api/Message/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessage(int id, Message message)
        {
            if (id != message.MessageId)
            {
                return BadRequest();
            }

            _context.Entry(message).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessageExists(id))
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

        // POST: api/Message
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Message>> PostMessage(Message message)
        {
            if (_context.Message == null)
            {
                return Problem("Entity set 'PlanetNineDatabaseContext.Messages'  is null.");
            }

            message.UserId = Int32.Parse(Request.Cookies["user"]);

            List<Message> returnedMessage = await _context.Message.Where(m => m.MessageValue == message.MessageValue && m.UserId == message.UserId).ToListAsync();
            
            if (returnedMessage.Count() > 0)
            {
                return CreatedAtAction("GetMessage", returnedMessage);
            }

            _context.Message.Add(message);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessage", new { id = message.MessageId }, message);
        }

        // DELETE: api/Message/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IEnumerable<Message>>> DeleteMessage(int id)
        {
            if (_context.Message == null)
            {
                return NotFound();
            }

            var message = await _context.Message.FindAsync(id);

            if (message == null)
            {
                return NotFound();
            }

            _context.Message.Remove(message);

            await _context.SaveChangesAsync();

            var userId = Int32.Parse(HttpContext.Request.Cookies["user"]);

            return await _context.Message.Where(m => m.UserId == userId).ToListAsync();
        }

        private bool MessageExists(int id)
        {
            return (_context.Message?.Any(e => e.MessageId == id)).GetValueOrDefault();
        }
    }
}
