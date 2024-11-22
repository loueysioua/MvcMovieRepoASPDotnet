public class MovieService : IMovieService
{
    private readonly IGenericeRepository<Movie> _repository;

    public MovieService(IGenericeRepository<Movie> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Movie>> GetMoviesAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Movie?> GetMovieByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Movie> AddMovieAsync(Movie movie)
    {
        return await _repository.AddAsync(movie);
    }
    public async Task<Movie> UpdateMovieAsync(Movie movie)
    {
        return await _repository.UpdateAsync(movie);
    }
    public async Task<Movie> DeleteMovieAsync(Guid id)
    {
        var movie = await _repository.GetByIdAsync(id);
        return await _repository.DeleteAsync(movie);
    }


}
