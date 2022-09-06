using AriBilgi.BankApp.Web.Data.Context;
using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Data.Interfaces;
using System.Linq;

namespace AriBilgi.BankApp.Web.Data.Repositories
{
    public class AccountRepository :IAccountRepository
    {
        private readonly BankContext _context;
        public AccountRepository(BankContext context)
        {
            _context = context;
        }

        public void CreateAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public int GettAccountCount(int UserId)
        {

            return _context.Accounts.Count(x=> x.ApplicationUserId == UserId);
        }
    }
}
