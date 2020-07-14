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
                new Quote { QuoteId = 1, Price = 350.0m, Status = Core.Models.Enums.StatusType.Open, CustomerId = 1, DateGiven = new DateTime(2020, 05, 08), Description = "Bleheheheheheh",
                    VehicleMake = "Honda", VehicleModel = "Civic"
                },
                new Quote { QuoteId = 2, Price = 250.0m, Status = Core.Models.Enums.StatusType.Closed, CustomerId = 1, DateGiven = new DateTime(2019, 12, 22), Description = "Bleheheheheheh",
                    VehicleMake = "Honda", VehicleModel = "Civic"
                },
                new Quote { QuoteId = 3, Price = 750.50m, Status = Core.Models.Enums.StatusType.Open, CustomerId = 3, DateGiven = new DateTime(2020, 05, 09), Description = "Bleheheheheheh",
                    VehicleMake = "Toyota", VehicleModel = "Landcruiser"
                },
            };

        }

        public int CommitChanges()
        {
            return 0;
        }

        public void CreateQuote(Quote quote)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuote(int id)
        {
            throw new NotImplementedException();
        }

        public Quote GetQuoteById(int id)
        {
            return _quotes.SingleOrDefault(q => q.QuoteId == id);
        }

        public IEnumerable<Quote> GetQuotesByCustomerId(int id)
        {
            return _quotes.Where(q => q.CustomerId == id).OrderByDescending(q => q.DateGiven);
        }

        public Quote UpdateQuote(Quote quote)
        {
            var quoteToUpdate = _quotes.Find(q => q.QuoteId == quote.QuoteId);

            if (quoteToUpdate == null)
                throw new InvalidOperationException("Quote not found");
            else
            {
                quoteToUpdate.Description = quote.Description;
                quoteToUpdate.VehicleMake = quote.VehicleMake;
                quoteToUpdate.VehicleModel = quote.VehicleModel;
                quoteToUpdate.Price = quote.Price;
                quoteToUpdate.DateGiven = quote.DateGiven;
                quoteToUpdate.Status = quote.Status;
                quoteToUpdate.CustomerId = quote.CustomerId;
                quoteToUpdate.DateModified = DateTime.Now;

                return quoteToUpdate;
            }            
        }
    }
}
