using Gemicle.Calculator.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Gemicle.Calculator.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddMarketerToolServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICampaignService, CampaignService>();

            services.AddMemoryCache();
        }
    }
}