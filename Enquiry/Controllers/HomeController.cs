using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Enquiry.Models;

namespace Enquiry.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Course ObjCourse = new Course();
            Chanel Objchanel = new Chanel();
           // List<Course> ListOfCourses = ObjCourse.ListOfCourses();
            ViewBag.Courses = new SelectList(ObjCourse.ListOfCourses(), "CourseId", "CourseName");
            ViewBag.Chanels = new SelectList(Objchanel.ListOfChanels(), "ChanelId", "ChanelName");
            return View();
        }

    }
}
