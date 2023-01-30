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
    public class TransactionNewsletterController : Controller
    {
        ITransactionNewsletterRepositorie newslatter;
        public TransactionNewsletterController(ITransactionNewsletterRepositorie _newslatter)
        {
            newslatter = _newslatter;
        }
        // GET: TransactionNewsletterController
        public ActionResult Index()
        {
            return View(newslatter.View());
        }

        // GET: TransactionNewsletterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionNewsletterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionNewsletterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionNewsletter collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    collection.CreateDate = DateTime.Now;
                    collection.CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    collection.IsActive = true;
                    newslatter.Add(collection);
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

        // GET: TransactionNewsletterController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = newslatter.Find(id);
            return View(data);
        }

        // POST: TransactionNewsletterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionNewsletter collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    collection.EditDate = DateTime.Now;
                    collection.EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    newslatter.Update(id,collection);
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

        public ActionResult Delete(int id, TransactionNewsletter collection)
        {

            newslatter.Delete(id, collection);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_Active(int id, TransactionNewsletter collection)
        {

            newslatter.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }
    }
}
