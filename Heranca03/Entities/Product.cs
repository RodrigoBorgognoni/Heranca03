namespace Heranca03.Entities
{
    internal class Product
    {
        public string  Name { get; protected set; }
        public double Price { get; protected set; }

        public Product()
        { 
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"{Name} {Price:C}";
        }

    }
}
