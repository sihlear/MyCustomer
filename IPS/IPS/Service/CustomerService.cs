using IPS.Interfaces;
using IPS.Models;
using IPS.Repositories;

namespace IPS.Service
{
    public class CustomerService : ICustomerService
    {
        public CustomerRepository _customerRepository;

        public Task AddProductAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
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

        public List<Customer> GetAllCustomers()
        {
            _customerRepository = new CustomerRepository();
            return _customerRepository.GetCustomers();
        }
    }
}
