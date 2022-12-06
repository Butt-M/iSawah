using AutoMapper;
using iSawah.Application.Services.Customers.Dto;
using iSawah.Application.Services.Distributors.Dto;
using iSawah.Data;
using iSawah.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Distributors
{
	public class OwnerAppService : IOwnerAppService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;
		public OwnerAppService(AppDbContext context, IMapper mapper)
		{
			_context= context;
			_mapper= mapper;
		}

		public FieldOwner Create(OwnerDto model)
		{
			var owner = _mapper.Map<FieldOwner>(model);
			_context.FieldOwners.Add(owner);
			_context.SaveChanges();

			return owner;
		}

		public FieldOwner Update(UpdateOwnerDto model)
		{
			var owner = _mapper.Map<FieldOwner>(model);
			_context.FieldOwners.Update(owner);
			_context.SaveChanges();

			return owner;
		}
	}
}
