using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcMovieRepo.Data;
using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories.interfaces;

namespace MvcMovieRepo.Repositories
{
    public class MembershipTypeRepository : GenericRepository<MembershipType> , IMembershipTypeRepository
    {
        public MembershipTypeRepository(MvcMovieRepoContext mvcMovieRepoContext) : base(mvcMovieRepoContext){}
    }
}