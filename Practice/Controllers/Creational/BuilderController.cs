using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuilderController : ControllerBase
    {

        private readonly ILogger<BuilderController> _logger;

        public BuilderController(ILogger<BuilderController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Builder")]
        public string Get()
        {
            return "response using builder pattern";
        }
    }
}
