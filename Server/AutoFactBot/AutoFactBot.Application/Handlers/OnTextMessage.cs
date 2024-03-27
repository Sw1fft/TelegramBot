using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace AutoFactBot.Application.Handlers
{
    public class OnTextMessage
    {
        private readonly ITelegramBotClient _botClient;

        public OnTextMessage(ITelegramBotClient botClient)
        {
            _botClient = botClient;
        }

        public async Task<Message> OnStartCommandHandler(Message message, CancellationToken cancellationToken)
        {


            InlineKeyboardMarkup inlineKeyboard = new(
                new[]
                {
                    new[]
                    {
                        InlineKeyboardButton.WithWebApp("Создать документ", new WebAppInfo() { Url = "https://www.google.com" })
                    }
                });

            return await _botClient.SendTextMessageAsync(
                chatId: message.From!.Id,
                text: "Выберите действие",
                replyMarkup: inlineKeyboard,
                cancellationToken: cancellationToken);
        }

        public async Task OnUnknowCommandHandler(Message message, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
