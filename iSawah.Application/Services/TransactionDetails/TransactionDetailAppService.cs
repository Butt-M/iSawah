using AutoMapper;
using iSawah.Application.Helper;
using iSawah.Application.Services.TransactionDetails.Dto;
using iSawah.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.TransactionDetails
{
	public class TransactionDetailAppService : ITransactionDetailAppService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public TransactionDetailAppService(AppDbContext context, IMapper mapper)
		{
			_context= context;
			_mapper= mapper;
		}

		public PagedResult<TransactionDetailDto> GetAllTransactions(PageInfo pageInfo)
		{
			var pagedResult = new PagedResult<TransactionDetailDto>
			{
				Data = (from detail in _context.TransactionDetails
						join transaction in _context.Transactions
						on detail.TransactionId equals transaction.Id
						select new TransactionDetailDto
						{
							TransactionId = transaction.Id,
							CustomerName = transaction.Customer.Name,
							StartDate= transaction.StartDate,
							EndDate= transaction.EndDate
						}).Skip(pageInfo.Skip)
						.Take(pageInfo.PageSize)
						.OrderBy(w => w.EndDate),
				Total = _context.TransactionDetails.Count()
			};

			return pagedResult;
		}
	}
}
