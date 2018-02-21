using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NomiSync.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NomipaqUtilities()
        {
            ViewData["Message"] = "Utilerias para Nomipaq (Nomina Maniobras)";

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Nomipaq Utilies.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Transmaquila.com";

            return View();
        }
    }
}