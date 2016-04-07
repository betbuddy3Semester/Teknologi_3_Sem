using System.Data.Entity;
using BusinessLogicLayer.Application_Layer.Model_Layer;

namespace BusinessLogicLayer.Data_Access_Layer.Contexts
{
    public class CrpContext : DbContext
    {
        public CrpContext() : base("name=CRPContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}