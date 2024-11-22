using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
{
    public interface IGenreService
    {
        Task<IEnumerable<Genre>> GetGenresAsync();
        Task<Genre?> GetGenreByIdAsync(Guid id);
        Task<Genre> AddGenreAsync(Genre genre);
        Task<Genre> UpdateGenreAsync(Genre genre);
        Task<Genre> DeleteGenreAsync(Guid id);
    }
}