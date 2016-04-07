using System;
using System.Collections.Generic;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    public class Customer
    {
        public IEnumerable<Rental> Rentals { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
