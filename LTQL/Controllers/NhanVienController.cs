using LTQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Controllers
{
    public class NhanVienController : Controller
    {
        LTQLsieuthimini db = new LTQLsieuthimini();
        // GET: NhanVien
        public ActionResult Index()
        {
            return View(db.NhanViens.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(NhanVien nv)
        {
            if(ModelState.IsValid)
            {
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}