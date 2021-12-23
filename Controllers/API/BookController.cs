using library1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace library1.Controllers
{
    public class BookController : Controller
    {
        List<Book> listofbooks = new List<Book>();
        void books()
        {
            Random random = new Random();

           

            Book[] arrayofbooks = new Book[]
               {
                new Book("BookOne", "WritterOne", 2010, random.Next(100, 500)),
                new Book("BookTwo", "WritterTwo", 2000, random.Next(100, 500)),
                new Book("BookThree", "WritterThree", 2003, random.Next(100, 500)),
                new Book("BookFour", "WritterFour", 2004, random.Next(100, 500)),
                new Book("BookFive", "WritterFive", 2005, random.Next(100, 500)),
                new Book("BookSix", "WritterSix", 2006, random.Next(100, 500)),
                new Book("BookSeven", "WritterSeven", 2007, random.Next(100, 500)),
                new Book("BookEigth", "WritterEigth", 2008, random.Next(100, 500))
               };

            listofbooks.AddRange(arrayofbooks);

        }
       


        // GET: Book
        public ActionResult Index()
        {
            books();
                    return Json(listofbooks, JsonRequestBehavior.AllowGet);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            books();
            foreach (Book bookitem in listofbooks)
            {
                if (id == bookitem.id)
                {
                    return Json(bookitem, JsonRequestBehavior.AllowGet);
                }
            }
            return Json("NOT FOUND", JsonRequestBehavior.AllowGet);

        }



        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            books();
            Book book567 = new Book(collection["name"],collection["author"], int.Parse(collection["year"]),250);
            listofbooks.Add(book567);

            return Json("added", JsonRequestBehavior.AllowGet);
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
