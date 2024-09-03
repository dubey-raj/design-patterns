using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FactoryController : ControllerBase
    {

        private readonly ILogger<FactoryController> _logger;

        public FactoryController(ILogger<FactoryController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Factory")]
        public string Get()
        {
            return "response using factory pattern";
        }
    }
}
