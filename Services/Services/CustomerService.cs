public class CustomerService : ICustomerService
{
    private readonly IGenericeRepository<Customer> _repository;

    public CustomerService(IGenericeRepository<Customer> repository)
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
    public async Task<Customer> UpdateCustomerAsync(Customer customer)
    {
        return await _repository.UpdateAsync(customer);
    }
    public async Task<Customer> DeleteCustomerAsync(Guid id);
    {
        var customer = await _repository.GetByIdAsync(id);
        return await _repository.DeleteAsync(customer);
    }


}
