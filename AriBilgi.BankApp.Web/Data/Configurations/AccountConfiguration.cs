﻿using AriBilgi.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AriBilgi.BankApp.Web.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.AccountNo).IsRequired();


            builder.Property(x => x.Balance).IsRequired();
            builder.Property(x => x.Balance).HasColumnType("decimal(18,4)");//kolon tipi
        }
    }
}
