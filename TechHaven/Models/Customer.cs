using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class Customer : IdentityUser, Person, User
    {
        [Key]
        override public string Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? NumberOfHavenCoins { get; set; }

        public ShoppingCart? ShoppingCart { get; set; }

        public List<Product>? Wishlist { get; set; }

        public List<Order>? Orders { get; set; }

        public Customer() { }
    }
}

