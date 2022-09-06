using AriBilgi.BankApp.Web.Data.Context;
using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AriBilgi.BankApp.Web.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly BankContext _context;
        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }
        public List<ApplicationUser> GetAll()
        {

            return _context.ApplicationUsers.ToList();
        }

        public ApplicationUser GetById(int Id)
        {

            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == Id);
        }
    }
}
