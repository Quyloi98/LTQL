using LTQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Controllers
{
    public class GianHangsController : Controller
    {
        LTQLsieuthimini db = new LTQLsieuthimini();
        // GET: GianHangs
        public ActionResult Index()
        {
            return View(db.GianHangs.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(GianHang gh)
        {
            if (ModelState.IsValid)
            {
                db.GianHangs.Add(gh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}