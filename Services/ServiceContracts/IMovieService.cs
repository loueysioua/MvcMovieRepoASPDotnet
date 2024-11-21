namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
public interface IMovieService
{
    public async Task<IEnumerable<Movie>> GetMoviesAsync();
    public async Task<Movie> GetMovieByIdAsync(int id);
    public async Task<Movie> AddMovieAsync(Movie movie);
    public async Task<Movie> UpdateMovieAsync(Movie movie);
    public async Task<Movie> DeleteMovieAsync(int id);
}