namespace mvcMovieRepositoryDotnet.Services.ServiceContracts
public interface ICustomerService
{
    public async Task<IEnumerable<Customer>> GetCustomersAsync();
    public async Task<Customer> GetCustomerByIdAsync(int id);
    public async Task<Customer> AddCustomerAsync(Customer Customer);
    public async Task<Customer> UpdateCustomerAsync(Customer Customer);
    public async Task<Customer> DeleteCustomerAsync(int id);
}