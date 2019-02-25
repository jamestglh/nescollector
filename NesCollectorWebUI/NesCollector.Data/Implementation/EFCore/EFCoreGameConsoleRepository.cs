using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NesCollector.Data.Implementation.EFCore
{
    public class EFCoreGameConsoleRepository : IGameConsoleRepository
    {
        public GameConsole Create(GameConsole newGameConsole)
        {
            using (var db = new NesCollectorDBContext())
            {
                db.GameConsoles.Add(newGameConsole);
                db.SaveChanges();

                return newGameConsole;
            }
        }

        public bool DeleteById(int gameConsoleId)
        {
            using (var db = new NesCollectorDBContext())
            {
                var gameToDelete = GetById(gameConsoleId);
                db.Remove(gameToDelete);
                db.SaveChanges();

                if (GetById(gameConsoleId) == null)
                {
                    return true;
                }

                return false;
            }
        }

        public GameConsole GetById(int gameConsoleId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.GameConsoles.Single(gc => gc.Id == gameConsoleId);
            }
        }

        public GameConsole Update(GameConsole updatedGameConsole)
        {
            using (var db = new NesCollectorDBContext())
            {
                var existingGameConsole = GetById(updatedGameConsole.Id);
                db.Entry(existingGameConsole).CurrentValues.SetValues(updatedGameConsole);
                db.SaveChanges();

                return existingGameConsole;
            }
        }
    }
}
