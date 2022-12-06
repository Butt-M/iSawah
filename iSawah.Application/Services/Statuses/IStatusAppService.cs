using iSawah.Application.Services.Statuses.Dto;
using iSawah.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Statuses
{
	public interface IStatusAppService
	{
		Status Create(StatusDto model);
		Status Update(UpdateStatusDto model);
	}
}
