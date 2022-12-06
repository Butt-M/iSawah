using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Distributors.Dto
{
	public class UpdateOwnerDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public int? FieldId { get; set; }
	}
}
