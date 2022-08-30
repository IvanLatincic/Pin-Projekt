using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MusicStore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
              new Category { Id = 1, Name = "CD" },
              new Category { Id = 2, Name = "Vinyl" },
              new Category { Id = 3, Name = "Kazeta" }
              );


            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 1,
                  CategoryId = 1,
                  Genre = "Pop",
                  Artist = "Adele",
                  Code = "30_CD",
                  Name = "30",
                  Year = 2021,
                  Price = (decimal)124.99
              },
              new Product
              {
                  Id = 2,
                  CategoryId = 1,
                  Genre = "Pop",
                  Artist = "Taylor Swift",
                  Code = "Red_CD",
                  Name = "Red (Taylor's Version)",
                  Year = 2021,
                  Price = (decimal)124.99
              },
              new Product
              {
                  Id = 3,
                  CategoryId = 2,
                  Genre = "Pop",
                  Artist = "Taylor Swift",
                  Code = "Red_VINYL",
                  Name = "Red (Taylor's Version)",
                  Year = 2021,
                  Price = (decimal)249.99
              },
               new Product
               {
                   Id = 4,
                   CategoryId = 1,
                   Genre = "Pop",
                   Artist = "Olivia Rodrigo",
                   Code = "Sour_CD",
                   Name = "Sour",
                   Year = 2021,
                   Price = (decimal)124.99
               },
                new Product
                {
                    Id = 5,
                    CategoryId = 1,
                    Genre = "Pop",
                    Artist = "Taylor Swift",
                    Code = "Folklore_CD",
                    Name = "Folklore",
                    Year = 2020,
                    Price = (decimal)124.99
                },
                 new Product
                 {
                     Id = 6,
                     CategoryId = 2,
                     Genre = "Pop",
                     Artist = "Taylor Swift",
                     Code = "Folklore_VINYL",
                     Name = "Folklore",
                     Year = 2020,
                     Price = (decimal)249.99
                 },
                 new Product
                 {
                     Id = 7,
                     CategoryId = 1,
                     Genre = "Pop",
                     Artist = "Taylor Swift",
                     Code = "Evermore_CD",
                     Name = "Evermore",
                     Year = 2020,
                     Price = (decimal)124.99
                 },
                 new Product
                 {
                     Id = 8,
                     CategoryId = 2,
                     Genre = "Pop",
                     Artist = "Taylor Swift",
                     Code = "Evermore_Vinyl",
                     Name = "Evermore",
                     Year = 2020,
                     Price = (decimal)249.99
                 },
                 new Product
                 {
                     Id = 9,
                     CategoryId = 3,
                     Genre = "Pop",
                     Artist = "Taylor Swift",
                     Code = "Evermore_C",
                     Name = "Evermore",
                     Year = 2020,
                     Price = (decimal)124.99
                 },
                 new Product
                 {
                     Id = 10,
                     CategoryId = 3,
                     Genre = "Alternative",
                     Artist = "The Strokes",
                     Code = "IsThisIt_C",
                     Name = "Is This It?",
                     Year = 2001,
                     Price = (decimal)149.99
                 },

                 new Product
                 {
                     Id = 11,
                     CategoryId = 1,
                     Genre = "Hip Hop",
                     Artist = "Tyler the Creator",
                     Code = "BecauseTheInternet_CD",
                     Name = "Because The Internet",
                     Year = 2011,
                     Price = (decimal)124.99
                 },
                 new Product
                 {
                     Id = 12,
                     CategoryId = 1,
                     Genre = "Rock",
                     Artist = "Nirvana",
                     Code = "Bleach_CD",
                     Name = "Bleach",
                     Year = 1991,
                     Price = (decimal)249.99
                 },

                 new Product
                 {
                     Id = 13,
                     CategoryId = 1,
                     Genre = "Pop",
                     Artist = "Doja Cat",
                     Code = "PlanetHer_CD",
                     Name = "Planet Her",
                     Year = 2021,
                     Price = (decimal)124.99
                 },

                 new Product
                 {
                     Id = 14,
                     CategoryId = 2,
                     Genre = "Pop",
                     Artist = "Dua Lipa",
                     Code = "FutureNostalgia_VINYL",
                     Name = "Future Nostalgia",
                     Year = 2020,
                     Price = (decimal)249.99
                 },

                 new Product
                 {
                     Id = 15,
                     CategoryId = 2,
                     Genre = "Alternative",
                     Artist = "Joni Mitchell",
                     Code = "Shine_VINYL",
                     Name = "Shine",
                     Year = 1979,
                     Price = (decimal)249.99
                 },

                 new Product
                 {
                     Id = 16,
                     CategoryId = 1,
                     Genre = "Alternative",
                     Artist = "Phoebe Bridgers",
                     Code = "Punisher_CD",
                     Name = "Punisher",
                     Year = 2020,
                     Price = (decimal)124.99
                 },

                 new Product
                 {
                     Id = 17,
                     CategoryId = 2,
                     Genre = "Alternative",
                     Artist = "Phoebe Bridgers",
                     Code = "Punisher_VINYL",
                     Name = "Punisher",
                     Year = 2020,
                     Price = (decimal)249.99
                 },

                  new Product
                  {
                      Id = 18,
                      CategoryId = 2,
                      Genre = "Alternative",
                      Artist = "Lucy Dacus",
                      Code = "HomeVideo_VINYL",
                      Name = "Home Video",
                      Year = 2018,
                      Price = (decimal)124.99
                  },

                 new Product
                 {
                     Id = 19,
                     CategoryId = 2,
                     Genre = "Alternative",
                     Artist = "Billie Marten",
                     Code = "FloraFauna_VINYL",
                     Name = "Flora Fauna",
                     Year = 2021,
                     Price = (decimal)249.99
                 },


                 new Product
                 {
                     Id = 20,
                     CategoryId = 3,
                     Genre = "Alternative",
                     Artist = "Billie Marten",
                     Code = "FloraFauna_Cassette",
                     Name = "Flora Fauna",
                     Year = 2021,
                     Price = (decimal)149.99
                 });



        }
    }
}
