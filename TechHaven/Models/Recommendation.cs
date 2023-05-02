﻿namespace TechHaven.Models
{
    public class Recommendation
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }

        public Recommendation(Customer customer, List<Order> orders)
        {
            Customer = customer;
            Orders = orders;
        }

        public Recommendation() { }
    }
}
