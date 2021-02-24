using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Login
{
	public class Account
	{
		public string Password;
		public string Email;
		public Account(string Email, string Password)
		{
			this.Email = Email;
			this.Password = Password;
		}
	}
}
