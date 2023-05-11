using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int Price { get; set; }
        public string ShippingAddress { get; set; }

        [NotMapped]
        public Discount Discount { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int orderId, List<Product> products, int price, string shippingAddress, Discount discount, DateTime orderDate)
        {
            OrderId = orderId;
            Products = products;
            Price = price;
            ShippingAddress = shippingAddress;
            Discount = discount;
            OrderDate = orderDate;
        }
    }
}
