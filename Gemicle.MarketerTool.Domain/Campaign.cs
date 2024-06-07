namespace Gemicle.MarketerTool.Domain
{
    public class Campaign
    {
        public Template Template { get; set; }

        public TimeSpan Time { get; set; }

        public int Priority { get; set; }

        public string PredicateJson { get; set; }
    }
}
