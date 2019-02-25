using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Service.Services
{

    public interface IGameConsoleService
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
    public class GameConsoleService : IGameConsoleService
    {
        private readonly IGameConsoleRepository _gameConsoleRepository;

        public GameConsoleService(IGameConsoleRepository gameConsoleRepository)
        {
            _gameConsoleRepository = gameConsoleRepository;
        }

    
        public GameConsole Create(GameConsole newGameConsole)
        {
            return _gameConsoleRepository.Create(newGameConsole);
        }

        public bool DeleteById(int gameConsoleId)
        {
            return _gameConsoleRepository.DeleteById(gameConsoleId);
        }

        public GameConsole GetById(int gameConsoleId)
        {
            return _gameConsoleRepository.GetById(gameConsoleId);
        }

        public GameConsole Update(GameConsole updatedGameConsole)
        {
            return _gameConsoleRepository.Update(updatedGameConsole);
        }
    }
}
