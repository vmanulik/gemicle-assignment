using Gemicle.MarketerTool.Domain;
using Gemicle.MarketerTool.Worker.HttpService;

namespace Gemicle.MarketerTool.Worker
{
    public class Worker(IApiHttpService apiHttpService,
                        ILogger<Worker> _logger) : BackgroundService
    {
        private List<Customer> _customerList;
        private List<Campaign> _campaignsList;

        public async override Task StartAsync(CancellationToken cancellationToken)
        {
            _customerList = await apiHttpService.GetCustomersAsync();
            _campaignsList = await apiHttpService.GetCampaignsAsync();

            var scheduler = new CampaignsScheduler(_customerList, _campaignsList);
            var queues = scheduler.BuildQueues();

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
