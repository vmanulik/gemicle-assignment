using Gemicle.MarketerTool.Data.Models;

namespace Gemicle.MarketerTool.API.Models
{
    public sealed class CustomerDto
    {
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string City { get; set; }

        public decimal Deposite { get; set; }

        public bool IsNewCustomer { get; set; }
    }
}