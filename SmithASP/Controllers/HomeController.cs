using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmithASP.Models;
using SmithASP.ViewModels;

namespace SmithASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var loginResults = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (loginResults.Succeeded)
                {
                    return RedirectToAction("Index", "LoggedIn");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Login Information.");
                    return View(model);
                }
            }
            return RedirectToAction("Index", "Home");
        }
         
        /*
        public IActionResult Authenticate(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                //If the Login is valid then redirect to the Index action on the LoggedIn Controller
                return RedirectToAction("Index", "LoggedIn");
            }
            //Using RedirectToAction causes the asp-validation to not work
            return View("Index");
        }
        */
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var identityUser = new ApplicationUser
                {
                    UserName = model.Username,
                    Email = model.Username,
                };
                var identityResults = await _userManager.CreateAsync(identityUser, model.Password);
                if (identityResults.Succeeded)
                {
                    await _signInManager.SignInAsync(identityUser, isPersistent: false);
                    return RedirectToAction("Index", "LoggedIn");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error in creating user account.");
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(RegisterViewModel model)
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }


        //Forgot password should email a link to a reset password page
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            return View();
        }

        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}