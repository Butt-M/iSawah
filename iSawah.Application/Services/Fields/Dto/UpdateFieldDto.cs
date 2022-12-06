using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Fields.Dto
{
	public class UpdateFieldDto
	{
		public int Id { get; set; }
		public string Code { get; set; }
		public string Type { get; set; }
		public int? StatusId { get; set; }
	}
}
