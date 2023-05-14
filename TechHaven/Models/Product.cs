using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        public Category Category { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int NumberOfAvailable { get; set; }

        public Product() { }
    }
}
