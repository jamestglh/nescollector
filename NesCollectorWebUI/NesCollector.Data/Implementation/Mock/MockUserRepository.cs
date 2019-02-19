using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Data.Implementation.Mock
{
    public class MockUserRepository : IUserRepository
    {
        private List<AppUser> Users = new List<AppUser>();
        public AppUser Create(AppUser newUser)
        {
            newUser.UserId = Users.OrderByDescending(u => u.UserId).Single().UserId + 1;
            Users.Add(newUser);
            return newUser;
        }

        public bool DeleteById(int userId)
        {
            var userToDelete = GetById(userId);
            Users.Remove(userToDelete);
            return true;
        }

        public AppUser GetById(int userId)
        {
            return Users.Single(u => u.UserId == userId);
        }

        public ICollection<AppUser> GetUsersByUserGameId(int userGameId) // returns a list of  users that owns a particular game
        {

            var results = new List<AppUser>();
            foreach (AppUser user in Users)
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

        public ICollection<AppUser> GetUsersByWishlistId(int wishlistId) // returns a list of users that wishlists a particular game
        {
            var results = new List<AppUser>();
            foreach (AppUser user in Users)
            {
                foreach (Wishlist wishlist in user.Wishlists)
                {
                    if (wishlist.Id == wishlistId)
                    {
                        results.Add(user);
                    }
                }
            }
            return results;
        }

        public AppUser Update(AppUser updatedUser)
        {
            DeleteById(updatedUser.UserId);
            Users.Add(updatedUser);

            return updatedUser;
        }
    }
}
