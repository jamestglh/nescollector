using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Data.Implementation.Mock
{
    class MockUserRepository : IUserRepository
    {
        private List<User> Users = new List<User>();
        public User Create(User newUser)
        {
            newUser.Id = Users.OrderByDescending(u => u.Id).Single().Id + 1;
            Users.Add(newUser);
            return newUser;
        }

        public bool DeleteById(int userId)
        {
            var userToDelete = GetByID(userId);
            Users.Remove(userToDelete);
            return true;
        }

        public User GetByID(int userId)
        {
            return Users.Single(u => u.Id == userId);
        }

        public ICollection<User> GetUsersByUserGameId(int userGameId) // returns a list of  users that owns a particular game
        {

            var results = new List<User>();
            foreach (User user in Users)
            {
                foreach (UserGame userGame in user.UserGames)
                {
                    if (userGame.Id == userGameId)
                    {
                        results.Add(user);
                    }
                }
            }
            return results;
        }

        public ICollection<User> GetUsersByWishlistId(int userWishlistId) // returns a list of users that wishlists a particular game
        {
            var results = new List<User>();
            foreach (User user in Users)
            {
                foreach (Wishlist wishlist in user.Wishlists)
                {
                    if (wishlist.Id == userWishlistId)
                    {
                        results.Add(user);
                    }
                }
            }
            return results;
        }

        public User Update(User updatedUser)
        {
            DeleteById(updatedUser.Id);
            Users.Add(updatedUser);

            return updatedUser;
        }
    }
}
