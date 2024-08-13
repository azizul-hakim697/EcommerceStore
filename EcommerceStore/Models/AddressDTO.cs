using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceStore.Models
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string ShippingAddress { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }


    }
}
