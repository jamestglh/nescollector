using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NesCollectorWebUI.ViewModels
{
    public class UserCollectionViewModel
    {
        public Game Game { get; set; }
        public UserGame UserGame { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<UserGame> UserGames { get; set; }
        public double TotalValue { get; set; }
        public ICollection<Wishlist> UserWishlist { get; set; }
        public List<int> GamesOwned { get; set; }
        public Wishlist Wishlist { get; set; }
        public double MaxPrice { get; set; }

    }
}