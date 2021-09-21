
using Microsoft.AspNetCore.Mvc;


namespace TestDotNetCore.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotatoesController : ControllerBase
    {
        [HttpGet]
        public IActionResult List()
        {
            var potatoe = new Potatoe();
            return new OkObjectResult("")
            {

            };
        }
    }
}
