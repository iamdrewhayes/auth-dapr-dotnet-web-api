using Dapr;
using MessageContracts;
using Microsoft.AspNetCore.Mvc;

namespace SampleProcessingService.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MessageFromBffController : ControllerBase
  {
    [HttpPost]
    [Topic("pubsub", "message-from-bff")]
    public IActionResult Post(MessageFromBff message)
    {
      Console.WriteLine(message.Description);
      return Accepted();
    }
  }
}
