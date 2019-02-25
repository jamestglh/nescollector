using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IGameConsoleRepository
    {
        //Read
        GameConsole GetById(int gameConsoleId);

        //Create 
        GameConsole Create(GameConsole newGameConsole);

        //Update
        GameConsole Update(GameConsole updatedGameConsole);

        //Delete
        bool DeleteById(int gameConsoleId);
    }
}
