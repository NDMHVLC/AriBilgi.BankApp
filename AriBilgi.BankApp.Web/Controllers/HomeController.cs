using AriBilgi.BankApp.Web.Data.Context;
using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Data.Interfaces;
using AriBilgi.BankApp.Web.Mapping;
using Microsoft.AspNetCore.Mvc;


namespace AriBilgi.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
   
        private readonly IApplicationUserMapping _userMap;
        private readonly IRepository<ApplicationUser> _userRepo;
        public HomeController(IApplicationUserMapping userMap, IRepository<ApplicationUser> userRepo)
        {          
            _userMap = userMap;
            _userRepo = userRepo;
        }
        public IActionResult Index()
        {
            

            return View(_userMap.MapToDTOList(_userRepo.GetAll()));
        }

        public IActionResult CreateUser()
        {

            return View();
        }


        #region HTTPMethods
        [HttpPost]
        public IActionResult AddUser(ApplicationUser user)
        {
            _userRepo.Create(user);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
