using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechHaven.Models
{
    public class Administrator : Person
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public ProductManager ProductManager { get; set; }

        public Administrator(int id, string username, string email, string password, string firstName, string lastName, ProductManager productManager)
        {
            Id = id;
            Username = username;
            Email = email;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            ProductManager = productManager;
        }

        public Administrator() { }
    }
}

