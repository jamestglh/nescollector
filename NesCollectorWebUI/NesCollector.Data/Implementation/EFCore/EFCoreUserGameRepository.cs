using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NesCollector.Data.Implementation.EFCore
{
    public class EFCoreUserGameRepository : IUserGameRepository
    {
        public UserGame Create(UserGame newUserGame)
        {
            using (var db = new NesCollectorDBContext())
            {
                db.UserGames.Add(newUserGame);
                db.SaveChanges();

                return newUserGame;
            }
        }

        public bool DeleteById(int userGameId)
        {
            using (var db = new NesCollectorDBContext())
            {
                var userGameToDelete = GetById(userGameId);
                db.Remove(userGameToDelete);
                db.SaveChanges();

                if (GetById(userGameId) == null)
                {
                    return true;
                }

                return false;
            }
        }

        public UserGame GetById(int userGameId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.UserGames.Single(u => u.Id == userGameId);
            }
        }

        public ICollection<UserGame> GetUserGamesByGameId(int gameId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.UserGames
                    .Where(u => u.GameId == gameId)
                    .ToList();
            }
        }

        public ICollection<UserGame> GetUserGamesByUserId(string userId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.UserGames
                    .Where(u => u.UserId == userId)
                    .ToList();
            }
        }

        public UserGame Update(UserGame updatedUserGame)
        {
            using (var db = new NesCollectorDBContext())
            {
                var existingUserGame = GetById(updatedUserGame.Id);

                //existingUserGame.Condition = updatedUserGame.Condition;
                //existingUserGame.HasBox = updatedUserGame.HasBox;
                //existingUserGame.HasManual = updatedUserGame.HasManual;

                db.Entry(existingUserGame).CurrentValues.SetValues(updatedUserGame);
                //existingUserGame = updatedUserGame;

                db.SaveChanges();

                return existingUserGame;
            }
        }
    }
}
