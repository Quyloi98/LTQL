using LTQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Controllers
{
    public class ChiTietLoaiHangController : Controller
    {
        LTQLsieuthimini db = new LTQLsieuthimini();
        // GET: ChiTietLoaiHang
        public ActionResult Index()
        {
            return View(db.ChiTietLoaiHangs.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ChiTietLoaiHang ctlh)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietLoaiHangs.Add(ctlh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}