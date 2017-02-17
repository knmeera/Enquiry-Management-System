using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Enquiry.Models
{
    public class Enquiry
    {
        
        public int EnquiryId { get; set; }
        [Required]
        [Display(Name = "Enter First name")]
        public string First_name { get; set; }
        [Required]
        [Display(Name = "Enter Last Name")]
        public string Last_name { get; set; }
        [Required]
        [Display(Name = "Enter Email id")]
        public string Emailid { get; set; }
        [Required]
        [Display(Name = "Enter Mobile number")]
        public string Mobilenumber { get; set; }
        [Required]
        [Display(Name = "Enter Qualification")]
        public string EducationQualification { get; set; }
        [Required]
        [Display(Name = "User name")]
        public string Experience { get; set; }
        [Required]
        [Display(Name = "User name")]
        public string Domain { get; set; }
   
        public int CoursesId { get; set; }
        
        public int ChanelId { get; set; }
       
        public int SourcesId { get; set; }
      
    }
}