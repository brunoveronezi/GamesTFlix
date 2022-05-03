using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesTFlix.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Descrição da página";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contato";

            return View();
        }
    }
}