using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Ocelot.Resource.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TicketController : ControllerBase
    {

        [HttpGet]
        public ActionResult<Ticket> GetTicket()
        {
            var ticket = new Ticket { Id = 1, Description = "asd" };
            return Ok(ticket);
        }
        [HttpPost]
        public ActionResult<Ticket> AddTicket([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }
    }
    public class Ticket
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
