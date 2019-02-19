using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Data.Implementation.Mock
{
    public class MockWishlistRepository : IWishlistRepository

    {
        private List<Wishlist> Wishlists = new List<Wishlist>();
        public Wishlist Create(Wishlist newWishlist)
        {
            newWishlist.Id = Wishlists.OrderByDescending(u => u.Id).Single().Id + 1;
            Wishlists.Add(newWishlist);
            return newWishlist;
        }

        public bool DeleteById(int wishlistId)
        {
            var wishlistToDelete = GetById(wishlistId);
            Wishlists.Remove(wishlistToDelete);
            return true;
        }

        public Wishlist GetById(int wishlistId)
        {
            return Wishlists.Single(w => w.Id == wishlistId);
        }

        public ICollection<Wishlist> GetWishlistGamesByGameId(int gameId) //returns a list of single wishlist game on users wishlists. useless?
        {
            return Wishlists.FindAll(w => w.GameId == gameId);
        }

        public ICollection<Wishlist> GetWishlistGamesByUserId(string userId) // generates a list of all games wished by a particular user
        {
            return Wishlists.FindAll(w => w.UserId == userId);
        }

        public Wishlist Update(Wishlist updatedWishlist)
        {
            DeleteById(updatedWishlist.Id);
            Wishlists.Add(updatedWishlist);

            return updatedWishlist;
        }
    }
}
