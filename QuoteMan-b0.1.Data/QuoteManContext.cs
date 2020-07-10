using Microsoft.EntityFrameworkCore;
using QuoteMan_b0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteMan_b0._1.Data
{
    public class QuoteManContext : DbContext
    {
        public QuoteManContext(DbContextOptions<QuoteManContext> options) : base (options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Quote> Quotes { get; set; }

    }
}
