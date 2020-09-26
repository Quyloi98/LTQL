using LTQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Controllers
{
    public class ChiTietHoaDonController : Controller
    {
        LTQLsieuthimini db = new LTQLsieuthimini();
        // GET: ChiTietHoaDon
        public ActionResult Index()
        {
            return View(db.ChiTietHoaDons.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ChiTietHoaDon cthd)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietHoaDons.Add(cthd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}