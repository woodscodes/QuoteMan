using QuoteMan_b0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteMan_b0._1.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public TitleType Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<Quote> Quotes { get; set; }
    }
}
