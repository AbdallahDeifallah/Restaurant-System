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

    public class MasterPartnerController : Controller

    {
        public IClassHelper HelperClass { get; }
        public IPartnerRepositorie Partner { get;  }
        public MasterPartnerController(IPartnerRepositorie _Partner, IClassHelper _HelperClass)
        {
            Partner = _Partner;
            HelperClass = _HelperClass;
        }

        // GET: MasterPartnerController
        public ActionResult Index()
        {
            var data = Partner.View();
            return View(data);
        }

        // GET: MasterPartnerController/Details/5
        public ActionResult Details(int id)
        {
            var data = Partner.Find(id);
            return View(data);
        }

        // GET: MasterPartnerController/Create
        public ActionResult Create()
        {
            MVMasterPartner Master = new MVMasterPartner
            {
                Parnters = Partner.View()
            };
            return View(Master);
        }

        // POST: MasterPartnerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVMasterPartner collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File, "Partner_img");

                MasterPartner master = new MasterPartner
                {
                    MasterPartnerName = collection.MasterPartnerName,
                    MasterPartnerLogoImageUrl = FileName,
                    MasterPartnerWebsiteUrl = collection.MasterPartnerWebsiteUrl,
                    CreateDate = DateTime.Now,
                    CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    IsActive = true
                };
                Partner.Add(master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPartnerController/Edit/5
        public ActionResult Edit(int id)
        {
            var master = Partner.Find(id);
            MVMasterPartner data = new MVMasterPartner
            {
                MasterPartnerLogoImageUrl = master.MasterPartnerLogoImageUrl,
                MasterPartnerName = master.MasterPartnerName,
                MasterPartnerId = master.MasterPartnerId,
                MasterPartnerWebsiteUrl = master.MasterPartnerWebsiteUrl,
                IsActive = master.IsActive,
                CreateDate = master.CreateDate,
                CreateId=master.CreateId
            };
            return View(data);
        }

        // POST: MasterPartnerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVMasterPartner collection)
        {
            try
            {
              
                string FileName = "";

                FileName =HelperClass.SaveImage(collection.File, "Partner_img");

                if (FileName == "")
                {
                    FileName = collection.MasterPartnerLogoImageUrl;
                }

                MasterPartner master = new MasterPartner
                {
                    MasterPartnerName = collection.MasterPartnerName,
                    MasterPartnerLogoImageUrl = FileName,
                    MasterPartnerId = collection.MasterPartnerId,
                    MasterPartnerWebsiteUrl = collection.MasterPartnerWebsiteUrl,
                    EditDate = DateTime.Now,
                    EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    CreateDate = collection.CreateDate,
                    CreateId = collection.CreateId,
                    IsActive = collection.IsActive
                };
                Partner.Update(id,master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterPartnerController/Delete/5
        public ActionResult Delete(int id,MasterPartner collection)
        {
            Partner.Delete(id,collection);
            return RedirectToAction(nameof(Index));
        }

        // POST: MasterPartnerController/Delete/5
        public ActionResult Update_Active(int id, MasterPartner collection)
        {

            Partner.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }

    }
}
