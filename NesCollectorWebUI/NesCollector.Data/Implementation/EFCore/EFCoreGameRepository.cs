using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NesCollector.Data.Implementation.EFCore
{
    public class EFCoreGameRepository : IGameRepository
    {
        public Game Create(Game newGame)
        {
            using (var db = new NesCollectorDBContext())
            {
                db.Games.Add(newGame);
                db.SaveChanges();

                return newGame;
            }
        }

        public bool DeleteById(int gameId)
        {
            using (var db = new NesCollectorDBContext())
            {
                var gameToDelete = GetById(gameId);
                db.Remove(gameToDelete);
                db.SaveChanges();

                if (GetById(gameId) == null)
                {
                    return true;
                }

                return false;
            }
        }

        public Game GetById(int gameId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.Games.Single(g => g.Id == gameId);
            }
        }

        public Game Update(Game updatedGame)
        {
            using (var db = new NesCollectorDBContext())
            {
                var existingGame = GetById(updatedGame.Id);
                db.Entry(existingGame).CurrentValues.SetValues(updatedGame);
                db.SaveChanges();

                return existingGame;
            }
        }
    }
}
