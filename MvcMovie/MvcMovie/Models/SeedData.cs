using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-01-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 5M,
                        ImageURL = "https://m.media-amazon.com/images/M/MV5BMTI4NzQ1OTMyNV5BMl5BanBnXkFtZTYwMTE1NzQ3._V1_UY1200_CR92,0,630,1200_AL_.jpg"
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        Genre = "Drama",
                        Rating = "PG",
                        Price = 1M,
                        ImageURL = "https://m.media-amazon.com/images/M/MV5BNjA0NTY1NzM2MV5BMl5BanBnXkFtZTgwMzgyMzYzNTE@._V1_UY1200_CR73,0,630,1200_AL_.jpg"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2015-02-26"),
                        Genre = "Documentary",
                        Rating = "PG",
                        Price = 9.99M,
                        ImageURL = "https://upload.wikimedia.org/wikipedia/en/1/17/Meet_the_Mormons_poster.jpg"
                    }
                );;
                context.SaveChanges();
            }
        }
    }
}