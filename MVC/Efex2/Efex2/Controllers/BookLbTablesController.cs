using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Efex2.Models;

namespace Efex2.Controllers
{
    public class BookLbTablesController : Controller
    {
        private LibraryBookLBEntities db = new LibraryBookLBEntities();

        // GET: BookLbTables
        public ActionResult Index()
        {
            return View(db.BookLbTables.ToList());
        }

        // GET: BookLbTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookLbTable bookLbTable = db.BookLbTables.Find(id);
            if (bookLbTable == null)
            {
                return HttpNotFound();
            }
            return View(bookLbTable);
        }

        // GET: BookLbTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookLbTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BookName,Quantity,Price")] BookLbTable bookLbTable)
        {
            if (ModelState.IsValid)
            {
                db.BookLbTables.Add(bookLbTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookLbTable);
        }

        // GET: BookLbTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookLbTable bookLbTable = db.BookLbTables.Find(id);
            if (bookLbTable == null)
            {
                return HttpNotFound();
            }
            return View(bookLbTable);
        }

        // POST: BookLbTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BookName,Quantity,Price")] BookLbTable bookLbTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookLbTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookLbTable);
        }

        // GET: BookLbTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookLbTable bookLbTable = db.BookLbTables.Find(id);
            if (bookLbTable == null)
            {
                return HttpNotFound();
            }
            return View(bookLbTable);
        }

        // POST: BookLbTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookLbTable bookLbTable = db.BookLbTables.Find(id);
            db.BookLbTables.Remove(bookLbTable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
