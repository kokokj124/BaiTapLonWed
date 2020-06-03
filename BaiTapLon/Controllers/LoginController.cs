using BaiTapLon.Models.DAOO;
using BaiTapLon.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace BaiTapLon.Controllers
{
    public class LoginController : Controller
    {
        bool login = false;
        // GET: Login
        [ChildActionOnly]
        public ActionResult Login(string email, string password)
        {
            if (new BaiTapLon.Models.DAOO.LoginDAO().checkUser(email, password) == "Success")
            {
                ViewBag.SanPham = new SanPhamDAO().getAll();
                return PartialView("Success");
            }
            else
                return Content("Erorr");
        }
        //public ActionResult creatUser(creatUser user)
        //{
        //    if (new BaiTapLon.Models.DAOO.LoginDAO().createUser(user) == "Success")
        //        return Content("Succress");
        //    else
        //        return Content("Erorr");
        //}
    }
}
