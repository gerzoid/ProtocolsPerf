using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfRestController : ControllerBase
    {
        [HttpPost("ping")]
        public ActionResult<PerfPayload> Ping([FromBody] PerfPayload payload)
        {
            payload.Timestamp = DateTime.UtcNow;
            return Ok(payload);
        }
    }
}
