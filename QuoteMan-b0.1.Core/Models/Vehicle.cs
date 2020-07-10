using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuoteMan_b0._1.Core.Models
{
    public class Vehicle
    {        
        public int VehicleId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Make { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string Model { get; set; }
    }
}
