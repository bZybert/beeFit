using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beeFit2019.Data;
using beeFit2019.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace beeFit2019.Controllers
{
    public class ProgressController : Controller
    {
        private DataContext _context;

        public ProgressController(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<IActionResult> ProgressTable()
        {
            var userId = await _context.Users.SingleOrDefaultAsync(x => x.Name == User.Identity.Name);

            var progressList = _context.BodyParameters.ToList();

            progressList = progressList.FindAll(x => x.UserId == userId.Id).ToList();
            
            if(progressList != null)
            {
            return View(progressList);
            }

            return View("NoProgressData");
            
        }
    }
}