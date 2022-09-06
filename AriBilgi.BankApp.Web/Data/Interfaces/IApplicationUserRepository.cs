using AriBilgi.BankApp.Web.Data.Entities;
using System.Collections.Generic;

namespace AriBilgi.BankApp.Web.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int Id);
    }
}
