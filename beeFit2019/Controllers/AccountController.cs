using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beeFit2019.Data;
using beeFit2019.Dtos;
using beeFit2019.Models;
using beeFit2019.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace beeFit2019.Controllers
{
    public class AccountController : Controller
    {
        private DataContext _dataContext;
        protected UserManager<IdentityUser> UserManager { get; }
        protected SignInManager<IdentityUser> SignInManager { get; }

        public AccountController(DataContext dataContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _dataContext = dataContext;
            UserManager = userManager;
            SignInManager = signInManager;
        }

        protected override void Dispose(bool disposing)
        {
            _dataContext.Dispose();
        }

        [HttpGet]
        public IActionResult Register()
        {
            

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User viewModel)
        {
            viewModel.Name = viewModel.Name.ToLower();

            if (ModelState.IsValid)
            {
                var user = new IdentityUser(viewModel.Name) { Email = viewModel.Email };
                var result = await UserManager.CreateAsync(user, viewModel.Password);  
                if (result.Succeeded)
                {
                 

                    var newUser = new User
                    {
                        Name = viewModel.Name,
                        Email = viewModel.Email,
                        Password = viewModel.Password,
                        Height = viewModel.Height,
                        DateOfBirth = viewModel.DateOfBirth
                        
                        
                    };

                    await _dataContext.Users.AddAsync(newUser); 
                    await _dataContext.SaveChangesAsync();
                    
                    return RedirectToAction("SetProfileDetails", "Profile");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserForLoginDto viewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await SignInManager.PasswordSignInAsync(viewModel.Name,
                viewModel.Password, viewModel.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("SetProfileDetails", "Profile");
                }
                else
                {
                    ModelState.AddModelError("", "Nie można się zalogować!");
                }
            }
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}