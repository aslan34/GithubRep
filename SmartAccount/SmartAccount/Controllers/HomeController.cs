using System.Web.Mvc;
using System.Web.Security;

namespace SmartAccount.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            return PartialView("Index");
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }

    }
}
