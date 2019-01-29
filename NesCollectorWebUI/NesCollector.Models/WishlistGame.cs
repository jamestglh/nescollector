using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    class WishlistGame
    {
        public int Id { get; set; }
        public double MaxPrice { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string SystemId { get; set; }

        public int WishlistId { get; set; }
        public int GameId { get; set; }
    }
}
