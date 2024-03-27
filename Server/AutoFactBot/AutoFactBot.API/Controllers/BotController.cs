using AutoFactBot.Core.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace AutoFactBot.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {
        private readonly IBotsService _botsService;

        public BotController(IBotsService botsService)
        {
            _botsService = botsService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update, CancellationToken cancellationToken)
        {
            await _botsService.UpdatesHandler(update, cancellationToken);

            return Ok();
        }
    }
}
