using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTapLon.Controllers
{
    public class BaiTapLonController : Controller
    {
        // GET: BaiTapLon
        public ActionResult Index()
        {
            return View("~/Views/BaiTapLon/index.cshtml");
        }
        public ActionResult Women()
        {
            return View("~/Views/BaiTapLon/women.cshtml");
        }
        public ActionResult Checkout()
        {
            return View("~/Views/BaiTapLon/checkout.cshtml");
        }
        public ActionResult Contact()
        {
            return View("~/Views/BaiTapLon/contact.cshtml");
        }
        public ActionResult Details()
        {
            return View("~/Views/BaiTapLon/details.cshtml");
        }
        public ActionResult Login()
        {
            return View("~/Views/BaiTapLon/login.cshtml");
        }
        public ActionResult Register()
        {
            return View("~/Views/BaiTapLon/register.cshtml");
        }
    }
}