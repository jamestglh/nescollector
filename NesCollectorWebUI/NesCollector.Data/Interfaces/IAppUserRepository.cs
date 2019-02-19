using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IAppUserRepository
    {
        //Read
        AppUser GetById(string userId);
        ICollection<AppUser> GetUsersByUserGameId(int userGameId);
        ICollection<AppUser> GetUsersByWishlistId(int wishlistId);

        //Create 
        AppUser Create(AppUser newUser);

        //Update
        AppUser Update(AppUser updatedUser);

        //Delete
        bool DeleteById(string userId);
    }
}
