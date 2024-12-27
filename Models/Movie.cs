using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models
{
    public class Movie : IEntity
    {
        public Guid Id {get; set ;} 
        public string? Name {get; set;}
        public Guid GenreId {get; set;}
        public Genre? Genre {get; set;}
        public List<MovieCustomer>? Customers {get; set;}
    }
}