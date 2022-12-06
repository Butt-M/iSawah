using iSawah.Application.Helper;
using iSawah.Application.Models;
using iSawah.Application.Services.TransactionDetails;
using iSawah.Application.Services.TransactionDetails.Dto;
using Microsoft.AspNetCore.Mvc;

namespace iSawah.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TransactionDetailsController : Controller
	{
		private ITransactionDetailAppService _transactionDetailAppService;
		public TransactionDetailsController(ITransactionDetailAppService transactionDetailAppService)
		{
			_transactionDetailAppService = transactionDetailAppService;
		}

		[HttpGet("GetAllDetails")]
		[Produces("application/json")]
		public IActionResult GetAllDetails([FromQuery] PageInfo pageInfo)
		{
			try
			{
				var details = _transactionDetailAppService.GetAllTransactions(pageInfo);
				return Requests.Response(this, new ApiStatus(200), details, "");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(404), null, ex.Message);
			}
		}
	}
}
