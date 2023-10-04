using IPS.Models;

namespace IPS.Interfaces
{
    public interface ICustomerRepository 
    {
        List<Customer> GetCustomers();
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
        void CreateCustomer(Customer customer);
    }
}
