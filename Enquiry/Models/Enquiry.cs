using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enquiry.Models
{
    public class Enquiry
    {
        public int EnquiryId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Emailid { get; set; }
        public string Mobilenumber { get; set; }
        public string EducationQualification { get; set; }
        public string Experience { get; set; }       
        public string Domain { get; set; }
        public int CoursesId { get; set; }
        public int ChanelId { get; set; }
        public int SourcesId { get; set; }
      
    }
}