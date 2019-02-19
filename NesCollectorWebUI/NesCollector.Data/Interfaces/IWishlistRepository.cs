using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IWishlistRepository
    {
        //Read
        Wishlist GetById(int wishlistId);
        ICollection<Wishlist> GetWishlistGamesByUserId(string userId);
        ICollection<Wishlist> GetWishlistGamesByGameId(int gameId);


        //Create 
        Wishlist Create(Wishlist newWishlist);

        //Update
        Wishlist Update(Wishlist updatedWishlist);

        //Delete
        bool DeleteById(int wishlistId);
    }
}
