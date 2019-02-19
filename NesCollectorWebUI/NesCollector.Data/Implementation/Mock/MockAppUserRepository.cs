using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Interfaces;
using NesCollector.Models;

namespace NesCollector.Data.Implementation.Mock
{
    public class MockAppUserRepository : IAppUserRepository
    {
        private List<AppUser> Users = new List<AppUser>();
        public AppUser Create(AppUser newUser)
        {
            Guid g = Guid.NewGuid();
            newUser.Id = g.ToString();
            Users.Add(newUser);
            return newUser;
        }

        public bool DeleteById(string userId)
        {
            var userToDelete = GetById(userId);
            Users.Remove(userToDelete);
            return true;
        }

        public AppUser GetById(string userId)
        {
            return Users.Single(u => u.Id == userId);
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
            DeleteById(updatedUser.Id);
            Users.Add(updatedUser);

            return updatedUser;
        }
    }
}
