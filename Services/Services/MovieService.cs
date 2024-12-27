
using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories;
using MvcMovieRepo.Repositories.interfaces;
using mvcMovieRepositoryDotnet.Services.ServiceContracts;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _repository;

    public MovieService(IMovieRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Movie>> GetMoviesAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Movie?> GetMovieByIdAsync(Guid id)
    {
        var movie = await _repository.GetByIdAsync(id);
        if (movie == null)
        {
            return null;
        }
        return movie;
    }

    public async Task<Movie> AddMovieAsync(Movie movie)
    {
        return await _repository.AddAsync(movie);
    }
    public async Task UpdateMovieAsync(Movie movie)
    {
        await _repository.UpdateAsync(movie);
    }
    public async Task DeleteMovieAsync(Guid id)
    {
        var movie = await _repository.GetByIdAsync(id);
        if (movie != null)
        {
            await _repository.DeleteAsync(movie);

        }
    }


}
