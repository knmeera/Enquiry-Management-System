using Enquiry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enquiry.Controllers
{
    public class EnquiryController : Controller
    {
        //
        // GET: /Enquiry/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Enquiry/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Enquiry/Create

        public ActionResult Create()
        {
            Course ObjCourse = new Course();
            Chanel Objchanel = new Chanel();
            Source ObjSource = new Source();
            // List<Course> ListOfCourses = ObjCourse.ListOfCourses();
            ViewBag.Courses = new SelectList(ObjCourse.ListOfCourses(), "CourseId", "CourseName");
            ViewBag.Chanels = new SelectList(Objchanel.ListOfChanels(), "ChanelId", "ChanelName");
            ViewBag.Sources = new SelectList(ObjSource.ListofSources(), "SourceId", "SourceName");
            return View();
        }

        //
        // POST: /Enquiry/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                if (!ModelState.IsValid)
                {


                    var firstname = Convert.ToString(collection["txt_first_name"]);
                    var Lastname = Convert.ToString(collection["txt_last_name"]);
                    var Emailid = Convert.ToString(collection["txt_Emailid"]);
                    var Mobilenumber = Convert.ToString(collection["txt_Mobilenumber"]);
                    var EducationQualification = Convert.ToString(collection["txt_EducationQualification"]);
                    var Experience = Convert.ToString(collection["txt_Experience"]);
                    var Course = Convert.ToString(collection["Courses"]);
                    var Domain = Convert.ToString(collection["txt_Domain"]);
                    var EnquiryChanel = Convert.ToString(collection["Chanels"]);
                    var EnquirySource = Convert.ToString(collection["Sources"]);


                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Enquiry/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Enquiry/Edit/5

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

        //
        // GET: /Enquiry/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Enquiry/Delete/5

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
