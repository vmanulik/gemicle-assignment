using Gemicle.MarketerTool.Worker.HttpService;

namespace Gemicle.MarketerTool.Worker
{
    public class Worker(IApiHttpService apiHttpService,
                        ILogger<Worker> _logger) : BackgroundService
    {
        public async override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Worker started...");

            // await for API to start
            var customers = await apiHttpService.GetCustomersAsync();

            _logger.LogInformation("Customers loaded...");

            await base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
