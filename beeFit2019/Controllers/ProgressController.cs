using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beeFit2019.Data;
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

        public IActionResult ProgressTable(int id)
        {
            var body = _context.Users.Where(x=>x.Id == id).Include(x=>x.BodyMeasurements).ToList();
            return View(body);
        }
    }
}