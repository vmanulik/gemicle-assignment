using Gemicle.MarketerTool.Worker.Models;
using System.Net.Http.Json;

namespace Gemicle.MarketerTool.Worker.HttpService
{
    public class ApiHttpService : IApiHttpService
    {
        private readonly IHttpClientFactory _factory;

        public ApiHttpService(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<List<CustomerDto>> GetCustomersAsync()
        {
            using (HttpClient client = _factory.CreateClient("gemicle-api"))
            {
                var response = await client.GetAsync("api/customer");
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Cannot fetch customers, status code: {response.StatusCode}");
                }

                return await response.Content.ReadFromJsonAsync<List<CustomerDto>>() ?? [];
            }
        }
    }
}