using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChainOfResponsibilityController : ControllerBase
    {

        private readonly ILogger<ChainOfResponsibilityController> _logger;

        public ChainOfResponsibilityController(ILogger<ChainOfResponsibilityController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "cor")]
        public string Get()
        {
            return "response using Chain Of Responsibility pattern";
        }
    }
}
