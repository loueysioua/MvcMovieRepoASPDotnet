using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories;
using mvcMovieRepositoryDotnet.Services.ServiceContracts;

public class MembershipTypeService : IMembershipTypeService
{
    private readonly MembershipTypeRepository _repository;

    public MembershipTypeService(MembershipTypeRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<MembershipType>> GetMemebershipTypesAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<MembershipType?> GetMemebershipTypeByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<MembershipType> AddMemebershipTypeAsync(MembershipType memebershipType)
    {
        return await _repository.AddAsync(memebershipType);

    }
    public async Task UpdateMemebershipTypeAsync(MembershipType memebershipType);
    {
        return await _repository.UpdateAsync(memebershipType);

    }
    public async Task<MembershipType> DeleteMemebershipTypeAsync(Guid id)
        var memebershipType = await _repository.GetByIdAsync(id);
        return await _repository.DeleteAsync(memebershipType);
    }


}
