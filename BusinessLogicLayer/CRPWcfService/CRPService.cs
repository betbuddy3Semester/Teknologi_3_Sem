using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Application_Layer.Model_Layer;
using BusinessLogicLayer.Data_Access_Layer.Contexts;

namespace CRPWcfService
{
    public class CrpService : ICrpServices
    {
        public void CreateProduct(Product product)
        {
            using (CrpContext crpContext = new CrpContext())
            {
                crpContext.Products.Add(product);
                crpContext.SaveChanges();
            }
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
