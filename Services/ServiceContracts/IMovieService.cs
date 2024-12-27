using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts;
public interface IMovieService
{
    public Task<IEnumerable<Movie>> GetMoviesAsync();
    public Task<Movie?> GetMovieByIdAsync(Guid id);
    public Task<Movie> AddMovieAsync(Movie movie);
    public Task UpdateMovieAsync(Movie movie);
    public Task DeleteMovieAsync(Guid id);
}