using AutoMapper;
using iSawah.Application.Helper;
using iSawah.Application.Services.Fields.Dto;
using iSawah.Data;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Fields
{
	public class FieldAppService : IFieldAppService
	{
		private readonly AppDbContext _context;
		private readonly IMapper _mapper;

		public FieldAppService(AppDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public Field Create(FieldDto model)
		{
			var field = _mapper.Map<Field>(model);
			_context.Fields.Add(field);
			_context.SaveChanges();

			return field;
		}

		public Field Delete(int id)
		{
			var field = _context.Fields.FirstOrDefault(w => w.Id == id);
			_context.Fields.Remove(field);
			_context.SaveChanges();

			return field;
		}

		public PagedResult<FieldListDto> GetAllField(PageInfo pageInfo)
		{
			var pagedResult = new PagedResult<FieldListDto>
			{
				Data = (from field in _context.Fields
				join owner in _context.FieldOwners
				on field.Id equals owner.FieldId
				join status in _context.Statuses
				on field.StatusId equals status.Id
				select new FieldListDto
				{
					Code= field.Code,
					OwnerName= owner.Name,
					FieldType= field.Type,
					FieldStatus= status.FieldStatus
				}).Skip(pageInfo.Skip)
				.Take(pageInfo.PageSize)
				.OrderBy(w => w.Code),
				Total = _context.Fields.Count()
			};	

			return pagedResult;
		}

		public Field Update(UpdateFieldDto model)
		{
			var field = _mapper.Map<Field>(model);
			_context.Fields.Update(field);
			_context.SaveChanges();

			return field;
		}
	}
}
