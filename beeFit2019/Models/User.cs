using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace beeFit2019.Models
{
    public class User
    {
        
        public int Id { get; set; }

        public string Email { get; set; }
        
        public string Name { get; set; }

       
        public string Password { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date of birth")]
        public DateTime? DateOfBirth { get; set; }

        public int Height { get; set; }

              
    }
}
