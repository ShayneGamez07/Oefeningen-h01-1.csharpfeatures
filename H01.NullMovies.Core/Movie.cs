using System.Collections.Generic;

namespace H01.NullMovies.Core.Models
{
    public class Movie
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public Movie Sequel { get; set; }

        public static List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = null,
                    Title = "Indiana Jones 1",
                    Director = null,
                    Sequel = new Movie
                    {
                        Title = "Indiana Jones 2"
                    }
                },
                new Movie
                {
                    Id = null,
                    Title = null,
                    Director = null,
                    Sequel = null
                },
                new Movie
                {
                    Id = 13,
                    Title = "Avengers 1",
                    Director = null,
                    Sequel = null
                }
            };
        }
    }
}