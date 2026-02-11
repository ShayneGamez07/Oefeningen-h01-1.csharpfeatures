using System;
using System.Linq;
using linq_methods.Core;

class Program
{
    static void Main()
    {
        var repo = new MovieRepository();

        // Alle Comedy movies
        var comedies = repo.GetMovies()
                           .Where(m => m.Genre == "Comedy");
        PrintMovies(comedies);

        // Movie met Id 8
        var movie8 = repo.GetMovies()
                         .FirstOrDefault(m => m.Id == 8);
        PrintMovie(movie8);

        // Movies tussen 2005 en 2010, gesorteerd
        var movies2005_2010 = repo.GetMovies()
                                  .Where(m => m.Year >= 2005 && m.Year <= 2010)
                                  .OrderBy(m => m.Year);
        PrintMovies(movies2005_2010);

        // Movie id 11 → enkel Id & Title
        var movie11 = repo.GetMovies()
                          .Where(m => m.Id == 11)
                          .Select(m => new { m.Id, m.Title })
                          .FirstOrDefault();

        Console.WriteLine($"Id: {movie11.Id}, Title: {movie11.Title}");
    }
}
