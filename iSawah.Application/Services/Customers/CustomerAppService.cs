using AutoMapper;
using iSawah.Application.Services.Customers.Dto;
using iSawah.Data;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Customers
{
    public class CustomerAppService : ICustomerAppService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public CustomerAppService(AppDbContext context, IMapper mapper)
		{
			_context= context;
			_mapper= mapper;
		}
		
		public Customer Create(CustomerDto model)
		{
			var customer = _mapper.Map<Customer>(model);
			_context.Customers.Add(customer);
			_context.SaveChanges();

			return customer;
		}

		public Customer Update(UpdateCustomerDto model)
		{
			var customer = _mapper.Map<Customer>(model);
			_context.Customers.Update(customer);
			_context.SaveChanges();

			return customer;
		}
	}
}
