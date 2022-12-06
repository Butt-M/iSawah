using iSawah.Application.Helper;
using iSawah.Application.Models;
using iSawah.Application.Services.Fields;
using iSawah.Application.Services.Fields.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iSawah.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FieldController : Controller
	{
		private readonly IFieldAppService _fieldAppService;
		public FieldController(IFieldAppService fieldAppService)
		{
			_fieldAppService= fieldAppService;
		}

		[HttpGet("GetAllField")]
		[Produces("application/json")]
		public IActionResult GetAllField([FromQuery] PageInfo pageInfo)
		{
			try
			{
				var fieldList = _fieldAppService.GetAllField(pageInfo);
				return Requests.Response(this, new ApiStatus(200), fieldList, "");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(404), null, ex.Message);
			}
		}

		[HttpPost("Create")]
		public IActionResult Create([FromBody] FieldDto model)
		{
			try
			{
				var field = _fieldAppService.Create(model); 
				if (field == null)
				{
					return Requests.Response(this, new ApiStatus(406), field, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), field, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}

		[HttpPatch("Edit")]
		public IActionResult Edit([FromBody] UpdateFieldDto model)
		{
			try
			{
				var field = _fieldAppService.Update(model);
				if (field == null)
				{
					return Requests.Response(this, new ApiStatus(406), field, "error");
				}
				return Requests.Response(this, new ApiStatus(200), field, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}
		
		[HttpDelete("Delete")]
		public IActionResult Delete(int id)
		{
			try
			{
				var field = _fieldAppService.Delete(id);
				if (field == null)
				{
					return Requests.Response(this, new ApiStatus(406), field, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), field, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}	
	}
}
