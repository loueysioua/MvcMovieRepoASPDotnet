using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts;
public interface IMembershipTypeService
{
    public Task<IEnumerable<MembershipType>> GetCustomersAsync();
    public Task<MembershipType> GetMembershipTypeByIdAsync(Guid? id);
    public Task<MembershipType> AddMembershipTypeAsync(MembershipType MembershipType);
    public Task UpdateMembershipTypeAsync(MembershipType MembershipType);
    public Task DeleteMembershipTypeAsync(MembershipType MembershipType);
}