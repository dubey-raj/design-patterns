using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacadeController : ControllerBase
    {

        private readonly ILogger<FacadeController> _logger;

        public FacadeController(ILogger<FacadeController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Facade")]
        public string Get()
        {
            return "response using facade pattern";
        }
    }
}
