using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Data.Models
{
	[Table("field_owner")]
	public class FieldOwner
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public int? FieldId { get; set; }

		public virtual Field Fields { get; set; }
		public virtual IEnumerable<Transaction> Transactions { get; set; }
	}
}
