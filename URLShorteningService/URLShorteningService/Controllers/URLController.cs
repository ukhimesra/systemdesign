using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace URLShorteningService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class URLController : ControllerBase
    {
        private readonly ILogger<URLController> _logger;

        public URLController(ILogger<URLController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetActualURL(string shortUrl)
        {
            return String.Empty;
        }


        [HttpPut]
        public string MapPath(string url)
        {
            return String.Empty;
        }
    }
}
