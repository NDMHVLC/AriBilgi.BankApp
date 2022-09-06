using AriBilgi.BankApp.Web.Data.Entities;

namespace AriBilgi.BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        int GettAccountCount(int UserId);

        void CreateAccount(Account account);
    }
}
