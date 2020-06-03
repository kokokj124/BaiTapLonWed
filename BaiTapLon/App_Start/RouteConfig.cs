using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BaiTapLon
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Index",
            url: "index/{id}",
            defaults: new { controller = "BaiTapLon", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Details",
            url: "details/{id}",
            defaults: new { controller = "BaiTapLon", action = "Details", id = UrlParameter.Optional }
            );


            routes.MapRoute(
            name: "Checkout",
            url: "checkout/{id}",
            defaults: new { controller = "BaiTapLon", action = "Checkout", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Contact",
            url: "contact/{id}",
            defaults: new { controller = "BaiTapLon", action = "Contact", id = UrlParameter.Optional }
            );


            routes.MapRoute(
            name: "Login",
            url: "login/{id}",
            defaults: new { controller = "BaiTapLon", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "CreatUser",
            url: "creatuser/{id}",
            defaults: new { controller = "BaiTapLon", action = "creatUser", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "AddSanPham",
            url: "addsanpham/{id}",
            defaults: new { controller = "BaiTapLon", action = "AddSanPham", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "DeleteSanPham",
            url: "deletesanpham/{id}",
            defaults: new { controller = "BaiTapLon", action = "DeleteSanPham", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Register",
            url: "register/{id}",
            defaults: new { controller = "BaiTapLon", action = "Register", id = UrlParameter.Optional }
            );


            routes.MapRoute(
            name: "Women",
            url: "women/{id}",
            defaults: new { controller = "BaiTapLon", action = "Women", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "BaiTapLon", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
