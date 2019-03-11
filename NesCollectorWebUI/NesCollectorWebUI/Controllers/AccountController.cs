using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NesCollector.Models;
using NesCollectorWebUI.ViewModels;

namespace NesCollectorWebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly List<IdentityRole> _roles;

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager) // constructor for dependancy injection
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _roles = _roleManager.Roles.ToList();
        }


        [HttpGet]
        public IActionResult Register()
        {
            //need to populate roles before rendering view, if you want ppl to choose roles
            var vm = new RegisterViewModel
            {
                Roles = new SelectList(_roles)
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var newUser = new AppUser
                {
                    Email = vm.Email,
                    UserName = vm.Email
                };
                var result = await _userManager.CreateAsync(newUser, vm.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(newUser, vm.Role); // apply role

                    await _signInManager.SignInAsync(newUser, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            vm.Roles = new SelectList(_roles);
            return View(vm);
            
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            //if (User != null)
            //{
            //    return RedirectToAction("Index", "Home");
            //}
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LogInViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.Email, vm.Password, vm.RememberMe, false);

                if (result.Succeeded)
                {
                    // get user
                    var user = await _userManager.FindByEmailAsync(vm.Email);
                    //identify role
                    bool isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                    //redirect to right controller based on role
                    if (isAdmin)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("Index", "User");
                    }
                }
                else
                {
                    ModelState.AddModelError("SignIn", "Incorrect Username or Password!");
                }
            }

            return View(vm);
        }

        public IActionResult LogOut()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
 }
