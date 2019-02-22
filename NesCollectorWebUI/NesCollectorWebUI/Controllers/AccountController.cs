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

        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager) // constructor for dependancy injection
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        [HttpGet]
        public IActionResult Register()
        {
            //need to populate roles before rendering view, if you want ppl to choose roles
            var vm = new RegisterViewModel
            {
                Roles = new SelectList(_roleManager.Roles.ToList())
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //if form is valid register the user
            }
            return View(vm);
            
        }
    }
}