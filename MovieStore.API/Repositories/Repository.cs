using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.API.Models;

namespace MovieStore.API.Repositories
{
    public interface IRepository<T> where T: class
    {
        //    IEnumerable<Movie> GetMovies();
        //    Task<Movie> GetMovieById(int id);
        //    Task CreateMovie(Movie movie);
        //    Task UpdateMovie(int id, Movie movie);
        //    Task DeleteMovie(int id);

        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        Task Create(Task obj);

        Task Update(int id, Task obj);
        Task Delete(int id);
    }
}
