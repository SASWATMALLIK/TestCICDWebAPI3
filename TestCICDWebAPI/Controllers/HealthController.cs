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
        public ActionResult Get()
        {
            _logger.LogInformation("Health API was called");

            _logger.LogInformation(
                "Health API request received at {Time}",
                DateTime.UtcNow);

            return Ok(new
            {
                status = "Healthy",
                timestamp = DateTime.UtcNow
            });
        }

    }
}
