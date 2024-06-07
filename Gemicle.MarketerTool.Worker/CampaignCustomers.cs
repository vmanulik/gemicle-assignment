using Gemicle.MarketerTool.Domain;

namespace Gemicle.MarketerTool.Worker
{
    public class CampaignCustomers
    {
        public Campaign Campaign { get; set; }

        public List<Customer> Customers { get; set; }
    }
}