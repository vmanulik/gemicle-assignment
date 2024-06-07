using Gemicle.MarketerTool.Domain;
using System.Net.Http.Json;

namespace Gemicle.MarketerTool.Worker.HttpService
{
    public class ApiHttpService(IHttpClientFactory factory) : IApiHttpService
    {
        public async Task<List<Customer>> GetCustomersAsync()
        {
            using (HttpClient client = factory.CreateClient("gemicle-api"))
            {
                var response = await client.GetAsync("api/customer");
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Cannot fetch customers, status code: {response.StatusCode}");
                }

                return await response.Content.ReadFromJsonAsync<List<Customer>>() ?? [];
            }
        }

        public async Task<List<Campaign>> GetCampaignsAsync()
        {
            using (HttpClient client = factory.CreateClient("gemicle-api"))
            {
                var response = await client.GetAsync("api/campaign");
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Cannot fetch campaigns, status code: {response.StatusCode}");
                }

                return await response.Content.ReadFromJsonAsync<List<Campaign>>() ?? [];
            }
        }
    }
}