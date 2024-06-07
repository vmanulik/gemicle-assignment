namespace Gemicle.MarketerTool.API.Models
{
    public sealed class CampaignDto
    {
        public TemplateEnum Template { get; set; }

        public TimeSpan Time { get; set; }

        public int Priority { get; set; }

        public string PredicateJson { get; set; }
    }
}