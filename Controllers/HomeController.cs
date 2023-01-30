using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using Restaurant.MVModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Areas.Admin.Controllers;

namespace Restaurant.Components
{

    public class HomeController : Controller
    {
        public IMenuRepositorie Menu { get; }
        public ISystemSettingRepositorie SystemSetting { get; }
        public ISliderRepositorie Slider { get; }
        public ItemMenuRepositorie Items { get; }
        public IOfferRepositorie offer { get; }
        public IPartnerRepositorie Partner { get; }
        public ISocialMediuauRepositorie Meida { get; }
        public ITransactionContactUsRepositorie ITransactionContactUsRepositorie { get; }
        public IOfferRepositorie IOfferRepositorie { get; }
        public IWorkingHourRepositorie MasterWorkingHours { get; }
        public IServiceRepositorie service { get; }
        public ICategoryMenuRepositorie Category{ get; }
      


        public HomeController(ICategoryMenuRepositorie _Category,IServiceRepositorie _service ,IMenuRepositorie _Menu, ISystemSettingRepositorie _SystemSetting, ISliderRepositorie _Slider, ItemMenuRepositorie _Items, IOfferRepositorie _offer, IPartnerRepositorie _Partner, IWorkingHourRepositorie _MasterWorkingHours, ISocialMediuauRepositorie _Meida, ITransactionContactUsRepositorie _ITransactionContactUsRepositorie, IOfferRepositorie _IOfferRepositorie)
        {
             Menu = _Menu;
            SystemSetting = _SystemSetting;
            Slider = _Slider;
            Items = _Items;
            offer = _offer;
            Partner = _Partner;
            MasterWorkingHours = _MasterWorkingHours;
            Meida = _Meida;
            ITransactionContactUsRepositorie = _ITransactionContactUsRepositorie;
            IOfferRepositorie = _IOfferRepositorie;
            service = _service;
            Category = _Category;
        }
        public IActionResult Index()
        {
            var offer_image = IOfferRepositorie.FrontEndView().Where(x => x.IsActive == true && x.IsDelete == 0).Single();

            MV_Front front = new MV_Front
            {
                MasterMenu = Menu.FrontEndView(),
                MasterSliders = Slider.FrontEndView(),
                SystemSetting = SystemSetting.FrontEndView().SingleOrDefault(),
                MasterItemMenu = Items.FrontEndView(),
                MasterOffer = offer.FrontEndView(),
                MasterPartner = Partner.FrontEndView(),
                MasterWorkingHours = MasterWorkingHours.FrontEndView(),
                MasterSocialMedia = Meida.FrontEndView(),
                MasterOffer_img = offer_image.MasterOfferImageUrl

            };


            return View(front);
        }

        public IActionResult About()
        {
            MVAbout front = new MVAbout
            {
                MasterMenu = Menu.FrontEndView(),
                SystemSetting = SystemSetting.FrontEndView().SingleOrDefault(),
                MasterServices = service.FrontEndView(),
                MasterWorkingHours = MasterWorkingHours.FrontEndView(),
                MasterSocialMedia = Meida.FrontEndView()

            };

            return View(front);
        } 
        public IActionResult ContactUs()
        {
            MVContactUs front = new MVContactUs
            {
                MasterMenu = Menu.FrontEndView(),
                SystemSetting = SystemSetting.FrontEndView().SingleOrDefault(),
    
                MasterWorkingHours = MasterWorkingHours.FrontEndView(),
                MasterSocialMedia = Meida.FrontEndView()

            };

            return View(front);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactUs(MVContactUs collection)
        {
            try
            {
                collection.CreateDate = DateTime.Now;
                collection.CreateId = "1";//HttpContext.Session.GetString("UserId");
                collection.IsActive = true;

                TransactionContactUs obj = new TransactionContactUs
                {
                    TransactionContactUsEmail=collection.TransactionContactUsEmail,
                    TransactionContactUsFullName = collection.TransactionContactUsFullName,
                    TransactionContactUsId = collection.TransactionContactUsId,
                    TransactionContactUsMessage = collection.TransactionContactUsMessage,
                    TransactionContactUsSubject=collection.TransactionContactUsSubject



                };
                ITransactionContactUsRepositorie.Add(obj);
                return RedirectToAction(nameof(Index),"Home");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult MENU()
        {
            MVMenu front = new MVMenu
            {
                MasterMenu = Menu.FrontEndView(),
                SystemSetting = SystemSetting.FrontEndView().SingleOrDefault(),
                MasterWorkingHours = MasterWorkingHours.FrontEndView(),
                MasterSocialMedia = Meida.FrontEndView(),
                MasterCategoryMenu = Category.FrontEndView(),
                MasterItemMenu = Items.FrontEndView(),
                MasterPartner = Partner.FrontEndView(),

            };

            return View(front);
        }

        public IActionResult GetItems(int id)
        {
            List<MasterItemMenu> data;
            if (id == 0)
            {
                 data = Items.View();

            }
            else
            {
                 data = Items.FrontEndView().Where(x => x.MasterCategoryMenuId == id && x.IsDelete == 0 && x.IsActive == true).ToList();

            }

            MV_Front data_id = new MV_Front
            {
                MasterMenu = Menu.FrontEndView(),
                SystemSetting = SystemSetting.FrontEndView().SingleOrDefault(),
                MasterWorkingHours = MasterWorkingHours.FrontEndView(),
                MasterSocialMedia = Meida.FrontEndView(),
                MasterCategoryMenu = Category.FrontEndView(),
                MasterItemMenu = data,
            };
            return View("Menu", data_id);
        }

    }
}
