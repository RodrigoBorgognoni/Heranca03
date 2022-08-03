using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca03.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturerDate { get; protected set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturerDate) : base(name, price)
        {
            ManufacturerDate = manufacturerDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (Used) {Price:C} ( Manufacturer's Date: {ManufacturerDate:dd/MM/yyyy})";
        }

    }
}
