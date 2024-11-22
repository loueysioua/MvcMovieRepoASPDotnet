using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts;
public interface IGenreService
{
    public Task<IEnumerable<Genre>> GetGenresAsync();
    public Task<Genre> GetGenreByIdAsync(Guid? id);
    public Task<Genre> AddGenreAsync(Genre Genre);
    public Task<Genre> UpdateGenreAsync(Genre Genre);
    public Task<Genre> DeleteGenreAsync(Genre Genre);
}