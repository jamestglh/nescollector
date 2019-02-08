using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IUserRepository
    {
        //Read
        User GetByID(int userId);
        ICollection<User> GetUsersByUserGameId(int userGameId);
        ICollection<User> GetUsersByWishlistId(int userWishlistId);

        //Create 
        User Create(User newUser);

        //Update
        User Update(User updatedUser);

        //Delete
        bool DeleteById(int userId);
    }
}
