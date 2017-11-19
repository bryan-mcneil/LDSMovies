using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "The Singles Ward",
                         ReleaseDate = DateTime.Parse("2002-1-11"),
                         Genre = "Romantic Comedy",
                         Rating = "PG",
                         Price = 7.99M
                     },

                     new Movie
                     {
                         Title = "The R.M.",
                         ReleaseDate = DateTime.Parse("2003-3-13"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 8.99M
                     },

                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("2014-2-23"),
                         Genre = "Documentary",
                         Rating = "PG",
                         Price = 9.99M
                     },

                   new Movie
                   {
                       Title = "The Other Side of Heaven",
                       ReleaseDate = DateTime.Parse("2001-4-15"),
                       Genre = "Drama",
                       Rating = "PG",
                       Price = 3.99M
                   },

                   new Movie
                   {
                       Title = "17 Miracles",
                       ReleaseDate = DateTime.Parse("2011-4-15"),
                       Genre = "History",
                       Rating = "PG",
                       Price = 3.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
