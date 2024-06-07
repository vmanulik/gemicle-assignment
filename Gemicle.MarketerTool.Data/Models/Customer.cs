using System.ComponentModel.DataAnnotations;

namespace Gemicle.MarketerTool.Data.Models
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }

        [Range(0, Int32.MaxValue)]
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string City { get; set; }

        public decimal Deposite { get; set; }

        public bool IsNewCustomer { get; set; }
    }
}
