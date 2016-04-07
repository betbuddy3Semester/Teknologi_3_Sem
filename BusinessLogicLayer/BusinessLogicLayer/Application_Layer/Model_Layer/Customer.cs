using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public IEnumerable<Rental> Rentals { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember, MaxLength(50), Required]
        public string Name { get; set; }
        [DataMember]
        public DateTime? Birthday { get; set; }
    }
}
