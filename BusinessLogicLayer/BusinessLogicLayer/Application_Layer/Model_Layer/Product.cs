using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    public class Product
    {
        [MaxLength(50), Required]
        public string Name { get; set; }
        public int ProductId { get; set; }
        public bool IsRented { get; set; }
    }
}
