using Gemicle.MarketerTool.Data.Models;

namespace Gemicle.Calculator.Services.Abstractions
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetCustomersAsync();
    }
}