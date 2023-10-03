using IPS.Models;
using IPS.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IPS.Pages.CustomerView
{
    public class AddCustomerModel : PageModel
    {
        public Customer customer = new Customer();
        public string errorMessage = string.Empty;
        private CustomerService _customerService;
        public void OnGet()
        {
          
        }

        public void OnPost() 
        {
            
            customer.CustomerName = Request.Form["name"];
            customer.Email = Request.Form["email"];
            customer.Phone = Request.Form["phone"];


            if(string.IsNullOrEmpty(customer.CustomerName) || string.IsNullOrEmpty(customer.Email) || string.IsNullOrEmpty(customer.Phone))
            {
                errorMessage = "one or more fields are missing entries";
            }
            else{
                CreatCustomer(customer);
                Response.Redirect("CustomerView");
            }

        }

        private void CreatCustomer(Customer customer)
        {
            _customerService = new CustomerService();
            _customerService.CreateCustomer(customer);
        }
    }
}
