using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartAccount.Models;
namespace SmartAccount.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult vwUser()
        {
            SmartAccountEntities entity = new SmartAccountEntities();
            User kul = new User() { UserId = Guid.NewGuid(), UserLoginName = "Sebahattin TONBUL", UserName = "stonbul" };
            entity.Users.AddObject(kul);
            entity.SaveChanges();
            return View();
        }

    }
}
