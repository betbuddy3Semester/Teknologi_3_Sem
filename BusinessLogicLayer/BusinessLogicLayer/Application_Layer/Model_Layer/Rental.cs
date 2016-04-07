using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    public class Rental
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }
        
        public Product Product { get; set; }
    }
}
