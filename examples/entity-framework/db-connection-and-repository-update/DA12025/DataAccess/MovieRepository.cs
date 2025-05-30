using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class MovieRepository
{
    private readonly AppDbContext _context;

    public MovieRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
    }

    public ICollection<Movie> GetMovies()
    {
        return _context.Movies.ToList();
    }

    public Movie GetMovie(int id)
    {
        return _context.Movies.Find(id);
    }

    public void Update(Movie movieWithUpdatedData)
    {
        Movie movieFound = _context.Movies.Find(movieWithUpdatedData.Id);
        _context.Movies.Update(movieWithUpdatedData);
        _context.Entry(movieWithUpdatedData).State = EntityState.Modified; 
        _context.SaveChanges();
    }

    public void Remove(Movie movie)
    {
        //Este ejemplo contiene manejo de exceptions, lo mismo debe ser realizado en todos los metodos de cada repository
        try
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }


}