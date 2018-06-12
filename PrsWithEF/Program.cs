using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrsEF;

namespace PrsWithEF {
	class Program {
		static private PrsDbContext db = new PrsDbContext();

		public void CalcPrTotal() {

			var prid = db.PurchaseRequests.SingleOrDefault(prs => prs.Id == 2).Id;
			var total = db.PurchaseRequestLineItems.Where(pl => pl.PurchaseRequest.Id == prid).Sum(li => li.Product.Price * li.Quantity);
			var pr = db.PurchaseRequests.SingleOrDefault(p => p.Id == prid);
			db.SaveChanges();

		}

		static void Main(string[] args) {
			(new Program()).CalcPrTotal();
		}

		static void Run() { 
			//List<User> users = db.Users.ToList();
			//User user = db.Users.Find(1);
			//User user1 = db.Users.Find(111);

			//User adduser = new User {
			//	Username = "Mcombs92",
			//	Password = "Pawww0rd",
			//	FirstName = "Mitch",
			//	LastName = "Combs",
			//	Phone = "513-501-2449",
			//	Email = "mitch92@gmail.com",
			//	IsReviewer = true,
			//	IsAdmin = true,
			//	Active = true
			//};

			//User addeduser = db.Users.Add(adduser);
			//db.SaveChanges();

			//db.Users.Remove(addeduser);
			//db.SaveChanges();

			//User user2 = db.Users.SingleOrDefault(u=> u.Email =="mitch@gmail.com");
			//user2.IsAdmin = false;
			//db.SaveChanges();

			//var pr = new PurchaseRequest {
			//	Description = "New Purchase Request",
			//	DeliveryMode = "Pickup",
			//	Status = "NEW",
			//	UserId = db.Users.SingleOrDefault(u => u.Username == "Mcombs92").Id
			//};

			//var addpr = db.PurchaseRequests.Add(pr);
			//db.SaveChanges();

			//var vendor = new Vendor {
			//	Code = "TAR",
			//	Name = "Target",
			//	Address = "123 Main",
			//	City = "Cincinnati",
			//	State = "OH",
			//	Zip = "45002",
			//	Phone = "5130000001",
			//	Email = "Target@gmail.com",
			//	IsPreApproved = true,
			//	Active = true
			//};
			//db.Vendors.Add(vendor);
			//db.SaveChanges();

			//var Product = new Product {
			//	PartNumber = "923-887-0978",
			//	Name = "Microsoft Office",
			//	Price = 199.99,
			//	Unit = "Each",
			//	VendorId = db.Vendors.SingleOrDefault(u => u.Code == "TAR").Id
			//};
			//db.Products.Add(Product);
			//db.SaveChanges();

			//var prli = new PurchaseRequestLineItem {
			//	ProductId = db.Products.Find(4).Id,
			//	PurchaseRequestId = db.PurchaseRequests.Find(3).Id,
			//	Quantity = 9
			//};
			//db.PurchaseRequestLineItems.Add(prli);
			//db.SaveChanges();


		}
	}
}
