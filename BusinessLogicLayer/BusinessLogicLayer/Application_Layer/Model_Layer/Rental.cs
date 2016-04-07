using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    [DataContract]
    public class Rental
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember, Key, DatabaseGenerated(DatabaseGeneratedOption.None), ForeignKey("Product")]
        public int ProductId { get; set; }
        
        [DataMember]
        public Product Product { get; set; }
    }
}
