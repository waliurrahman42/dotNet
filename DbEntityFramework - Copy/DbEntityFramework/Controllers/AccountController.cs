using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DbEntityFramework.Models.collageDb;


namespace DbEntityFramework.Controllers
{
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
                    /* ViewBag.UserName = login.Username;
                     TempData["UserName"]=login.Username;*//*

                    // cookies
                     HttpCookie ht = new HttpCookie("PGDAC");
                     ht.Values.Add("UserName", login.Username);
                     ht.Values.Add("LoginTime", DateTime.Now.ToString());

                     //to create presistant cookies
                     ht.Expires= DateTime.Now.AddMinutes(2);

                     //wruiting cookie data with current responce
                     Response.Cookies.Add(ht);*/

                    //Using session 
                    Session["UserName"] = login.Username;
                    Session["LoginTime"]=DateTime.Now;
                    
                    
                    return RedirectToAction("UserProfile");
                }
                else
                {
                    ModelState.AddModelError("","Invalid Username/Password");
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


        public ActionResult Register()
        {


            return View();
        }

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
           
            //resteing cookies
         /*   HttpCookie cookie = Request.Cookies["PGDAC"];
            cookie.Expires = DateTime.Now.AddMilliseconds(-1);
            Response.Cookies.Add(cookie);*/


            Session.Abandon();

            return View("Login");
        }




        public ActionResult SessionExpired()
        {
            return  View();
        }
    }
}