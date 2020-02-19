using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class students
    {
        [Key]
        public int id { get; set; }
        [Display(Name="First Name:")]
        public string name { get; set; }
        [Display(Name = "Last Name:")]
        public string lastname { get; set; }
        [Display(Name = "Gender:")]
        public string sex { get; set; }
        [Display(Name = "Address:")]
        public string address { get; set; }
    }
}