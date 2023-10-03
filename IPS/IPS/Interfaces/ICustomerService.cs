

using IPS.Models;

namespace IPS.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAllCustomers();
        Task<Customer> GetProductByIdAsync(int id);
        void CreateCustomer(Customer customer);
        Task UpdateProductAsync(Customer product);
        Task DeleteProductAsync(int id);
    }
}
