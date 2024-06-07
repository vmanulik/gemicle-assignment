using Gemicle.MarketerTool.Domain;

namespace Gemicle.MarketerTool.Worker.HttpService
{
    public interface IApiHttpService
    {
        Task<List<Customer>> GetCustomersAsync();

        Task<List<Campaign>> GetCampaignsAsync();
    }
}