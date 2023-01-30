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


    public class MasterItemMenuController : Controller
    {
        public ItemMenuRepositorie itemMenu { get; }
        public IClassHelper HelperClass { get; }
        public ICategoryMenuRepositorie Category { get; }


        public MasterItemMenuController(ItemMenuRepositorie _itemMenu , ICategoryMenuRepositorie _Category, IClassHelper _HelperClass) {
            itemMenu = _itemMenu;
            HelperClass = _HelperClass;
            Category = _Category;
        }
        // GET: MasterItemMenuController
        public ActionResult Index()
        {
            return View(itemMenu.View());
        }

        // GET: MasterItemMenuController/Details/5
        public ActionResult Details(int id)
        {
            var data = itemMenu.Find(id);
            MVMasterItemMenu master = new MVMasterItemMenu
            {
                Category = Category.Find(data.MasterCategoryMenuId),
                MasterItemMenuBreef = data.MasterItemMenuBreef,
                MasterItemMenuDate = data.MasterItemMenuDate,
                MasterItemMenuDesc = data.MasterItemMenuDesc,
                MasterItemMenuImageUrl = data.MasterItemMenuImageUrl,
                MasterItemMenuPrice = data.MasterItemMenuPrice,
                MasterItemMenuTitle = data.MasterItemMenuTitle,
                CreateDate = data.CreateDate,
                EditDate = data.EditDate,
                CreateId = data.CreateId,
                EditId = data.EditId,
                IsActive=data.IsActive

            };

            return View(master);
        }

        // GET: MasterItemMenuController/Create
        public ActionResult Create()
        {

            MVMasterItemMenu master = new MVMasterItemMenu
            {
                Categorys = Category.View()
            };
            return View(master);
        }

        // POST: MasterItemMenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVMasterItemMenu collection)
        {
            try
            {


   
                
                if (ModelState.IsValid)
                {
                    string FileName = "";
                    FileName = HelperClass.SaveImage(collection.File, "Item_Image");
                    MasterItemMenu master = new MasterItemMenu
                    {
                        MasterItemMenuTitle = collection.MasterItemMenuTitle,
                        MasterItemMenuBreef = collection.MasterItemMenuBreef,
                        MasterItemMenuDesc = collection.MasterItemMenuDesc,
                        MasterItemMenuDate = collection.MasterItemMenuDate,
                        MasterItemMenuPrice = collection.MasterItemMenuPrice,
                        MasterCategoryMenuId = collection.MasterCategoryMenuId,
                        MasterItemMenuImageUrl = FileName,
                        CreateDate = DateTime.Now,
                        CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                        IsActive = true,



                    };

                    itemMenu.Add(master);

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

        // GET: MasterItemMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = itemMenu.Find(id);
            MVMasterItemMenu master = new MVMasterItemMenu
            {
                Categorys = Category.View(),
                MasterItemMenuId = data.MasterItemMenuId,
                MasterItemMenuTitle      = data.MasterItemMenuTitle,
                MasterItemMenuBreef      = data.MasterItemMenuBreef,
                MasterItemMenuDesc       = data.MasterItemMenuDesc,
                MasterItemMenuDate       = data.MasterItemMenuDate,
                MasterItemMenuPrice      = data.MasterItemMenuPrice,
                MasterCategoryMenuId     = data.MasterCategoryMenuId,
                MasterItemMenuImageUrl   = data.MasterItemMenuImageUrl,
                CreateDate               = data.CreateDate,
                CreateId                 = data.CreateId,
                IsActive                 = data.IsActive,
                IsDelete                 = data.IsDelete

            };
            return View(master);
        }

        // POST: MasterItemMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVMasterItemMenu collection)
        {
            try
            {
                string FileName = "";

                FileName = HelperClass.SaveImage(collection.File, "Item_Image");

                if (FileName == "")
                {
                    FileName = collection.MasterItemMenuImageUrl;
                }
                MasterItemMenu master = new MasterItemMenu
                {
                    MasterItemMenuId = collection.MasterItemMenuId,

                    MasterItemMenuTitle = collection.MasterItemMenuTitle,
                    MasterItemMenuBreef = collection.MasterItemMenuBreef,
                    MasterItemMenuDesc = collection.MasterItemMenuDesc,
                    MasterItemMenuDate = collection.MasterItemMenuDate,
                    MasterItemMenuPrice = collection.MasterItemMenuPrice,
                    MasterCategoryMenuId = collection.MasterCategoryMenuId,
                    MasterItemMenuImageUrl = FileName,
                    CreateDate = collection.CreateDate,
                    CreateId = collection.CreateId,
                    IsActive = collection.IsActive,
                    IsDelete = collection.IsDelete,
                    EditDate = DateTime.Now,
                    EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value
                };
                itemMenu.Update(id,master);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterItemMenuController/Delete/5
        public ActionResult Delete(int id,MasterItemMenu collection)
        {
            itemMenu.Delete(id,collection);

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_Active(int id, MasterItemMenu collection)
        {

            itemMenu.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }

    }
}
