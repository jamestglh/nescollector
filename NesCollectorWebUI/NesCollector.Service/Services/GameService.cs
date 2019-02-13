using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Service.Services
{

    public interface IGameService
    {
        //Read
        Game GetById(int gameId);

        //Create 
        Game Create(Game newGame);

        //Update
        Game Update(Game updatedGame);

        //Delete
        bool DeleteById(int gameId);
    }
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public Game Create(Game newGame)
        {
            return _gameRepository.Create(newGame);
        }

        public bool DeleteById(int gameId)
        {
            return _gameRepository.DeleteById(gameId);
        }

        public Game GetById(int gameId)
        {
            return _gameRepository.GetById(gameId);
        }

        public Game Update(Game updatedGame)
        {
            return _gameRepository.Update(updatedGame);
        }
    }
}
