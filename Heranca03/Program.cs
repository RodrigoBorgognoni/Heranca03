using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca03.Entities;
using Heranca03.Enums;

namespace Heranca03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int p = int.Parse(Console.ReadLine());

            for (int i = 1; i <= p; i++)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, Used or Imported? ");
                ProductType type = (ProductType)Enum.Parse(typeof(ProductType), Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type.ToString() == "imported")
                {               
                    Console.Write("Customs Fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, fee));
                }
                else if (type.ToString() == "used")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }

                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Price Tags:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
