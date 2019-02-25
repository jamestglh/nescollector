using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IGameRepository
    {
        //Read
        Game GetById(int gameId);
        ICollection<Game> GetByGameConsoleId(int gameConsoleId);

        //Create 
        Game Create(Game newGame);

        //Update
        Game Update(Game updatedGame);

        //Delete
        bool DeleteById(int gameId);
    }
}
