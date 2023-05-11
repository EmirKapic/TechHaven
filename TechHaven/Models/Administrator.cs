namespace TechHaven.Models
{
    public class Administrator : Person
    {
        public int AdministratorId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ProductManager ProductManager { get; set; }

        public Administrator(int administratorId, string username, string email, string password, string firstName, string lastName, ProductManager productManager)
        {
            AdministratorId = administratorId;
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

