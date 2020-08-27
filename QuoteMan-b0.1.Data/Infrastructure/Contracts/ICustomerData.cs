using QuoteMan_b0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuoteMan_b0._1.Data.Infrastructure.Contracts
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetCustomersByName(string name = null);
        Customer GetCustomerById(int id);
        Customer UpdateCustomer(Customer customer);
        void CreateCustomer(Customer customer);
        void DeleteCustomer(int id);
        int CommitChanges();
    }
}
