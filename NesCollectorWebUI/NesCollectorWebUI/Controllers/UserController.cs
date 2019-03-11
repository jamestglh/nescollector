using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NesCollector.Models;
using NesCollector.Service.Services;
using NesCollectorWebUI.ViewModels;

namespace NesCollectorWebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private readonly IUserGameService _userGameService;
        private readonly IWishlistService _wishlistService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IGameService _gameService;

        public UserController(IUserGameService userGameService, 
            IWishlistService wishlistService,
            IGameService gameService,
            UserManager<AppUser> userManager)
        {
            _userGameService = userGameService;
            _wishlistService = wishlistService;
            _userManager = userManager;
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListUserGames(UserCollectionViewModel vm)
        {
            var games = _gameService.GetByGameConsoleId(1);
            vm.Games = games;
            var userId = _userManager.GetUserId(User);
            vm.UserGames = _userGameService.GetUserGamesByUserId(userId);

            return View(vm);
        }
    }
}