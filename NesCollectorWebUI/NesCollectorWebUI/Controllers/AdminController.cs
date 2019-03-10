﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NesCollector.Models;
using NesCollector.Service.Services;
using NesCollectorWebUI.ViewModels;

namespace NesCollectorWebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IUserGameService _userGameService;
        private readonly IWishlistService _wishlistService;
        private readonly IGameService _GameService;
        private readonly IUserService _userService;
        private readonly IHostingEnvironment _environment;

        public AdminController(IUserGameService userGameService,
            IWishlistService wishlistService,
            IUserService userService,
            IGameService gameService,
            IHostingEnvironment environment)
        {
            _userGameService = userGameService;
            _wishlistService = wishlistService;
            _GameService = gameService;
            _userService = userService;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAllGames()
        {
            var games = _GameService.GetByGameConsoleId(1);
            return View(games);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateGameViewModel vm)
        {
            Game newGame = vm.Game;
            IFormFile image = vm.Image;
            

            //upload image

            if (image != null && image.Length > 0)
            {
                string storageFolder = Path.Combine(_environment.WebRootPath, "img/games");
                string newImageName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}"; // gives the image name a guid and puts the extension on the end


                string fullPath = Path.Combine(storageFolder, newImageName); // builds path to image, goes to stream

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
                //append img location to new home
                newGame.CoverURL = $"/img/games/{newImageName}";
                newGame.SystemId = "NES";
                newGame.GameConsoleId = 1;
            }
            
            //save newGame
            _GameService.Create(newGame);

            return RedirectToAction("ListAllGames");
        }
    }
}