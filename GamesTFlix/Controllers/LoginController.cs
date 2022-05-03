using GamesTFlix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesTFlix.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void ChecarLogin()
        {
            var usuario = new Usuarios();
            usuario.Email = Request["Email"];
            usuario.SenhaUsuario = Request["SenhaUsuario"];

            if (usuario.Login())
            {
                Session["Autorizado"] = "OK";
                Response.Redirect("/Home/Index");
            }
            else
            {
                Response.Redirect("/Login/Index");
            }
        }
    }
}