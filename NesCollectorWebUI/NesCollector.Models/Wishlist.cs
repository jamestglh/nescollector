using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    public class Wishlist
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string SystemId { get; set; }
        public double MaxPrice { get; set; }

        //foreign keys
        public int UserId { get; set; }
        public AppUser User { get; set; } //navigation reference
        public int GameId { get; set; }
        public Game Game { get; set; } //navigation reference

    }
}
