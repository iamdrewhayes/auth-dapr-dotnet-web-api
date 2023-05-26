using Dapr.Client;
using MessageContracts;
using Microsoft.AspNetCore.Mvc;

namespace SampleBff.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class InitiateBackgroundProcessingController : ControllerBase
  {
    private readonly DaprClient _client;
    public InitiateBackgroundProcessingController(DaprClient client) 
    { 
      _client = client;
    }

    [HttpPost]
    public async Task<IActionResult> Post()
    {
      for (int i = 0; i < 10; i++)
      {
        var message = new MessageFromBff($"Message from BFF number {i}", DateTime.UtcNow);
        await _client.PublishEventAsync("pubsub", "message-from-bff", message);
      }

      return Accepted();
    }
  }
}
