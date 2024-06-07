namespace Gemicle.MarketerTool.Worker.MailClient
{
    public class MailClient(IConfiguration configuration) : IMailClient
    {
        public async Task SendAsync(IEnumerable<MailMessage> messages)
        {
            string mailPath = configuration.GetValue<string>("MarketerToolSettings:MailPath");

            // use ticks to ensure unique names
            string date = $"{DateTime.Now.ToShortDateString()}_{DateTime.Now.Ticks}";
            using (FileStream stream = File.OpenWrite(@$"{mailPath}\\sends_{date}"))
            {
                foreach (MailMessage message in messages)
                {
                    await stream.WriteAsync(message.Body);
                }
            }
        }
    }
}