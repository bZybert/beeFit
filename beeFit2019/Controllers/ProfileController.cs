using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beeFit2019.Data;
using beeFit2019.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace beeFit2019.Controllers
{
    public class ProfileController : Controller
    {
        private DataContext _conterxt;

        public ProfileController(DataContext dataContext)
        {
            _conterxt = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> SetProfileDetails()
        {
            var list = new List<SelectListItem>()
                {
                        new SelectListItem()
                {
                Text = "Body measurements",
                Value = "1"
                },
                new SelectListItem()
                {
                Text = "Race result",
                Value = "2"
                }
                };

            ViewBag.Options = list;


            return View();

        }

        [HttpPost]
        public async Task<IActionResult> SetProfileDetails(Body body)
        {
            if (ModelState.IsValid)
            {



                var user = _conterxt.Users.FirstOrDefault(x => x.Name == User.Identity.Name);


                Body paramsUpd = new Body
                {
                    Id = body.Id,
                    Day = body.Day,
                    LBic = body.LBic,
                    RBic = body.RBic,
                    Waist = body.Waist,
                    Chest = body.Chest,
                    LThigh = body.LThigh,
                    RThigh = body.RThigh,
                    UserId = user.Id

                };



                _conterxt.BodyParameters.Add(paramsUpd);

                await _conterxt.SaveChangesAsync();

                return View("SuccessfullyUpdatedProfile");
            }


            return View(body);
        }

        [HttpPut]
        public IActionResult UpdateProfileDetails(int id)
        {
            return View();
        }
    }
}