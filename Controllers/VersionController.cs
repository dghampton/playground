using Microsoft.AspNetCore.Mvc;

namespace playground.Controllers;

[ApiController]
[Route("[controller]")]
public class VersionController : ControllerBase
{
    private readonly ILogger<VersionController> _logger;
    public VersionController(ILogger<VersionController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetVersion")]
    public VersionResponse Get()
    {
        var version = Environment.GetEnvironmentVariable("VERSION");
        return new VersionResponse {
            Version = version
        };
    }

    public class VersionResponse
    {
        public string Version {get; set;}
    }
}
