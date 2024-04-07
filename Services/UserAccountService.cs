using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserAccountService
    {
        private UserAccountRepository _uar = new();
        public UserAccount CheckLogin(string email)
        {
            return _uar.GetAccount(email);
        }
    }
}
