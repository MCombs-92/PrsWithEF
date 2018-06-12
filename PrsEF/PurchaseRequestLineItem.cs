using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEF {
	public class PurchaseRequestLineItem {

		public int Id { get; set; }

		[Required]
		public int PurchaseRequestId { get; set; }

		[Required]
		public int ProductId { get; set; }

		[Required]
		public int Quantity { get; set; }
		
		public virtual PurchaseRequest PurchaseRequest { get; set; }
		public virtual Product Product { get; set; }

		public PurchaseRequestLineItem() {

		}

	}
}
