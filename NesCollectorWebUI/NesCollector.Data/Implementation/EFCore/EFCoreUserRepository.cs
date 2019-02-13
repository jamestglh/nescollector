using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NesCollector.Data.Implementation.EFCore
{
    public class EFCoreUserRepository : IUserRepository
    {
        public User Create(User newUser)
        {
            using (var db = new NesCollectorDBContext())
            {
                db.Users.Add(newUser);
                db.SaveChanges();

                return newUser;
            }
        }

        public bool DeleteById(int userId)
        {
            using (var db = new NesCollectorDBContext())
            {
                var userToDelete = GetById(userId);
                db.Remove(userToDelete);
                db.SaveChanges();

                if (GetById(userId) == null)
                {
                    return true;
                }

                return false;
            }
        }

        public User GetById(int userId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.Users.Single(u => u.Id == userId);
            }
        }

        public ICollection<User> GetUsersByUserGameId(int userGameId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.Users.Where(u => u.UserGames.Any(ug => ug.Id == userGameId)).ToList();
            }
        }

        public ICollection<User> GetUsersByWishlistId(int wishlistId)
        {
            using (var db = new NesCollectorDBContext())
            {
                return db.Users.Where(u => u.Wishlists.Any(w => w.Id == wishlistId)).ToList();
            }
        }

        public User Update(User updatedUser)
        {
            using (var db = new NesCollectorDBContext())
            {
                var existingUser = GetById(updatedUser.Id);
                db.Entry(existingUser).CurrentValues.SetValues(updatedUser);
                db.SaveChanges();

                return existingUser;
            }
        }
    }
}
