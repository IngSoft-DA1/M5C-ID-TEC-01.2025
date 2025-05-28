using Domain;
using DataAccess;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieRepository _movieRepository;

        public MovieService(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public void AddMovie(MovieDTO movie)
        {
            ValidateUniqueTitle(movie.Title);
            _movieRepository.Add(ToEntity(movie));
        }

        public List<MovieDTO> GetMovies()
        {
            List<MovieDTO> moviesDTO = new List<MovieDTO>();

            foreach (var movie in _movieRepository.GetAll())
            {
                moviesDTO.Add(FromEntity(movie));
            }

            return moviesDTO;
        }


        public MovieDTO GetMovie(string title)
        {
            Movie? movie = _movieRepository.Get(movie => movie.Title == title);
            if (movie == null)
            {
                throw new ArgumentException("Cannot find movie with this title");
            }

            return FromEntity(movie);
        }

        private void ValidateUniqueTitle(string title)
        {
            foreach (var movie in _movieRepository.GetAll())
            {
                if (movie.Title == title)
                {
                    throw new ArgumentException("There`s a movie already defined with that title");
                }
            }
        }

        private static Movie ToEntity(MovieDTO movieDTO)
        {
            return new Movie(movieDTO.Id, movieDTO.Title, movieDTO.Director, movieDTO.ReleaseDate, movieDTO.Budget);
        }

        private static MovieDTO FromEntity(Movie movie)
        {
            return new MovieDTO()
            {
                Title = movie.Title,
                Director = movie.Director,
                ReleaseDate = movie.ReleaseDate
            };
        }
    }
}