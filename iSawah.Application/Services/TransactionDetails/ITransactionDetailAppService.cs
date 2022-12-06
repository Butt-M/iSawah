using iSawah.Application.Helper;
using iSawah.Application.Services.TransactionDetails.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.TransactionDetails
{
	public interface ITransactionDetailAppService
	{
		PagedResult<TransactionDetailDto> GetAllTransactions(PageInfo pageInfo);
	}
}
