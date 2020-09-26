using LTQL.Models;
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
        //http post la phuong thuc de nhap du lieu tu client gui len
        [HttpPost]
        public ActionResult Create(KhachHang kh)
        {
            //kiem tra du lieu o model
            if(ModelState.IsValid)
            {
                //kh la du lieu cua doi tuong khach hang ma client gui len
                db.KhachHangs.Add(kh);
                //luu thong tin thay doi voi database
                db.SaveChanges();
                //dieu huong den trang index neu thuc hien thang cong
                return RedirectToAction("Index");
            }
            //tra ve view nhap thong tin khach hang
            return View();
        }
    }
}