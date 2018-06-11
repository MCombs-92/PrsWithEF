using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEF {
	public class Vendor {

		public int Id { get; set; }

		[Required]
		[Index(IsUnique = true)]
		[StringLength(30)]
		public string Code { get; set; }

		[Required]
		[StringLength(30)]
		public string Name { get; set; }

		[Required]
		[StringLength(255)]
		public string Address { get; set; }

		[Required]
		[StringLength(255)]
		public string City { get; set; }

		[Required]
		[StringLength(2)]
		public string State { get; set; }

		[Required]
		[StringLength(5)]
		public string Zip { get; set; }

		[Required]
		[StringLength(12)]
		public string Phone { get; set; }

		[Required]
		[StringLength(255)]
		public string Email { get; set; }

		[Required]
		public bool IsPreApproved { get; set; }

		[Required]
		public bool Active { get; set; }

		public Vendor() {

		}


	}
}
