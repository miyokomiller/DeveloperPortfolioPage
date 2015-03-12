using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DEVSITE.Controllers
{
    public class HomeController : Controller
    {
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
            ViewBag.Message = "If you have any questions, I have all the answers.";

            return View();
        }
        public ActionResult Works()
        {
            ViewBag.Message = "Your Works page.";
            return View();
        }
    }
}