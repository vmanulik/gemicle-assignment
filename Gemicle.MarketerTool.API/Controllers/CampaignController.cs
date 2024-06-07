using Gemicle.Calculator.Services.Abstractions;
using Gemicle.MarketerTool.Data.Models;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace Gemicle.MarketerTool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CampaignController(ILogger<CampaignController> logger,
                                  ICampaignService campaignService,
                                  IMapper mapper) : ControllerBase
    {

        [HttpGet(Name = "GetCampaigns")]
        public async Task<ActionResult<IEnumerable<Domain.Campaign>>> Get()
        {
            List<Campaign> customers = await campaignService.GetCampaignsAsync();

            return this.Ok(mapper.Map<IEnumerable<Domain.Campaign>>(customers));
        }
    }
}
