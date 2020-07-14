using QuoteMan_b0._1.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuoteMan_b0._1.Core.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string VehicleMake { get; set; }
        
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string VehicleModel { get; set; }

        public StatusType Status { get; set; }
        public DateTime DateGiven { get; set; }
        public DateTime DateModified { get; set; }

        [Required]
        [MaxLength(255)]
        public string Description { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
