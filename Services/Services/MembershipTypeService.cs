using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories;
using MvcMovieRepo.Repositories.interfaces;
using mvcMovieRepositoryDotnet.Services.ServiceContracts;

public class MembershipTypeService : IMembershipTypeService
{
    private readonly IMembershipTypeRepository _repository;

    public MembershipTypeService(IMembershipTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MembershipType>> GetMembershipTypesAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<MembershipType?> GetMembershipTypeByIdAsync(Guid id)
    {
        var membershipType = await _repository.GetByIdAsync(id);
        if (membershipType == null)
        {
            return null;
        }
        return membershipType;
    }

    public async Task<MembershipType> AddMembershipTypeAsync(MembershipType membershipType)
    {
        return await _repository.AddAsync(membershipType);

    }
    public async Task UpdateMembershipTypeAsync(MembershipType membershipType)
    {
        await _repository.UpdateAsync(membershipType);
    }


    public async Task DeleteMembershipTypeAsync(Guid id)
    {
        var membershipType = await _repository.GetByIdAsync(id);
        if (membershipType != null)
        {
            await _repository.DeleteAsync(membershipType);
        }
    }

}