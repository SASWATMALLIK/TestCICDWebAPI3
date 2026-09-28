using Microsoft.AspNetCore.Mvc;

namespace TestCICDWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Health")]
        public bool Get()
        {
            return true;
        }

    }
}
