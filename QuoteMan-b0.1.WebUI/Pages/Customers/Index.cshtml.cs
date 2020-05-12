using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;

namespace QuoteMan_b0._1.WebUI.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private ICustomerData _customerData;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Customer> Customers { get; set; }

        public IndexModel(ICustomerData customerData)
        {
            _customerData = customerData;
        }
        
        public void OnGet()
        {
            Customers = _customerData.GetCustomersByName(SearchTerm);
        }
    }
}