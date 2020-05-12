using QuoteMan_b0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteMan_b0._1.Data.Infrastructure.Contracts
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetCustomersByName(string name = null);
        Customer FindCustomerById(int id);
    }
}
