using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SmartCodeManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        [HttpPost("git-events")]
        public IActionResult ReceiveGitEvent([FromBody] dynamic payload)
        {
            Console.WriteLine($"Received Webhook: {payload}");

            return Ok("Webhook received successfully!");
        }
    }
}
