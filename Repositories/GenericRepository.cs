using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovieRepo.Data;

namespace MvcMovieRepo.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class 
    {
        private readonly MvcMovieRepoContext _mvcMovieRepoContext;

        protected readonly DbSet<T> _dbSet;
        public GenericRepository(MvcMovieRepoContext mvcMovieRepoContext) {
            _mvcMovieRepoContext = mvcMovieRepoContext;
            _dbSet = mvcMovieRepoContext.Set<T>();
        }
        public Task<IEnumerable<T>> GetAllAsync(){
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsynct(){
            throw new NotImplementedException();
        }

        public Task<T> AddAsync(T entity){
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity){
            throw new NotImplementedException();

        }

        public Task DeleteAsync(T entity){
            throw new NotImplementedException();

        }
        
    }
}