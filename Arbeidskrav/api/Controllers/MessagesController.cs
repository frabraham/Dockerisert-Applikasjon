using Arbeidskrav.api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Arbeidskrav.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MessagesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMessages()
        {
            var messages = _context.Messages.ToList();
            return Ok(messages);
        }

        [HttpPost]
        public IActionResult AddMessage([FromBody] Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMessages), new { id = message.Id }, message);
        }
    }
}
