using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkDemo.Models;
using EntityFrameworkDemo.Migrations;
using System.Data.Entity;

namespace EntityFrameworkDemo.Controllers
{
    public class StudentController : Controller
    {
        PGDACContext db=new PGDACContext();//creating db context for db  operation 
        
        // GET: Student
        public ActionResult Index()
        {
                           //SELECT * FROM table
            return View(db.Students.Include("Address").ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        //insert code to save student data
        [HttpPost]
        public ActionResult Create(Student student)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PGDACContext, Configuration>());
           
            //it will delete all previous data
            // Database.SetInitializer(new DropCreateDatabaseAlways<PGDACContext>());

            if (ModelState.IsValid) //validaton check
            {
                db.Students.Add(student);//adding current entity in  context
                db.SaveChanges();//saving in database
               // ViewBag.Message = "student data saved successfully";
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
