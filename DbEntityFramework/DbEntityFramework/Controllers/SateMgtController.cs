using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbEntityFramework.Controllers
{
    public class Test
    {
        public int Id { get; set; }
    }
    public class SateMgtController : Controller
    {
      
        
        // GET: SateMgt
        public ActionResult Index()
        {
            ViewData["Message"] = "Data from viewdata";
            ViewData["Test"]=new Test() { Id = 1001 };

            //writing data in tempdata
            TempData["mykey"] = "data from temp";


            return View();
        }


        public ActionResult Index2()
        {
            //reading from tempdata
            ViewBag.MyKey1 = TempData["mykey"];
            TempData.Keep("mykey");
            return View();
        }

        public ActionResult Index3()
        {
            //reading from tempdata
            ViewBag.MyKey2 = TempData["mykey"];
            TempData.Keep("mykey");
            return View();
        }

    }
}