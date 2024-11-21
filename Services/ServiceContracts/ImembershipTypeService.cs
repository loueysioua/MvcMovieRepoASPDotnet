namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
public interface IMemebershipTypeService
{
    public async Task<IEnumerable<MemebershipType>> GetMemebershipTypsAsync();
    public async Task<MemebershipType> GetMemebershipTypeByIdAsync(int id);
    public async Task<MemebershipType> AddMemebershipTypeAsync(MemebershipTyp MemebershipTyp);
    public async Task<MemebershipType> UpdateMemebershipType Async(MemebershipType MemebershipType);
    public async Task<MemebershipType> DeleteMemebershipType Async(int id);
}