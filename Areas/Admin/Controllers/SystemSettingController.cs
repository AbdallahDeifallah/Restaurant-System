using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Areas.Admin.MVModels;
using Restaurant.Areas.Admin.MyClass;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]

    public class SystemSettingController : Controller
    {

        public ISystemSettingRepositorie system { get; }
        public IClassHelper HelperClass { get; }
        public SystemSettingController(ISystemSettingRepositorie _system, IClassHelper _HelperClass)
        {
            system = _system;
            HelperClass = _HelperClass;
        }
        // GET: SystemSettingController
        public ActionResult Index()
        {
            var data = system.View();
            return View(data);
        }

        // GET: SystemSettingController/Details/5
        public ActionResult Details(int id)
        {
            var sy = system.Find(id);
            MVSystemSetting data = new MVSystemSetting
            {
                SystemSettingCopyright = sy.SystemSettingCopyright,
                SystemSettingLogoImageUrl = sy.SystemSettingLogoImageUrl,
                SystemSettingLogoImageUrl2 = sy.SystemSettingLogoImageUrl2,
                SystemSettingMapLocation = sy.SystemSettingMapLocation,
                SystemSettingWelcomeNoteBreef = sy.SystemSettingWelcomeNoteBreef,
                SystemSettingWelcomeNoteDesc = sy.SystemSettingWelcomeNoteDesc,
                SystemSettingWelcomeNoteImageUrl = sy.SystemSettingWelcomeNoteImageUrl,
                SystemSettingWelcomeNoteTitle = sy.SystemSettingWelcomeNoteTitle,
                SystemSettingWelcomeNoteUrl = sy.SystemSettingWelcomeNoteUrl,
                CreateDate = sy.CreateDate,
                CreateId = sy.CreateId,
                EditDate = sy.EditDate,
                EditId = sy.EditId,
                IsActive = sy.IsActive,
                SystemSettingId = sy.SystemSettingId
            };
            return View(data);
        }

        // GET: SystemSettingController/Create
        public ActionResult Create()
        {
            MVSystemSetting data = new MVSystemSetting
            {
                SystemSettings = system.View()
            };
            return View(data);
        }

        // POST: SystemSettingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVSystemSetting collection)
        {
            try
            {
                Random rd = new Random();
                string FileName1, FileName2, FileName3 = "";
                FileName1 = HelperClass.SaveImage(collection.File_logo1, "System_img");
                FileName2 = HelperClass.SaveImage(collection.File_logo2, "System_img");
                FileName3 = HelperClass.SaveImage(collection.File_Welcome, "System_img");

                
                SystemSetting master = new SystemSetting
                {
                    SystemSettingWelcomeNoteTitle = collection.SystemSettingWelcomeNoteTitle,
                    SystemSettingWelcomeNoteUrl = collection.SystemSettingWelcomeNoteUrl,
                    SystemSettingWelcomeNoteDesc = collection.SystemSettingWelcomeNoteDesc,
                    SystemSettingCopyright = collection.SystemSettingCopyright,
                    SystemSettingLogoImageUrl = FileName1,
                    SystemSettingLogoImageUrl2 = FileName2,
                    SystemSettingWelcomeNoteImageUrl = FileName3,
                    SystemSettingMapLocation = collection.SystemSettingMapLocation,
                    SystemSettingWelcomeNoteBreef = collection.SystemSettingWelcomeNoteBreef,
                    CreateDate = DateTime.Now,
                    CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    IsActive = true

                };
                system.Add(master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SystemSettingController/Edit/5
        public ActionResult Edit(int id)
        {
            var sy = system.Find(id);
            MVSystemSetting master = new MVSystemSetting
            {
                SystemSettingCopyright = sy.SystemSettingCopyright,
                SystemSettingLogoImageUrl = sy.SystemSettingLogoImageUrl,
                SystemSettingLogoImageUrl2 = sy.SystemSettingLogoImageUrl2,
                SystemSettingMapLocation = sy.SystemSettingMapLocation,
                SystemSettingWelcomeNoteBreef = sy.SystemSettingWelcomeNoteBreef,
                SystemSettingWelcomeNoteDesc = sy.SystemSettingWelcomeNoteDesc,
                SystemSettingWelcomeNoteImageUrl = sy.SystemSettingWelcomeNoteImageUrl,
                SystemSettingWelcomeNoteTitle = sy.SystemSettingWelcomeNoteTitle,
                SystemSettingWelcomeNoteUrl = sy.SystemSettingWelcomeNoteUrl,
                CreateDate = sy.CreateDate,
                CreateId = sy.CreateId,
                IsActive = sy.IsActive,
                SystemSettingId = sy.SystemSettingId
            };
            return View(master);
        }

        // POST: SystemSettingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVSystemSetting collection)
        {
            try
            {
            

                Random rd = new Random();
                
                string FileName1, FileName2, FileName3 = "";

                FileName1 = HelperClass.SaveImage(collection.File_logo1, "System_img");
                FileName2 = HelperClass.SaveImage(collection.File_logo2, "System_img");
                FileName3 = HelperClass.SaveImage(collection.File_Welcome, "System_img");

                if (FileName1 == "")
                {
                    FileName1 = collection.SystemSettingLogoImageUrl;
                }
                if (FileName2 == "")
                {
                    FileName2 = collection.SystemSettingLogoImageUrl2;
                }
                if (FileName3 == "")
                {
                    FileName3 = collection.SystemSettingWelcomeNoteImageUrl;
                }
                SystemSetting master = new SystemSetting
                {
                    SystemSettingCopyright = collection.SystemSettingCopyright,
                    SystemSettingMapLocation = collection.SystemSettingMapLocation,
                    SystemSettingWelcomeNoteBreef = collection.SystemSettingWelcomeNoteBreef,
                    SystemSettingWelcomeNoteDesc = collection.SystemSettingWelcomeNoteDesc,
                    SystemSettingId = collection.SystemSettingId,
                    SystemSettingWelcomeNoteTitle = collection.SystemSettingWelcomeNoteTitle,
                    SystemSettingLogoImageUrl =FileName1,
                    SystemSettingLogoImageUrl2 =FileName2,
                    SystemSettingWelcomeNoteUrl = collection.SystemSettingWelcomeNoteUrl,
                    SystemSettingWelcomeNoteImageUrl = FileName3,
                    CreateDate = collection.CreateDate,
                    CreateId = collection.CreateId , 
                    IsActive = collection .IsActive,
                    EditDate = DateTime.Now,
                    EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value

                };
                system.Update(id,master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SystemSettingController/Delete/5
        public ActionResult Delete(int id , SystemSetting collection)
        {

            system.Delete(id,collection);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_Active(int id, SystemSetting collection)
        {

            system.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }



    }
}
