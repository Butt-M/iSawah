using iSawah.Application.Services.Distributors.Dto;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Distributors
{
	public interface IOwnerAppService
	{
		FieldOwner Create(OwnerDto model);
		FieldOwner Update(UpdateOwnerDto model);
	}
}
