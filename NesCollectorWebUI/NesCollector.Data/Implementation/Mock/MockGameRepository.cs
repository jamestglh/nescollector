using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Data.Implementation.Mock
{
    public class MockGameRepository : IGameRepository
    {
        private List<Game> Games = new List<Game>()
        {
            new Game { Id = 1, Title = "A Game that Totally Exists", Genre = "Not an Imaginary Game" }
        };

        

        public Game Create(Game newGame)
        {
            //since new games aren't made for NES i may never use this unless i want to add homebrew games. 
            int id = 0;
            foreach (Game g in Games)
            {
                if (g.Id >= id)
                {
                    id = g.Id + 1;
                    newGame.Id = id;
                }
            }
            Games.Add(newGame);
            return newGame;
        }

        public bool DeleteById(int gameId)
        {
            var gameToDelete = GetById(gameId);
            Games.Remove(gameToDelete);
            return true;
        }

        public Game GetById(int gameId)
        {
            return Games.Single(l => l.Id == gameId); 
        }

        public Game Update(Game updatedGame)
        {
            DeleteById(updatedGame.Id);
            Games.Add(updatedGame);

            return updatedGame;
        }
        public ICollection<Game> GetByGameConsoleId(int gameConsoleId)
        {
            return Games.FindAll(g => g.GameConsoleId == gameConsoleId);
        }
    }
}
