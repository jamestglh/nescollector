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
        private List<Game> Games = new List<Game>();

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
            var gameToDelete = GetByID(gameId);
            Games.Remove(gameToDelete);
            return true;
        }

        public Game GetByID(int gameId)
        {
            return Games.Single(l => l.Id == gameId); 
        }

        public Game Update(Game updatedGame)
        {
            DeleteById(updatedGame.Id);
            Games.Add(updatedGame);

            return updatedGame;
        }
    }
}
