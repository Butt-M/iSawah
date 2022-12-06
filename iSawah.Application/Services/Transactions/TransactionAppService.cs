using AutoMapper;
using iSawah.Application.Services.Transactions.Dto;
using iSawah.Data;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Customers
{
	public class TransactionAppService : ITransactionAppService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public TransactionAppService(AppDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public Transaction Create(TransactionDto model)
		{
			var transaction = _mapper.Map<Transaction>(model);
			_context.Transactions.Add(transaction);
			_context.SaveChanges();

			return transaction;
		}

		public Transaction Update(UpdateTransactionDto model)
		{
			var transaction = _mapper.Map<Transaction>(model);
			_context.Transactions.Update(transaction);
			_context.SaveChanges();

			return transaction;
		}
	}
}
