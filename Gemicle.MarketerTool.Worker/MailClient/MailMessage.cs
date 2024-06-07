namespace Gemicle.MarketerTool.Worker.MailClient
{
    public class MailMessage
    {
        public DateTime TimeStamp { get; set; }

        public byte[] Body { get; set; }
    }
}