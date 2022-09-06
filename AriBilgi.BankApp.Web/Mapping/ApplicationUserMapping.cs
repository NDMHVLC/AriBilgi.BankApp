using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Data.Interfaces;
using AriBilgi.BankApp.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace AriBilgi.BankApp.Web.Mapping
{
    public class ApplicationUserMapping : IApplicationUserMapping
    {
        private readonly IAccountRepository _accoRepo;
        public ApplicationUserMapping(IAccountRepository accoRepo)
        {
            _accoRepo = accoRepo;
        }

        public ApplicationUserDTO MapToDTO(ApplicationUser applicationUser)
        {
            return new ApplicationUserDTO
            {
                Id = applicationUser.Id,
                Name = applicationUser.Name,
                Surname = applicationUser.Surname,
                AccountCount = _accoRepo.GettAccountCount(applicationUser.Id),
            };
        }

        public List<ApplicationUserDTO> MapToDTOList(List<ApplicationUser> applicationUser)
        {
            return applicationUser.Select(x => new ApplicationUserDTO
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                AccountCount = _accoRepo.GettAccountCount(x.Id),
            }).ToList();
        }
    }
}
