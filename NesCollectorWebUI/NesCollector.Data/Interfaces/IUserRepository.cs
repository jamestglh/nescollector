using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IUserRepository
    {
        //Read
        AppUser GetById(int userId);
        ICollection<AppUser> GetUsersByUserGameId(int userGameId);
        ICollection<AppUser> GetUsersByWishlistId(int wishlistId);

        //Create 
        AppUser Create(AppUser newUser);

        //Update
        AppUser Update(AppUser updatedUser);

        //Delete
        bool DeleteById(int userId);
    }
}
