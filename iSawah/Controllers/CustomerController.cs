using iSawah.Application.Helper;
using iSawah.Application.Models;
using iSawah.Application.Services.Customers;
using iSawah.Application.Services.Customers.Dto;
using iSawah.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iSawah.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : Controller
	{
		
		private readonly ICustomerAppService _customerAppService;

		public CustomerController(ICustomerAppService customerAppService)
		{
			_customerAppService = customerAppService;
		}

		[HttpPost("Create")]		
		[Produces("application/json")]
		public IActionResult Create([FromBody] CustomerDto model)
		{
			try
			{
				var customer = _customerAppService.Create (model);
				return Requests.Response(this, new ApiStatus(200), customer, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(404), null, ex.Message);
			}
		}
		
		[HttpPatch("Edit")]
		public IActionResult Edit([FromBody] UpdateCustomerDto model)
		{
			try
			{
				var customer = _customerAppService.Update(model);
				if (customer == null)
				{
					return Requests.Response(this, new ApiStatus(406), customer, "error");
				}
				return Requests.Response(this, new ApiStatus(200), customer, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(404), null, ex.Message);
			}
		}
	}
}
