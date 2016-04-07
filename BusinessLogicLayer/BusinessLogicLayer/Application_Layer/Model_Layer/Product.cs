using System.Collections.Generic;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    public class Product
    {
        public IEnumerable<Rental> Rentals { get; set; }

        public Product(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}
