using QuoteMan_b0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteMan_b0._1.Core.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public decimal Price { get; set; }
        public Vehicle Vehicle { get; set; }
        public StatusType Status { get; set; }
        public DateTime DateGiven { get; set; }
        public DateTime DateModified { get; set; }
        public string Description { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
