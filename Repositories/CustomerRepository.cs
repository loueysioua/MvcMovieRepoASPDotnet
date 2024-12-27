using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovieRepo.Data;
using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories.interfaces;

namespace MvcMovieRepo.Repositories
{
    public class CustomerRepository : GenericRepository<Customer> , ICustomerRepository
    {
        public CustomerRepository(MvcMovieRepoContext mvcMovieRepoContext): base(mvcMovieRepoContext){}
    }
}