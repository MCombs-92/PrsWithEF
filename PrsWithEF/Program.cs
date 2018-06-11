using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrsEF;

namespace PrsWithEF {
	class Program {
		static private PrsDbContext db = new PrsDbContext();

		static void Main(string[] args) {
			List<User> users = db.Users.ToList();
			User user = db.Users.Find(1);
			User user1 = db.Users.Find(111);

			User adduser = new User {
				Username = "Mcombs92",
				Password = "Pawww0rd",
				FirstName = "Mitch",
				LastName = "Combs",
				Phone = "513-501-2449",
				Email = "mitch92@gmail.com",
				IsReviewer = true,
				IsAdmin = true,
				Active = true
			};

			User addeduser = db.Users.Add(adduser);
			db.SaveChanges();

			//db.Users.Remove(addeduser);
			//db.SaveChanges();

			//User user2 = db.Users.SingleOrDefault(u=> u.Email =="mitch@gmail.com");
			//user2.IsAdmin = false;
			//db.SaveChanges();
		}
	}
}
