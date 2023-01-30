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
    public class TransactionContactUsController : Controller
    {
        ITransactionContactUsRepositorie ContactUs { get; }
        public TransactionContactUsController(ITransactionContactUsRepositorie _ContactUs)
        {
            ContactUs = _ContactUs;
        }

        // GET: TransactionContactUsController
        public ActionResult Index()
        {
            return View(ContactUs.View());
        }

        // GET: TransactionContactUsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionContactUsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionContactUsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionContactUs collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    collection.CreateDate = DateTime.Now;
                    collection.CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    collection.IsActive = true;
                    ContactUs.Add(collection);
                }
                else
                {
                    return View();
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransactionContactUsController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = ContactUs.Find(id);
            return View(data);
        }

        // POST: TransactionContactUsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionContactUs collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    collection.EditDate = DateTime.Now;
                    collection.EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    ContactUs.Update(id,collection);
                }
                else
                {
                    return View();
                }



                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id, TransactionContactUs collection)
        {

            ContactUs.Delete(id, collection);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_Active(int id, TransactionContactUs collection)
        {

            ContactUs.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }

    }
        }
 
 
