using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Selenium_MVC.Models
{
    public class Profile
    {
        [Required]
        [Display(Name = "Given name")]
        public string First_Name { get;set; }

        [Required]
        [Display(Name = "Surname")]
        public string Last_Name { get; set; }

        [Required]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0{:yyyy-MM-dd}")]
        public DateTime DOB { get; set; }

        [Display(Name = "Full name")]
        public string Fullname { get; set; }

        public int Age
        {
            get
            {
                if (DateTime.Now.DayOfYear > DOB.DayOfYear)
                {
                    return DateTime.Now.Year - DOB.Year - 1;
                }
                else
                {
                    return DateTime.Now.Year - DOB.Year;
                }
            }
        }
    }
}