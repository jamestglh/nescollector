using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NesCollector.Data.Implementation.EFCore
{
    public class EFCoreWishlistRepository : IWishlistRepository
    {
        public Wishlist Create(Wishlist newWishlist)
        {
            using (var db = new NesCollectorDBContext())
            {
                db.Wishlists.Add(newWishlist);
                db.SaveChanges();

                return newWishlist;
            }
        }

        public bool DeleteById(int wishlistId)
        {
            using (var db = new NesCollectorDBContext())
            {
                var wishlistToDelete = GetById(wishlistId);
                db.Remove(wishlistToDelete);
                db.SaveChanges();

                if (GetById(wishlistId) == null)
                {
                    return true;
                }

                return false;
            }
        }

        public Wishlist GetById(int wishlistId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.Wishlists.Single(w => w.Id == wishlistId);
            }
        }

        public ICollection<Wishlist> GetWishlistGamesByGameId(int gameId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.Wishlists
                    .Where(w => w.GameId == gameId)
                    .ToList();
            }
        }

        public ICollection<Wishlist> GetWishlistGamesByUserId(string userId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.Wishlists
                    .Where(w => w.UserId == userId)
                    .ToList();
            }
        }

        public Wishlist Update(Wishlist updatedWishlist)
        {
            using (var db = new NesCollectorDBContext())
            {
                var existingWishlist = GetById(updatedWishlist.Id);
                db.Entry(existingWishlist).CurrentValues.SetValues(updatedWishlist);
                db.SaveChanges();

                return existingWishlist;
            }
        }
    }
}
