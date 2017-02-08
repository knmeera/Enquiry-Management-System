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
            return View();
        }

        public ActionResult Create()
        {
            Course ObjCourse = new Course();
            Chanel Objchanel = new Chanel();
            Source ObjSource = new Source();
            // List<Course> ListOfCourses = ObjCourse.ListOfCourses();
            ViewBag.Courses = new SelectList(ObjCourse.ListOfCourses(),  "CourseId", "CourseName");
            ViewBag.Chanels = new SelectList(Objchanel.ListOfChanels(),  "ChanelId", "ChanelName");
            ViewBag.Sources = new SelectList(ObjSource.ListofSources(),  "SourceId", "SourceName");
            return View();

        }

    }
}
