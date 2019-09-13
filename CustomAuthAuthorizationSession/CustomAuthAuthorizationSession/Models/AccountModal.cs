using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthAuthorizationSession.Models
{
    public class AccountModal
    {
        private List<Account> listAccounts = new List<Account>();

        public AccountModal()
        {
            listAccounts.Add(new Account
            {
                Username = "san",
                Password = "san",
                Roles = new string[] { "superadmin", "admin", "employee" }
            });

            listAccounts.Add(new Account
            {
                Username = "san2",
                Password = "san2",
                Roles = new string[] { "admin", "employee" }
            });

            listAccounts.Add(new Account
            {
                Username = "san3",
                Password = "san3",
                Roles = new string[] {"employee"}
            });
        }

        public Account find(string username)
        {
            return listAccounts.Single(acc => acc.Username.Equals(username));
        }

        public Account login(string username, string password)
        {
            return listAccounts.Where(acc => acc.Username.Equals(username)&&acc.Password.Equals(password)).FirstOrDefault();
        }
    }
}