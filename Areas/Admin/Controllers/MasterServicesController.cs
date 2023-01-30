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
    //////[Authorize]

    public class MasterServicesController : Controller
    {
        public IClassHelper HelperClass { get; }
        public IServiceRepositorie service { get; }

        public MasterServicesController(IServiceRepositorie _service , IClassHelper _HelperClass)
        {
            service = _service;
            HelperClass = _HelperClass;
        }
        // GET: MasterServicesController
        public ActionResult Index()
        {
            return View(service.View()) ;
        }

        // GET: MasterServicesController/Details/5
        public ActionResult Details(int id)
        {
            var master = service.Find(id);
            MVMasterServices data = new MVMasterServices
            {
                MasterServicesTitle = master.MasterServicesTitle,
                MasterServicesDesc = master.MasterServicesDesc,
                MasterServicesImage = master.MasterServicesImage,
                CreateDate = master.CreateDate,
                CreateId = master.CreateId,
                EditDate = master.EditDate,
                EditId = master.EditId,
                IsActive = master.IsActive
            };
            return View(data);
        }

        // GET: MasterServicesController/Create
        public ActionResult Create()
        {
            MVMasterServices master = new MVMasterServices
            {
                MasterServices = service.View()
            };
            return View(master);
        }

        // POST: MasterServicesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVMasterServices collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File, "Services_image");
                MasterServices master = new MasterServices
                {

                    MasterServicesTitle = collection.MasterServicesTitle,
                    MasterServicesDesc = collection.MasterServicesDesc,
                    MasterServicesIcon = collection.MasterServicesIcon,
                    MasterServicesImage = FileName,
                    CreateDate = DateTime.Now,
                    CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    IsActive = true,    
                    };

           
                    service.Add(master);

               

                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: MasterServicesController/Edit/5
        public ActionResult Edit(int id)
        {
            var master = service.Find(id);
            MVMasterServices data = new MVMasterServices
            {
                MasterServicesDesc = master.MasterServicesDesc,
                MasterServicesTitle = master.MasterServicesTitle,
                MasterServicesId = master.MasterServicesId,
                MasterServicesIcon = master.MasterServicesIcon,
                MasterServicesImage = master.MasterServicesImage,
                IsActive = master.IsActive,
                CreateDate = master.CreateDate,
                CreateId = master.CreateId,
                EditDate = master.EditDate,
                EditId = master.EditId
            };
            return View(data);
        }

        // POST: MasterServicesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVMasterServices collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File, "Services_image");
                if (FileName == "")
                {
                    FileName = collection.MasterServicesImage;
                }
                MasterServices master = new MasterServices
                {
                    MasterServicesImage = FileName,
                    MasterServicesDesc = collection.MasterServicesDesc,
                    MasterServicesId = collection.MasterServicesId,
                    MasterServicesTitle = collection.MasterServicesTitle,
                    MasterServicesIcon = collection.MasterServicesIcon,
                    IsActive = collection.IsActive,
                    EditDate = DateTime.Now,
                    EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                    CreateDate = collection.CreateDate,
                    CreateId =collection.CreateId

                };
                service.Update(id,master);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterServicesController/Delete/5
        public ActionResult Delete(int id,MasterServices collection)
        {

            service.Delete(id,collection);
            return RedirectToAction(nameof(Index));
        }

        // POST: MasterServicesController/Delete/5

        public ActionResult Update_Active(int id, MasterServices collection)
        {

            service.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }
    }
}
