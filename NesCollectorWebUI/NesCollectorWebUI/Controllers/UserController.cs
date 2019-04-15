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
        [HttpGet]
        public IActionResult ListUserGames(UserCollectionViewModel vm)
        {
            var games = _gameService.GetByGameConsoleId(1);
            vm.Games = games;
            var userId = _userManager.GetUserId(User);
            vm.UserGames = _userGameService.GetUserGamesByUserId(userId);
            foreach (UserGame u in vm.UserGames)
            {
                vm.TotalValue = vm.TotalValue + u.Value;
            }

            return View(vm);
        }

        public IActionResult ListWishlist(UserWishlistViewModel vm)
        {
            var games = _gameService.GetByGameConsoleId(1);
            vm.Games = games;
            var userId = _userManager.GetUserId(User);
            vm.UserWishlist = _wishlistService.GetWishlistGamesByUserId(userId);

            return View(vm);
        }

        [HttpGet]
        public IActionResult AddGame()
        {
            UserCollectionViewModel vm = new UserCollectionViewModel();
            vm.Games = _gameService.GetByGameConsoleId(1);
            var userId = _userManager.GetUserId(User);
            vm.UserGames = _userGameService.GetUserGamesByUserId(userId);
            return View(vm);
        }

        [HttpPost]
        public IActionResult AddGame(UserCollectionViewModel vm)
        {
            var gameFromView = vm.Game;
            vm.Games = _gameService.GetByGameConsoleId(1);
            var gameFromViewTitle = vm.Game.Title;
            var ug = vm.UserGame;

            foreach (Game g in vm.Games)
            {
                if (gameFromViewTitle == g.Title)
                {
                    gameFromView = g;
                    ug.GameId = gameFromView.Id;
                }
            }
            ug.UserId = _userManager.GetUserId(User);

            if (ug.HasBox && ug.HasManual)
            {
                ug.Value = gameFromView.CibPrice;
            }
            else
            {
                ug.Value = gameFromView.LoosePrice;
            }

            _userGameService.Create(ug);
            return RedirectToAction("ListUserGames");
        }

        [HttpGet]
        public IActionResult AddWishlist()
        {
            UserWishlistViewModel vm = new UserWishlistViewModel();
            vm.Games = _gameService.GetByGameConsoleId(1);
            var userId = _userManager.GetUserId(User);
            vm.UserWishlist = _wishlistService.GetWishlistGamesByUserId(userId);
            return View(vm);
        }

        [HttpPost]
        public IActionResult AddWishlist(UserWishlistViewModel vm)
        {
            Game gameFromView = vm.Game;
            vm.Games = _gameService.GetByGameConsoleId(1);
            string gameFromViewTitle = vm.Game.Title;
            Wishlist wishlistGame = vm.Wishlist;

            foreach (Game g in vm.Games)
            {
                if (gameFromViewTitle == g.Title)
                {
                    gameFromView = g;
                    vm.Wishlist = new Wishlist { GameId = gameFromView.Id, UserId = _userManager.GetUserId(User), MaxPrice = vm.MaxPrice };

                }
            }
            //wishlistGame.UserId = _userManager.GetUserId(User);


            _wishlistService.Create(vm.Wishlist);
            return RedirectToAction("ListWishlist");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            UserCollectionViewModel vm = new UserCollectionViewModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, UserCollectionViewModel vm)
        {
            try
            {
                _userGameService.DeleteById(id);
                return RedirectToAction("ListUserGames");
            }
            catch
            {
                return RedirectToAction("ListUserGames");
            }
        }

        [HttpGet]
        public ActionResult DeleteWishlist(int id)
        {
            UserCollectionViewModel vm = new UserCollectionViewModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteWishlist(int id, UserCollectionViewModel vm)
        {
            try
            {
                _wishlistService.DeleteById(id);
                return RedirectToAction("ListWishlist");
            }
            catch
            {
                return RedirectToAction("ListWishlist");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            UserCollectionViewModel vm = new UserCollectionViewModel();
            return View(vm);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, UserCollectionViewModel vm)
        //{
        //    UserGame userGameToEdit = _userGameService.GetById(id);
        //    UserGame ugFromVm = vm.UserGame;
        //    ugFromVm.GameId = userGameToEdit.GameId;
        //    ugFromVm.UserId = userGameToEdit.UserId;
        //    vm.Game = _gameService.GetById(userGameToEdit.GameId);
        //    vm.Games = _gameService.GetByGameConsoleId(1);
            

        //    foreach (Game g in vm.Games)
        //    {
        //        if (vm.Game.Title == g.Title)
        //        {
        //            vm.Game = g;
        //            ugFromVm.GameId = vm.Game.Id;
        //        }
        //    }

        //    if (ugFromVm.HasBox && ugFromVm.HasManual)
        //    {
        //        ugFromVm.Value = vm.Game.CibPrice;
        //    }
        //    else
        //    {
        //        ugFromVm.Value = vm.Game.LoosePrice;
        //    }
        //    _userGameService.Create(ugFromVm);

        //    try
        //    {
        //        _userGameService.DeleteById(id);
        //        return RedirectToAction("ListUserGames");
        //    }
        //    catch
        //    {
        //        return RedirectToAction("ListUserGames");
        //    }
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UserCollectionViewModel vm)
        {
            UserGame userGameToEdit = _userGameService.GetById(id);
            UserGame ugFromVm = vm.UserGame;
            ugFromVm.GameId = userGameToEdit.GameId;
            ugFromVm.UserId = userGameToEdit.UserId;
            ugFromVm.Id = userGameToEdit.Id;
            vm.Game = _gameService.GetById(userGameToEdit.GameId);
            vm.Games = _gameService.GetByGameConsoleId(1);

            foreach (Game g in vm.Games)
            {
                if (vm.Game.Title == g.Title)
                {
                    vm.Game = g;
                    ugFromVm.GameId = vm.Game.Id;
                }
            }
            if (ugFromVm.HasBox && ugFromVm.HasManual)
            {
                ugFromVm.Value = vm.Game.CibPrice;
            }
            else
            {
                ugFromVm.Value = vm.Game.LoosePrice;
            }
            try
            {
                _userGameService.Update(ugFromVm);
                return RedirectToAction("ListUserGames");
            }
            catch
            {
                return RedirectToAction("ListUserGames");
            }
        }

        [HttpGet]
        public ActionResult EditWishlist(int id)
        {
            UserWishlistViewModel vm = new UserWishlistViewModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditWishlist(int id, UserWishlistViewModel vm)
        {
            Wishlist wishlistToEdit = _wishlistService.GetById(id);
            Wishlist wishlistFromVm = vm.Wishlist;
            wishlistFromVm.GameId = wishlistToEdit.GameId;
            wishlistFromVm.UserId = wishlistToEdit.UserId;
            wishlistFromVm.Id = wishlistToEdit.Id;
            vm.Game = _gameService.GetById(wishlistToEdit.GameId);
            vm.Games = _gameService.GetByGameConsoleId(1);

            try
            {
                _wishlistService.Update(wishlistFromVm);
                return RedirectToAction("ListWishlist");
            }
            catch
            {
                return RedirectToAction("ListWishlist");
            }
        }
    }
}