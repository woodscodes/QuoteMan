﻿using QuoteMan_b0._1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteMan_b0._1.Data.Infrastructure.Contracts
{
    interface IQuoteData
    {
        IEnumerable<Quote> GetQuotesByCustomerId(int id);
    }
}