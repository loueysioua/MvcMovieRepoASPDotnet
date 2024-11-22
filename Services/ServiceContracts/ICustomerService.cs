using MvcMovieRepo.Models;

namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
{
    public interface ICustomerService
    {
        public Task<IEnumerable<Customer>> GetCustomersAsync();
        public Task<Customer?> GetCustomerByIdAsync(Guid id);
        public Task<Customer> AddCustomerAsync(Customer customer);
        public Task<Customer> UpdateCustomerAsync(Customer customer);
        public Task<Customer> DeleteCustomerAsync(Guid id);
    }
}