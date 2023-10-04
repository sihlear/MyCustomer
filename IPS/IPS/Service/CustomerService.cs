using IPS.Interfaces;
using IPS.Models;
using IPS.Repositories;

namespace IPS.Service
{
    public class CustomerService : ICustomerService
    {
        public CustomerRepository _customerRepository;

        public void CreateCustomer(Customer customer)
        {
            _customerRepository = new CustomerRepository();
            _customerRepository.CreateCustomer(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            _customerRepository = new CustomerRepository();
            return _customerRepository.GetCustomers();
        }

        public void UpdateCustomer(Customer customer)
        {
            _customerRepository = new CustomerRepository();
            _customerRepository.UpdateCustomer(customer);
        }

        public Customer GetCustomerById(int id)
        {
            _customerRepository = new CustomerRepository();
            return _customerRepository.GetCustomerById(id);
        }
        public void DeleteCustomer(int id) 
        {
            _customerRepository = new CustomerRepository();
            _customerRepository.DeleteCustomer(id);
        }
    }
}
