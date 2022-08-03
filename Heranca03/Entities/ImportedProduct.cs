namespace Heranca03.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; protected set; }

        public ImportedProduct()
        { 
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} {TotalPrice():C} (Customs Fee: {CustomsFee:C})";
        }
    }
}
