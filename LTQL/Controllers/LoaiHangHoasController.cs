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
    public class LoaiHangHoasController : Controller
    {
        private LTQLsieuthimini db = new LTQLsieuthimini();

        // GET: LoaiHangHoas
        public ActionResult Index()
        {
            return View(db.LoaiHangHoas.ToList());
        }

        // GET: LoaiHangHoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHangHoa loaiHangHoa = db.LoaiHangHoas.Find(id);
            if (loaiHangHoa == null)
            {
                return HttpNotFound();
            }
            return View(loaiHangHoa);
        }

        // GET: LoaiHangHoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiHangHoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLHH,TenLHH,GhiChu,MaGH")] LoaiHangHoa loaiHangHoa)
        {
            if (ModelState.IsValid)
            {
                db.LoaiHangHoas.Add(loaiHangHoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiHangHoa);
        }

        // GET: LoaiHangHoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHangHoa loaiHangHoa = db.LoaiHangHoas.Find(id);
            if (loaiHangHoa == null)
            {
                return HttpNotFound();
            }
            return View(loaiHangHoa);
        }

        // POST: LoaiHangHoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLHH,TenLHH,GhiChu,MaGH")] LoaiHangHoa loaiHangHoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiHangHoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiHangHoa);
        }

        // GET: LoaiHangHoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiHangHoa loaiHangHoa = db.LoaiHangHoas.Find(id);
            if (loaiHangHoa == null)
            {
                return HttpNotFound();
            }
            return View(loaiHangHoa);
        }

        // POST: LoaiHangHoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LoaiHangHoa loaiHangHoa = db.LoaiHangHoas.Find(id);
            db.LoaiHangHoas.Remove(loaiHangHoa);
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
