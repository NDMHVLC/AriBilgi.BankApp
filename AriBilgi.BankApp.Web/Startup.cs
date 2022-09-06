using AriBilgi.BankApp.Web.Data.Context;
using AriBilgi.BankApp.Web.Data.Interfaces;
using AriBilgi.BankApp.Web.Data.Repositories;
using AriBilgi.BankApp.Web.Mapping;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AriBilgi.BankApp.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddControllersWithViews();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IApplicationUserMapping, ApplicationUserMapping>();
            



            services.AddDbContext<BankContext>(options =>
            {
                options.UseSqlServer(@"Server=NED\NED; Database=BankAppDB; Trusted_Connection=True;");
            });

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
