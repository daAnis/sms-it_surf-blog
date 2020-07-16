using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Surf_blog.DAL;


namespace Surf_blog.Controllers
{
    public class HomeController : Controller
    {
        SurfDBContext dBContext = new SurfDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BoardSelling()
        {
            ViewBag.Message = "Serfing club sells boards.";

            ViewBag.Ads = "Sells";

            ViewBag.Prices = new[] { 100, 120, 140, 90 };

            var user = dBContext.Users.FirstOrDefault();
            ViewBag.Seller = user;

            return View(user);
        }
    }
}