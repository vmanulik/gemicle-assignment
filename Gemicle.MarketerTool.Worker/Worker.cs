using Gemicle.MarketerTool.Worker.HttpService;
using Gemicle.MarketerTool.Worker.Models;
using Serialize.Linq.Serializers;
using System.Linq.Expressions;

namespace Gemicle.MarketerTool.Worker
{
    public class Worker(IApiHttpService apiHttpService,
                        ILogger<Worker> _logger) : BackgroundService
    {
        private List<CustomerDto> _customerList;
        private List<CampaignDto> _campaignsList;

        public async override Task StartAsync(CancellationToken cancellationToken)
        {
            _customerList = await apiHttpService.GetCustomersAsync();
            _campaignsList = await apiHttpService.GetCampaignsAsync();

            var serializer = new ExpressionSerializer(new JsonSerializer());
            var obj = (Expression<Func<Domain.Customer, bool>>) serializer.DeserializeText(_campaignsList.First().PredicateJson);


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
