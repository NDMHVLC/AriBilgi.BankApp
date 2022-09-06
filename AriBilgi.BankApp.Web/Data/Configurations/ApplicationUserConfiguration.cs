using AriBilgi.BankApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AriBilgi.BankApp.Web.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(x => x.Name).IsRequired(); //IsRequired = Boş geçilemez 
            builder.Property(x => x.Name).HasMaxLength(200); // HasMaxLength = Max Karakter Sayısı


            builder.Property(x => x.Surname).IsRequired(); //IsRequired = Boş geçilemez 
            builder.Property(x => x.Surname).HasMaxLength(250);// HasMaxLength = Max Karakter Sayısı


            builder.HasMany(x => x.Accounts).WithOne(x => x.ApplicationUser).HasForeignKey(x => x.ApplicationUserId);

            //HasMoney = birden fazla accounts sahiptir 
            //WithOne = bir applicationUser
            //HasForeignKey = applicationUserId üzerinden
        }
    }
}
