using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
{
    public interface IMovieService
    {
        public Task<IEnumerable<Movie>> GetMoviesAsync();
        public Task<Movie?> GetMovieByIdAsync(Guid id);
        public Task<Movie> AddMovieAsync(Movie movie);
        public Task<Movie> UpdateMovieAsync(Movie movie);
        public Task<Movie> DeleteMovieAsync(Guid id);
    }
}