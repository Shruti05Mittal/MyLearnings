using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GaneshAlmirah.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            return View("Login", user);
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if(ModelState.IsValid)
            {
                GaneshAlmirahEntities db = new GaneshAlmirahEntities();
                var v = db.Logins.Where(a => a.UserName.Equals(user.UserName) && a.Password.Equals(user.Password)).FirstOrDefault();
                if(v!=null)
                {
                    Session["User"] = v.UserName.ToString();
                    return RedirectToAction("Main");
                }
            }
            return View(user);
        }
        public ActionResult Main()
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
    }
}