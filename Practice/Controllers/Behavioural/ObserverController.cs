using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObserverController : ControllerBase
    {

        private readonly ILogger<ObserverController> _logger;

        public ObserverController(ILogger<ObserverController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "observer")]
        public string Get()
        {
            return "response using Observer pattern";
        }
    }
}
