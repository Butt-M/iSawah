using iSawah.Application.Helper;
using iSawah.Application.Models;
using iSawah.Application.Services.Customers;
using iSawah.Application.Services.Transactions.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace iSawah.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransactionController : Controller
	{				
		private readonly ITransactionAppService _transactionAppService;
		public TransactionController(ITransactionAppService transactionAppService)
		{
			_transactionAppService= transactionAppService;
		}
				
		[HttpPost("Create")]
		[Produces("application/json")]
		[ValidateAntiForgeryToken]
		public IActionResult Create([FromBody] TransactionDto model)
		{
			try
			{
				var trans = _transactionAppService.Create(model);
				if (trans == null)
				{
					return Requests.Response(this, new ApiStatus(406), trans, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), trans, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}		

		
		[HttpPatch("Edit")]
		[ValidateAntiForgeryToken]
		public IActionResult Edit([FromBody] UpdateTransactionDto model)
		{
			try
			{
				var trans = _transactionAppService.Update(model);
				if (trans == null)
				{
					return Requests.Response(this, new ApiStatus(406), trans, "error");
				}
				return Requests.Response(this, new ApiStatus(200), trans, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}
	}
}
