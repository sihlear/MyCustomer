using IPS.Interfaces;
using IPS.Models;
using IPS.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IPS.Pages.CustomerView
{
    public class IndexModel : PageModel
    {
        private CustomerService _customerService;
        public List<Customer> customers;
        public void OnGet()
        {
            _customerService= new CustomerService();
             customers = _customerService.GetAllCustomers();

        }
    }
}
