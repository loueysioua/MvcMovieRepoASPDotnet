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
        private readonly MvcMovieRepoContext _dbContext;

        protected readonly DbSet<T> _dbSet;
        public GenericRepository(MvcMovieRepoContext mvcMovieRepoContext) {
            _dbContext = mvcMovieRepoContext;
            _dbSet = mvcMovieRepoContext.Set<T>();
        }
        public async  Task<IEnumerable<T>> GetAllAsync(){
            return await _dbSet.ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id){
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(id), "Entity not found");
            }
            return entity;
        }
        

        public async Task<T> AddAsync(T entity){
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(T entity){
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity){
        
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        
    }
}