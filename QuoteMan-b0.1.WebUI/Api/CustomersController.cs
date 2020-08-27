using Microsoft.AspNetCore.Mvc;
using QuoteMan_b0._1.Core.Models;
using QuoteMan_b0._1.Data.Infrastructure.Contracts;
using QuoteMan_b0._1.Data.Infrastructure.Repositories.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteMan_b0._1.WebUI.Api
{
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerData _customerData;

        public CustomersController(ICustomerData customerData)
        {
            _customerData = customerData ??
                throw new ArgumentNullException(nameof(SQLCustomerRepo));
        }

        [HttpGet]
        [Route("api/{controller}")]
        public IActionResult GetCustomers(string name)
        {
            var customers = _customerData.GetCustomersByName(name);

            if (customers != null)
                return new JsonResult(customers);
            else
                return BadRequest();
        }

        [HttpGet]
        [Route("api/{controller}/{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _customerData.GetCustomerById(id);

            if (customer != null)
                return Ok(customer);
            else
                return BadRequest();
        }

        [HttpPost]
        [Route("api/{controller}")]
        public IActionResult AddCustomer([FromBody]Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerData.CreateCustomer(customer);
                _customerData.CommitChanges();
                return Created($"api/customers/{customer.CustomerId}", customer);
            }
            else
                return BadRequest("Failed to save customer");
        }
    }
}
