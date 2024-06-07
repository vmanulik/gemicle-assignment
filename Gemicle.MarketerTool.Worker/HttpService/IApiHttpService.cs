using Gemicle.MarketerTool.Worker.Models;

namespace Gemicle.MarketerTool.Worker.HttpService
{
    public interface IApiHttpService
    {
        Task<List<CustomerDto>> GetCustomersAsync();
    }
}