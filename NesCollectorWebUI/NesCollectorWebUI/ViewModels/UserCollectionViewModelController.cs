using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NesCollectorWebUI.ViewModels
{
    public class UserCollectionViewModel
    {
         public AppUser User { get; set; }
         public ICollection<UserGame> UserGames { get; set; }

    }
}