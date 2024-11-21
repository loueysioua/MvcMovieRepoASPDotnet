using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models
{
    public class Movie
    {
        private Guid Id {get; set ;} 
        private string Name {get; set;}
        private int GenreId {get; set;}
        private Genre Genre {get; set;}
    }
}