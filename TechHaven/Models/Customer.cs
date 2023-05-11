using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class Customer : IdentityUser, Person, User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfHavenCoins { get; set; }
        [NotMapped]
        public ShoppingCart ShoppingCart { get; set; }
        [NotMapped]
        public List<Product> Wishlist { get; set; }
        [NotMapped]
        public List<Order> Orders { get; set; }


        public Customer() { FirstName = ""; LastName = ""; NumberOfHavenCoins = 0; }
    }
}

