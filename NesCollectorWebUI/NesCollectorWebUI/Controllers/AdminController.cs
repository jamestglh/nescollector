using System;
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
        private readonly IGameService _gameService;
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
            _gameService = gameService;
            _userService = userService;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAllGames()
        {
            var games = _gameService.GetByGameConsoleId(1);
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
            _gameService.Create(newGame);

            return RedirectToAction("ListAllGames");
        }

        public IActionResult ListAllUsers()
        {
            var users = _userService.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(EditGameViewModel vm)
        {
            return View(vm);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Game gameToDelete = new Game();
            return View(gameToDelete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Game gameToDelete)
        {
            try
            {
                _gameService.DeleteById(gameToDelete.Id);
                return RedirectToAction("ListAllGames");
            }
            catch
            {
                return RedirectToAction("ListAllGames");
            }
        }

        [HttpGet]
        public ActionResult DeleteUser(string Id)
        {
            AppUser userToDelete = new AppUser();
            return View(userToDelete);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteUser(string id, AppUser userToDelete)
        {
            try
            {
                _userService.DeleteById(userToDelete.Id);
                return RedirectToAction("ListAllUsers");
            }
            catch
            {
                return RedirectToAction("ListAllUsers");
            }
        }
    }
}