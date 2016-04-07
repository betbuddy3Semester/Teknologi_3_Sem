using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Application_Layer.Model_Layer;

namespace CRPWcfService
{   
    [ServiceContract]
    interface ICrpServices
    {
        //Product
        [OperationContract]
        void CreateProduct(Product product);

        [OperationContract]
        Product GetProduct(int id);
        
        [OperationContract]
        IEnumerable<Product> GetProducts();

        [OperationContract]
        void DeleteProduct(Product product);

        [OperationContract]
        void UpdateProduct(Product product);
    }
}
