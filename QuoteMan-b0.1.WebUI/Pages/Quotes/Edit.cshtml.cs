using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;

namespace QuoteMan_b0._1.WebUI.Pages.Quotes
{
    public class EditModel : PageModel
    {
        private ICustomerData _customerData;
        private IQuoteData _quoteData;

        public Quote Quote { get; set; }


        public void OnGet()
        {
           

        }
    }
}