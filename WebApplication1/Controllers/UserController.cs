using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Music(string Music,float? User)

        {
            ViewBag.Music = Music;
            ViewBag.User = User;
            return View();
        }
    }
}