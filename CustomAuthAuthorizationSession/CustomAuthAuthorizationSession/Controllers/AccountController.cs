using CustomAuthAuthorizationSession.Security;
using CustomAuthAuthorizationSession.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthAuthorizationSession.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            if(string.IsNullOrEmpty(avm.account.Username)|| string.IsNullOrEmpty(avm.account.Password))
            {
                ViewBag.Error = "Account is invaild";
                return View("Index");
            }
            SessionPersister.Username = avm.account.Username;
            return View("Success");
        }

        public ActionResult Logout()
        {
            SessionPersister.Username = string.Empty;
            return RedirectToAction("Index");
        }
    }
}