using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.Transactions.Dto
{
	public class UpdateTransactionDto
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int FieldOwnerId { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
	}
}
