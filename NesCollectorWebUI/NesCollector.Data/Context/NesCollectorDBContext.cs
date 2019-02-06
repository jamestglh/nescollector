using Microsoft.EntityFrameworkCore;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.IO;
using System.Reflection;
using System.Linq;

namespace NesCollector.Data.Context
{
    public class NesCollectorDBContext : DbContext
    {
         

        // Interpret models - turning into DB entities
        // query those entities (tables)

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<UserGame> UserGames { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }

        //setting up provider (sqlserver) and location of db
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //bad way of providing connection string
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=nescollector;Trusted_Connection=True");
            optionBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             
            using (var reader = new StreamReader("..\\NesCollector.Data\\SeedData\\nesmasterlist.csv"))
            using (var csv = new CsvReader(reader))



            {
                IEnumerable<Game> games = csv.GetRecords<Game>();
                foreach (var Game in games)
                {
                    var id = csv.GetField<string>("Id");
                    var apiGameId = csv.GetField<string>("ApiGameId");
                    var systemId = csv.GetField<string>("SystemId");
                    var title = csv.GetField<string>("Title");
                    var genre = csv.GetField<string>("Genre");
                    var coverUrl = csv.GetField<string>("CoverURL");

                    
                     

                    modelBuilder.Entity<Game>().HasData(
                    new Game {  Id = id, ApiGameId = apiGameId, SystemId = systemId, Title = title, Genre = genre });
                    
                }
            }
        }

    }
}
