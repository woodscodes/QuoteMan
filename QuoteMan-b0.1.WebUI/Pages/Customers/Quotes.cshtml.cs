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
    public class QuotesModel : PageModel
    {
        private ICustomerData _customerData;
        private IQuoteData _quoteData;

        public IEnumerable<Quote> Quotes { get; set; }
        public Customer Customer { get; set; }
        public string Message { get; set; }

        public QuotesModel(ICustomerData customerData, IQuoteData quoteData)
        {
            _customerData = customerData;
            _quoteData = quoteData;
        }

        public void OnGet(int customerId)
        {
            Customer = _customerData.FindCustomerById(customerId);
            Quotes = _quoteData.GetQuotesByCustomerId(customerId);
            Message = MessageToDisplay(Quotes);
        }

        public string MessageToDisplay(IEnumerable<Quote> quotes)
        {
            if(quotes.Count() != 0)
            {
                return ($"Quotes for {Customer.Title} {Customer.FirstName} {Customer.LastName}");
            }

            return ($"No quotes found for {Customer.Title} {Customer.FirstName} {Customer.LastName}");
        }
    }
}