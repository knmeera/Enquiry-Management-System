using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enquiry.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }


        public List<Course> ListOfCourses()
        {
            List<Course> CourseList = new List<Course>();
            

            CourseList.Add(new Course { CourseId = 1, CourseName = "ASP.NET MVC" });
            CourseList.Add(new Course { CourseId = 2, CourseName = "BUSINESS ANALYST" });
            CourseList.Add(new Course { CourseId = 3, CourseName = "JAVA" });
            CourseList.Add(new Course { CourseId = 4, CourseName = "SQL SERVER" });
            CourseList.Add(new Course { CourseId = 5, CourseName = "ORACLE" });
            CourseList.Add(new Course { CourseId = 6, CourseName = "RUBY" });
            CourseList.Add(new Course { CourseId = 7, CourseName = "PHP" });
            CourseList.Add(new Course { CourseId = 8, CourseName = "MSBI" });
            CourseList.Add(new Course { CourseId = 9, CourseName = "OBIEE" });
            CourseList.Add(new Course { CourseId = 10, CourseName = "TABLEAU" });
            CourseList.Add(new Course { CourseId = 10, CourseName = "CLICKVIEW" });
            return CourseList;
        }
    }
}