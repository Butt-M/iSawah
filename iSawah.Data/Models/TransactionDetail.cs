using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Data.Models
{
	[Table("transaction_detail")]
	public class TransactionDetail
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int TransactionId { get; set; }
		public int Total { get; set; }

		public virtual Transaction Transaction { get; set; }
	}
}
