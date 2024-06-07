using Gemicle.Calculator.Services.Abstractions;
using Gemicle.MarketerTool.Data.Models;
using Gemicle.MarketerTool.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Gemicle.Calculator.Services
{
    internal sealed class CampaignService(MarketerToolContext context, IMemoryCache memoryCache) : ICampaignService
    {
        public Task<List<Campaign>> GetCampaignsAsync()
        {
            return memoryCache.GetOrCreateAsync($"Campaigns", entry =>
            {
                return context.Set<Campaign>().AsNoTracking().ToListAsync();
            })!;
        }
    }
}