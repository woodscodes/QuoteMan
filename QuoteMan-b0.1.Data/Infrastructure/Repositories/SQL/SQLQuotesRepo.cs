using Microsoft.EntityFrameworkCore;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteMan_b0._1.Data.Infrastructure.Repositories.SQL
{
    public class SQLQuotesRepo : IQuoteData
    {
        private QuoteManContext _context;

        public SQLQuotesRepo(QuoteManContext context)
        {
            _context = context;
        }

        public int CommitChanges()
        {
            return _context.SaveChanges();
        }

        public void CreateQuote(Quote quote)
        {
            _context.Add(quote);
        }

        public void DeleteQuote(int id)
        {
            var quoteToDelete = GetQuoteById(id);
            
            if(quoteToDelete != null)
                _context.Remove(quoteToDelete);
        }

        public Quote GetQuoteById(int id)
        {
            return _context.Quotes.Find(id);
        }

        public IEnumerable<Quote> GetQuotesByCustomerId(int id)
        {
            return from q in _context.Quotes
                   where q.CustomerId == id
                   orderby q.DateGiven descending
                   select q;
        }

        public Quote UpdateQuote(Quote quote)
        {
            var entity = _context.Quotes.Attach(quote);

            entity.State = EntityState.Modified;

            return quote;
        }
    }
}
