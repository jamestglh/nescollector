using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NesCollectorWebUI.ViewModels
{
    public class EditGameViewModel
    {
        public Game Game { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
