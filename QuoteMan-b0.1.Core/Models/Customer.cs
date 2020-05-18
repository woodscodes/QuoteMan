using QuoteMan_b0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuoteMan_b0._1.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public TitleType Title { get; set; }

        [Display(Name = "First name")]
        [Required(ErrorMessage = "A first name is required")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "A last name is required")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage = "A valid email address is required")]
        public string Email { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "A phone number is required")]
        [MaxLength(15)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "A valid phone number is required")]
        public string PhoneNumber { get; set; }

        public List<Quote> Quotes { get; set; }
    }
}
