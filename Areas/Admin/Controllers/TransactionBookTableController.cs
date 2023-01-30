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
    public class TransactionBookTableController : Controller
    {
        ITransactionBookTableRepositorie TransactionBook { get; }
        public TransactionBookTableController(ITransactionBookTableRepositorie _TransactionBook)
        {
            TransactionBook = _TransactionBook;
        }
        // GET: TransactionBookTableController
        public ActionResult Index()
        {
            return View(TransactionBook.View());
        }

        // GET: TransactionBookTableController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransactionBookTableController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionBookTableController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionBookTable collection)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    collection.IsActive = true;
                    collection.CreateDate = DateTime.Now;
                    collection.CreateId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
         
                    TransactionBook.Add(collection);
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

        // GET: TransactionBookTableController/Edit/5
        public ActionResult Edit(int id)
        {
            var data = TransactionBook.Find(id);
            return View(data);
        }

        // POST: TransactionBookTableController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TransactionBookTable collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    collection.EditDate = DateTime.Now;
                    collection.EditId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    TransactionBook.Update(id,collection);

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


        public ActionResult Delete(int id, TransactionBookTable collection)
        {

            TransactionBook.Delete(id, collection);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Update_Active(int id, TransactionBookTable collection)
        {

            TransactionBook.Update_Active(id, collection);
            return RedirectToAction(nameof(Index));
        }
    }
}
