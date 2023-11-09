using Microsoft.AspNetCore.Mvc;

namespace DieRollerAPI.Controllers
{
    [ApiController]
    [Route("die")]
    public class DieController : ControllerBase
    {
        public DieController()
        {
        }

        [HttpGet("roll")]
        public ActionResult<DieRollDto> Get()
        {
            var rnd = new Random();
            return Ok(new DieRollDto(rnd.Next(1, 7)));
        }
    }
}