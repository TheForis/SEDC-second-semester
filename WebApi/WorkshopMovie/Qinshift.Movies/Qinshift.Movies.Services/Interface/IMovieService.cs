﻿using Qinshift.Movies.DTOs;

namespace Qinshift.Movies.Services.Interface
{
    public interface IMovieService
    {
        List<MovieDto> GetAllMovies();
        MovieDto GetById(int id);
        MovieDto GetMovieByGenre();
        MovieDto GetMovieByYear();
        void CreateMovie(CreateMovieDto movie);
        void UpdateMovie(int id,CreateMovieDto movie);
        void DeleteMovie(int id);

    }
}
