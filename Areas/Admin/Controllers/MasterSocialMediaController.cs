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
    public class MasterSocialMediaController : Controller
    {
        public IClassHelper HelperClass { get; }
        public ISocialMediuauRepositorie SocialMediuau { get; }
        public MasterSocialMediaController(ISocialMediuauRepositorie _SocialMediuau, IClassHelper _HelperClas)
        {
            HelperClass = _HelperClas;
            SocialMediuau = _SocialMediuau;
        }


        // GET: MasterSocialMediaController
        public ActionResult Index()
        {
            var data = SocialMediuau.View();
            return View(data);
        }

        // GET: MasterSocialMediaController/Details/5
        public ActionResult Details(int id)
        {
            var data = SocialMediuau.Find(id);
            return View(data);
        }

        // GET: MasterSocialMediaController/Create
        public ActionResult Create()
        {
            MVMasterSocialMedia data = new MVMasterSocialMedia
            {
                MastersSocialMedia = SocialMediuau.View()
            };
            return View(data);
        }

        // POST: MasterSocialMediaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVMasterSocialMedia collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File, "SocialMedia_img");

                MasterSocialMedia obj = new MasterSocialMedia
                {
                    MasterSocialMediaImageUrl = FileName,
                    MasterSocialMediaUrl = collection.MasterSocialMediaUrl,
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value
                };
                SocialMediuau.Add(obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSocialMediaController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = SocialMediuau.Find(id);
            MVMasterSocialMedia master = new MVMasterSocialMedia
            {
                MasterSocialMediaId = data.MasterSocialMediaId,
                MasterSocialMediaImageUrl = data.MasterSocialMediaImageUrl,
                MasterSocialMediaUrl = data.MasterSocialMediaUrl,
               CreateDate = data.CreateDate,
               CreateId = data.CreateId,
                IsActive = data.IsActive
            };
            return View(master);
        }

        // POST: MasterSocialMediaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVMasterSocialMedia collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File, "SocialMedia_img");
                if (FileName == "")
                {
                    FileName =collection.MasterSocialMediaImageUrl;
                }
                MasterSocialMedia master = new MasterSocialMedia
                {
                    MasterSocialMediaId = collection.MasterSocialMediaId,
                    MasterSocialMediaImageUrl = FileName,
                    MasterSocialMediaUrl = collection.MasterSocialMediaUrl,
                    CreateDate = collection.CreateDate,
                    CreateId = collection.CreateId,
                    EditDate = collection.EditDate,
                    EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    IsActive = collection.IsActive,



                };
                SocialMediuau.Update(id,master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSocialMediaController/Delete/5
        public ActionResult Delete(int id ,MasterSocialMedia collection)
        {
            SocialMediuau.Delete(id,collection);


            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_Active(int id, MasterSocialMedia collection)
        {

            SocialMediuau.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }
    }
}
