using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BusinessLogicLayer.Application_Layer.Model_Layer
{
    [DataContract]
    public class Product
    {
        [DataMember, MaxLength(50), Required]
        public string Name { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public bool IsRented { get; set; }
    }
}
