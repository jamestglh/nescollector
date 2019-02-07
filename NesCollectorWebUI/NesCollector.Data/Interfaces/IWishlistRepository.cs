using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    interface IWishlistRepository
    {
        //Read
        Wishlist GetByID(int userGameId);
        ICollection<Wishlist> GetWishlistGamesByUserId(int userId);
        ICollection<Wishlist> GetWishlistGamesByGameId(int gameId);


        //Create 
        Wishlist Create(Wishlist newUserGame);

        //Update
        Wishlist Update(Wishlist updatedUserGame);

        //Delete
        bool DeleteById(int wishlistId);
    }
}
