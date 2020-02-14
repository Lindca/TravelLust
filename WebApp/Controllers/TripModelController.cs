using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TripModelController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TripModel
        public ActionResult Index()
        {
            return View(db.TripModels.ToList());
        }

        // GET: TripModel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TripModel tripModel = db.TripModels.Find(id);
            if (tripModel == null)
            {
                return HttpNotFound();
            }
            return View(tripModel);
        }

        // GET: TripModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TripModel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,DateTimeStart,DateTimeEnd,Destination,Name")] TripModel tripModel)
        {
            if (ModelState.IsValid)
            {
                db.TripModels.Add(tripModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tripModel);
        }

        // GET: TripModel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TripModel tripModel = db.TripModels.Find(id);
            if (tripModel == null)
            {
                return HttpNotFound();
            }
            return View(tripModel);
        }

        // POST: TripModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,DateTimeStart,DateTimeEnd,Destination,Name")] TripModel tripModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tripModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tripModel);
        }

        // GET: TripModel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TripModel tripModel = db.TripModels.Find(id);
            if (tripModel == null)
            {
                return HttpNotFound();
            }
            return View(tripModel);
        }

        // POST: TripModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TripModel tripModel = db.TripModels.Find(id);
            db.TripModels.Remove(tripModel);
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
