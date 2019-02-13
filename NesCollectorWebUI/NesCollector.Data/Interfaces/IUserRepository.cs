using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IUserRepository
    {
        //Read
        User GetById(int userId);
        ICollection<User> GetUsersByUserGameId(int userGameId);
        ICollection<User> GetUsersByWishlistId(int wishlistId);

        //Create 
        User Create(User newUser);

        //Update
        User Update(User updatedUser);

        //Delete
        bool DeleteById(int userId);
    }
}
