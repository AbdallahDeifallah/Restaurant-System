using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models.Repositories;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Areas.Admin.MVModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Restaurant.Areas.Admin.Components
{
    [Area("Admin")]
 
        public class MasterMenuComponent : ViewComponent

        {
        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<ApplicationUser> SignInManager { get; }
        AppDbContext db;
        public MasterMenuComponent(AppDbContext _db, UserManager<ApplicationUser> _UserManager,SignInManager<ApplicationUser> _SignInManager)
            {
                db = _db;
                UserManager  = _UserManager;
                 SignInManager = _SignInManager;
            }
            public IViewComponentResult Invoke()
            {

            if (User.Identity.IsAuthenticated)
            {
                var iduser = UserManager.GetUserId(HttpContext.User);
                ApplicationUser app = UserManager.FindByIdAsync(iduser).Result;

                var data = new MVAccounts
                {
                    email = app.Email,
                    username = app.Dis_Name,
                    PassWord = app.PasswordHash,
                    id = app.Id,
                    user_image = app.User_image
                };
                return View(data);

            }
            else
            {
                return View("Login","Home");
            }
 
            }
     
    
}
}
