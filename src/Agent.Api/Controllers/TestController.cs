namespace Agent.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase {

    [HttpPost]
    public IActionResult Post([FromServices] ILogger<TestController> _logger, [FromBody] RequestDto dto) {
        _logger.LogInformation($"Request from {HttpContext.Connection.RemoteIpAddress}; Source: {dto.Source}; Message: {dto.Message};");
        return Ok();
    }
}