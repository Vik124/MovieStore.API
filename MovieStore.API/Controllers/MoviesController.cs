using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieStore.API.Repositories;
using Microsoft.AspNetCore.Http;
using MovieStore.API.Models;


namespace MovieStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MoviesController : ControllerBase
    {
        private readonly MovieRepository _repository;

        public MoviesController(MovieRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("GetAllMovies")]
        public IEnumerable<Movie> GetMovies()
        {
            return _repository.GetAll();
        }

        [HttpGet]
        public async Task<ActionResult> GetMovieById(int id)
        {
            var movie = await _repository.GetById(id);
            if (movie != null)
            {
                return Ok(movie);

            }
        
        return NotFound();
       }

   }
}
