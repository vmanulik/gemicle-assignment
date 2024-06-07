namespace Gemicle.MarketerTool.Worker.MailClient
{
    public class MailClient : IMailClient
    {
        public async Task SendAsync(MailMessage message)
        {
            // use ticks to ensure unique names
             await File.WriteAllBytesAsync(@$"C:\\sends{message.TimeStamp.ToShortDateString()}_{message.TimeStamp.Ticks}", message.Body);
        }
    }
}