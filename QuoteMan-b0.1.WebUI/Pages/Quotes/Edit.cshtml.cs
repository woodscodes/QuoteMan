using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Core.Models.Enums;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;

namespace QuoteMan_b0._1.WebUI.Pages.Quotes
{
    public class EditModel : PageModel
    {
        private ICustomerData _customerData;
        private IQuoteData _quoteData;
        private IHtmlHelper _htmlHelper;

        [BindProperty]
        public Quote Quote { get; set; }
        public IEnumerable<SelectListItem> Statuses { get; set; }

        public EditModel(IQuoteData quoteData, ICustomerData customerData, IHtmlHelper htmlHelper)
        {
            _quoteData = quoteData;
            _customerData = customerData;
            _htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int quoteId)
        {
            Statuses = _htmlHelper.GetEnumSelectList<StatusType>();

            Quote = _quoteData.GetQuoteById(quoteId);
            if (Quote == null)
                return RedirectToPage("/Shared/_NotFound");

            Quote.Customer = _customerData.FindCustomerById(Quote.CustomerId);

            if (Quote.Customer == null)
                return RedirectToPage("/Shared/_NotFound");
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            Statuses = _htmlHelper.GetEnumSelectList<StatusType>();

            if (ModelState.IsValid)
            {
                _quoteData.UpdateQuote(Quote);
                _quoteData.CommitChanges();
                return RedirectToPage("../Customers/Index/");
            }
            else
                return Page();
        }

    }
}