using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories;
using mvcMovieRepositoryDotnet.Services.ServiceContracts;

public class GenreService : IGenreService
{
    private readonly GenreRepository _repository;

    public GenreService(GenreRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Genre>> GetGenresAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Genre?> GetGenreByIdAsync(Guid? id)
    {
        if(id==null) return null;
        return await _repository.GetByIdAsync((Guid)id);
    }

    public async Task<Genre> AddGenreAsync(Genre genre)
    {
        return await _repository.AddAsync(genre);

    }
    public async Task UpdateGenreAsync(Genre genre)
    {
        await _repository.UpdateAsync(genre);

    }
    public async Task DeleteGenreAsync(Guid id){
        var genre = await _repository.GetByIdAsync(id);
        if(genre != null)
            await _repository.DeleteAsync(genre);
    }


}
