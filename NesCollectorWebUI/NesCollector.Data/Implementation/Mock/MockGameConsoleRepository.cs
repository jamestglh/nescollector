using NesCollector.Data.Interfaces;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NesCollector.Data.Implementation.Mock
{
    public class MockGameConsoleRepository : IGameConsoleRepository
    {
        private List<GameConsole> GameConsoles = new List<GameConsole>()
        {
            new GameConsole { Id = 1, Name = "NES" }
        };

        public GameConsole Create(GameConsole newGameConsole)
        {
            int id = 0;
            foreach (GameConsole g in GameConsoles)
            {
                if (g.Id >= id)
                {
                    id = g.Id + 1;
                    newGameConsole.Id = id;
                }
            }
            GameConsoles.Add(newGameConsole);
            return newGameConsole;
        }

        public bool DeleteById(int gameConsoleId)
        {
            var gameConsoleToDelete = GetById(gameConsoleId);
            GameConsoles.Remove(gameConsoleToDelete);
            return true;
        }

        public GameConsole GetById(int gameConsoleId)
        {
            return GameConsoles.Single(gc => gc.Id == gameConsoleId);
        }

        public GameConsole Update(GameConsole updatedGameConsole)
        {
            DeleteById(updatedGameConsole.Id);
            GameConsoles.Add(updatedGameConsole);

            return updatedGameConsole;
        }
    }
}

