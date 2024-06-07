using Gemicle.MarketerTool.Domain;
using Gemicle.MarketerTool.Worker.HttpService;
using Quartz;

namespace Gemicle.MarketerTool.Worker
{
    public class Worker(IApiHttpService apiHttpService,
                        ISchedulerFactory schedulerFactory,
                        ILogger<Worker> _logger) : BackgroundService
    {
        private List<Customer> _customerList;
        private List<Campaign> _campaignsList;

        public async override Task StartAsync(CancellationToken cancellationToken)
        {
            IScheduler scheduler = await schedulerFactory.GetScheduler(cancellationToken);

            _customerList = await apiHttpService.GetCustomersAsync();
            _campaignsList = await apiHttpService.GetCampaignsAsync();

            var manager = new CampainsManager(_customerList, _campaignsList);
            var queues = manager.BuildQueues();

            foreach(var queue in queues)
            {
                IJobDetail job = JobBuilder.Create<MailJob>()
                    .WithIdentity($"MailJob with Prioity {queue.campaign.Priority}", "MailJobs")
                    .Build();

                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity($"MailTrigger with Prioity {queue.campaign.Priority}", "MailTriggers")
                    .WithSchedule(CronScheduleBuilder
                    //.DailyAtHourAndMinute(queue.campaign.Time.Hours, queue.campaign.Time.Minutes))
                    .DailyAtHourAndMinute(18, 18)) // testing
                    .Build();

                await scheduler.ScheduleJob(job, trigger, cancellationToken);
            }
            
            await scheduler.Start(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) { }
    }
}
