using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    public class Customer
    {
        public IEnumerable<Rental> Rentals { get; set; }
        public int CustomerId { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
