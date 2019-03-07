using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NesCollector.Service.Services;

namespace NesCollectorWebUI.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        private readonly IUserGameService _userGameService;
        private readonly IWishlistService _wishlistService;

        public UserController(IUserGameService userGameService, IWishlistService wishlistService)
        {
            _userGameService = userGameService;
            _wishlistService = wishlistService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}