using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Models
{
    public class Runner
    {
        public int Id;
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Day { get; set; }
        public int Distance;
        public string Time;
        public string Record;
        public string Goal;
    }
}
