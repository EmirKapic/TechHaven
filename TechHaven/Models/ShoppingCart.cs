using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }
        private List<Product> products = new List<Product>();
        private double totalPrice;

        public void AddProduct(Product product)
        {
            products.Add(product);
            totalPrice += product.Price;
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
            totalPrice -= product.Price;
        }

        public IReadOnlyList<Product> GetProducts()
        {
            return products.AsReadOnly();
        }

        public double GetTotalPrice()
        {
            return totalPrice;
        }

        public ShoppingCart() { }
    }
}

