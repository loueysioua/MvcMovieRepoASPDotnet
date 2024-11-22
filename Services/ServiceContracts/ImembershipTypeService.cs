using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
{
    public interface IMembershipTypeService
    {
        public Task<IEnumerable<MembershipType>> GetMemebershipTypesAsync();
        public Task<MembershipType?> GetMemebershipTypeByIdAsync(Guid id);
        public Task<MembershipType> AddMemebershipTypeAsync(MembershipType memebershipType);
        public Task<MembershipType> UpdateMemebershipTypeAsync(MembershipType memebershipType);
        public Task<MembershipType> DeleteMemebershipTypeAsync(Guid id);
    }


}