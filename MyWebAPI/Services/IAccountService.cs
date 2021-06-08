using MyWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPI.Services
{
    public interface IAccountService
    {
        bool Login(string username, string password);
        List<Account> GetAllAccounts();

        bool Register(Account account);
    }
}
