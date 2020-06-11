using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovies.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovies.Models
{
    public static class seedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMoviesContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMoviesContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(


                     new Movie
                     {
                         Title = "Jumanji",
                         ReleaseDate = DateTime.Parse("2020-02-20"),
                         Genre = "Action",
                         Price = 15,
                         Rating = "5"

                     },
                     new Movie
                     {
                         Title = "Lossing Lerato ",
                         ReleaseDate = DateTime.Parse("2019-02-20"),
                         Genre = "Thriller",
                         Price = 14,
                         Rating = "5"
                     },
                     new Movie
                     {
                         Title = "Bad Boys",
                         ReleaseDate = DateTime.Parse("2020-01-10"),
                         Genre = "Action Thriller",
                         Price = 10,
                         Rating = "5"
                     },
                      new Movie
                      {
                          Title = "Queen Sono",
                          ReleaseDate = DateTime.Parse("2020-01-05"),
                          Genre = "Action Thriller",
                          Price = 15,
                          Rating = "5"
                      }
                    );
                context.SaveChanges();
               

            }
        }
    }
}
