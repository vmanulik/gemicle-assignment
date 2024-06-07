using Gemicle.MarketerTool.Domain;
using Gemicle.MarketerTool.Worker.HttpService;
using Quartz;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            // sort customers to particular campaigns basing on priority and rules
            var manager = new CampainsManager(_customerList, _campaignsList);
            var campaigns = manager.BuildCampaigns();

            foreach(var campaign in campaigns)
            {
                IJobDetail job = JobBuilder.Create<MailJob>()
                    .WithIdentity($"MailJob with Prioity {campaign.Campaign.Priority}", "MailJobs")
                    .Build();

                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity($"MailTrigger with Prioity {campaign.Campaign.Priority}", "MailTriggers")
                    .UsingJobData("campaignCustomer", JsonSerializer.Serialize(campaign))
                    .WithSchedule(CronScheduleBuilder
                    //.DailyAtHourAndMinute(campaign.Campaign.Time.Hours, campaign.Campaign.Time.Minutes))
                    .DailyAtHourAndMinute(23, 11)) // testing
                    .Build();

                await scheduler.ScheduleJob(job, trigger, cancellationToken);
            }
            
            await scheduler.Start(cancellationToken);
        }

        // is not used due to the usage of Quartz.NET for queued jobs
        protected override async Task ExecuteAsync(CancellationToken stoppingToken) { }
    }
}
