using Gemicle.MarketerTool.Domain;
using Serialize.Linq.Serializers;
using System.Linq.Expressions;

namespace Gemicle.MarketerTool.Worker
{
    public class CampainsManager(
        List<Customer> customerList,
        List<Campaign> campaignsList)
    {        
        public List<(Campaign campaign, IEnumerable<Customer>)> BuildQueues()
        {
            var serializer = new ExpressionSerializer(new JsonSerializer());
            List<(Campaign campaign, IEnumerable<Customer>)> campaignCustomers = new List<(Campaign campaign, IEnumerable<Customer>)>(campaignsList.Count);
            var processedCustomers = new List<Customer>(customerList.Count);

            // assume higher number means higher prioity due to the nature of example predicates
            foreach (var campaign in campaignsList.OrderByDescending(c => c.Priority))
            {
                var predicate = (Expression<Func<Customer, bool>>) serializer.DeserializeText(campaign.PredicateJson);

                // filter eligible customers and then remove all categorized as suitable for higher priority campaigns
                IEnumerable<Customer> filteredCustomers = customerList.AsQueryable().Where(predicate);
                var eligibleCustomers = filteredCustomers.Where(c => !processedCustomers.Contains(c));

                campaignCustomers.Add((campaign, eligibleCustomers.ToList()));
                processedCustomers.AddRange(eligibleCustomers);
            }

            return campaignCustomers;
        }
    }
}