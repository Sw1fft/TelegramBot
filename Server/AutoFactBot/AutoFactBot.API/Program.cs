using AutoFactBot.Application.Services;
using AutoFactBot.Core.Abstractions;
using AutoFactBot.Data.Repositories;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration.GetRequiredSection("Token");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("telegram_bot_client")
                .AddTypedClient<ITelegramBotClient>((httpClient, sp) =>
                {
                    TelegramBotClientOptions options = new(config.Value!);
                    return new TelegramBotClient(options, httpClient);
                });

builder.Services.AddScoped<IDocumentsService, DocumentsService>();
builder.Services.AddScoped<IDocumentsRepository, DocumentsRepository>();
builder.Services.AddHostedService<WebhooksService>();
builder.Services.AddScoped<IBotsService, BotsService>();

builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x =>
{
    x.WithHeaders().AllowAnyHeader();
    x.WithOrigins("http://localhost:3000");
    x.WithMethods("http://localhost:3000").AllowAnyMethod();
});

app.Run();
