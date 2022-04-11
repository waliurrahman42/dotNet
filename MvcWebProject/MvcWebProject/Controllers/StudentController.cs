using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWebProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student

        [Route("students/{sid?}")]
        public ActionResult Index(string sid)
        {
            ViewBag.Id = sid;
            return View();
        }




        [Route("students/{studentId}/courses")]
        public ViewResult GetStudentCourses(int ? studentId)
        {
           List<string> courses =new List<string>();//list to store courses

            switch (studentId)
            {
                case 1: courses = new List<string>() { "c", "c++", "java" };
                          break;
                case 2:
                    courses = new List<string>() { "asp.net", "c", "php" };
                    break;
                case 3:
                    courses = new List<string>() { "ruby", "python", "reach" };
                    break;
                default:
                    courses = new List<string>() { "html", "css", "bootstrap" };
                    break;
            }

            ViewBag.Courses = courses;
            return View();
        }
    }
}