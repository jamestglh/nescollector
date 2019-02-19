using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Models
{
    public class AppUser : IdentityUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //navigation collections
        public IEnumerable<UserGame> UserGames { get; set; }
        public IEnumerable<Wishlist> Wishlists { get; set; }

    }
}
