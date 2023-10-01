using IPS.Interfaces;
using IPS.Models;

namespace IPS.Service
{
    public class CustomerService : ICustomerService
    {
        public readonly ICustomerRepository _customerRepository;

        public Task AddProductAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
