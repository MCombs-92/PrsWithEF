using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrsEF {
	public class UsersController {

		public UsersController() {

		}

		private PrsDbContext db = new PrsDbContext();

		public IEnumerable<User> list()  {
			return db.Users.ToList();

		}

		public User Get (int? id) {
			if (id == null) {
				return null;
			}

			return db.Users.Find(id);
		}

		public bool Create(User user) {
			if(user == null) {
				return false;
			}

			db.Users.Add(user);
			db.SaveChanges();
			return true;
		}

		public bool Change(User user) {
			if (user == null) {
				return false;
			}

			User aUser = Get(user.Id);
			if(aUser == null) {
				return false;
			}

			aUser.Username = user.Username;
			aUser.Password = user.Password;
			aUser.FirstName = user.FirstName;
			aUser.LastName = user.LastName;
			aUser.Phone = user.Phone;
			aUser.Email = user.Email;
			aUser.IsReviewer = user.IsReviewer;
			aUser.IsAdmin = user.IsAdmin;
			aUser.Active = user.Active;
			db.SaveChanges();
			return true;
		}

		public bool Remove(User user) {
			if (user == null) {
				return false;
			}

			User aUser = Get(user.Id);
			if (aUser == null) {
				return false;
			}

			db.Users.Remove(user);
			db.SaveChanges();
			return true;
		}

	}
}
