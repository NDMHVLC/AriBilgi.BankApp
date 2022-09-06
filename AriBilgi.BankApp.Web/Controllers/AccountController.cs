using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Data.Interfaces;
using AriBilgi.BankApp.Web.Mapping;
using AriBilgi.BankApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AriBilgi.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepository<ApplicationUser> _userRepo;
        private readonly IRepository<Account> _accoRepo;
        private readonly IApplicationUserMapping _userMapp;
        public AccountController( IApplicationUserMapping userMapp, IRepository<ApplicationUser> userRepo, IRepository<Account> accoRepo)
        {
            _userMapp = userMapp;
            _userRepo = userRepo;
            _accoRepo = accoRepo;
        }
        public IActionResult Index(int UserId)
        {
            ApplicationUserDTO dto = _userMapp.MapToDTO(_userRepo.GetById(UserId));
            dto.AccountList = _accoRepo.GetAll(x=>x.ApplicationUserId == UserId);

            return View(dto);
        }

        #region HTTP Methods
        [HttpPost]
        public IActionResult Create(Account account)
        {

            _accoRepo.Create(account);
            return RedirectToAction("Index","Home");
        }


        #endregion
    }
}
