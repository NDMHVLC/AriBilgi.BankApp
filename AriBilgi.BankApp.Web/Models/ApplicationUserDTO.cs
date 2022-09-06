using AriBilgi.BankApp.Web.Data.Entities;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace AriBilgi.BankApp.Web.Models
{
    public class ApplicationUserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AccountCount { get; set; }

        public List<Account> AccountList { get; set; } = new();

    }
}
