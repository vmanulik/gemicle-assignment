using Gemicle.MarketerTool.Data.Models;

namespace Gemicle.Calculator.Services.Abstractions
{
    public interface ICampaignService
    {
        public Task<List<Campaign>> GetCampaignsAsync();
    }
}