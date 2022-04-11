using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebProject.Controllers
{
    public class HtmlHelperDemoController : Controller
    {
        // GET: HtmlHelperDemo
        public ActionResult Index()
        {
            ViewBag.courses = new string[] { "java", "c++", " php", "React" };
            return View();
        }

        public ViewResult StandardHelper()
        {
            ViewBag.Qualification = new string[] { "mtech", "mba", " mca", "btech" };


            ViewBag.City = new SelectList(
                                            new string[] { "patna", "delhi", " ranchi  ", "mubai" }
                                         );

            return View();
        }

        [HttpPost]
        public string StandardHelper(FormCollection form)
        {
            return "Details: \t Id:   " + form["Id"] + "City:\t " + form["City"] + "Name: " + form["Name"] + "Gender:\t " + form["Gender"] + "Qulafication:\t " + form["Qualfication"];
        }


        public ViewResult TempletedHellper()
        {
            return View();
        }

        public ViewResult CustomHelper()
        {
            return View();
        }












    }
}