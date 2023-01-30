using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Areas.Admin.MVModels;
using Restaurant.Areas.Admin.MyClass;
using Restaurant.Models;
using Restaurant.Models.Repositories;
using Restaurant.MyClass;
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


    public class MasterSliderController : Controller
    {
        public ISliderRepositorie MasterSlider { get; }
        public IClassHelper HelperClass { get; }

        public MasterSliderController(ISliderRepositorie _MasterSlider, IClassHelper _HelperClass)
        {
            MasterSlider = _MasterSlider;
            HelperClass = _HelperClass;

        }
        // GET: MasterSliderController
        public ActionResult Index()
        {

            
            return View(MasterSlider.View());
        }

        // GET: MasterSliderController/Details/5
        public ActionResult Details(int id)
        {
            var data = MasterSlider.Find(id);
            MVMasterSlider data_slider = new MVMasterSlider
            {
                MasterSliderBreef    = data.MasterSliderBreef,
                MasterSliderDesc     = data.MasterSliderDesc,
                MasterSliderImageUrl = data.MasterSliderImageUrl,
                MasterSliderTitle    = data.MasterSliderTitle,
                IsActive             = data.IsActive,
                CreateId             = data.CreateId,
                EditId               = data.EditId,
                EditDate             = data.EditDate,
                CreateDate           = data.CreateDate,
                MasterSliderId = data.MasterSliderId
                
            };

            return View(data_slider);
        }

        // GET: MasterSliderController/Create
        public ActionResult Create()
        {
            MVMasterSlider data = new MVMasterSlider
            {
                MasterSliders = MasterSlider.View()

            };
            return View(data);
        }

        // POST: MasterSliderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MVMasterSlider collection)
        {
            try
            {
                string FileName = "";
                FileName = HelperClass.SaveImage(collection.File,"Sider_image");
                if(FileName == "error")
                {
                    return View();
                }
                else { 

                if (ModelState.IsValid)
                {
                    MasterSlider obj = new MasterSlider
                    {
                        MasterSliderTitle = collection.MasterSliderTitle,
                        MasterSliderDesc = collection.MasterSliderDesc,
                        MasterSliderBreef = collection.MasterSliderBreef,
                        MasterSliderImageUrl = FileName,
                        IsActive = true,
                        CreateDate = DateTime.Now,
                        CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value
                    };
                    MasterSlider.Add(obj);

                }
                else
                {
                    ModelState.AddModelError("", "Fill Data");
                    return View();
                }
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSliderController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = MasterSlider.Find(id);
            MVMasterSlider master = new MVMasterSlider
            {
                MasterSliderId       = data.MasterSliderId,
                MasterSliderTitle    = data.MasterSliderTitle,
                MasterSliderDesc     = data.MasterSliderDesc,
                MasterSliderBreef    = data.MasterSliderBreef,
                MasterSliderImageUrl = data.MasterSliderImageUrl,
                IsActive             = data.IsActive,
                CreateDate           = data.CreateDate,
                CreateId             =data.CreateId
                
                

            };
            return View(master);
        }

        // POST: MasterSliderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, MVMasterSlider collection)
        {
            try
            {
                string FileName = "";

                FileName =HelperClass.SaveImage(collection.File, "Sider_image");

                if (FileName == "")
                {
                    FileName = collection.MasterSliderImageUrl;
                }

                MasterSlider obj = new MasterSlider
                {
                    MasterSliderId       = collection.MasterSliderId,
                    MasterSliderTitle    = collection.MasterSliderTitle,
                    MasterSliderDesc     = collection.MasterSliderDesc,
                    MasterSliderBreef    = collection.MasterSliderBreef,
                    MasterSliderImageUrl = FileName,
                    CreateDate           = collection.CreateDate,
                    CreateId             =collection.CreateId,
                    IsActive             = collection.IsActive,
                    EditDate             = DateTime.Now,
                    EditId               = User.FindFirst(ClaimTypes.NameIdentifier).Value
                };

                MasterSlider.Update(id,obj);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MasterSliderController/Delete/5
        public ActionResult Delete(int id, MasterSlider collection)
        {

            MasterSlider.Delete(id, collection);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_Active(int id, MasterSlider collection)
        {

            MasterSlider.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }

    }
}
