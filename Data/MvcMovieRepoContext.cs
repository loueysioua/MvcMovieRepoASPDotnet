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
    }
}
