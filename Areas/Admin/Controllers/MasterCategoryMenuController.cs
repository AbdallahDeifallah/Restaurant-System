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
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]


    public class MasterCategoryMenuController : Controller
    {
        public ICategoryMenuRepositorie MasterCategory { get; }


        public MasterCategoryMenuController(ICategoryMenuRepositorie _MasterCategory)
        {
            MasterCategory = _MasterCategory;
        }
        // GET: MasterCategoryMenuController
        public ActionResult Index()
        {

            return View(MasterCategory.View());
        }

        // GET: MasterCategoryMenuController/Details/5
        public ActionResult Details(int id)
        {
            var data = MasterCategory.Find(id);
            return View(data);
        }

        // GET: MasterCategoryMenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterCategoryMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterCategoryMenu collection)
        {
            try
            {
                collection.CreateDate = DateTime.Now;
                collection.CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value;//HttpContext.Session.GetString("UserId");
                collection.IsActive = true;
                MasterCategory.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCategoryMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterCategory.Find(id);
            MVMasterCategoryMenu master = new MVMasterCategoryMenu
            {
                MasterCategoryMenuName = data.MasterCategoryMenuName,
                MasterCategoryMenuId  = data.MasterCategoryMenuId,
                IsActive   = data.IsActive,
                IsDelete   = data.IsDelete,
                CreateDate = data.CreateDate,
                CreateId   = data.CreateId,
       
            };
            return View(master);
        }

        // POST: MasterCategoryMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVMasterCategoryMenu collection)
        {
            try
            {

                MasterCategoryMenu obj = new MasterCategoryMenu
                {
                    MasterCategoryMenuName = collection.MasterCategoryMenuName,
                    MasterCategoryMenuId = collection.MasterCategoryMenuId,
                    IsActive = collection.IsActive,
                    IsDelete = collection.IsDelete,
                    CreateDate = collection.CreateDate,
                    EditDate = DateTime.Now,
                    CreateId = collection.CreateId,
                    EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value
                };
                MasterCategory.Update(id,obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterCategoryMenuController/Delete/5
        public ActionResult Delete(int id, MasterCategoryMenu collection)
        {
            MasterCategory.Delete(id, collection);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Update_Active(int id, MasterCategoryMenu collection)
        {

            MasterCategory.Update_Active(id,collection);
            return RedirectToAction(nameof(Index));
        }


    }
}
