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
                var entry = db.Entry(updatedUserGame);
                entry.Property(w => w.HasBox).IsModified = true;
                entry.Property(w => w.HasManual).IsModified = true;
                entry.Property(w => w.Condition).IsModified = true;

                db.SaveChanges();
                return updatedUserGame;
            }
        }
    }
}
