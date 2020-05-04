using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteMan_b0._1.Data.Infrastructure.Repositories.InMemory
{
    public class InMemoryQuoteRepo : IQuoteData
    {
        private List<Quote> _quotes;

        public InMemoryQuoteRepo()
        {
            _quotes = new List<Quote>
            {
                new Quote { QuoteId = 1, Price = 350.0m, Status = Core.Models.Enums.StatusType.Open, CustomerId = 1, DateGiven = DateTime.Today, Description = "Bleheheheheheh",
                    Vehicle = new Vehicle { Make = "Honda", Model = "Civic"}
                },
                new Quote { QuoteId = 2, Price = 250.0m, Status = Core.Models.Enums.StatusType.Closed, CustomerId = 1, DateGiven = DateTime.Today, Description = "Bleheheheheheh",
                    Vehicle = new Vehicle { Make = "Honda", Model = "Civic"}
                },
                new Quote { QuoteId = 3, Price = 750.50m, Status = Core.Models.Enums.StatusType.Open, CustomerId = 3, DateGiven = DateTime.Today, Description = "Bleheheheheheh",
                    Vehicle = new Vehicle { Make = "Toyota", Model = "Landcruiser"}
                },
            };
        }

        public IEnumerable<Quote> GetQuotesByCustomerId(int id)
        {
            return _quotes.Where(q => q.CustomerId == id);
        }
    }
}
