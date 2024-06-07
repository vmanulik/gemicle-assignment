namespace Gemicle.MarketerTool.Worker.MailClient
{
    public class MailClient(IConfiguration configuration) : IMailClient
    {
        public async Task SendAsync(MailMessage message)
        {
            string mailPath = configuration.GetValue<string>("MarketerToolSettings:MailPath");

            // use ticks to ensure unique names
             await File.WriteAllBytesAsync(@$"{mailPath}\\sends_{message.TimeStamp.ToShortDateString()}_{message.TimeStamp.Ticks}", message.Body);
        }
    }
}