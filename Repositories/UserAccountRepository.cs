using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;

        public UserAccount GetAccount(string email)
        {
            _context = new();
            if(_context.UserAccounts.FirstOrDefault(r => r.Email == email) == null)
            {
                return _context.UserAccounts.First();
            }
            return _context.UserAccounts.FirstOrDefault(r => r.Email == email);
        }
    }
}
