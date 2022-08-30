﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicStore.Models;

namespace MusicStore.Migrations.AppDb
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MusicStore.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CD"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Vinyl"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kazeta"
                        });
                });

            modelBuilder.Entity("MusicStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Adele",
                            CategoryId = 1,
                            Code = "30_CD",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "30",
                            Price = 124.99m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 2,
                            Artist = "Taylor Swift",
                            CategoryId = 1,
                            Code = "Red_CD",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Red (Taylor's Version)",
                            Price = 124.99m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 3,
                            Artist = "Taylor Swift",
                            CategoryId = 2,
                            Code = "Red_VINYL",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Red (Taylor's Version)",
                            Price = 249.99m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 4,
                            Artist = "Olivia Rodrigo",
                            CategoryId = 1,
                            Code = "Sour_CD",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Sour",
                            Price = 124.99m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 5,
                            Artist = "Taylor Swift",
                            CategoryId = 1,
                            Code = "Folklore_CD",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Folklore",
                            Price = 124.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 6,
                            Artist = "Taylor Swift",
                            CategoryId = 2,
                            Code = "Folklore_VINYL",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Folklore",
                            Price = 249.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 7,
                            Artist = "Taylor Swift",
                            CategoryId = 1,
                            Code = "Evermore_CD",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Evermore",
                            Price = 124.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 8,
                            Artist = "Taylor Swift",
                            CategoryId = 2,
                            Code = "Evermore_Vinyl",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Evermore",
                            Price = 249.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 9,
                            Artist = "Taylor Swift",
                            CategoryId = 3,
                            Code = "Evermore_C",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Evermore",
                            Price = 124.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 10,
                            Artist = "The Strokes",
                            CategoryId = 3,
                            Code = "IsThisIt_C",
                            DiscountPercent = 0m,
                            Genre = "Alternative",
                            Name = "Is This It?",
                            Price = 149.99m,
                            Year = 2001
                        },
                        new
                        {
                            Id = 11,
                            Artist = "Tyler the Creator",
                            CategoryId = 1,
                            Code = "BecauseTheInternet_CD",
                            DiscountPercent = 0m,
                            Genre = "Hip Hop",
                            Name = "Because The Internet",
                            Price = 124.99m,
                            Year = 2011
                        },
                        new
                        {
                            Id = 12,
                            Artist = "Nirvana",
                            CategoryId = 1,
                            Code = "Bleach_CD",
                            DiscountPercent = 0m,
                            Genre = "Rock",
                            Name = "Bleach",
                            Price = 249.99m,
                            Year = 1991
                        },
                        new
                        {
                            Id = 13,
                            Artist = "Doja Cat",
                            CategoryId = 1,
                            Code = "PlanetHer_CD",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Planet Her",
                            Price = 124.99m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 14,
                            Artist = "Dua Lipa",
                            CategoryId = 2,
                            Code = "FutureNostalgia_VINYL",
                            DiscountPercent = 0m,
                            Genre = "Pop",
                            Name = "Future Nostalgia",
                            Price = 249.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 15,
                            Artist = "Joni Mitchell",
                            CategoryId = 2,
                            Code = "Shine_VINYL",
                            DiscountPercent = 0m,
                            Genre = "Alternative",
                            Name = "Shine",
                            Price = 249.99m,
                            Year = 1979
                        },
                        new
                        {
                            Id = 16,
                            Artist = "Phoebe Bridgers",
                            CategoryId = 1,
                            Code = "Punisher_CD",
                            DiscountPercent = 0m,
                            Genre = "Alternative",
                            Name = "Punisher",
                            Price = 124.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 17,
                            Artist = "Phoebe Bridgers",
                            CategoryId = 2,
                            Code = "Punisher_VINYL",
                            DiscountPercent = 0m,
                            Genre = "Alternative",
                            Name = "Punisher",
                            Price = 249.99m,
                            Year = 2020
                        },
                        new
                        {
                            Id = 18,
                            Artist = "Lucy Dacus",
                            CategoryId = 2,
                            Code = "HomeVideo_VINYL",
                            DiscountPercent = 0m,
                            Genre = "Alternative",
                            Name = "Home Video",
                            Price = 124.99m,
                            Year = 2018
                        },
                        new
                        {
                            Id = 19,
                            Artist = "Billie Marten",
                            CategoryId = 2,
                            Code = "FloraFauna_VINYL",
                            DiscountPercent = 0m,
                            Genre = "Alternative",
                            Name = "Flora Fauna",
                            Price = 249.99m,
                            Year = 2021
                        },
                        new
                        {
                            Id = 20,
                            Artist = "Billie Marten",
                            CategoryId = 3,
                            Code = "FloraFauna_Cassette",
                            DiscountPercent = 0m,
                            Genre = "Alternative",
                            Name = "Flora Fauna",
                            Price = 149.99m,
                            Year = 2021
                        });
                });

            modelBuilder.Entity("MusicStore.Models.Product", b =>
                {
                    b.HasOne("MusicStore.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
