using System.Net.Mail;

namespace Gemicle.MarketerTool.Worker.MailClient
{
    public interface IMailClient
    {
        Task SendAsync(MailMessage message);
    }
}