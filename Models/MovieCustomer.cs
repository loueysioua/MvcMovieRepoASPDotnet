using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models
{
    public class MovieCustomer
    {
        [Key]
        public Guid MovieId { get; set; }
        [Key]
        public Guid CustomerId { get; set; }
        public required Movie Movie { get; set; }
        public required Customer Customer { get; set; }
    }
}