using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mission6.Models
{
    public class MovieEntryContext : DbContext
    {
        //constructor
        public MovieEntryContext (DbContextOptions<MovieEntryContext> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<MovieResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponse>().HasData(
                
                //seed the data
                new MovieResponse
                {
                    MovieId = 1,
                    Category = "Fantasy",
                    Title = "Harry Potter",
                    Year = 2007,
                    Director = "JK Rowling",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "This was a great film"
                },
                new MovieResponse
                {
                    MovieId = 2,
                    Category = "Fantasy",
                    Title = "Harry Potter: The Chamber of Secrets",
                    Year = 2010,
                    Director = "JK Rowling",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "This was a great film as well"
                },
                new MovieResponse
                {
                    MovieId = 3,
                    Category = "Fantasy",
                    Title = "Harry Potter: The Prisoner of Azkaban",
                    Year = 2012,
                    Director = "JK Rowling",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "This was a great film too!"
                }


                );


        }

    }
}
