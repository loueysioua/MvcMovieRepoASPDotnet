using MvcMovieRepo.Models;
using MvcMovieRepo.Repositories.interfaces;
using mvcMovieRepositoryDotnet.Services.ServiceContracts;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Customer?> GetCustomerByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        return await _repository.AddAsync(customer);
    }
    public async Task<> UpdateCustomerAsync(Customer customer)
    {
        return await _repository.UpdateAsync(customer);
    }
    public async Task<Customer> DeleteCustomerAsync(Guid id);
    {
        var customer = await _repository.GetByIdAsync(id);
        return await _repository.DeleteAsync(customer);
    }


}
