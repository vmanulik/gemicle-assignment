using Gemicle.MarketerTool.Worker.MailClient;
using Quartz;
using System.Text.Json;

namespace Gemicle.MarketerTool.Worker
{
    public class MailJob(IMailClient mailClient) : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            var dataMap = context.MergedJobDataMap;
            CampaignCustomers campaignCustomers = JsonSerializer.Deserialize<CampaignCustomers>(dataMap["campaignCustomer"].ToString());

            // actual customer data is not used as per assignement task
            foreach(var customer in campaignCustomers.Customers)
            {
                var message = new MailMessage()
                {
                    TimeStamp = DateTime.Now,
                    Body = await File.ReadAllBytesAsync($".\\Templates\\{campaignCustomers.Campaign.Template}.html")
                };

                await mailClient.SendAsync(message);
            }

            // wait for now reason as it stated in the assigment
            await Task.Delay(new TimeSpan(hours: 0, minutes: 30, seconds: 0));
        }
    }
}