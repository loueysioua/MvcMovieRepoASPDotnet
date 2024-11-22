using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieRepo.Models;

namespace MvcMovieRepo.Data
{
    public class MvcMovieRepoContext : DbContext
    {
        public MvcMovieRepoContext (DbContextOptions<MvcMovieRepoContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovieRepo.Models.Genre> Genre { get; set; } = default!;
        public DbSet<MvcMovieRepo.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MvcMovieRepo.Models.Customer> Customer { get; set; } = default!;
        public DbSet<MvcMovieRepo.Models.MembershipType> MembershipType { get; set; } = default!;

    }
}
