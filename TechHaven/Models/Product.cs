using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? Manufacturer { get; set; }
        public string? Model { get; set; }
        public double? Price { get; set; }
        public int? NumberOfAvailable { get; set; }

        [ForeignKey("Customer")]
        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [ForeignKey("ShoppingCart")]
        public int? ShoppingCartId { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }

        public Product() { }
    }
}
