using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
    [ApiController]
    [Route("logger")]
    public class LoggerController : ControllerBase
    {
        private readonly ICustomLogger _customLogger;
        public LoggerController(ICustomLogger customLogger)
        {
            _customLogger = customLogger;
        }

        [HttpPost("write")]
        public void Write([FromQuery] string message)
        {
            _customLogger.Log(message);
        }
    }
}
