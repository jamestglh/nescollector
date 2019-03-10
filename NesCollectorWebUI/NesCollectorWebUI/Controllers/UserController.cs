using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NesCollector.Models;
using NesCollector.Service.Services;

namespace NesCollectorWebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private readonly IUserGameService _userGameService;
        private readonly IWishlistService _wishlistService;
        private readonly UserManager<AppUser> _userManager;

        public UserController(IUserGameService userGameService, 
            IWishlistService wishlistService, 
            UserManager<AppUser> userManager)
        {
            _userGameService = userGameService;
            _wishlistService = wishlistService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUserGames()
        {
            var userId = _userManager.GetUserId(User);
            var userGames = _userGameService.GetUserGamesByUserId(userId);

            return View(userGames);
        }
    }
}