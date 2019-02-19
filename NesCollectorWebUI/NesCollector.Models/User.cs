using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //navigation collections
        public IEnumerable<UserGame> UserGames { get; set; }
        public IEnumerable<Wishlist> Wishlists { get; set; }


    }
} 
