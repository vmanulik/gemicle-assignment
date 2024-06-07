﻿using Gemicle.MarketerTool.Worker.MailClient;
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

            //var template = await File.ReadAllBytesAsync(".\\A.html");

            await mailClient.SendAsync(null);

            // wait for now reason as it stated in the assigment
            await Task.Delay(new TimeSpan(hours: 0, minutes: 30, seconds: 0));
        }
    }
}