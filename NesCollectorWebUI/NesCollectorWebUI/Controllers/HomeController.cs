using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NesCollector.Service.Services;
using NesCollectorWebUI.Models;

namespace NesCollectorWebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameService _gameService;

        //constructor
        public HomeController(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult Index()
        {
            var game = _gameService.GetById(345);
            return View(game);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
