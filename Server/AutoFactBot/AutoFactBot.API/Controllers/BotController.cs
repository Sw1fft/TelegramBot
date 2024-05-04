using AutoFactBot.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace AutoFactBot.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Post(
            [FromBody] Update update,
            [FromServices] BotsService botsService,
            CancellationToken cancellationToken)
        {
            await botsService.UpdatesHandler(update, cancellationToken);

            return Ok();
        }
    }
}
