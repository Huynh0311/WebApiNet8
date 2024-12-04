using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiNet8.Controllers {
    [Route("api/emails")]
    [ApiController]
    public class EmailsController : ControllerBase {
        public EmailsController() { }

        [HttpGet()]
        public IActionResult Get() {

            return Ok("Test api");
        }

        [HttpGet("test")]
        public IActionResult Get() {

            return Ok("Test api");
        }
    }

}
