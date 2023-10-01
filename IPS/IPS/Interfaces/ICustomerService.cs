

using IPS.Models;

namespace IPS.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllProductsAsync();
        Task<Customer> GetProductByIdAsync(int id);
        Task AddProductAsync(Customer product);
        Task UpdateProductAsync(Customer product);
        Task DeleteProductAsync(int id);
    }
}
