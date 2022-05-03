using GamesTrailerFlix.Models;
using System.Web.Mvc;

namespace GamesTrailerFlix.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [Microsoft.AspNetCore.Mvc.HttpPost]
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
