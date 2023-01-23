using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.API.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public  string ProductionName { get; set; }

        public DateTime ReleaseDate { get; set; }

        //
        public Genre Genre { get; set; }
        //
        public int GenreId { get; set; }

    }
}
