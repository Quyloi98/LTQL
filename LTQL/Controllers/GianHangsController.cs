using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;

namespace LTQL.Controllers
{
    public class GianHangsController : Controller
    {
        private LTQLsieuthimini db = new LTQLsieuthimini();

        // GET: GianHangs
        public ActionResult Index()
        {
            return View(db.GianHangs.ToList());
        }

        // GET: GianHangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GianHang gianHang = db.GianHangs.Find(id);
            if (gianHang == null)
            {
                return HttpNotFound();
            }
            return View(gianHang);
        }

        // GET: GianHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GianHangs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGH,TenGH,ViTri,MaNQL")] GianHang gianHang)
        {
            if (ModelState.IsValid)
            {
                db.GianHangs.Add(gianHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gianHang);
        }

        // GET: GianHangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GianHang gianHang = db.GianHangs.Find(id);
            if (gianHang == null)
            {
                return HttpNotFound();
            }
            return View(gianHang);
        }

        // POST: GianHangs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGH,TenGH,ViTri,MaNQL")] GianHang gianHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gianHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gianHang);
        }

        // GET: GianHangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GianHang gianHang = db.GianHangs.Find(id);
            if (gianHang == null)
            {
                return HttpNotFound();
            }
            return View(gianHang);
        }

        // POST: GianHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            GianHang gianHang = db.GianHangs.Find(id);
            db.GianHangs.Remove(gianHang);
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
