using Telegram.Bot.Types;

namespace AutoFactBot.Core.Abstractions
{
    public interface IBotsService
    {
        Task UpdatesHandler(Update update, CancellationToken cancellationToken);
    }
}
