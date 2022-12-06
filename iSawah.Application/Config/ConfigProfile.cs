using AutoMapper;
using iSawah.Application.Services.Customers.Dto;
using iSawah.Application.Services.Distributors.Dto;
using iSawah.Application.Services.Fields.Dto;
using iSawah.Application.Services.Transactions.Dto;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Config
{
	public class ConfigProfile: Profile
	{
		public ConfigProfile()
		{
			// Customer
			CreateMap<CustomerDto, Customer>();
			CreateMap<Customer, CustomerDto>();

			CreateMap<Customer, UpdateCustomerDto>();
			CreateMap<UpdateCustomerDto, Customer>();

			// Field Owner
			CreateMap<FieldOwner, OwnerDto>();
			CreateMap<OwnerDto, FieldOwner>();

			CreateMap<UpdateOwnerDto, FieldOwner>();
			CreateMap<FieldOwner, UpdateOwnerDto>();

			// Field
			CreateMap<Field, FieldDto>();
			CreateMap<FieldDto, Field>();

			CreateMap<Field, UpdateFieldDto>();
			CreateMap<UpdateFieldDto, Field>();

			// Transaction
			CreateMap<Transaction, TransactionDto>();
			CreateMap<TransactionDto, Transaction>();

			CreateMap<Transaction, UpdateTransactionDto>();
			CreateMap<UpdateTransactionDto, Transaction>();
		}
	}
}
