using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Data.Models
{
	[Table("transaction")]
	public class Transaction
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int FieldOwnerId { get; set;}
		public string StartDate { get; set; }
		public string EndDate { get; set; }

		public virtual Customer Customer { get; set; }
		public virtual FieldOwner FieldOwner { get; set; }
		public virtual IEnumerable<TransactionDetail> TransactionDetails { get; set; }
	}
}
