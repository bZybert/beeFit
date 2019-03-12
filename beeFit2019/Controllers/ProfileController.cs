using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beeFit2019.Models;
using Microsoft.AspNetCore.Mvc;

namespace beeFit2019.Controllers
{
    public class ProfileController : Controller
    {
        public ProfileController()
        {

        }

        [HttpGet]
        public IActionResult SetProfileDetails()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SetProfileDetails(User user)
        {
            return View();
        }

        [HttpPut]
        public IActionResult UpdateProfileDetails(int id)
        {
            return View();
        }
    }
}