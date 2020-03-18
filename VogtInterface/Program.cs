using System;
using System.Collections.Generic;

namespace VogtInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductsModel> products = new List<IProductsModel>();

            products = AddSampleData();
            foreach (var product in products)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Product name: {product.Name}");
                Console.WriteLine($"Product price: {product.Price:C2}");

                if (product is IMeatModel meat)
                {
                    Console.WriteLine($"Meat type: {meat.Type}");
                }
                if (product is IDairyModel dairy)
                {
                    Console.WriteLine($"Shelf life: {dairy.ShelfLife}");
                }
                if (product is IProduceModel produce)
                {
                    Console.WriteLine($"Packaging: {produce.Package}");
                }

            }

        }

        private static List<IProductsModel> AddSampleData()
        {
            List<IProductsModel> sampleData = new List<IProductsModel>();

            sampleData.Add(new MeatModel { Name = "Chicken", Price = 8.00m, Type = "Chicken" });
            sampleData.Add(new ProduceModel { Name = "Apple", Price = 1.50m, Package = "None" });
            sampleData.Add(new DairyModel { Name = "Milk", Price = 3.50m, ShelfLife = "2 weeks" });

            return sampleData;
        }
    }
}
