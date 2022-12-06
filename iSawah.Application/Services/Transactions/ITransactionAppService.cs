using iSawah.Application.Services.Transactions.Dto;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Customers
{
	public interface ITransactionAppService
	{
		Transaction Create(TransactionDto model);
		Transaction Update(UpdateTransactionDto model);
	}
}
