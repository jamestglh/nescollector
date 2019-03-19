using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NesCollector.Models;

namespace NesCollectorWebUI.ViewModels
{
    public class UserWishlistViewModel
    {
        public Game Game { get; set; }
        public Wishlist Wishlist { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<Wishlist> UserWishlist { get; set; }
        public double MaxPrice { get; set; }


    }
}
