using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovieRepo.Data;
using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories.interfaces;

namespace MvcMovieRepo.Repositories
{
    public class MovieRepository : GenericRepository<Movie> , IMovieRepository
    {
        public MovieRepository(MvcMovieRepoContext mvcMovieRepoContext) : base(mvcMovieRepoContext){}
    }
}