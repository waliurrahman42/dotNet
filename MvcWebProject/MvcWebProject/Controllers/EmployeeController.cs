using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcWebProject.Models;

namespace MvcWebProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Emplyoee
        public ActionResult Index()
        {
            return View();
        }

        public String Name()
        {
            return "wali";
        }

        public string Hello()
        {
            return "wellcome to ASP.Net MVC";
        }

        string Id()
        {
            return "1";
        }


        public string EmpProfile(int ? id)
        {
            string profile = string .Empty;
           
            switch (id)
            {
                case 1:profile = "emp-1 profile";
                    break;
                case 2:
                    profile = "emp-2 profile";
                    break;
                case 3:
                    profile = "emp-3 profile";
                    break;

                default:
                    profile = "no emp found";
                    break;
            }

            return profile;
        }

        public ActionResult ContactUs()
        {
            ViewBag.Message = "employee contact us view page";
            ViewBag.Id = 1000;
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Message = "employee About Us view page";
            return View();
        }

        public ViewResult GetAllEmployee()
        {
            ViewBag.Message = "Get All Employee View Page";
            //passing  VIEW name on other then action name to render the reponse
            return View("GetEmployee");
        }


        //method to return employee object

        Employee GetEmployee()
        {
            return new Employee()
            {
                Id = 1000,
                Name ="wali",
                Salary =5000.00f,
            };
        }

        public ViewResult ViewEmployee()
        {
            var emp = GetEmployee();
            return View(emp);//passing employee model object with view
        }
    }
}