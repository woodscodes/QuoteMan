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
    public class QuotesController : ControllerBase
    {
        private IQuoteData _quoteData;

        public QuotesController(IQuoteData quoteData)
        {
            _quoteData = quoteData ??
                throw new ArgumentNullException(nameof(SQLQuotesRepo));
        }

        [HttpGet]
        [Route("api/{controller}/{id}")]
        public IActionResult GetQuotes(int id)
        {
            var quotes = _quoteData.GetQuotesByCustomerId(id);

            if (quotes != null)
                return Ok(quotes);

            return NotFound();
        }
    }
}
