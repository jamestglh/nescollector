using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Data.Implementation.Mock
{
    public class MockUserGameRepository : IUserGameRepository
    {
        private List<UserGame> UserGames = new List<UserGame>();
        public UserGame Create(UserGame newUserGame)
        {
            newUserGame.Id = UserGames.OrderByDescending(u => u.Id).Single().Id + 1;
            UserGames.Add(newUserGame);
            return newUserGame;
        }

        public bool DeleteById(int userGameId)
        {
            var userGameToDelete = GetById(userGameId);
            UserGames.Remove(userGameToDelete);
            return true;
        }

        public UserGame GetById(int userGameId)
        {
            return UserGames.Single(u => u.Id == userGameId);
        }

        public ICollection<UserGame> GetUserGamesByGameId(int gameId) // returns a list of a particular game owned by many users. seems useless?
        {
            return UserGames.FindAll(u => u.GameId == gameId);
        }

        public ICollection<UserGame> GetUserGamesByUserId(int userId) // return a list of all games owned by a single user.
        {
            return UserGames.FindAll(u => u.UserId == userId);
        }

        public UserGame Update(UserGame updatedUserGame)
        {
            DeleteById(updatedUserGame.Id);
            UserGames.Add(updatedUserGame);

            return updatedUserGame;
        }
    }
}
