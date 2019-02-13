using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NesCollector.Data.Context;
using NesCollector.Data.Interfaces;
using NesCollector.Models;


namespace NesCollector.Service.Services
{
    public interface IWishlistService
    {
        //Read
        Wishlist GetById(int wishlistId);
        ICollection<Wishlist> GetWishlistGamesByUserId(int userId);
        ICollection<Wishlist> GetWishlistGamesByGameId(int gameId);


        //Create 
        Wishlist Create(Wishlist newWishlist);

        //Update
        Wishlist Update(Wishlist updatedWishlist);

        //Delete
        bool DeleteById(int wishlistId);
    }


    public class WishlistService : IWishlistService
    {
        private readonly IWishlistRepository _wishlistRepository;

        public WishlistService(IWishlistRepository wishlistRepository)
        {
            _wishlistRepository = wishlistRepository;
        }

        public Wishlist Create(Wishlist newWishlist)
        {
            return _wishlistRepository.Create(newWishlist);
        }

        public bool DeleteById(int wishlistId)
        {
            return _wishlistRepository.DeleteById(wishlistId);
        }

        public Wishlist GetById(int wishlistId)
        {
            return _wishlistRepository.GetById(wishlistId);
        }

        public ICollection<Wishlist> GetWishlistGamesByGameId(int gameId)
        {
            return _wishlistRepository.GetWishlistGamesByGameId(gameId);
        }

        public ICollection<Wishlist> GetWishlistGamesByUserId(int userId)
        {
            return _wishlistRepository.GetWishlistGamesByUserId(userId);
        }

        public Wishlist Update(Wishlist updatedWishlist)
        {
            return _wishlistRepository.Update(updatedWishlist);
        }
    }
}
