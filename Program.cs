using CosinusApp.Messages;
using CosinusApp.Services;
using Microsoft.AspNetCore.Http;
using static CosinusApp.Messages.Message;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//обработчик ping
app.MapGet("/ping", async (context) =>
{
    await context.Response.WriteAsync("pong");
});

//обработчик вывода статуса сервера
app.MapGet("/status", async (context) =>
{
    Message.ServerStatus serverStatus = new Message.ServerStatus("OK", DateTime.Now, System.Net.Dns.GetHostName()); 

    await context.Response.WriteAsJsonAsync(serverStatus);
});

//обработчик вывода доступных методов
app.MapGet("/info", async (context) =>
{
    List<Message.Methods> messages = new List<Message.Methods>()
    {
    new Message.Methods("/ping", "checking the work"),
    new Message.Methods("/status", "server status information"),
   //new Message.CalcMessage()

    };
});

app.MapPost("/calc", async (context) =>
{
    CalcMessage.CalcInput input = await context.Request.ReadFromJsonAsync<CalcMessage.CalcInput>();
    var service = new CalcService();
    await context.Response.WriteAsJsonAsync(service.CosineTheorem(input));
});
app.Run();
