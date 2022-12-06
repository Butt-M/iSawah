using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Application.Services.TransactionDetails.Dto
{
	public class TransactionDetailDto
	{
		public int TransactionId { get; set; }
		public string CustomerName { get; set; }
		public int Total { get; set; }
		public string StartDate { get; set; }
		public string EndDate { get; set; }
	}
}
