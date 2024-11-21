using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models;

public class Customer
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int? MembershipTypeId { get; set; }
    public MembershipType? MembershipType { get; set; }
    public List<Movie>? Movies { get; set; }

}