using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Models
{
    public class BodyGoals
    {
        public int Id { get; set; }
        public DateTime Day { get; set; }
        public double LBic { get; set; }
        public double RBic { get; set; }
        public double Waist { get; set; }
        public double Chest { get; set; }
        public double LThigh { get; set; }
        public double RThigh { get; set; }
        public double Weight { get; set; }
    }
}
