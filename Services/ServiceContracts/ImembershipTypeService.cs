using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts ;
public interface IMemebershipTypeService
{
    public Task<IEnumerable<MembershipType>> GetMemebershipTypsAsync();
    public Task<MembershipType> GetMemebershipTypeByIdAsync(Guid? id);
    public Task<MembershipType> AddMemebershipTypeAsync(MembershipType MemebershipTyp);
    public Task<MembershipType> UpdateMembershipType(MembershipType MemebershipType);
    public Task<MembershipType> DeleteMemebershipType(MembershipType MemebershipType);
}