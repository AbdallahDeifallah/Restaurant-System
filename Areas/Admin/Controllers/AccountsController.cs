using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Areas.Admin.MVModels;
using Restaurant.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using Microsoft.AspNetCore.Http;
using Restaurant.Areas.Admin.MyClass;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
 
    public class AccountsController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<ApplicationUser> SignInManager { get; }
        AppDbContext db;
        public IClassHelper HelperClass { get; }

        public AccountsController(IClassHelper _HelperClass,UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager , AppDbContext _db)
        {
            db = _db;
            UserManager = userManager;
            SignInManager = signInManager;
            HelperClass = _HelperClass;
        }

        public ActionResult Index()
        {
            var users = UserManager.Users.Select(c => new
            MVAccounts()
            {
                email = c.Email,
                username = c.Dis_Name,
                PassWord = c.PasswordHash,
                user_image = c.User_image,
                id = c.Id
            }).ToList();

            return View(users);
        }

        public ActionResult Edit(string id)
        {
            var master = db.Users.Find(id);

            var data = new MVAccounts
            {
                email = master.Email,
                username = master.Dis_Name,
                PassWord = master.PasswordHash,
                id = master.Id,
                user_image = master.User_image
            };

            return View(data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> Edit(MVAccounts collection)
        {
            string FileName = "";
            FileName = HelperClass.SaveImage(collection.File, "User_img");
            if (FileName == "")
            {
                FileName = collection.user_image;
            }
            if (ModelState.IsValid)
            {
                var user = db.Users.Find(collection.id);

                user.Id = collection.id;
                user.PasswordHash = collection.PassWord;
                user.Email = collection.email;
                user.Dis_Name = collection.username;
                user.User_image = FileName;
                user.PasswordHash = collection.PassWord;


                var result = await UserManager.UpdateAsync(user);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }

          
         
   
        }

        public ActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(MVRegister collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File, "User_img");
                if (ModelState.IsValid)
                {
                    var user = new ApplicationUser
                    {
                        UserName = collection.Email,
                        Email = collection.Email,
                        Dis_Name = collection.UserName,
                        User_image = FileName
                    };
                    var result = await UserManager.CreateAsync(user, collection.PassWord);
                    if (result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction(nameof(Index));
                    }
 
                }
                return View(collection);

            }
            catch
            {
                return View(collection);
            }
        }
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(MVLogin collection)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var result = await SignInManager.PasswordSignInAsync(collection.email, collection.PassWord, isPersistent: false, collection.RememberMe);

                    if (result.Succeeded)
                    {
            /*          var iduser = UserManager.GetUserId(HttpContext.User);
                        ApplicationUser app = UserManager.FindByIdAsync(iduser).Result;
                        TempData["User"] = app;*/

                        return RedirectToAction("Index", "Home");

                    }

                    else
                    {
                        ModelState.AddModelError("", "Error Register");
                    }
                }
                return View(collection);

            }
            catch
            {
                return View(collection);
            }
        }
        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();

            return RedirectToAction("Login");
        }

    }
}
