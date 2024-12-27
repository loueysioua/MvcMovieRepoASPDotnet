using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models;

public class Genre : IEntity
{
    public Guid Id { get; set; }
    public string? GenreName { get; set; }
    public List<Movie>? Movies { get; set; }
}