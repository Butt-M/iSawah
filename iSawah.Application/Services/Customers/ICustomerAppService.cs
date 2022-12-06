using iSawah.Application.Services.Customers.Dto;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Customers
{
	public interface ICustomerAppService
	{ 

		Customer Create(CustomerDto model);
		Customer Update(UpdateCustomerDto model);
	}
}
