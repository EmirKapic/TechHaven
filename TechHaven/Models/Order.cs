using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Customer")]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<Product> Products { get; set; }

        public int Price { get; set; }
        public string ShippingAddress { get; set; }

        [NotMapped]
        public Discount Discount { get; set; }
        public DateTime OrderDate { get; set; }

        public Order() { }
    }
}
