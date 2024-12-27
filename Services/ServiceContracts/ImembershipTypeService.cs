using System.Runtime.CompilerServices;
using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts;
public interface IMembershipTypeService
{
    Task<IEnumerable<MembershipType>> GetMembershipTypesAsync();
    public Task<MembershipType?> GetMembershipTypeByIdAsync(Guid id);
    public Task<MembershipType> AddMembershipTypeAsync(MembershipType MembershipType);
    public Task UpdateMembershipTypeAsync(MembershipType MembershipType);
    public Task DeleteMembershipTypeAsync(Guid id);
}