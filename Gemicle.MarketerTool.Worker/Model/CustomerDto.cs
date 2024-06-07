namespace Gemicle.MarketerTool.Worker.Models
{
    public sealed class CustomerDto
    {
        public int Age { get; set; }

        public GenderEnum Gender { get; set; }

        public string City { get; set; }

        public decimal Deposite { get; set; }

        public bool IsNewCustomer { get; set; }
    }
}