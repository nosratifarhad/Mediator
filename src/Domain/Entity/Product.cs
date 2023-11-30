namespace WebApplicationMediator.Domain.Entity
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
