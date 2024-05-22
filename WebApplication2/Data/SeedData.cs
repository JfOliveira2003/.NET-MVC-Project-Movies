using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "When Harry Met Sally",
                    Ano = DateTime.Parse("1989-2-12"),
                    Genero = "Romantic Comedy",
                    Price = 7.99M,
                    rating = "R"

                },
                new Movie
                { 
                    Title = "Ghostbusters ",
                    Ano= DateTime.Parse("1984-3-13"),
                    Genero = "Comedy",
                    Price = 8.99M,
                    rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    Ano = DateTime.Parse("1986-2-23"),
                    Genero = "Comedy",
                    Price = 9.99M,
                    rating = "R"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    Ano = DateTime.Parse("1959-4-15"),
                    Genero = "Western",
                    Price = 3.99M,
                    rating = "R"
                }
            );
            context.SaveChanges();
        }
    }
}