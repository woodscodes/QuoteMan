using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuoteMan_b0._1.Data.Infrastructure.Repositories.SQL
{
    public class SQLCustomerRepo : ICustomerData
    {
        private QuoteManContext _context;

        public SQLCustomerRepo(QuoteManContext context)
        {
            _context = context;
        }

        public int CommitChanges()
        {
            return _context.SaveChanges();
        }

        public void CreateCustomer(Customer customer)
        {
            _context.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            var customerToDelete = FindCustomerById(id);

            if (customerToDelete != null)
                _context.Customers.Remove(customerToDelete);
        }

        public Customer FindCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }

        public IEnumerable<Customer> GetCustomersByName(string name = null)
        {
            if (name != null)
                name = name.ToUpper();

            return from c in _context.Customers
                   where String.IsNullOrEmpty(name) || c.LastName.ToUpper().StartsWith(name) || c.FirstName.ToUpper().StartsWith(name)
                   orderby c.LastName descending
                   select c;
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var entity = _context.Customers.Attach(customer);

            entity.State = EntityState.Modified;

            return customer;           
        }
    }
}
