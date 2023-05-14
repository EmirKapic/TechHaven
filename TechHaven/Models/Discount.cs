using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    [NotMapped]
    public class Discount
    {
        public int ID { get; set; }
        public List<Product> Products { get; set; }
        public int NumberOfHavenCoins { get; set; }
        public double AdditionalDiscount { get; set; }
        public double TotalDiscount { get; set; }

        public Discount(int id, List<Product> products, int numberOfHavenCoins, double additionalDiscount, double totalDiscount)
        {
            ID = id;
            Products = products;
            NumberOfHavenCoins = numberOfHavenCoins;
            AdditionalDiscount = additionalDiscount;
            TotalDiscount = totalDiscount;
        }

        public Discount() { }
    }
}

