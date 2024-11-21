namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
public interface IGenreService
{
    public async Task<IEnumerable<Genre>> GetGenresAsync();
    public async Task<Genre> GetGenreByIdAsync(int id);
    public async Task<Genre> AddGenreAsync(Genre Genre);
    public async Task<Genre> UpdateGenreAsync(Genre Genre);
    public async Task<Genre> DeleteGenreAsync(int id);
}