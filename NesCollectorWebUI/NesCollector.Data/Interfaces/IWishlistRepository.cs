using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    interface IWishlistRepository
    {
        //Read
        Wishlist GetByID(int wishlistId);
        ICollection<Wishlist> GetWishlistGamesByUserId(int userId);
        ICollection<Wishlist> GetWishlistGamesByGameId(int gameId);


        //Create 
        Wishlist Create(Wishlist newWishlist);

        //Update
        Wishlist Update(Wishlist updatedWishlist);

        //Delete
        bool DeleteById(int wishlistId);
    }
}
