using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Areas.Admin.MVModels;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]

    public class MasterWorkingHoursController : Controller
    {
        public IWorkingHourRepositorie Work { get; }
        public MasterWorkingHoursController(IWorkingHourRepositorie _Work) {

            Work = _Work;
        }
        // GET: MasterWorkingHoursController
        public ActionResult Index()
        {

            return View(Work.View()) ;
        }

        // GET: MasterWorkingHoursController/Details/5
        public ActionResult Details(int id)
        {
            var data = Work.Find(id);
            return View(data);
        }

        // GET: MasterWorkingHoursController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterWorkingHoursController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterWorkingHours collection)
        {
            try
            {
                collection.IsActive = true;
                collection.CreateDate = DateTime.Now;
                collection.CreateId = HttpContext.Session.GetString("UserId");
                Work.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterWorkingHoursController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Work.Find(id);
            return View(data);
        }

        // POST: MasterWorkingHoursController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterWorkingHours collection)
        {
            try
            {
                collection.EditDate = DateTime.Now;
                collection.EditId = HttpContext.Session.GetString("UserId");
                
                Work.Update(id,collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterWorkingHoursController/Delete/5
        public ActionResult Delete(int id, MasterWorkingHours collection)
        {
            Work.Delete(id, collection);


            return RedirectToAction(nameof(Index));
        }


        public ActionResult Update_Active(int id, MasterWorkingHours collection)
        {

            Work.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }
    }
}
