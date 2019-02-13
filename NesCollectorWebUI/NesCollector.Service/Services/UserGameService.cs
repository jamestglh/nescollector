using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Service.Services
{
    public interface IUserGameService
    {
        //Read
   
        UserGame GetById(int userGameId);
        ICollection<UserGame> GetUserGamesByUserId(int userId);
        ICollection<UserGame> GetUserGamesByGameId(int gameId);


        //Create 
        UserGame Create(UserGame newUserGame);

        //Update
        UserGame Update(UserGame updatedUserGame);

        //Delete
        bool DeleteById(int userGameId);
    }

    public class UserGameService : IUserGameService
    {
        private readonly IUserGameRepository _userGameRepository;

        public UserGameService(IUserGameRepository userGameRepository)
        {
            _userGameRepository = userGameRepository;
        }
        public UserGame Create(UserGame newUserGame)
        {
            return _userGameRepository.Create(newUserGame);
        }

        public bool DeleteById(int userGameId)
        {
            return _userGameRepository.DeleteById(userGameId);
        }

        public UserGame GetById(int userGameId)
        {
            return _userGameRepository.GetById(userGameId);
        }

        public ICollection<UserGame> GetUserGamesByGameId(int gameId)
        {
            return _userGameRepository.GetUserGamesByGameId(gameId);
        }

        public ICollection<UserGame> GetUserGamesByUserId(int userId)
        {
            return _userGameRepository.GetUserGamesByUserId(userId);
        }

        public UserGame Update(UserGame updatedUserGame)
        {
            return _userGameRepository.Update(updatedUserGame);
        }
    }
}
