using IPS.Database;
using IPS.Models;
using IPS.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;

namespace IPS.Pages.CustomerView
{
    public class AddCustomerModel : PageModel
    {
        public Customer customer = new Customer();
        public string errorMessage = string.Empty;
        public string succefulMessage = string.Empty;
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
                return;
            }else if(!validatePhone(customer.Phone)) { errorMessage = "Please enter a valid Phone number";return; }
            else if (!isValidMail(customer.Email))
            {
                errorMessage = "Invalid email address";
                return;
            }

            try
            {
                CreatCustomer(customer);
                succefulMessage = "User added succesfully";
                Response.Redirect("/CustomerView/Index");

            }
            catch(Exception ex) { 

                if(ex.Message.Contains(customer.Email)) errorMessage ="User with "+ customer.Email + " already exist" ;
                return;
            }
        }

        private void CreatCustomer(Customer customer)
        {
            _customerService = new CustomerService();
            _customerService.CreateCustomer(customer);
        }
        private bool isValidMail(string email)
        {
            Regex regex = new Regex(Constants.emailPattern);
            Match match = regex.Match(email);
            if (match.Success)  return true;
            return false;
        }

        private bool validatePhone(string phone)
        {
            Regex regex = new Regex(Constants.phonePattern);
            Match match = regex.Match(phone);
            if (match.Success) return true;
            return false;
        }
    }
}
