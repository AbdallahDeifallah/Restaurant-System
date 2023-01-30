using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Restaurant.Areas.Admin.MyClass;
using Restaurant.MyClass;

namespace Restaurant
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(x => x.EnableEndpointRouting = false);

            services.AddScoped<IClassHelper, HelperClass>();
            services.AddScoped<ICategoryMenuRepositorie, CategoryMenuRepositorie>();
            services.AddScoped<ItemMenuRepositorie, ItemMenuRepositorie>();
            services.AddScoped<IMenuRepositorie, MenuRepositorie>();
            services.AddScoped<IOfferRepositorie, OfferRepositorie>();
            services.AddScoped<IPartnerRepositorie, PartnerRepositorie>();
            services.AddScoped<IServiceRepositorie, ServiceRepositorie>();
            services.AddScoped<ISliderRepositorie, MasterSliderRepositorie>();
            services.AddScoped<ISocialMediuauRepositorie, SocialMediuauRepositorie>();
            services.AddScoped<ISystemSettingRepositorie, SystemSettingRepositorie>();
            services.AddScoped<ITransactionBookTableRepositorie, TransactionBookTableRepositorie>();
            services.AddScoped<ITransactionContactUsRepositorie, TransactionContactUsRepositorie>();
            services.AddScoped<ITransactionNewsletterRepositorie, TransactionNewsletterRepositorie>();
            services.AddScoped<IWorkingHourRepositorie, WorkingHourRepositorie>();
            services.AddDbContext<AppDbContext>(x =>
            {

                x.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
            });

            services.AddDistributedMemoryCache();
            services.AddSession();


            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.ConfigureApplicationCookie(options =>
            {
                //options here

                options.LoginPath = "/Admin/Accounts/Login";

                //...
            });
            services.Configure<IdentityOptions>(x =>
            {

                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 3;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireUppercase = false;


            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();


            //Category/Index/
            //app.UseAuthentication();
            //app.UseAuthorization();
            //app.UseMvcWithDefaultRoute();
            //app.UseSession();


            app.UseRouting();
            app.UseMvc();

            app.UseHttpsRedirection();
            //app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseStaticFiles();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapControllerRoute(
                //    name: "areas", // first char is small
                //    pattern: "{area=exists}/{controller=Home}/{action=Index}/{id?}" // area the rout in controller
                //);
                // endpoints.MapControllerRoute(
                //     name: "default",
                //     pattern: "{controller=Home}/{action=Index}/{id?}"
                // );


                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Accounts}/{action=Login}/{id?}"

                   );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=index}/{id?}"

                    );

            });


            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
