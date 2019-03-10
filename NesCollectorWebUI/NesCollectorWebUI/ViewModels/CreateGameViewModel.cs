using Microsoft.AspNetCore.Http;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NesCollectorWebUI.ViewModels
{
    public class CreateGameViewModel
    {
        public Game Game { get; set; }
        public IFormFile Image { get; set; }
    } 
}
