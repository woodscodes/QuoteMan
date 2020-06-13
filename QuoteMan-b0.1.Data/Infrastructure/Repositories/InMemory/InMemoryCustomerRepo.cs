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
                new Customer { CustomerId = 1, Email = "bleh@abc.net", Title = Core.Models.Enums.TitleType.Mr, FirstName = "Bob", LastName = "Smith", PhoneNumber = "07833373407" },
                new Customer { CustomerId = 2, Email = "bleh@def.net", Title = Core.Models.Enums.TitleType.Ms, FirstName = "Lucy", LastName = "Lou", PhoneNumber = "07833373407" },
                new Customer { CustomerId = 3, Email = "bleh@ghi.net", Title = Core.Models.Enums.TitleType.Dr, FirstName = "Fred", LastName = "Octagon", PhoneNumber = "07833373407" },
                new Customer { CustomerId = 4, Email = "bleh@jkh.net", Title = Core.Models.Enums.TitleType.Mr, FirstName = "Henry", LastName = "Smith", PhoneNumber = "07833373407" }
            };
        }

        public int CommitChanges()
        {
            return 0;
        }

        public void CreateCustomer(Customer customer)
        {
            customer.CustomerId = _customers.Max(c => c.CustomerId) + 1;
            _customers.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            var customerToDelete = _customers.Find(c => c.CustomerId == id);

            if (customerToDelete == null)
                throw new Exception("Customer not found");
            else            
                _customers.Remove(customerToDelete);
        }

        public Customer FindCustomerById(int id)
        {
            return _customers.SingleOrDefault(c => c.CustomerId == id);
        }

        public IEnumerable<Customer> GetCustomersByName(string name = null)
        {
            if (name != null)
                name = name.ToUpper();

            return from c in _customers
                   where string.IsNullOrEmpty(name) || c.LastName.ToUpper().StartsWith(name) || c.FirstName.ToUpper().StartsWith(name)
                   orderby c.LastName descending
                   select c;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var customerToUpdate = _customers.Find(c => c.CustomerId == customer.CustomerId);

            if (customerToUpdate == null)
                throw new InvalidOperationException("Customer not found");
            else
            {
                customerToUpdate.Title = customer.Title;
                customerToUpdate.FirstName = customer.FirstName;
                customerToUpdate.LastName = customer.LastName;
                customerToUpdate.Email = customer.Email;
                customerToUpdate.PhoneNumber = customer.PhoneNumber;
                customerToUpdate.Quotes = customer.Quotes;
                return customerToUpdate;
            }
        }

    }
}
