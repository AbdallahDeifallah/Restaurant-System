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

    public class MasterOfferController : Controller
    {
        public IOfferRepositorie Offer { get; }
        public IClassHelper HelperClass { get; }
        public MasterOfferController(IOfferRepositorie _Offer , IClassHelper _HelperClass)
        {
            Offer = _Offer;
            HelperClass = _HelperClass;
        }
        // GET: MasterOfferController
        public ActionResult Index()
        {
            var data = Offer.View();
            return View(data);
        }

        // GET: MasterOfferController/Details/5
        public ActionResult Details(int id)
        {
            var data = Offer.Find(id);
            MVMasterOffer master = new MVMasterOffer
            {
                MasterOfferBreef = data.MasterOfferBreef,
                MasterOfferImageUrl = data.MasterOfferImageUrl,
                MasterOfferDesc = data.MasterOfferDesc,
                MasterOfferTitle = data.MasterOfferTitle,
                IsActive = data.IsActive,
                CreateDate = data.CreateDate,
                CreateId = data.CreateId,
                EditDate=data.EditDate,
                EditId=data.EditId
                
            };
            return View(master);
        }

        // GET: MasterOfferController/Create
        public ActionResult Create()
        {
            MVMasterOffer master = new MVMasterOffer
            {
                MasterOffers = Offer.View()
            };
            return View();
        }

        // POST: MasterOfferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVMasterOffer collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File, "Offer_image");
                MasterOffer master = new MasterOffer
                {
                    MasterOfferTitle = collection.MasterOfferTitle,
                    MasterOfferBreef = collection.MasterOfferBreef,
                    MasterOfferDesc = collection.MasterOfferDesc,
                    MasterOfferImageUrl = FileName,
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value
                };
                Offer.Add(master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterOfferController/Edit/5
        public ActionResult Edit(int id)
        {
            var master = Offer.Find(id);
            MVMasterOffer data = new MVMasterOffer
            {
                MasterOfferId = master.MasterOfferId,
                MasterOfferBreef = master.MasterOfferBreef,
                MasterOfferImageUrl = master.MasterOfferImageUrl,
                MasterOfferTitle = master.MasterOfferTitle,
                MasterOfferDesc = master.MasterOfferDesc,
                IsActive = master.IsActive,
                CreateDate = master.CreateDate,
                CreateId = master.CreateId
            };
            return View(data);
        }

        // POST: MasterOfferController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVMasterOffer collection)
        {
            try
            {
                string FileName = "";

                FileName = HelperClass.SaveImage(collection.File, "Offer_image");

                if (FileName == "")
                {
                    FileName = collection.MasterOfferImageUrl;
                }
                MasterOffer master = new MasterOffer
                {
                    MasterOfferId = collection.MasterOfferId,
                    MasterOfferBreef = collection.MasterOfferBreef,
                    MasterOfferDesc = collection.MasterOfferDesc,
                    MasterOfferImageUrl = FileName,
                    MasterOfferTitle = collection.MasterOfferTitle,
                    CreateDate = collection.CreateDate,
                    CreateId = collection.CreateId,
                    EditDate = DateTime.Now,
                    EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    IsActive = collection.IsActive
                };
                Offer.Update(id,master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterOfferController/Delete/5
        public ActionResult Delete(int id, MasterOffer collection)
        {
            Offer.Delete(id,collection);

            return RedirectToAction(nameof(Index));

        }


        public ActionResult Update_Active(int id, MasterOffer collection)
        {

            Offer.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }

    }
}
