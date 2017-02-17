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

       

        public ActionResult AboutUs()
        {

            return View();
        }

    }
}
