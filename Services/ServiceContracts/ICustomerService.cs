using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts;
public interface ICustomerService
{
    public Task<IEnumerable<Customer>> GetCustomersAsync();
    public Task<Customer> GetCustomerByIdAsync(Guid? id);
    public Task<Customer> AddCustomerAsync(Customer Customer);
    public Task<Customer> UpdateCustomerAsync(Customer Customer);
    public Task<Customer> DeleteCustomerAsync(Customer Customer);
}