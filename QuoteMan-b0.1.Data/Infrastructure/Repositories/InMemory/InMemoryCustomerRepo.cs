using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteMan_b0._1.Data.Infrastructure.Repositories.InMemory
{
    public class InMemoryCustomerRepo : ICustomerData
    {
        private List<Customer> _customers;

        public InMemoryCustomerRepo()
        {
            _customers = new List<Customer>
            {
                new Customer { CustomerId = 1, Email = "bleh@abc.net", Title = Core.Models.Enums.TitleType.Mr, FirstName = "Bob", LastName = "Smith", PhoneNumber = "123456789" },
                new Customer { CustomerId = 2, Email = "bleh@def.net", Title = Core.Models.Enums.TitleType.Ms, FirstName = "Lucy", LastName = "Lou", PhoneNumber = "123456789" },
                new Customer { CustomerId = 3, Email = "bleh@ghi.net", Title = Core.Models.Enums.TitleType.Dr, FirstName = "Fred", LastName = "Octagon", PhoneNumber = "123456789" }
            };
        }

        public Customer FindCustomerById(int id)
        {
            return _customers.SingleOrDefault(c => c.CustomerId == id);
        }

        public IEnumerable<Customer> GetCustomersByName(string name = null)
        {
            return from c in _customers
                   where string.IsNullOrEmpty(name) || c.LastName.StartsWith(name) || c.FirstName.StartsWith(name)
                   orderby c.LastName descending
                   select c;
        }
    }
}
