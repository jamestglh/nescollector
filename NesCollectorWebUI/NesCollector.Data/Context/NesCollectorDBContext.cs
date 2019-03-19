using Microsoft.EntityFrameworkCore;
using NesCollector.Models;
using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.IO;
using System.Reflection;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace NesCollector.Data.Context
{
    public class NesCollectorDBContext : IdentityDbContext<AppUser>
    {
        // Interpret models - turning into DB entities
        // query those entities (tables)

        public DbSet<Game> Games { get; set; }
        public DbSet<UserGame> UserGames { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<GameConsole> GameConsoles { get; set; }

        //setting up provider (sqlserver) and location of db
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //bad way of providing connection string
            optionBuilder.UseSqlServer(Environment.GetEnvironmentVariable("SQLCONNSTR_NESCOLLECTOR_DB"));
            optionBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GameConsole>().HasData(new GameConsole { Id = 1, Name = "NES" });

            modelBuilder.Entity<UserGame>()
                .HasOne(ug => ug.User)
                .WithMany(u => u.UserGames)
                .HasForeignKey(ug => ug.UserId)
                .HasConstraintName("ForeignKey_UserGame_AppUser");

            modelBuilder.Entity<Wishlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.Wishlists)
                .HasForeignKey(w => w.UserId)
                .HasConstraintName("ForeignKey_Wishlist_AppUser");

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "User", NormalizedName = "USER" },
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" }
                );

            //using (var reader = new StreamReader(@"..\NesCollector.Data\SeedData\nesmasterlist.csv"))
            //using (var csv = new CsvReader(reader, new CsvHelper.Configuration.Configuration { HeaderValidated = null, MissingFieldFound = null }))
            //{
            //    IEnumerable<Game> games = csv.GetRecords<Game>();


            //    foreach (var Game in games)
            //    {
            //        var id = csv.GetField<int>("Id");
            //        var apiGameId = csv.GetField<int>("ApiGameId");
            //        var systemId = csv.GetField<string>("SystemId");
            //        var title = csv.GetField<string>("Title");
            //        var genre = csv.GetField<string>("Genre");
            //        var coverUrl = csv.GetField<string>("CoverURL");
            //        var upc = csv.GetField<string>("Upc");
            //        var loosePrice = csv.GetField<double>("LoosePrice");
            //        var cibPrice = csv.GetField<double>("CibPrice");
            //        var gameConsoleId = csv.GetField<int>("GameConsoleId");
            //        var releaseDate = csv.GetField<string>("ReleaseDate");



            //        modelBuilder.Entity<Game>().HasData(
            //        new Game
            //        {
            //            Id = id,
            //            ApiGameId = apiGameId,
            //            SystemId = systemId,
            //            Title = title,
            //            Genre = genre,
            //            CoverURL = coverUrl,
            //            Upc = upc,
            //            LoosePrice = loosePrice,
            //            CibPrice = cibPrice,
            //            GameConsoleId = gameConsoleId,
            //            ReleaseDate = releaseDate
            //        })
            //        ;
            //    }
            //}
        }
    }
}
