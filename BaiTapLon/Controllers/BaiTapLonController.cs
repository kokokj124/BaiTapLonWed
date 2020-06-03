using BaiTapLon.Models.DAOO;
using BaiTapLon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BaiTapLon.Controllers
{
    public class BaiTapLonController : Controller
    {
        // GET: BaiTapLon
        static List<TungSanPham> listTungSanPham = new List<TungSanPham>();
        public ActionResult Index()
        {
            ViewBag.SanPham = new SanPhamDAO().getAll();
            return View("~/Views/BaiTapLon/index.cshtml");
        }
        public ActionResult Women(string ShoeFirm,String Type)
        {
            ViewBag.SanPham = new BaiTapLon.Models.DAOO.SanPhamDAO().getSanPham(ShoeFirm,Type);
            return View("~/Views/BaiTapLon/women.cshtml");
        }
        public ActionResult WomenShoeFirm(string ShoeFirm)
        {
            ViewBag.SanPham = new BaiTapLon.Models.DAOO.SanPhamDAO().getSanPham(ShoeFirm);
            return View("~/Views/BaiTapLon/women.cshtml");
        }
        public ActionResult Checkout()
        {
            ViewBag.listTungSanPham = listTungSanPham;
            return View("~/Views/BaiTapLon/checkout.cshtml");
        }
        public ActionResult Contact()
        {
            return View("~/Views/BaiTapLon/contact.cshtml");
        }
        public ActionResult Details(string Name)
        {
            ViewBag.SanPham = new BaiTapLon.Models.DAOO.SanPhamDAO().thongTinSanPham(Name);
            return View("~/Views/BaiTapLon/details.cshtml");
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult Login()
        {
            return View("~/Views/BaiTapLon/login.cshtml");
        }

        [System.Web.Mvc.HttpPost]
        public JsonResult Login(string email,string password)
        {
            if (new BaiTapLon.Models.DAOO.LoginDAO().checkUser(email, password) == "Success")
            {
                return Json("Success", JsonRequestBehavior.AllowGet);
            }
            else
                return Json("Erorr", JsonRequestBehavior.AllowGet);
        }

        [System.Web.Mvc.HttpPost]
        public JsonResult creatUser(string FirstName,string LastName,String Email,bool Sex,String Password)
        {
            Login user = new Login();
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.Email = Email;
            user.Sex = true;
            user.Password = Password;
            if (new BaiTapLon.Models.DAOO.LoginDAO().createUser(user) == "Success")
                return Json("Success", JsonRequestBehavior.AllowGet);
            else
                return Json("Erorr", JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddSanPham(String Image, int Price, String Name, String ShoeFirm)
        {
            TungSanPham tungSanPham = new TungSanPham();
            tungSanPham.Image = Image;
            tungSanPham.Price = Price;
            tungSanPham.ShoeFirm = ShoeFirm;
            tungSanPham.Name = Name;
            if (tungSanPham != null)
            {
                listTungSanPham.Add(tungSanPham);
                return Content("Success");
            }
            else
                return Content("Erorr");
        }

        public ActionResult DeleteSanPham(int id)
        {
            listTungSanPham.RemoveAt(id);
            return Content("Success");
        }

        public ActionResult Register()
        {
            return View("~/Views/BaiTapLon/register.cshtml");
        }
    }
}