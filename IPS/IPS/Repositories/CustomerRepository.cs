using IPS.Database;
using IPS.Interfaces;
using IPS.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System.Data;

namespace IPS.Repositories
{
    public class CustomerRepository : ICustomerRepository

    {
        
        public void addCustomer()
        {
            throw new NotImplementedException();
        }

        public void deleteCustomer()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                string DbConnectionString = "server=ESEN\\SQLEXPRESS;database=TechSolutions;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(DbConnectionString))
                {
                    connection.Open();
                    string query = "Select * from Customer";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using(SqlDataReader sqlDataReader = command.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                Customer customer = new Customer();
                                customer.CustomerId = sqlDataReader.GetInt32(0);
                                customer.CustomerName = sqlDataReader.GetString(1);
                                customer.Email = sqlDataReader.GetString(2);
                                customer.Phone = sqlDataReader.GetString(3);

                                customers.Add(customer);
                            }
                        }
                    }

                }
                return customers;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error getting customer list "+e.ToString());
            }

            return customers;
        }

        public void updateCustomer()
        {
            throw new NotImplementedException();
        }

        public void CreateCustomer(Customer customer)
        {
            try
            {
                string DbConnectionString = Constants.DbconnectionString;
                using (SqlConnection connection = new SqlConnection(DbConnectionString))
                {
                    connection.Open();
                    string query = Constants.InsertCustomer;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerName",customer.CustomerName);
                        command.Parameters.AddWithValue("@Email", customer.Email);
                        command.Parameters.AddWithValue("@Phone", customer.Phone);

                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error adding new customer! " + e.ToString());
            }

        }
    }
}
