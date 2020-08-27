using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Core.Models.Enums;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;

namespace QuoteMan_b0._1.WebUI.Pages.Customers
{
    public class EditModel : PageModel
    {
        private ICustomerData _customerData;
        private IHtmlHelper _htmlHelper;

        [BindProperty]
        public Customer Customer { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }
        
        public EditModel(ICustomerData customerData, IHtmlHelper htmlHelper)
        {
            _customerData = customerData;
            _htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int customerId)
        {
            Titles = _htmlHelper.GetEnumSelectList<TitleType>();
            Customer = _customerData.GetCustomerById(customerId);

            if (Customer != null)
                return Page();
            else
                return RedirectToPage("/Shared/_NotFound");
        }

        public IActionResult OnPost()
        {
            Titles = _htmlHelper.GetEnumSelectList<TitleType>();

            if (ModelState.IsValid)
            {
                _customerData.UpdateCustomer(Customer);
                _customerData.CommitChanges();
                return RedirectToPage("/Customers/Index");
            }
            else
                return Page();
        }
    }
}