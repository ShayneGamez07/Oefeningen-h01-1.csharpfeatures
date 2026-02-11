using System;
using System.Collections.Generic;
using H01.NullMovies.Core.Models;

namespace H01.NullMovies.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = Movie.GetMovies();
            var output = new List<string>();

            foreach (var movie in movies)
            {
                output.Add(BuildMovieString(movie));
            }

            PrintMovies(output);
        }

        private static string BuildMovieString(Movie movie)
        {
            return $"""
            Id: {movie.Id ?? -1}
            Title: {movie.Title ?? "Geen titel"}
            Director: {movie.Director ?? "Onbekend"}
            Sequel: {movie.Sequel?.Title ?? "Geen sequel"}
            """;
        }

        private static void PrintMovies(List<string> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
                Console.WriteLine("--------------");
            }
        }
    }
}
