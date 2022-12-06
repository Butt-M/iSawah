using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSawah.Data.Models
{
	[Table("fields")]
	public class Field
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
		public int Id { get; set; }
		public string Code { get; set; }
		public string Type { get; set; }
		public int? StatusId { get; set; }

		public virtual ICollection<FieldOwner> FieldOwner { get; set; }
		public virtual Status Status { get; set; }

	}
}
