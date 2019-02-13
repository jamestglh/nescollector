using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Service.Services
{
    public interface IUserService
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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create(User newUser)
        {
            return _userRepository.Create(newUser);
        }

        public bool DeleteById(int userId)
        {
            return _userRepository.DeleteById(userId);
        }

        public User GetById(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public ICollection<User> GetUsersByUserGameId(int userGameId)
        {
            return _userRepository.GetUsersByUserGameId(userGameId);
        }

        public ICollection<User> GetUsersByWishlistId(int wishlistId)
        {
            return _userRepository.GetUsersByWishlistId(wishlistId);
        }

        public User Update(User updatedUser)
        {
            return _userRepository.Update(updatedUser);
        }
    }

}
