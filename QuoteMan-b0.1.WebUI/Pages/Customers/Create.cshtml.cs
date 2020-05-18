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
    public class CreateModel : PageModel
    {
        private ICustomerData _customerData;
        private IHtmlHelper _htmlHelper;

        [BindProperty]
        public Customer Customer { get; set; }
        public IEnumerable<SelectListItem> Titles { get; set; }

        public CreateModel(ICustomerData customerData, IHtmlHelper htmlHelper)
        {
            _customerData = customerData;
            _htmlHelper = htmlHelper;
        }

        public void OnGet()
        {
            Titles = _htmlHelper.GetEnumSelectList<TitleType>();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _customerData.CreateCustomer(Customer);
                _customerData.CommitChanges();
                return RedirectToPage("/Customers/Index");
            }
            else
            {
                return RedirectToPage(Customer);
            }
        }
    }
}