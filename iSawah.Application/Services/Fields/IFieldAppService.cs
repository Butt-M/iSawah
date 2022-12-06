using iSawah.Application.Helper;
using iSawah.Application.Services.Fields.Dto;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Fields
{
	public interface IFieldAppService
	{
		Field Create(FieldDto model);
		Field Update(UpdateFieldDto model);
		Field Delete(int id);
		PagedResult<FieldListDto> GetAllField(PageInfo pageInfo);
	}
}
