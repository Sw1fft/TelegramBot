using AutoFactBot.Application.Services;
using AutoFactBot.Core.Abstractions;
using AutoFactBot.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoFactBot.Data.Context;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient("telegram_bot_client")
                .AddTypedClient<ITelegramBotClient>((httpClient, sp) =>
                {
                    TelegramBotClientOptions options = new(config.GetRequiredSection("BotToken").Value!);
                    return new TelegramBotClient(options, httpClient);
                });

builder.Services.AddScoped<IDocumentsRepository, DocumentsRepository>();
builder.Services.AddScoped<IDocumentsService, DocumentsService>();
builder.Services.AddScoped<IBotsService, BotsService>();
builder.Services.AddHostedService<WebhooksService>();

builder.Services.AddDbContext<DocumentDbContext>(options =>
{
    options.UseNpgsql(config.GetConnectionString("DbConnect"));
});

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
    x.WithMethods().AllowAnyMethod();
});

app.Run();
