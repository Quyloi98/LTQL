﻿using LTQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Controllers
{
    public class KhachHangController : Controller
    {
        LTQLsieuthimini db = new LTQLsieuthimini();
        // GET: KhachHang
        public ActionResult Index()
        {
            return View(db.KhachHangs.ToList());
        }
        // tra ve mot view cho client nhap thong tin khach hang
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(KhachHang kh)
        {          
            if(ModelState.IsValid)
            {               
                db.KhachHangs.Add(kh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }            
           return View();
        }
    }
}