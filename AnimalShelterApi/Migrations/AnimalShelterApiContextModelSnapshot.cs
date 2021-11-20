﻿// <auto-generated />
using AnimalShelterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelterApi.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    partial class AnimalShelterApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelterApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 3,
                            Color = "Brown",
                            Description = "Ralph is a 3 year old male dog. He is brown in color and as lovable as they come!",
                            Gender = "Male",
                            Name = "Ralph",
                            Species = "Canine"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 9,
                            Color = "Orange",
                            Description = "Suzy is an older 9 year old female cat. She is orange in color, gentle and nurturing -- great for an older person with plenty of patience.",
                            Gender = "Female",
                            Name = "Suzy",
                            Species = "Feline"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 5,
                            Color = "Black",
                            Description = "Terry is a 5 year old female dog. Terry is black in color, energetic and ready to meet her new active family!",
                            Gender = "Female",
                            Name = "Terry",
                            Species = "Canine"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Color = "Tabby",
                            Description = "Jake is a 4 year old male cat. Jake is a tabby cat, and quite playful. He'd be a great addition to a younger family.",
                            Gender = "Male",
                            Name = "Jake",
                            Species = "Feline"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 8,
                            Color = "Yellow",
                            Description = "Dino is an 8 year old male dog. Dino is Yellow in color. Don't let his age fool you; this happy dog's best days are still in front of him.",
                            Gender = "Male",
                            Name = "Dino",
                            Species = "Canine"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 1,
                            Color = "Grey",
                            Description = "Lambert is a 1 year old female kitten, grey in color. Lambert is as cute and cuddly as they come, and is sure to warm even the coldest of hearts.",
                            Gender = "Female",
                            Name = "Lambert",
                            Species = "Feline"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
