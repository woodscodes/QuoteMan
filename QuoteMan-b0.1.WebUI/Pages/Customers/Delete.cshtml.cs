using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;

namespace QuoteMan_b0._1.WebUI.Pages.Customers
{
    public class DeleteModel : PageModel
    {
        private ICustomerData _customerData;

        [BindProperty]
        public Customer Customer { get; set; }

        public DeleteModel(ICustomerData customerData)
        {
            _customerData = customerData;
        }
        
        public IActionResult OnGet(int customerId)
        {
            Customer = _customerData.FindCustomerById(customerId);

            if(Customer != null)
            {
                return Page();
            }
            else
            {
                return RedirectToPage("/Shared/_NotFound");
            }
        }

        public IActionResult OnPost()
        {
            _customerData.DeleteCustomer(Customer.CustomerId);
            return RedirectToPage("/Customers/Index");
        }
    }
}