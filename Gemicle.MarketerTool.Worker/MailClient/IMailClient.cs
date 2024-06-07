namespace Gemicle.MarketerTool.Worker.MailClient
{
    public interface IMailClient
    {
        Task SendAsync(IEnumerable<MailMessage> messages);
    }
}