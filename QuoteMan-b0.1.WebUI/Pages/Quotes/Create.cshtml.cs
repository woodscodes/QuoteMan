using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;

namespace QuoteMan_b0._1.WebUI.Pages.Quotes
{
    public class CreateModel : PageModel
    {
        private ICustomerData _customerData;
        private IQuoteData _quoteData;
        private IHtmlHelper _htmlHelper;

        public Quote Quote { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }
        public IEnumerable<SelectListItem> Statuses { get; set; }
        public string SearchTerm { get; set; }

        public CreateModel(ICustomerData customerData, IQuoteData quoteData, IHtmlHelper htmlHelper)
        {
            _customerData = customerData;
            _quoteData = quoteData;
            _htmlHelper = htmlHelper;
        }

        public void OnGet()
        {
            Quote = new Quote();
            Customer = new Customer();
            

            // needs to be done with ajax -> find the customer using ajax and save the customer too
        }

    }
}