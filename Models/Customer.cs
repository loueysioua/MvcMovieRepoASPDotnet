using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models;

public class Customer : IEntity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid? MembershipTypeId { get; set; }
    public MembershipType? MembershipType { get; set; }
    public List<MovieCustomer>? Movies { get; set; }

}