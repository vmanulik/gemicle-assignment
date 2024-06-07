using Gemicle.Calculator.Services.Abstractions;
using Gemicle.MarketerTool.Data.Models;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;

namespace Gemicle.MarketerTool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController(ILogger<CustomerController> logger,
                                  ICustomerService сustomerService,
                                  IMapper mapper) : ControllerBase
    {

        [HttpGet(Name = "GetCustomers")]
        public async Task<ActionResult<IEnumerable<Domain.Customer>>> Get()
        {
            List<Customer> customers = await сustomerService.GetCustomersAsync();

            return this.Ok(mapper.Map<IEnumerable<Domain.Customer>>(customers));
        }
    }
}
