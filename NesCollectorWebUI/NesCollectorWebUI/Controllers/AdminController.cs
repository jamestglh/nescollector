using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NesCollector.Service.Services;

namespace NesCollectorWebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserGameService _userGameService;
        private readonly IWishlistService _wishlistService;
        private readonly IGameService _GameService;
        private readonly IUserService _userService;

        public AdminController(IUserGameService userGameService, IWishlistService wishlistService, 
            IUserService userService, IGameService gameService)
        {
            _userGameService = userGameService;
            _wishlistService = wishlistService;
            _GameService = gameService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}