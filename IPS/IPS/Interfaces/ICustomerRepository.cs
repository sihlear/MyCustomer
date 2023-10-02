using IPS.Models;

namespace IPS.Interfaces
{
    public interface ICustomerRepository 
    {
        List<Customer> GetCustomers();
        void updateCustomer();
        void deleteCustomer();
        void addCustomer();
    }
}
