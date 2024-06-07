using System.ComponentModel.DataAnnotations;

namespace Gemicle.MarketerTool.Data.Models
{
    public class Campaign
    {
        [Key]
        public long Id { get; set; }

        public Template Template { get; set; }

        public TimeSpan Time { get; set; }

        public int Priority { get; set; }

        public string PredicateJson { get; set; }
    }
}
