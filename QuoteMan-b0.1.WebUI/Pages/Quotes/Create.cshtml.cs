using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuoteMan_b0._1.WebUI.Pages.Quotes
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {
            // Use an async await to find the customer attached to the new quote (nice bit of practice)
            // needs to find the customer without using a post operation
            // way to disable the button while async is running with js? 
        }
    }
}