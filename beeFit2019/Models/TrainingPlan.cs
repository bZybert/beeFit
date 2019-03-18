using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }

        [Range(1,4)]
        public int WeekNumber { get; set; }

        public string Mon { get; set; }
        public string Tue { get; set; }
        public string Wed { get; set; }
        public string Thr { get; set; }
        public string Fri { get; set; }
        public string Sat { get; set; }
        public string Sun { get; set; }

        public int UserId { get; set; }
    }
}
