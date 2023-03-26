using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HospitalManagemetSystem.MVVM.Model.Authentication
{
	public class User
	{
		public User(string userName, string password, bool isSuperUser)
		{
			this.userName = userName;
			this.password = password;
			IsSuperUser = isSuperUser;
		}

		public string userName { get; set; }
		public string password { get; set; }
		public bool IsSuperUser { get; set; }
	}
}
