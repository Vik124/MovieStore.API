using MovieStore.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace MovieStore.API.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Create(Task obj)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies.ToList();
            //throw new NotImplementedException();
        }

        //public Task<Movie> GetById(int id)
        //{
        //    return _context.Movies.ToList();
        //}

        public async Task<Movie>GetById(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie!=null)
            {
                return movie;

            }
            return null;
        }
        public Task Update(int id, Task obj)
        {
            throw new NotImplementedException();
        }
    }
}
