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

        //setting up provider (sqlserver) and location of db
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            //bad way of providing connection string
            optionBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=nescollector;Trusted_Connection=True");
            optionBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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

            using (var reader = new StreamReader(@"..\NesCollector.Data\SeedData\nesmasterlist.csv"))
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
                    //var loosePrice = csv.GetField<string>("LoosePrice");
                    //var cibPrice = csv.GetField<string>("CibPrice");


                    modelBuilder.Entity<Game>().HasData(
                    new Game { Id = int.Parse(id),
                        ApiGameId = int.Parse(apiGameId),
                        SystemId = systemId,
                        Title = title,
                        Genre = genre,
                        CoverURL = coverUrl,
                        //LoosePrice = loosePrice,
                        //CibPrice = cibPrice,
                    });


                }
            }
        }
    }
}
