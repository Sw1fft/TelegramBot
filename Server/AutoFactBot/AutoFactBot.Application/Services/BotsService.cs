using AutoFactBot.Application.Handlers;
using AutoFactBot.Core.Abstractions;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace AutoFactBot.Application.Services
{
    public class BotsService : IBotsService
    {
        private readonly ITelegramBotClient _botClient;

        public BotsService(ITelegramBotClient botClient)
        {
            _botClient = botClient;
        }

        public async Task UpdatesHandler(Update update, CancellationToken cancellationToken)
        {
            var handler = update switch
            {
                { Message: { } message } => OnMessageHandler(message, cancellationToken),
                { CallbackQuery: { } callbackQuery } => OnCallbackQueryHandler(callbackQuery, cancellationToken),
                _ => OnUnknowHandler(update, cancellationToken)
            };

            await handler;
        }

        private async Task OnMessageHandler(Message message, CancellationToken cancellationToken)
        {
            if (message.Text is not { } messageText)
                return;

            var command = messageText switch
            {
                "/start" => new OnTextMessage(_botClient).OnStartCommandHandler(message, cancellationToken),
                _ => new OnTextMessage(_botClient).OnUnknowCommandHandler(message, cancellationToken)
            };

            await command;
        }

        private async Task OnCallbackQueryHandler(CallbackQuery callbackQuery, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private async Task OnUnknowHandler(Update update, CancellationToken cancellationToken)
        {
            await _botClient.SendTextMessageAsync(
                chatId: update.Message!.From!.Id,
                text: "Unknow update",
                parseMode: ParseMode.MarkdownV2,
                cancellationToken: cancellationToken);
        }
    }
}
