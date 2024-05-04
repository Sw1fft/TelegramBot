using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace AutoFactBot.Application.Services
{
    public class BotsService
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
                _ => OnUnknowHandler(update, cancellationToken)
            };

            await handler;
        }

        private async Task OnMessageHandler(Message message, CancellationToken cancellationToken)
        {
            if (message.Text == null || message.Text.StartsWith('/') == false)
                return;

            string text = message.Text;

            var command = text switch
            {
                "/start"    => OnStartCommandReceived(message, cancellationToken),
                _           => OnUnknowReceived(message, cancellationToken)
            };

            await command;
        }

        private async Task OnStartCommandReceived(Message message, CancellationToken cancellationToken)
        {
            InlineKeyboardMarkup inlineKeyboard = new(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithWebApp("Создать документ", new WebAppInfo() { Url = "" })
                }
            });

            await _botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Success",
                parseMode: ParseMode.MarkdownV2,
                cancellationToken: cancellationToken);
        }

        private async Task OnUnknowReceived(Message message, CancellationToken cancellationToken)
        {
            await _botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "Unknow",
                parseMode: ParseMode.MarkdownV2,
                cancellationToken: cancellationToken);
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
