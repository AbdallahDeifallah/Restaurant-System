using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Areas.Admin.MVModels;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]

    public class HomeController : Controller
    {
        public ItemMenuRepositorie Item { get; }
        public ISliderRepositorie slider { get; }
        public ITransactionBookTableRepositorie bookTable { get; }
        public ITransactionContactUsRepositorie ContactUs { get; }
        public IPartnerRepositorie Partner { get; }
        public IServiceRepositorie Service{ get; }
        public UserManager<ApplicationUser> UserManager { get; }
        public HomeController(UserManager<ApplicationUser> _UserManager, IServiceRepositorie _Service,IPartnerRepositorie _Partner, ISliderRepositorie _slider, ItemMenuRepositorie _Item, ITransactionBookTableRepositorie _bookTable, ITransactionContactUsRepositorie _ContactUs)
        {
            Item = _Item;
            slider = _slider;
            bookTable = _bookTable;
            ContactUs = _ContactUs;
            Partner = _Partner;
            Service = _Service;
            UserManager = _UserManager;
        }
        public IActionResult Index()
        {
            var userid = UserManager.GetUserId(HttpContext.User);
            ApplicationUser user = UserManager.FindByIdAsync(userid).Result;

            MVHome data = new MVHome
            {
                Items = Item.View().Count(),
                Sliders = slider.View().Count(),
                bookTables = bookTable.View().Count(),
                ContactUs = ContactUs.View().Count(),
                Partners = Partner.View().Count(),
                Services = Service.View().Count(),
                ApplicationUser = user


            };
            return View(data);
        }
    }
}
