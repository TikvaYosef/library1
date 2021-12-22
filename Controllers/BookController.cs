using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace library1.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

     

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            return Json("", JsonRequestBehavior.AllowGet);
        }

      

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}
