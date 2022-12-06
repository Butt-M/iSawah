using AutoMapper;
using iSawah.Application.Services.Statuses.Dto;
using iSawah.Data;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Statuses
{
	public class StatusAppService : IStatusAppService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;
		public StatusAppService(AppDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public Status Create(StatusDto model)
		{
			var status = _mapper.Map<Status>(model);
			_context.Statuses.Add(status);
			_context.SaveChanges();

			return status;
		}

		public Status Update(UpdateStatusDto model)
		{
			var status = _mapper.Map<Status>(model);
			_context.Statuses.Update(status);
			_context.SaveChanges();

			return status;
		}
	}
}
