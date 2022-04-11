using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcWebProject.Models;

namespace MvcWebProject.Controllers
{
    public class ParsingDataController : Controller
    {
        // GET: ParsingData
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public string Index(string fname, string lname)
        {
            return "data using parameters:" + fname + "&nbsp" + lname;
        }

        
        
        
        [HttpPost]
        public string PostUsingRequest()
        {
            return "data using Request:" + Request["fname"] + "&nbsp" + Request["lname"];
        }



        [HttpPost]
        public string PostUsingForm(FormCollection form)
        {
            return "data using data FromCollection:" + form["fname"] + "&nbsp" + form["lname"];
        }




        public ViewResult RegisterStudent()
        {
            return View();
        }




        //post using model
        //[HttpPost]
        //public String RegisterStudent(Student std)
        //{
        //    return $"Data using model:\t ID: {std.Id}\t name: {std.Name}\t address :{std.Address}\t marks: {std.Marks}";
        //}



        [HttpPost]
        public ViewResult RegisterStudent(Student std)
        {
            return View("Details",std);
        }

    }


}