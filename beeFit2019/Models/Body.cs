using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Models
{
    public class Body
    {
        public int Id { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date: MM/dd/yyyy")]
        public DateTime Day { get; set; }
        [Display(Name = "Left biceps")]
        public double LBic { get; set; }
        [Display(Name = "Right biceps")]
        public double RBic { get; set; }
        public double Waist { get; set; }
        public double Chest { get; set; }
        [Display(Name = "Left thigh")]
        public double LThigh { get; set; }
        [Display(Name = "Right thigh")]
        public double RThigh { get; set; }
        public double Weight { get; set; }

       public int  UserId { get; set; }
    }
}
