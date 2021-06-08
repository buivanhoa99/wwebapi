using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly TodoContext _context;
        private readonly IJWTService _JWT;
        public AccountService(TodoContext context, IJWTService jwt)
        {
            _context = context;
            this._JWT = jwt;
        }

        public List<Account> GetAllAccounts()
        {
            return _context.Accounts.ToList<Account>();
        }

        public bool Login(string username, string password)
        {
            var myAccount  = _context.Accounts.First<Account>(x => x.Username == username && x.Password == password);
            if (myAccount != null)
            {
                Console.WriteLine(myAccount.Username, myAccount.Password);
                return true;
            }
            return false;
        }

        public bool Register(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
            return true;
        }
    }
}
