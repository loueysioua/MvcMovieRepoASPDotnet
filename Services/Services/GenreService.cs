public class GenreService : IGenreService
{
    private readonly IGenericeRepository<Genre> _repository;

    public GenreService(IGenericeRepository<Genre> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Genre>> GetGenresAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Genre?> GetGenreByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Genre> AddGenreAsync(Genre genre)
    {
        return await _repository.AddAsync(genre);

    }
    public async Task<Genre> UpdateGenreAsync(Genre genre)
    {
        return await _repository.UpdateAsync(genre);

    }
    public async Task<Genre> DeleteGenreAsync(Guid id)
        var genre = await _repository.GetByIdAsync(id);
        return await _repository.DeleteAsync(genre);
    }


}
