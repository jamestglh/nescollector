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
        AppUser GetById(string userId);
        ICollection<AppUser> GetUsersByUserGameId(int userGameId);
        ICollection<AppUser> GetUsersByWishlistId(int wishlistId);
        ICollection<AppUser> GetAllUsers();

        //Create 
        AppUser Create(AppUser newUser);

        //Update
        AppUser Update(AppUser updatedUser);

        //Delete
        bool DeleteById(string userId);
    }
    public class UserService : IUserService
    {
        private readonly IAppUserRepository _userRepository;

        public UserService(IAppUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public AppUser Create(AppUser newUser)
        {
            return _userRepository.Create(newUser);
        }

        public bool DeleteById(string userId)
        {
            return _userRepository.DeleteById(userId);
        }

        public AppUser GetById(string userId)
        {
            return _userRepository.GetById(userId);
        }

        public ICollection<AppUser> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
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
