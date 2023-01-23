using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.API.Models;

namespace MovieStore.API.Repositories
{
    public interface IRepository
    {
        IEnumerable<Movie> GetMovies();
        Task<Movie> GetMovieById(int id);
        Task CreateMovie(Movie movie);
        Task UpdateMovie(int id, Movie movie);
        Task DeleteMovie(int id);
    }
}
