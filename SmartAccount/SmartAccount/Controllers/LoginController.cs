using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartAccount.Models;
using System.Web.Security;
namespace SmartAccount.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            //SmartAccountEntities entity = new SmartAccountEntities();
            //User kul = new User() { UserId = Guid.NewGuid(), UserLoginName = "Sebahattin TONBUL", UserName = "stonbul" };
            //entity.Users.AddObject(kul);
            //entity.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel lmodel)
        {
            if (ModelState.IsValid)
            {
                if (lmodel.UserName == "a" && lmodel.Password == "1")
                {
                    FormsAuthentication.SetAuthCookie(lmodel.UserName, false);
                    return RedirectToAction("index", "home"); //sayfa adı - klasör adı
                }
                else
                {
                    ModelState.AddModelError("", "Login failed.");
                }

            }
            return View();
        }

    }
}
