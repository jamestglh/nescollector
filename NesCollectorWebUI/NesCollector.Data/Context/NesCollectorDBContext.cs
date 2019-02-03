using Microsoft.EntityFrameworkCore;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NesCollector.Data.Context
{
    public class NesCollectorDBContext : DbContext
    {
        public NesCollectorDBContext(DbContextOptions<NesCollectorDBContext> options): base(options) { }




        // Interpret models - turning into DB entities
        // query those entities (tables)

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<UserGame> UserGames { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
    }
}
