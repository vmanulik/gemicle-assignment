using Gemicle.Calculator.Services.Abstractions;
using Gemicle.MarketerTool.API.Models;
using Gemicle.MarketerTool.Data.Models;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace Gemicle.MarketerTool.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController(ILogger<CustomerController> logger,
                                  ICustomerService сustomerService,
                                  IMapper mapper) : ControllerBase
    {

        [HttpGet(Name = "GetCustomers")]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> Get()
        {
            List<Customer> customers = await сustomerService.GetCustomersAsync();

            return this.Ok(mapper.Map<IEnumerable<CustomerDto>>(customers));
        }
    }
}
