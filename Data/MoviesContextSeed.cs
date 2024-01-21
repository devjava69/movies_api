using Movies.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace Movies.API.Data
{
    public class MoviesContextSeed
    {
        public static void SeedAsync(MoviesAPIContext moviesContext)
        {
            if(!moviesContext.Movie.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre = "Drama",
                        Title = "The Shawshank Redembption",
                        Rating = "9.3",
                        ImageUrl = "images/src",
                        ReleaseDate = new System.DateTime(1994, 5, 5),
                        Owner = "alice"
                    },
                    new Movie
                    {
                        Id = 2,
                        Genre = "Action",
                        Title = "La fureur du dragon",
                        Rating = "8.0",
                        ImageUrl = "images/src",
                        ReleaseDate = new System.DateTime(1990, 5, 5),
                        Owner = "bob"
                    },
                    new Movie
                    {
                        Id = 3,
                        Genre = "Thriller",
                        Title = "Scarface",
                        Rating = "9.9",
                        ImageUrl = "images/src",
                        ReleaseDate = new System.DateTime(1994, 2, 3),
                        Owner = "karim"
                    },
                    new Movie
                    {
                        Id = 4,
                        Genre = "Thriller",
                        Title = "Les Affranchis",
                        Rating = "9.8",
                        ImageUrl = "images/src",
                        ReleaseDate = new System.DateTime(1994, 5, 5),
                        Owner = "karim"
                    },
                    new Movie
                    {
                        Id = 5,
                        Genre = "Comedie",
                        Title = "Les Ratzs",
                        Rating = "9.3",
                        ImageUrl = "images/src",
                        ReleaseDate = new System.DateTime(1994, 5, 5),
                        Owner = "bob"
                    },
                    new Movie
                    {
                        Id = 6,
                        Genre = "Drama",
                        Title = "Cendrillon",
                        Rating = "9.3",
                        ImageUrl = "images/src",
                        ReleaseDate = new System.DateTime(1994, 5, 5),
                        Owner = "alice"
                    }
                };
                moviesContext.Movie.AddRange(movies);
                moviesContext.SaveChanges();
            }
        }
    }
}
