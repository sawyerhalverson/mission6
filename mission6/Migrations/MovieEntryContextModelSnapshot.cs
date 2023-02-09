﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission6.Models;

namespace mission6.Migrations
{
    [DbContext(typeof(MovieEntryContext))]
    partial class MovieEntryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mission6.Models.MovieResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Fantasy",
                            Director = "JK Rowling",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "This was a great film",
                            Rating = "PG",
                            Title = "Harry Potter",
                            Year = 2007
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Fantasy",
                            Director = "JK Rowling",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "This was a great film as well",
                            Rating = "PG-13",
                            Title = "Harry Potter: The Chamber of Secrets",
                            Year = 2010
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Fantasy",
                            Director = "JK Rowling",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "This was a great film too!",
                            Rating = "PG-13",
                            Title = "Harry Potter: The Prisoner of Azkaban",
                            Year = 2012
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
