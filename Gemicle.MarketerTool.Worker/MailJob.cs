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
            var messages = new List<MailMessage>();
            foreach(var customer in campaignCustomers.Customers)
            {
                var message = new MailMessage()
                {
                    Body = await File.ReadAllBytesAsync($".\\Templates\\{campaignCustomers.Campaign.Template}.html")
                };

                messages.Add(message);
            }

            await mailClient.SendAsync(messages);

            // wait for now reason as it stated in the assigment
            await Task.Delay(new TimeSpan(hours: 0, minutes: 30, seconds: 0));
        }
    }
}