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
            VersionNumber = version,
            Status = "success"
        };
    }

    public class VersionResponse
    {
        public string VersionNumber {get; set;}
        public string Status {get;set;}
    }
}
