using IPS.Models;
using Microsoft.EntityFrameworkCore;

namespace IPS.Database
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) 
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
