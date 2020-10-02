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
    public class ChiTietLoaiHangsController : Controller
    {
        private LTQLsieuthimini db = new LTQLsieuthimini();

        // GET: ChiTietLoaiHangs
        public ActionResult Index()
        {
            return View(db.ChiTietLoaiHangs.ToList());
        }

        // GET: ChiTietLoaiHangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietLoaiHang chiTietLoaiHang = db.ChiTietLoaiHangs.Find(id);
            if (chiTietLoaiHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietLoaiHang);
        }

        // GET: ChiTietLoaiHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiTietLoaiHangs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNCC,TenNCC,SoLuong")] ChiTietLoaiHang chiTietLoaiHang)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietLoaiHangs.Add(chiTietLoaiHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(chiTietLoaiHang);
        }

        // GET: ChiTietLoaiHangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietLoaiHang chiTietLoaiHang = db.ChiTietLoaiHangs.Find(id);
            if (chiTietLoaiHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietLoaiHang);
        }

        // POST: ChiTietLoaiHangs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNCC,TenNCC,SoLuong")] ChiTietLoaiHang chiTietLoaiHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietLoaiHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(chiTietLoaiHang);
        }

        // GET: ChiTietLoaiHangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietLoaiHang chiTietLoaiHang = db.ChiTietLoaiHangs.Find(id);
            if (chiTietLoaiHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietLoaiHang);
        }

        // POST: ChiTietLoaiHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChiTietLoaiHang chiTietLoaiHang = db.ChiTietLoaiHangs.Find(id);
            db.ChiTietLoaiHangs.Remove(chiTietLoaiHang);
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
