using DataAccess;
using Domain;

namespace Services.Tests;

[TestClass]
public class MovieServiceTests
{
    private InMemoryDatabase _inMemoryDatabase;
    private MovieService _movieService;
    private Movie _movie;

    [TestInitialize]
    public void Setup()
    {
        _inMemoryDatabase = new InMemoryDatabase();
        _movieService = new MovieService(_inMemoryDatabase);
        _movie = new Movie("aTitle", "aDirector", new DateTime(2024, 07, 12), 2000000);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void AddMovie_WhenAddTheSameMovieTwice_ThenThrowException()
    {
        //arrange
        //act
        _movieService.AddMovie(_movie);
        _movieService.AddMovie(_movie);
        //assert
    }

    [TestMethod]
    public void AddMovie_WhenAddAMovie_ThenReturnSuccessfully()
    {
        //arrange
        //act
        _movieService.AddMovie(_movie);
        var retrievedMovie = _inMemoryDatabase.Movies.Find(m => m.Title == _movie.Title);
        //assert
        Assert.IsNotNull(retrievedMovie);
        Assert.IsTrue(_inMemoryDatabase.Movies.Count == 1);
    }

    [TestMethod]
    public void GetMovies_WhenGetAllMoviesAndThereAreNoMovies_ThenNoMoviesAreReturned()
    {
        //arrange
        //act
        _movieService.GetMovies();
        //assert
        Assert.IsTrue(_inMemoryDatabase.Movies.Count == 0);
    }

    [TestMethod]
    public void GetMovies_WhenGetAllMoviesAndThereAreSomeMovies_ThenAllMoviesAreReturned()
    {
        //arrange
        _inMemoryDatabase.Movies.Add(_movie);
        //act
        _movieService.GetMovies();
        //assert
        Assert.IsTrue(_inMemoryDatabase.Movies.Contains(_movie));
        Assert.IsTrue(_inMemoryDatabase.Movies.Count == 1);
    }
}