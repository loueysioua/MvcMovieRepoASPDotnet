using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovieRepo.Data;
using MvcMovieRepo.Models;

namespace MvcMovieRepo.Repositories
{
    public class GenreRepository : GenericRepository<Genre>,  IGenreRepository 
    {
        public GenreRepository(MvcMovieRepoContext mvcMovieRepoContext): base(mvcMovieRepoContext){
        } 
    }
}
