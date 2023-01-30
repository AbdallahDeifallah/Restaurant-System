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
using System.Security.Claims;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]


    public class MasterMenuController : Controller
    {
        public IMenuRepositorie Menu{ get; }
        public MasterMenuController(IMenuRepositorie _Menu) {

            Menu = _Menu;
        }
        // GET: MasterMenuController
        public ActionResult Index()
        {
            return View(Menu.View());
        }

        // GET: MasterMenuController/Details/5
        public ActionResult Details(int id)
        {
            return View(Menu.Find(id));
        }

        // GET: MasterMenuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MasterMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MasterMenu collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    collection.IsActive = true;
                    collection.CreateDate = DateTime.Now;
                    collection.CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    Menu.Add(collection);
                    return RedirectToAction(nameof(Index));

                }
                else
                {
                    return View();
                }
   


            }
            catch
            {
                return View();
            }
        }

        // GET: MasterMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = Menu.Find(id);
            return View(data);
        }

        // POST: MasterMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MasterMenu collection)
        {
            try
            {
                collection.EditDate = DateTime.Now;
                collection.EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                Menu.Update(id,collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: MasterMenuController/Delete/5
        public ActionResult Delete(int id , MasterMenu collection)
        {
            Menu.Delete(id,collection);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Update_Active(int id, MasterMenu collection)
        {

            Menu.Update_Active(id,collection);
            return RedirectToAction(nameof(Index));
        }

    }
}
