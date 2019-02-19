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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public AppUser Create(AppUser newUser)
        {
            return _userRepository.Create(newUser);
        }

        public bool DeleteById(int userId)
        {
            return _userRepository.DeleteById(userId);
        }

        public AppUser GetById(int userId)
        {
            return _userRepository.GetById(userId);
        }

        public ICollection<AppUser> GetUsersByUserGameId(int userGameId)
        {
            return _userRepository.GetUsersByUserGameId(userGameId);
        }

        public ICollection<AppUser> GetUsersByWishlistId(int wishlistId)
        {
            return _userRepository.GetUsersByWishlistId(wishlistId);
        }

        public AppUser Update(AppUser updatedUser)
        {
            return _userRepository.Update(updatedUser);
        }
    }

}
