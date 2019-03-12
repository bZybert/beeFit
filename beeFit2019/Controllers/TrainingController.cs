using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace beeFit2019.Controllers
{
    public class TrainingController : Controller
    {
        public IActionResult ViewOfTheWeek()
        {
            return View();
        }
    }
}