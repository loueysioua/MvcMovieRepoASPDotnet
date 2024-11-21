using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models;

public class Genre
{
    public Guid Id { get; set; }
    public string GenreName { get; set; }
    public Movie Movie { get; set; }
    public int MovieId { get; set; }
}