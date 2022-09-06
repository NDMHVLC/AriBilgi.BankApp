using AriBilgi.BankApp.Web.Data.Entities;
using AriBilgi.BankApp.Web.Models;
using System.Collections.Generic;

namespace AriBilgi.BankApp.Web.Mapping
{
    public interface IApplicationUserMapping
    {
        List<ApplicationUserDTO> MapToDTOList(List<ApplicationUser> applicationUser);
        ApplicationUserDTO MapToDTO(ApplicationUser applicationUser);
    }
}
