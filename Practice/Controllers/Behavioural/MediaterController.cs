using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediaterController : ControllerBase
    {

        private readonly ILogger<MediaterController> _logger;

        public MediaterController(ILogger<MediaterController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Mediater")]
        public string Get()
        {
            return "response using Mediater pattern";
        }
    }
}
