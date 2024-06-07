using Gemicle.Calculator.Services.Abstractions;
using Gemicle.MarketerTool.Data;
using Gemicle.MarketerTool.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Gemicle.Calculator.Services
{
    internal sealed class CustomerService(MarketerToolContext context, IMemoryCache memoryCache) : ICustomerService
    {
        public Task<List<Customer>> GetCustomersAsync()
        {
            return memoryCache.GetOrCreateAsync($"Customers", entry =>
            {
                return context.Set<Customer>().AsNoTracking().ToListAsync();
            })!;
        }
    }
}