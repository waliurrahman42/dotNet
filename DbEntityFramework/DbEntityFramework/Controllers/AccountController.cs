using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbEntityFramework.Models.collageDb;
using System.Web.Security;

namespace DbEntityFramework.Controllers
{

    [AllowAnonymous]
    public class AccountController : Controller
    {
        CollegeDbEntities db=new CollegeDbEntities();// creating object of collage 

        // GET: Account
        public ActionResult Login()
        {


            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {

               bool isValidUser= db.Logins.Any
                                 (u => u.Username == login.Username && u.Password == login.Password);

                if (isValidUser)
                {
                    FormsAuthentication.SetAuthCookie(login.Username, false);

                    return RedirectToAction("Index", "Students");

                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username/Password");
                    return View(login);
                }
            }
            return View(login);
        }



        public ActionResult UserProfile()
        {
            //using cookies
            /* if (Request.Cookies["PGDAC"]!=null)
             {
                 ViewBag.UserName = Request.Cookies["PGDAC"]["UserName"];
                 ViewBag.LoginTime = Request.Cookies["PGDAC"]["LoginTime"];
                 return View();
             }
             else
             {
                 return View("Login");
             }


 */
            //using session
            if (Session.IsNewSession)
            {
                return View("SessionExpired");
            }

            if (Session["UserName"] != null)
            {
                ViewBag.UserName = Session["UserName"];
                ViewBag.LoginTime =Session["LoginTime"];

                ViewBag.TotalVisitors = HttpContext.Application["Totalvisitor"];

                return View();
            }
            else
            {
                return View("Login");
            }

        }

      //  [AllowAnonymous]
        public ActionResult Register()
        {


            return View();
        }
        
      //  [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(Login login)
        {
            if (ModelState.IsValid)
            {
                db.Logins.Add(login);// to save user data in context
                db.SaveChanges();// to save user data in database
                return RedirectToAction("Login");// redirect to login page 
            }

            return View();
        }



        public ActionResult SignOut()
        {
           
            FormsAuthentication.SignOut();
            return View("Login");
        }




        public ActionResult SessionExpired()
        {
            return  View();
        }
    }
}