﻿using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Interfaces
{
    public interface IUserGameDataService
    {
        //Read
        UserGame GetByID(int userGameId);
        ICollection<UserGame> GetUserGamesByUserId(int userId);
        ICollection<UserGame> GetUserGamesByGameId(int gameId);


        //Create 
        UserGame Create(UserGame newUserGame);

        //Update
        UserGame Update(UserGame updatedUserGame);

        //Delete
        bool DeleteById(int userGameId);
    }
}
