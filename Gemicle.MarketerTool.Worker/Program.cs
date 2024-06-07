using Gemicle.MarketerTool.Worker;
using Gemicle.MarketerTool.Worker.HttpService;
using Gemicle.MarketerTool.Worker.MailClient;
using Quartz;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddSingleton<IApiHttpService, ApiHttpService>();
builder.Services.AddScoped<IMailClient, MailClient>();

builder.Services.AddQuartz();

 string apiUrl = builder.Configuration.GetValue<string>("MarketerToolSettings:ApiUrl");
builder.Services.AddHttpClient("gemicle-api", (serviceProvider, client) =>
{
    client.BaseAddress = new Uri(apiUrl);
});

var host = builder.Build();
host.Run();
