﻿using DataAccess;
using Domain;
using Services.Interfaces;
using Services.Models;

namespace Services
{
    public class MovieService : IMovieService
    {
        private readonly InMemoryDatabase _inMemoryDatabase;

        public MovieService(InMemoryDatabase inMemoryDatabase)
        {
            _inMemoryDatabase = inMemoryDatabase;
        }

        public void AddMovie(MovieDTO movie)
        {
            ValidateUniqueTitle(movie.Title);

            _inMemoryDatabase.Movies.Add(ToEntity(movie));
        }


        public List<MovieDTO> GetMovies()
        {
            List<MovieDTO> moviesDTO = new List<MovieDTO>();

            foreach (var movie in _inMemoryDatabase.Movies)
            {
                moviesDTO.Add(FromEntity(movie));
            }

            return moviesDTO;
        }

        public MovieDTO GetMovie(string title)
        {
            Movie? movie = _inMemoryDatabase.Movies.FirstOrDefault(movie => movie.Title == title);
            if (movie == null)
            {
                throw new ArgumentException("Cannot find movie with this title");
            }

            return FromEntity(movie);
        }

        private void ValidateUniqueTitle(String title)
        {
            foreach (var movie in _inMemoryDatabase.Movies)
            {
                if (movie.Title == title)
                {
                    throw new ArgumentException("There`s a movie already defined with that title");
                }
            }
        }

        private Movie ToEntity(MovieDTO movieDTO)
        {
            return new Movie(movieDTO.Title, movieDTO.Director, movieDTO.ReleaseDate, movieDTO.Budget);
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