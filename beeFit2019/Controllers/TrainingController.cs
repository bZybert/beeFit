using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace beeFit2019.Controllers
{
    public class TrainingController : Controller
    {
        [HttpGet]
        public IActionResult ViewOfTheWeek()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditTrainingPlan()
        {
            var list = new List<SelectListItem>()
            {
                    new SelectListItem()
                    {
                    Text = "1",
                    Value = "1"
                    },

                    new SelectListItem()
                    {
                    Text = "2",
                    Value = "2"
                    },
                    new SelectListItem()
                    {
                    Text = "3",
                    Value = "3"
                    },
                    new SelectListItem()
                    {
                    Text = "4",
                    Value = "4"
                    },

            };

            ViewBag.weeknumber = list;
            return View();
        }
    }
}