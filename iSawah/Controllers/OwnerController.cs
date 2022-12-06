using AutoMapper;
using iSawah.Application.Helper;
using iSawah.Application.Services.Distributors;
using iSawah.Application.Services.Distributors.Dto;
using iSawah.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace iSawah.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OwnerController : Controller
	{
		private readonly IOwnerAppService _ownerAppService;

		public OwnerController(IOwnerAppService ownerAppService)
		{
			_ownerAppService= ownerAppService;
		}

		[HttpPost("Create")]
		[Produces("application/json")]
		public IActionResult Create([FromBody] OwnerDto model)
		{
			try
			{
				var owner = _ownerAppService.Create(model);
				return Requests.Response(this, new ApiStatus(200), owner, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(404), null, ex.Message);
			}
		}

		[HttpPatch("Edit")]
		public IActionResult Edit([FromBody] UpdateOwnerDto model)
		{
			try
			{
				var owner = _ownerAppService.Update(model);
				if (owner == null)
				{
					return Requests.Response(this, new ApiStatus(406), owner, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), owner, "Success");
			}
			catch(Exception ex)
			{
				return Requests.Response(this, new ApiStatus(404), null, ex.Message);
			}
		}
	}
}
