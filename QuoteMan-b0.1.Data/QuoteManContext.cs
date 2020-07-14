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
                
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Email = "bobsmithh@gmail.com", Title = Core.Models.Enums.TitleType.Mr, FirstName = "Bob", LastName = "Smith", PhoneNumber = "07833373407" },
                new Customer { CustomerId = 2, Email = "droctagon@fastmail.net", Title = Core.Models.Enums.TitleType.Dr, FirstName = "Fred", LastName = "Octagon", PhoneNumber = "07833373408" }
                );

            modelBuilder.Entity<Quote>().HasData(
                new Quote {
                    QuoteId = 1,
                    Price = 350.0m,
                    VehicleMake = "Honda",
                    VehicleModel = "Civic",
                    Status = Core.Models.Enums.StatusType.Open,
                    CustomerId = 1,
                    DateGiven = new DateTime(2020, 05, 08),
                    Description = "Vehicle done got a bit of damage"                    
                },

                new Quote
                {
                    QuoteId = 2,
                    Price = 550.0m,
                    VehicleMake = "Honda",
                    VehicleModel = "Civic Type-R",
                    Status = Core.Models.Enums.StatusType.Closed,
                    CustomerId = 1,
                    DateGiven = new DateTime(2020, 06, 11),
                    Description = "Vehicle done got a bit of damage"
                },

                new Quote
                {
                    QuoteId = 3,
                    Price = 950.0m,
                    VehicleMake = "Toyota",
                    VehicleModel = "Landcruiser",
                    Status = Core.Models.Enums.StatusType.Closed,
                    CustomerId = 2,
                    DateGiven = new DateTime(2019, 12, 15),
                    Description = "Bleheheheheheh"
                },

                new Quote
                {
                    QuoteId = 4,
                    Price = 550.0m,
                    VehicleMake = "Toyota",
                    VehicleModel = "GT86",
                    Status = Core.Models.Enums.StatusType.Open,
                    CustomerId = 2,
                    DateGiven = new DateTime(2020, 04, 11),
                    Description = "Bleheheheheheh"
                }
                );
        }

    }
}
